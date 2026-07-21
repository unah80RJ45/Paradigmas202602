create table Maestro
(
	MaestroID	int not null primary key,
	Nombre		varchar(50) not null unique
)

--create user db2 for login db2
--alter role db_owner add member db2

select * from Maestro
