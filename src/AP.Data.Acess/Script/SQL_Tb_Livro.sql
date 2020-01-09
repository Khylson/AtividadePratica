create table Livro 
(
  LivroId int identity (1,1) primary key NOT NULL,
  Titulo varchar(50) NOT NULL,
  ISBN varchar(20) NOT NULL,
  Valor money NOT NULL,
  Quantidade int NOT NULL,
  Atatus varchar (20) NOT NULL,
  fk_AutorId int  NOT NULL,
  fk_EditoraId int  NULL,
  constantints foreign key(fk_AutorId) references   Autor(AutorId),
  constantints foreign key(fk_EditoraId) references Editora(EditoraId)
);
