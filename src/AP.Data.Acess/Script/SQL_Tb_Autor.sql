create table Autor 
(
  AutorId int identity (1,1) primary key NOT NULL,
  Nome varchar(50) NOT NULL,
  Sobrenome varchar(50) NOT NULL,
  Idade int  NOT NULL
);
