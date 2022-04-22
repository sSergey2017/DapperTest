use DapperTestCat

drop table if exists [Participants]
go
drop table if exists [Exposition]
go
drop table dbo.Cat
go
drop table if exists [Owners]
go




if OBJECT_ID('dbo.Cat') is not null
drop table dbo.Cat

if OBJECT_ID('dbo.Owners') is not null
drop table dbo.Owners

if OBJECT_ID('dbo.Exposition') is not null
drop table dbo.Exposition

if OBJECT_ID('dbo.Participants') is not null
drop table dbo.Participants