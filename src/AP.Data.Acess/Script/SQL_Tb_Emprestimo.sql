create table Emprestimo 
(
  EmpId int identity (1,1) primary key NOT NULL,
  DataEmprestimo dateTime NOT NULL,
  DataDevolucao dateTime NOT NULL,
  ValorMulta money NOT NULL,
  QuantidadeEmpretismo int NOT NULL,
  fk_ ISBNLivro varchar (20)  NOT NULL,
  fk_ IdentidadaUsuario int identity(02842,1) NULL,
  constantints foreign key(fk_ ISBNLivro) references Livro (ISBNLivro),
  constantints foreign key(fk_ IdentidadaUsuario) references Usuario    (IdentidadaUsuario)
);

