CREATE DATABASE POCOTest;

USE POCOTest;
CREATE TABLE Teams (
	Id int Not Null Primary Key Identity(1,1),
	Name varchar(255) Not Null,
	Logo varchar(255) Not Null
);

CREATE TABLE Players (
	Id int Not Null Primary Key Identity(1,1),
	UserName varchar(30) Not Null,
	TeamId int Foreign Key References Teams(id)
);