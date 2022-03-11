create database if not exists Pcc_Fit;
use Pcc_Fit;

drop table if exists tb_nutricionista;
create table tb_nutricionista(
id int not null auto_increment,
cpf varchar(15) not null unique,
nome varchar(100) not null,
email varchar(100) not null,
cep varchar(11),
logradouro varchar(100) not null,
numero varchar(10),
bairro varchar(20) not null,
cidade varchar(20) not null,
estado varchar(2) not null,
telefone varchar(15) not null,
dt_inicio date,
dt_final date,
primary key(id)
);


drop table if exists tb_paciente;
create table tb_paciente(
id int not null auto_increment,
id_nutricionista int,
cpf varchar(15) not null unique,
nome varchar(100) not null,
email varchar(100)not null,
cep varchar(11) not null,
logradouro varchar(100) not null,
numero varchar(10),
bairro varchar(20) not null,
cidade varchar(20) not null,
estado varchar(2) not null,
telefone varchar(15) not null,
dt_inicio date,
dt_final date,
valor float,
quantidade int,
objetivo text,
altura int not null,
peso float not null,
dt_nascimento date not null,
primary key(id)
);


drop table if exists tb_atendente;
create table tb_atendente(
id int not null auto_increment,
cpf varchar(15) not null unique,
nome varchar(100) not null,
email varchar(100)not null,
cep varchar(11),
logradouro varchar(100) not null,
numero varchar(10),
bairro varchar(20) not null,
cidade varchar(20) not null,
estado varchar(2) not null,
telefone varchar(15) not null,
dt_inicio date not null,
dt_final date,
primary key(id)
);


drop table if exists tb_agenda;
create table tb_agenda(
id int not null auto_increment,
id_nutricionista int not null,
id_paciente int not null,
dt_agenda date not null,
horario time not null,
descricao text not null,
primary key(id)
);

drop table if exists tb_login;
create table tb_login(
cpf varchar(14) not null unique,
senha varchar(20) not null,
acesso varchar(20) not null,
primary key(cpf)
);
INSERT INTO tb_login (cpf, senha, acesso) VALUES ("000.000.000-00","admin","atendente");

create view Vw_Agenda as SELECT nut.nome as nutricionista, pac.nome as paciente, ag.* FROM tb_agenda ag
LEFT JOIN tb_nutricionista nut ON nut.id = ag.id_nutricionista
LEFT JOIN tb_paciente pac ON pac.id = ag.id_paciente;


drop table if exists tb_comentarios;
create table tb_comentarios(
id int not null auto_increment,
nome varchar(100),
email varchar(50),
comentario text,
assunto varchar(100),
primary key(id)
);