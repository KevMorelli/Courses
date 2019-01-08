#Topic 5

##############
# EXERCISE 1 #
##############

CREATE DATABASE IF NOT EXISTS HighSchool;

USE HighSchool;

#students table
CREATE TABLE IF NOT EXISTS Students (
    RegNumber INT NOT NULL AUTO_INCREMENT,
    FirstName VARCHAR(20) NOT NULL,
    LastName VARCHAR(20) NOT NULL,
    DateOfBirth DATE NOT NULL,
    PRIMARY KEY(RegNumber)
)  ENGINE=INNODB;

#teachers table
CREATE TABLE IF NOT EXISTS Teachers (
    TeacherId INT NOT NULL AUTO_INCREMENT,
    FirstName VARCHAR(20) NOT NULL,
    LastName VARCHAR(20) NOT NULL,
    DateOfBirth DATE NOT NULL,
    PRIMARY KEY (TeacherId)
)  ENGINE=INNODB;

#courses table
CREATE TABLE IF NOT EXISTS Courses (
	CourseId INT NOT NULL AUTO_INCREMENT,
    CourseName VARCHAR(40) NOT NULL,
    AsignedTeacher INT NOT NULL,
    HoursByWeek INT,
    ScheduleTime ENUM('Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday'),
    PRIMARY KEY (CourseId)
)  ENGINE=INNODB;

##############
# EXERCISE 2 #
##############

#Junction table for many to many with student and courses
CREATE TABLE IF NOT EXISTS CurrentlyStudying (
	StudentId INT NOT NULL,
    CourseId INT NOT NULL,
    FirstPartialNote DOUBLE,
    SecondPartialNote DOUBLE,
    ThirdPartialNote DOUBLE,
    FinalNote DOUBLE
) ENGINE=INNODB;

##############
# EXERCISE 3 #
##############

#teachers
INSERT INTO Teachers
VALUES(NULL,'Alicia','Gonzalez','19801220');
INSERT INTO Teachers
VALUES(NULL,'Julia','Wayne','19810302');
INSERT INTO Teachers
VALUES(NULL,'Laura','Herrera','19850815');

#courses
INSERT INTO Courses
VALUES(NULL,'Algorithms I', (SELECT TeacherId FROM Teachers WHERE LastName='Wayne'), 6, 3);
INSERT INTO Courses
VALUES(NULL,'Algorithms II', (SELECT TeacherId FROM Teachers WHERE LastName='Herrera'), 2, 1);
INSERT INTO Courses
VALUES(NULL,'English I', (SELECT TeacherId FROM Teachers WHERE LastName='Gonzalez'), 1, 4);
INSERT INTO Courses
VALUES(NULL,'English II', (SELECT TeacherId FROM Teachers WHERE LastName='Gonzalez'), 2, 1);

#students
INSERT INTO Students
VALUES(NULL,'Kevin','Morelli','19931202');
INSERT INTO Students
VALUES(NULL,'Robert','Wayne','19911205');
INSERT INTO Students
VALUES(NULL,'Walter','Gonzalez','19920220');
INSERT INTO Students
VALUES(NULL,'George','Smith','19930615');
INSERT INTO Students
VALUES(NULL,'Will','Smith','19920501');

##############
# EXERCISE 5 #
##############

INSERT INTO CurrentlyStudying
VALUES (1,1,5.0,0.0,0.0,0.0);
INSERT INTO CurrentlyStudying
VALUES (1,2,7.0,0.0,0.0,0.0);
INSERT INTO CurrentlyStudying
VALUES (2,1,2.0,0.0,0.0,0.0);
INSERT INTO CurrentlyStudying
VALUES (4,1,10.0,0.0,0.0,0.0);
INSERT INTO CurrentlyStudying
VALUES (3,3,8.0,0.0,0.0,0.0);



SELECT t1.LastName, t1.FirstName,t3.CourseName, t2.FirstPartialNote, t2.SecondPartialNote, t2.ThirdPartialNote, t2.FinalNote
FROM Students AS t1
INNER JOIN CurrentlyStudying AS t2 ON t2.StudentId = t1.RegNumber
INNER JOIN Courses AS t3 ON t3.CourseId = t2.CourseId
ORDER BY t2.FirstPartialNote DESC;



