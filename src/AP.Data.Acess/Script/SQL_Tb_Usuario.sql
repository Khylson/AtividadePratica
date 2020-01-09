create table Usuario 
(
  UsuarioId int identity (1,1) primary key NOT NULL,
  Nome varchar(20) NOT NULL,
  Sobrenome varchar(20) NOT NULL,
  Sexo char(1) check(Sexo IN(‘M’,’F’))  NOT NULL,
  NumeroUsuario int identity(02842,1)

);
