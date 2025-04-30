create database recruitmentbuddy;
use recruitmentbuddy;

CREATE TABLE Users(
    UserId INT AUTO_INCREMENT PRIMARY KEY,
    Username NVARCHAR(50),
    PasswordHash NVARCHAR(50) NOT NULL
);

CREATE TABLE Classes(
    ClassId INT PRIMARY KEY,
    ClassName NVARCHAR(50)
);


INSERT INTO Classes (ClassName, ClassId)
VALUES
('Arts and Humanities',1),
('Fine Arts',2),
('Music',3),
('Theatre',4),
('Literature',5),
('Philosophy',6),
('History',7),
('Art History',8),
('Business',9),
('Business Administration',10),
('Marketing',11),
('Finance',12),
('Accounting',13),
('Management',14),
('Entrepreneurship',15),
('International Business',16),
('-Science and Technology',17),
('Biology',18),
('Chemistry',19),
('Physics',20),
('Computer Science',21),
('Information Technology',22),
('Environmental Science',23),
('Mathematics',24),
('Health Sciences',25),
('Nursing',26),
('Public Health',27),
('Pharmacy',28),
('Physical Therapy',29),
('Nutrition',30),
('Occupational Therapy',31),
('Health Administration',32),
('Social Sciences',33),
('Psychology',34),
('Sociology',35),
('Political Science',36),
('Economics',37),
('Anthropology',38),
('International Relations',39),
('Education',40),
('-Engineering',41),
('Civil Engineering',42),
('Mechanical Engineering',43),
('Electrical Engineering',44),
('Chemical Engineering',45),
('Computer Engineering',46),
('Aerospace Engineering',47),
('Applied Sciences',48),
('Graphic Design',49),
('Culinary Arts',50),
('Hospitality Management',51),
('Interior Design',52),
('Fashion Design',53),
('Interdisciplinary Studies',54),
('Women''s Studies',55),
('Environmental Studies',56),
('Ethnic Studies',57),
('Global Studies',58);

CREATE TABLE QuestionnaireAnswers (
    AnswerId INT AUTO_INCREMENT PRIMARY KEY,
    UserId INT,
    EducationLevel VARCHAR(50),
    PersonalityType VARCHAR(50),
    OtherPersonality TEXT,
    ProgramType VARCHAR(50),
    Comments TEXT,
    FOREIGN KEY (UserId) REFERENCES Users(UserId)
);

CREATE TABLE AnswerInterests (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    AnswerId INT,
    Interest VARCHAR(50),
    FOREIGN KEY (AnswerId) REFERENCES QuestionnaireAnswers(AnswerId)
);

CREATE TABLE AnswerSubjects (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    AnswerId INT,
    Subject VARCHAR(50),
    FOREIGN KEY (AnswerId) REFERENCES QuestionnaireAnswers(AnswerId)
);

CREATE TABLE AnswerWorkplaceValues (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    AnswerId INT,
    Value VARCHAR(50),
    FOREIGN KEY (AnswerId) REFERENCES QuestionnaireAnswers(AnswerId)
);


INSERT INTO Users (Username, PasswordHash)
VALUES ('testuser', '1234');
