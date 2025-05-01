import mysql.connector

# Function to connect to the database
def get_db_connection():
    return mysql.connector.connect(
        host="localhost",
        user="root",
        password="password",  # Replace with your actual MySQL password
        database="recruitmentbuddy"
    )

# Function to retrieve all programs from the database
def get_programs_from_db():
    connection = get_db_connection()
    cursor = connection.cursor(dictionary=True)
    cursor.execute("SELECT * FROM Programs")
    programs = cursor.fetchall()
    cursor.close()
    connection.close()
    return programs

# Function to recommend programs based on user profile
def recommend_programs(user):
    programs = get_programs_from_db()
    recommendations = []

    for program in programs:
        score = 0

        # Compare each attribute
        if program.get("EducationLevel", "").strip().lower() == user.get("EducationLevel", "").strip().lower():
            score += 1
        if program.get("ClassEnv", "").strip().lower() == user.get("ClassEnvironment", "").strip().lower():
            score += 1
        if program.get("SocialEnergy", "").strip().lower() == user.get("SocialEnergy", "").strip().lower():
            score += 1
        if program.get("Mind", "").strip().lower() == user.get("Mind", "").strip().lower():
            score += 1
        if program.get("Nature", "").strip().lower() == user.get("Nature", "").strip().lower():
            score += 1
        if program.get("Tactics", "").strip().lower() == user.get("Tactics", "").strip().lower():
            score += 1

        if score >= 4:  # Threshold to consider a program as a recommendation
            recommendations.append({
                "ProgramName": program["Name"],
                "Score": score
            })

    # Sort by best match
    recommendations.sort(key=lambda x: x["Score"], reverse=True)

    # Output recommendations
    if recommendations:
        print("Recommended Programs:\n")
        for rec in recommendations:
            print(f"{rec['ProgramName']} (Score: {rec['Score']})")
    else:
        print("No recommended program found.")

# Sample user profile input
user_profile = {
    "EducationLevel": "Bachelor's Degree",
    "ClassEnvironment": "Online",
    "SocialEnergy": "Introvert",
    "Mind": "Intuitive",
    "Nature": "Thinking",
    "Tactics": "Judging"
}

# Run the recommendation
if __name__ == "__main__":
    recommend_programs(user_profile)

