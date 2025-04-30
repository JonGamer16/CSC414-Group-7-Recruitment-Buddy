
Backend & Database Setup Guide

REQUIREMENTS:
-------------
- Python 3.11+
- MySQL Workbench + MySQL Server (running locally)
- Postman (optional but good for testing)

1. VIRTUAL ENVIRONMENT SETUP
--------------------
Navigate to the backend folder and run:

> python -m venv venv

Activate it:

> .\venv\Scripts\activate

Install dependencies:

> pip install -r requirements.txt


2. DATABASE SETUP
--------------------
Open MySQL Workbench.

1. Open the file: recruitmentbuddy_schema.sql (located in the backend folder)
2. Run the full script.

3. RUNNING THE FLASK BACKEND
--------------------
With the virtual environment still activated:

> python app.py

You should see:

> * Running on http://127.0.0.1:5000

--------------------
4. TESTING WITH POSTMAN (OPTIONAL)
--------------------
Send a POST request to:

> http://127.0.0.1:5000/submit-questionnaire

Set the request Body to raw JSON and paste:

{
  "UserId": 1,
  "EducationLevel": "Bachelor Degree",
  "PersonalityType": "Ambivert",
  "OtherPersonality": "",
  "ProgramType": "Online",
  "Comments": "Excited to explore!",
  "Interests": ["Arts", "Technology"],
  "Subjects": ["Math", "Computer Science"],
  "WorkplaceValues": ["Collaboration", "Structure"]
}

You should get a success message like:

{
  "message": "Questionnaire submitted successfully",
  "AnswerId": 1
}

Important: 
- Do not commit the 'venv/' folder — it's excluded via .gitignore.
- If your MySQL login is different, update the get_db_connection() function in app.py.

