create database DapperTest;
go

use DapperTest
go

create table [User] (
 UserId int identity(1,1),
 Email nvarchar(50),
 [Password] nvarchar(50),
 FirstName nvarchar(50),
 LastName nvarchar(50)
)
go

insert into [User] (Email, [Password], FirstName, LastName)
values (N'test@user.com', N'password', N'Mike', N'Fles');

insert into [User] (Email, [Password], FirstName, LastName)
values (N'test1@user.com', N'password1', N'Mike1', N'Fles1');