import json
import mysql.connector

def get_db_connection():
    return mysql.connector.connect(
        host="localhost",
        port=3306,
        user="recruituser",
        password="R3cru!tB@ckend",
        database="recruitmentbuddy"
    )

def insert_programs_from_json(filename="programs.json"):
    with open(filename, "r") as file:
        programs = json.load(file)

    conn = get_db_connection()
    cursor = conn.cursor()

    for prog in programs:
        # Insert main program
        cursor.execute("""
            INSERT INTO Programs (Name, EducationLevel, ClassEnv, SocialEnergy, Mind, Nature, Tactics)
            VALUES (%s, %s, %s, %s, %s, %s, %s)
        """, (
            prog["name"],
            prog["education_level"],
            prog["class_env"],
            prog["social_energy"],
            prog["mind"],
            prog["nature"],
            prog["tactics"]
        ))

        program_id = cursor.lastrowid

        # Insert career clusters
        for cluster in prog.get("career_clusters", []):
            cursor.execute("INSERT INTO ProgramCareerClusters (ProgramId, Cluster) VALUES (%s, %s)", (program_id, cluster))

        # Insert subjects
        for subject in prog.get("subjects", []):
            cursor.execute("INSERT INTO ProgramSubjects (ProgramId, Subject) VALUES (%s, %s)", (program_id, subject))

        # Insert workplace values
        for value in prog.get("workplace_values", []):
            cursor.execute("INSERT INTO ProgramWorkplaceValues (ProgramId, ValueName) VALUES (%s, %s)", (program_id, value))

    conn.commit()
    cursor.close()
    conn.close()
    print("✅ Programs inserted successfully!")

if __name__ == "__main__":
    insert_programs_from_json()
