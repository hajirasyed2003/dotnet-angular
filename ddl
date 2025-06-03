use EventDb

--1
create table UserInfo
( EmailId varchar(100) primary key,
  UserName varchar(50) not null check (LEN(UserName) between 1 and 50),
  Role varchar(50) not null check (Role in ('Admin','Participant')),
  Password varchar(50) not null check (LEN(Password) between 6 and 20)
);

--2
create table EventDetails
( EventId int primary key,
  EventName varchar(50) not null check (LEN(EventName) between 1 and 50),
  EventCategory varchar(50) not null check (LEN(EventCategory) between 1 and 50),
  EventDate datetime not null,
  Description varchar(100),
  Status varchar(100) check (Status in ('Áctive','In-Active'))
);

--3
create table SpeakerDetails
( SpeakerId int primary key,
  SpeakerName varchar(100) not null check (LEN(SpeakerName) between 1 and 50)
);

--4
create table SessionInfo 
( SessionId int primary key,
  EventId int not null foreign key references EventDetails(EventId),
  SessionTitle varchar(100) not null check(LEN(SessionTitle) between 1 and 50),
  SpeakerId int not null foreign key references SpeakerDetails(SpeakerId),
  Description varchar(100),
  SessionStart datetime not null,
  SessionUrl varchar
);

--5
create table ParticipantEventDetails
( Id int primary key,
  ParticipantEmailId varchar(100) not null foreign key references UserInfo(EmailId),
  EventId int not null foreign key references EventDetails(EventId),
  SessionId INT NOT NULL foreign key references SessionInfo(SessionId),
  IsAttended bit check(IsAttended in ('Yes','No'))
);
