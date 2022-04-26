create database DapperTestCat;
go

use DapperTestCat
go

create table [Owners](
Id int primary key identity,
NameOvner nvarchar(50) 
)

create table [Cat](
Id int primary key identity,
OwnerId INT REFERENCES Owners (Id),
NameCat nvarchar(50) 
)

create table [Exposition](
Id int primary key identity,
DateExpo nvarchar(50),
City nvarchar(50), 
Country nvarchar(50) 
)

create table [Participants](
CatId INT REFERENCES Cat (Id),
ExpoId INT REFERENCES Exposition (Id)
)


-- для удаления таблиц с ключами нужно удалить таблицу которая зависит от другой
use DapperTestCat

drop table if exists [Participants]
go
drop table if exists [Exposition]
go
drop table dbo.Cat
go
drop table if exists [Owners]
go

-- заполнение таблиц
use DapperTestCat


insert into [Owners] (NameOvner)
values ( N'Ow1');

insert into [Cat] (NameCat)
values (N'Cat1');

insert into [Exposition] (DateExpo, City, Country)
values (N'mart', N'dnd', N'Country');

insert into [Participants] (CatId, ExpoId)
values (N'1', N'1');
