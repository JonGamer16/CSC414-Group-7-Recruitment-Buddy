from flask import Flask, request, jsonify
import mysql.connector
from mysql.connector import Error

app = Flask(__name__)


def get_db_connection():
    return mysql.connector.connect(
        host="localhost",
        port=3306,
        user="recruituser",    # Replace with your MySQL info here ⬅️
        password="R3cru!tB@ckend",
        database="recruitmentbuddy"
    )




@app.route("/")
def home():
    return "RecruitmentBuddy Flask API is ON"

@app.route("/submit-questionnaire", methods=["POST"])
def submit_questionnaire():
    try:
        data = request.get_json()

        conn = get_db_connection()
        cursor = conn.cursor()

        # Insert main answers
        cursor.execute("""
            INSERT INTO QuestionnaireAnswers (UserId, EducationLevel, PersonalityType, OtherPersonality, ProgramType, Comments)
            VALUES (%s, %s, %s, %s, %s, %s)
        """, (
            data["UserId"],
            data["EducationLevel"],
            data["PersonalityType"],
            data.get("OtherPersonality", ""),
            data["ProgramType"],
            data.get("Comments", "")
        ))

        answer_id = cursor.lastrowid

        # Insert Interests
        for interest in data.get("Interests", []):
            cursor.execute("INSERT INTO AnswerInterests (AnswerId, Interest) VALUES (%s, %s)", (answer_id, interest))

        # Insert Subjects
        for subject in data.get("Subjects", []):
            cursor.execute("INSERT INTO AnswerSubjects (AnswerId, Subject) VALUES (%s, %s)", (answer_id, subject))

        # Insert Workplace Values
        for value in data.get("WorkplaceValues", []):
            cursor.execute("INSERT INTO AnswerWorkplaceValues (AnswerId, Value) VALUES (%s, %s)", (answer_id, value))

        conn.commit()
        cursor.close()
        conn.close()

        return jsonify({"message": "Questionnaire submitted successfully", "AnswerId": answer_id})

    except Error as e:
        print("MySQL error:", e)
        return jsonify({"error": "Database error"}), 500

    except Exception as ex:
        print("General error:", ex)
        return jsonify({"error": "Internal server error"}), 500
    
    except Error as e:
        print("MySQL error:", e)  # <-- ADD THIS
        return jsonify({"error": "Database error"}), 500 

    
@app.route("/db-test")
def db_test():
    try:
        conn = get_db_connection()
        cursor = conn.cursor()
        cursor.execute("SELECT NOW();")
        result = cursor.fetchone()
        cursor.close()
        conn.close()
        return f"✅ Connected to MySQL. Current time: {result[0]}"
    except Exception as e:
        return f"❌ Connection failed: {e}"



if __name__ == "__main__":
    app.run(debug=True)
