CREATE TABLE DiaryUser
(
  UserName VARCHAR(40) NOT NULL,
  Password CHAR(40) NOT NULL,
  Firstname VARCHAR(40) NOT NULL,
  Lastname VARCHAR(40) NOT NULL,
  PRIMARY KEY (UserName)
);

CREATE TABLE Diary
(
  DiaryTitle VARCHAR(40) NOT NULL,
  DiaryContent VARCHAR(250) NOT NULL,
  UserName VARCHAR(40) NOT NULL,
  PRIMARY KEY (DiaryTitle),
  FOREIGN KEY (UserName) REFERENCES DiaryUser(UserName)
);

CREATE TABLE Stared_Diaries
(
  DiaryTitle VARCHAR(40) NOT NULL,
  FOREIGN KEY (DiaryTitle) REFERENCES Diary(DiaryTitle)
);

CREATE TABLE Tasks
(
  TaskTitle VARCHAR(40) NOT NULL,
  Deadline DATE NOT NULL,
  Priority CHAR NOT NULL,
  TaskContent VARCHAR(40) NOT NULL,
  UserName VARCHAR(40) NOT NULL,
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
  DiaryTitle VARCHAR(40) NOT NULL,
  FOREIGN KEY (TagID) REFERENCES Tags(TagID),
  FOREIGN KEY (DiaryTitle) REFERENCES Diary(DiaryTitle)
); 