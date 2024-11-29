use lop;

create table TTLOP(
idClass varchar(20) primary key,
nameClass nvarchar(30),
nameSubject nvarchar(30),
nameTeacher nvarchar(30),
numberLearners varchar,
dateCreated date);

create table NguoiHoc(
iduser varchar(20) primary key,
userName nvarchar(30));

select * from TTLOP;
drop table TTLOP;