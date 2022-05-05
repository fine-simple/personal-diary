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
  DiaryTitle VARCHAR(100) NOT NULL,
  DiaryContent VARCHAR(500) NOT NULL,
  UserName VARCHAR(40) NOT NULL,
  PRIMARY KEY (DiaryTitle),
  FOREIGN KEY (UserName) REFERENCES DiaryUser(UserName)
);

CREATE TABLE Stared_Diaries
(
  DiaryTitle VARCHAR(100) NOT NULL,
  FOREIGN KEY (DiaryTitle) REFERENCES Diary(DiaryTitle)
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
  TagID INT NOT NULL,
  DiaryTitle VARCHAR(100) NOT NULL,
  FOREIGN KEY (TagID) REFERENCES Tags(TagID),
  FOREIGN KEY (DiaryTitle) REFERENCES Diary(DiaryTitle)
);


INSERT INTO DiaryUser (UserName,Password,Firstname,Lastname) VALUES (
  'EslamEsam',
  '1234',
  'Eslam',
  'Esam'
); 

INSERT INTO DiaryUser (UserName,Password,Firstname,Lastname) VALUES (
  'AhmedTawfik',
  '9876',
  'Ahmed',
  'Tawfik'
); 

INSERT INTO DiaryUser (UserName,Password,Firstname,Lastname) VALUES (
  'MonayAhmed',
  '2468',
  'Monay',
  'Ahmed'
);

INSERT INTO Diary (DiaryTitle,DiaryContent,UserName) VALUES (
  'day one',
  'our first test in diary app',
  'EslamEsam'
); 

INSERT INTO Diary (DiaryTitle,DiaryContent,UserName) VALUES (
  'day two',
  'another test',
  'MonayAhmed'
);


INSERT INTO Diary (DiaryTitle,DiaryContent,UserName) VALUES (
  '5-5-2022',
  'this must have the date as a title',
  'AhmedTawfik'
);


INSERT INTO Diary (DiaryTitle,DiaryContent,UserName) VALUES (
  'day 50',
  'link tag with diary',
  'EslamEsam'
);  


INSERT INTO Stared_Diaries (DiaryTitle) VALUES (
  'day one'
); 




INSERT INTO Tasks (TaskTitle,Deadline,Priority,TaskContent,UserName) VALUES (
  'task one',
  TO_DATE('5/5/2022', 'DD/MM/YYYY'),
  'h',
  'finish thw script before the deadline',
  'EslamEsam'
); 


INSERT INTO Tasks (TaskTitle,Deadline,Priority,TaskContent,UserName) VALUES (
  'task 2',
  TO_DATE('5/5/2022', 'DD/MM/YYYY'),
  'm',
  'finish the connected form',
  'AhmedTawfik'
); 


INSERT INTO Tasks (TaskTitle,Deadline,Priority,TaskContent,UserName) VALUES (
  '5-5-2022',
  TO_DATE('5/5/2022', 'DD/MM/YYYY'),
  'l',
  'finish the disconnected form (date must be title )',
  'MonayAhmed'
);


INSERT INTO Tags (TagID,Title) VALUES (
  '1',
  'work'
); 


INSERT INTO Tags (TagID,Title) VALUES (
  '2',
  'family'
); 


INSERT INTO TagDiary (TagID,DiaryTitle) VALUES (
  '1',
  'day two'
);

INSERT INTO TagDiary (TagID,DiaryTitle) VALUES (
  '2',
  'day 50'
);    