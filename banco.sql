create database Pcc_Fit;
use Pcc_Fit;

drop table if exists tb_nutricionista;
create table tb_nutricionista(
id int not null auto_increment,
cpf varchar(15) not null unique,
nome varchar(100) not null,
email varchar(100) not null,
cep varchar(11),
logradouro varchar(100) not null,
numero varchar(10) not null,
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
id_nutricionista int not null,
cpf varchar(15) not null unique,
nome varchar(100) not null,
email varchar(100)not null,
cep varchar(11),
logradouro varchar(100) not null,
numero varchar(10) not null,
bairro varchar(20) not null,
cidade varchar(20) not null,
estado varchar(2) not null,
telefone varchar(15) not null,
dt_inicio date not null,
dt_final date,
valor float not null,
quantidade int not null,
objetivo text not null,
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
numero varchar(10) not null,
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


drop table if exists tb_caixa;
create table tb_caixa(
id int not null auto_increment,
id_paciente int not null,
dt_vencimento date not null,
primary key(id)
);


drop table if exists tb_login;
create table tb_login(
cpf int not null auto_increment unique,
senha varchar(20) not null,
acesso varchar(20) not null,
primary key(cpf)
);



