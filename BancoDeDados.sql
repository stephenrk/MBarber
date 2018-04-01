
CREATE DATABASE Mbarber;

USE Mbarber;

CREATE TABLE Enderecos (
	EndId integer,
    EndCEP integer,
    EndLogradouro nvarchar(50),
    EndNumero nvarchar (6),
    EndComplemento nvarchar(50),
    EndBairro nvarchar(30),
    EndCidade nvarchar(20),
    EndEstado nvarchar(2),
    PRIMARY KEY (EndId)
);

CREATE TABLE Clientes (
    CLiCPF integer,
    CliNome nvarchar(15),
    CliSobreNome nvarchar(50),
    CliTelefone integer,
	EndId integer,
    PRIMARY KEY (CLiCPF),
	FOREIGN KEY (EndId) REFERENCES Enderecos (EndId)
);

CREATE TABLE Empresas (
    EmpCNPJ integer,
    EmpNome nvarchar (50),
    EmpNomeRedu nvarchar (25),
    EndId integer ,
    PRIMARY KEY (EmpCNPJ),
    FOREIGN KEY (EndId) REFERENCES Enderecos (EndId)
);


CREATE TABLE Servicos (
    ServID integer not null,
    CliNome nvarchar (50),
    Valor Decimal,
    EmpCNPJ integer not null,
    PRIMARY KEY (ServID),
    FOREIGN KEY (EmpCNPJ) REFERENCES Empresas (EmpCNPJ)
);

CREATE TABLE Agendamentos (
	AgendId integer,
    DataHora datetime,
    Status nvarchar(10),
    EmpCNPJ integer,
    CLiCPF integer,
    PRIMARY KEY (AgendId),
    FOREIGN KEY (EmpCNPJ) REFERENCES Empresas (EmpCNPJ),
    FOREIGN KEY (CLiCPF) REFERENCES Clientes (CLiCPF)
);

CREATE TABLE Avaliacoes (
	AvaliacaoId integer,
    Nota nvarchar(150),
    Descricao nvarchar(200),
    AgendId integer,
    PRIMARY KEY (AvaliacaoId),
    FOREIGN KEY (AgendId) REFERENCES Agendamentos (AgendId)
);

insert into Enderecos values
insert into Clientes values (1,1,1,1,1)