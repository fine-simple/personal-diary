-- Drop Old Tables
DROP TABLE TagDiary CASCADE CONSTRAINTS PURGE;
DROP TABLE Starred_Diaries CASCADE CONSTRAINTS PURGE;
DROP INDEX diary_index;
DROP TABLE Diary CASCADE CONSTRAINTS PURGE;
DROP TABLE Tasks CASCADE CONSTRAINTS PURGE;
DROP TABLE Tags CASCADE CONSTRAINTS PURGE;
DROP TABLE DiaryUser CASCADE CONSTRAINTS PURGE;
DROP SEQUENCE diary_seq;

-- Creating Schema

CREATE TABLE DiaryUser
(
  UserName VARCHAR(40) NOT NULL,
  Password VARCHAR(40) NOT NULL,
  Firstname VARCHAR(40) NOT NULL,
  Lastname VARCHAR(40) NOT NULL,
  PRIMARY KEY (UserName)
);

CREATE TABLE Diary
(
  Id INT NOT NULL,
  Title VARCHAR(100) NOT NULL,
  Content VARCHAR(500) NOT NULL,
  UserName VARCHAR(40) NOT NULL,
  PRIMARY KEY (Id),
  FOREIGN KEY (UserName) REFERENCES DiaryUser(UserName),
  UNIQUE (Title, UserName)
);

CREATE SEQUENCE diary_seq
 START WITH     5
 INCREMENT BY   1
 NOCACHE
 NOCYCLE;

CREATE INDEX diary_index on Diary (
  Title 
);

CREATE TABLE Starred_Diaries
(
  DiaryId INT NOT NULL,
  FOREIGN KEY (DiaryId) REFERENCES Diary(Id)
);

CREATE TABLE Tasks
(
  TaskTitle VARCHAR(40) NOT NULL,
  Deadline DATE NOT NULL,
  Priority CHAR NOT NULL,
  TaskContent VARCHAR(250) NOT NULL,
  UserName VARCHAR(40) NOT NULL,
  PRIMARY KEY (TaskTitle),
  FOREIGN KEY (UserName) REFERENCES DiaryUser(UserName)
);

CREATE TABLE Tags
(
  TagID INT NOT NULL,
  Title VARCHAR(40) NOT NULL,
  PRIMARY KEY (TagID)
);

CREATE TABLE TagDiary
(
  TagId INT NOT NULL,
  DiaryId INT NOT NULL,
  FOREIGN KEY (TagID) REFERENCES Tags(TagID),
  FOREIGN KEY (DiaryId) REFERENCES Diary(Id)
);

create or replace
PROCEDURE getTags( DiaryT IN VARCHAR2 ,dt OUT sys_refcursor )
AS
BEGIN
OPEN dt FOR
  SELECT Tags.TagId, Tags.title AS tagtitle, Diary.Title AS diarytitle
  FROM tags
  LEFT JOIN tagdiary
  ON tags.tagid = tagdiary.tagid 
  LEFT JOIN Diary
  ON tagdiary.diaryId = Diary.Id AND Diary.Title = DiaryT;
END getTags;
/

create or replace PROCEDURE getUser(uname IN VARCHAR2 , Ux OUT VARCHAR2 )
AS
BEGIN 
  SELECT username
  INTO Ux
  FROM diaryuser u
  WHERE u.username= uname;
  
EXCEPTION
  WHEN NO_DATA_FOUND THEN
    Ux := NULL;
END getUser;
/

create or replace
TRIGGER TRIGGER1
BEFORE INSERT ON DIARY
FOR EACH ROW
  WHEN (new.id IS NULL)
BEGIN
--  SELECT diary_seq.nextval INTO :new.id FROM dual;
  :new.Id := diary_seq.nextval;
END;
/

-- Inserting Records

INSERT INTO DiaryUser VALUES (
  'EslamEsam',
  '1234',
  'Eslam',
  'Esam'
); 

INSERT INTO DiaryUser VALUES (
  'AhmedTawfik',
  '9876',
  'Ahmed',
  'Tawfik'
); 

INSERT INTO DiaryUser VALUES (
  'MonayAhmed',
  '2468',
  'Monay',
  'Ahmed'
);

INSERT INTO Diary VALUES (
  '1',
  'day one',
  'our first test in diary app',
  'EslamEsam'
); 

INSERT INTO Diary VALUES (
  '2',
  'day two',
  'another test',
  'MonayAhmed'
);


INSERT INTO Diary VALUES (
  '3',
  '5-5-2022',
  'this must have the date as a title',
  'AhmedTawfik'
);


INSERT INTO Diary VALUES (
  '4',
  'day 50',
  'link tag with diary',
  'EslamEsam'
);  


INSERT INTO Starred_Diaries VALUES (
  '4'
);

INSERT INTO Tasks VALUES (
  'task one',
  TO_DATE('5/5/2022', 'DD/MM/YYYY'),
  'h',
  'finish thw script before the deadline',
  'EslamEsam'
); 


INSERT INTO Tasks VALUES (
  'task 2',
  TO_DATE('5/5/2022', 'DD/MM/YYYY'),
  'm',
  'finish the connected form',
  'AhmedTawfik'
); 


INSERT INTO Tasks VALUES (
  '5-5-2022',
  TO_DATE('5/5/2022', 'DD/MM/YYYY'),
  'l',
  'finish the disconnected form (date must be title )',
  'MonayAhmed'
);

INSERT INTO Tags VALUES (
  '1',
  'Family'
);

INSERT INTO Tags VALUES (
  '2',
  'Work'
);

INSERT INTO Tags VALUES (
  '3',
  'Sport'
);

INSERT INTO Tags VALUES (
  '4',
  'Happy'
);

INSERT INTO Tags VALUES (
  '5',
  'Sad'
);

INSERT INTO TagDiary VALUES (
  '1',
  '4'
);

INSERT INTO TagDiary VALUES (
  '2',
  '4'
);