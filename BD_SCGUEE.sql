create database BD_ESPORTIVO;
use BD_ESPORTIVO;
create table tb_basquete(
		tb_basquete_id integer not null auto_increment primary key,
        tb_basquete_turma varchar(64) not null,
        tb_basquete_horario time not null);
        create table tb_volei(
		tb_volei_id integer not null auto_increment primary key,
        tb_volei_turma varchar(64) not null,
        tb_volei_horario time not null);
        create table tb_futsal(
		tb_futsal_id integer not null auto_increment primary key,
        tb_futsal_turma varchar(64) not null,
        tb_futsal_horario time not null);
        create table tb_handebol(
        tb_handebol_id integer not null auto_increment primary key,
        tb_handebol_turma varchar(64) not null,
        tb_handebol_horario time not null);
		create table tb_natacao(
        tb_natacao_id integer not null auto_increment primary key,
        tb_natacao_turma varchar(64) not null,
        tb_natacao_horario time not null
        );
        create table tb_professor(
        tb_professor_id integer not null auto_increment primary key,
        tb_professor_nome varchar(64) not null,
        tb_professor_email varchar(64) not null,
        tb_professor_telefone varchar(35) not null
        /*basq_fk int not null,
        
        foreign key(basq_fk) references tb_basquete(tb_basquete_id)*/
        );
		create table tb_alunos(
	tb_alunos_id integer not null primary key auto_increment,
    tb_alunos_nome varchar(164) not null,
    tb_alunos_sexo varchar(9) not null,
    tb_alunos_email varchar(64) not null,
    tb_alunos_telefone varchar(34),
    tb_alunos_celular varchar(34) not null,
	tb_alunos_endereco varchar(32) not null,
	tb_alunos_complemento varchar(64) not null,
    professor_fk integer not null,
    basquete_fk int,
    futsal_fk int,
    volei_fk int,
    handebol_fk int,
    natacao_fk int,
    
    foreign key(professor_fk) references tb_professor(tb_professor_id),
    foreign key(basquete_fk) references tb_basquete(tb_basquete_id),
    foreign key(futsal_fk) references tb_futsal(tb_futsal_id),
    foreign key(volei_fk) references tb_volei(tb_volei_id),
    foreign key(handebol_fk) references tb_handebol(tb_handebol_id),
	foreign key(natacao_fk) references tb_natacao(tb_natacao_id)

    );create table tb_produto(
tb_produto_id integer not null auto_increment primary key,
tb_produto_nome varchar (50) not null,
tb_produto_descricao varchar (100),
tb_produto_tipo varchar(25),
tb_produto_dt_chegada_estoque varchar(23) not null,
tb_produto_dt_verificacao varchar(23),
fornecedor_fk integer,
                                        
foreign key(fornecedor_fk) references tb_fornecedor(tb_fornecedor_id)
);
insert into tb_basquete(tb_basquete_turma, tb_basquete_horario)values("turma 1","18:30");
insert into tb_basquete(tb_basquete_turma, tb_basquete_horario)values("turma 2","19:30");
insert into tb_futsal(tb_futsal_turma, tb_futsal_horario)values("turma 4","21:30");
insert into tb_handebol(tb_handebol_turma, tb_handebol_horario)values("turma 3","13:30");
      insert into tb_natacao(tb_natacao_turma, tb_natacao_horario)values("turma 1","13:30");

insert into tb_volei(tb_volei_turma, tb_volei_horario)values("turma 2","20:30");
  insert into tb_professor(tb_professor_nome, tb_professor_email, tb_professor_telefone)
            values ("Professor", "professordefaut@gmail.com", 00000000);
			insert into tb_professor(tb_professor_nome, tb_professor_email, tb_professor_telefone)
            values ("Vanderlei", "Vanderlei@gmail.com", 4154298);

	insert into tb_alunos(tb_alunos_nome,tb_alunos_sexo, tb_alunos_email, tb_alunos_telefone,tb_alunos_celular, tb_alunos_complemento, tb_alunos_endereco, professor_fk, basquete_fk)
    values ("Ana", "Feminino", "pedro@gmail.com", "41542970",'11950587500',"Rua Franca", "360", 1, 1);
insert into tb_produto(
tb_produto_nome,
tb_produto_descricao,
tb_produto_tipo,
tb_produto_dt_chegada_estoque,
tb_produto_dt_verificacao,
fornecedor_fk
)
values('Tênis','esportivo, nike','vestuário','14-09-2020','14-09-2020',1);

create table tb_fornecedor(
tb_fornecedor_id integer not null primary key auto_increment,
tb_fornecedor_nome varchar(50) not null,
tb_fornecedor_email varchar (55)not null,
tb_fornecedor_telefone  varchar(34) not null, 
tb_fornecedor_celular  varchar(34) not null,                                                
tb_fornecedor_endereco varchar (65),
tb_fornecedor_identidade integer (20)
);

insert into tb_fornecedor(
tb_fornecedor_nome,
tb_fornecedor_email,
tb_fornecedor_telefone,
tb_fornecedor_celular,                                          
tb_fornecedor_endereco,
tb_fornecedor_identidade
)
values('Fornecedor','fornecedordefaut@hotmail.com','1000100110','10001001111','Rua Defaut','0000000100011100');

insert into tb_fornecedor (
tb_fornecedor_nome,
tb_fornecedor_email,
tb_fornecedor_telefone, 
tb_fornecedor_celular,                                               
tb_fornecedor_endereco,
tb_fornecedor_identidade
)
values('Geltech','gel.tech@hotmail.com','119876543','10001001111','Rua das Camélias N20','000000010001101');

create table TB_OITAVAS_ALUNO_1(
TB_OITAVAS_ID INTEGER auto_increment primary KEY,
TB_ALUNO_NOME VARCHAR (70)
);
insert tb_OITAVAS_aluno_1(TB_ALUNO_NOME) values('Adicione o primeiro aluno');

create table TB_OITAVAS_ALUNO_2(
TB_OITAVAS_ID INTEGER auto_increment primary KEY ,
TB_ALUNO_NOME VARCHAR (70)
);
insert tb_OITAVAS_aluno_2(TB_ALUNO_NOME) values('Adicione o primeiro aluno');

create table TB_OITAVAS_ALUNO_3(
TB_OITAVAS_ID INTEGER auto_increment primary KEY ,
TB_ALUNO_NOME VARCHAR (70)
);
insert tb_OITAVAS_aluno_3(TB_ALUNO_NOME) values('Adicione o primeiro aluno');

create table TB_OITAVAS_ALUNO_4(
TB_OITAVAS_ID INTEGER auto_increment primary KEY ,
TB_ALUNO_NOME VARCHAR (70)
);
insert tb_OITAVAS_aluno_4(TB_ALUNO_NOME) values('Adicione o primeiro aluno');

create table TB_OITAVAS_ALUNO_5(
TB_OITAVAS_ID INTEGER auto_increment primary KEY ,
TB_ALUNO_NOME VARCHAR (70)
);
insert tb_OITAVAS_aluno_5(TB_ALUNO_NOME) values('Adicione o primeiro aluno');

create table TB_OITAVAS_ALUNO_6(
TB_OITAVAS_ID INTEGER auto_increment primary KEY ,
TB_ALUNO_NOME VARCHAR (70)
);
insert tb_OITAVAS_aluno_6(TB_ALUNO_NOME) values('Adicione o primeiro aluno');

create table TB_OITAVAS_ALUNO_7(
TB_OITAVAS_ID INTEGER auto_increment primary KEY ,
TB_ALUNO_NOME VARCHAR (70)
);
insert tb_OITAVAS_aluno_7(TB_ALUNO_NOME) values('Adicione o primeiro aluno');

create table TB_OITAVAS_ALUNO_8(
TB_OITAVAS_ID INTEGER auto_increment primary KEY ,
TB_ALUNO_NOME VARCHAR (70)
);
insert tb_OITAVAS_aluno_8(TB_ALUNO_NOME) values('Adicione o primeiro aluno');

create table TB_OITAVAS_ALUNO_9(
TB_OITAVAS_ID INTEGER auto_increment primary KEY ,
TB_ALUNO_NOME VARCHAR (70)
);
insert tb_OITAVAS_aluno_9(TB_ALUNO_NOME) values('Adicione o primeiro aluno');

create table TB_OITAVAS_ALUNO_10(
TB_OITAVAS_ID INTEGER auto_increment primary KEY ,
TB_ALUNO_NOME VARCHAR (70)
);
insert tb_OITAVAS_aluno_10(TB_ALUNO_NOME) values('Adicione o primeiro aluno');

create table TB_OITAVAS_ALUNO_11(
TB_OITAVAS_ID INTEGER auto_increment primary KEY ,
TB_ALUNO_NOME VARCHAR (70)
);
insert tb_OITAVAS_aluno_11(TB_ALUNO_NOME) values('Adicione o primeiro aluno');

create table TB_OITAVAS_ALUNO_12(
TB_OITAVAS_ID INTEGER auto_increment primary KEY ,
TB_ALUNO_NOME VARCHAR (70)
);
insert tb_OITAVAS_aluno_12(TB_ALUNO_NOME) values('Adicione o primeiro aluno');

create table TB_OITAVAS_ALUNO_13(
TB_OITAVAS_ID INTEGER auto_increment primary KEY ,
TB_ALUNO_NOME VARCHAR (70)
);
insert tb_OITAVAS_aluno_13(TB_ALUNO_NOME) values('Adicione o primeiro aluno');

create table TB_OITAVAS_ALUNO_14(
TB_OITAVAS_ID INTEGER auto_increment primary KEY ,
TB_ALUNO_NOME VARCHAR (70)
);
insert tb_OITAVAS_aluno_14(TB_ALUNO_NOME) values('Adicione o primeiro aluno');

create table TB_OITAVAS_ALUNO_15(
TB_OITAVAS_ID INTEGER auto_increment primary KEY ,
TB_ALUNO_NOME VARCHAR (70)
);
insert tb_OITAVAS_aluno_15(TB_ALUNO_NOME) values('Adicione o primeiro aluno');

create table TB_OITAVAS_ALUNO_16(
TB_OITAVAS_ID INTEGER auto_increment primary KEY ,
TB_ALUNO_NOME VARCHAR (70)
);
insert tb_OITAVAS_aluno_16(TB_ALUNO_NOME) values('Adicione o primeiro aluno');

create table TB_QUARTAS_ALUNO_1(
TB_QUARTAS_ID INTEGER auto_increment primary KEY ,
TB_ALUNO_NOME VARCHAR (70)
);
insert tb_QUARTAS_aluno_1(TB_ALUNO_NOME) values('Adicione o primeiro aluno');

create Table TB_QUARTAS_ALUNO_2(
TB_QUARTAS_ID INTEGER auto_increment primary KEY ,
TB_ALUNO_NOME VARCHAR (70)
);
insert tb_QUARTAS_aluno_2(TB_ALUNO_NOME) values('Adicione o primeiro aluno');

create table TB_QUARTAS_ALUNO_3(
TB_QUARTAS_ID INTEGER auto_increment primary KEY ,
TB_ALUNO_NOME VARCHAR (70)
);
insert tb_QUARTAS_aluno_3(TB_ALUNO_NOME) values('Adicione o primeiro aluno');

create table TB_QUARTAS_ALUNO_4(
TB_QUARTAS_ID INTEGER auto_increment primary KEY ,
TB_ALUNO_NOME VARCHAR (70)
);
insert tb_QUARTAS_aluno_4(TB_ALUNO_NOME) values('Adicione o primeiro aluno');

create table TB_QUARTAS_ALUNO_5(
TB_QUARTAS_ID INTEGER auto_increment primary KEY ,
TB_ALUNO_NOME VARCHAR (70)
);
insert tb_QUARTAS_aluno_5(TB_ALUNO_NOME) values('Adicione o primeiro aluno');

create table TB_QUARTAS_ALUNO_6(
TB_QUARTAS_ID INTEGER auto_increment primary KEY ,
TB_ALUNO_NOME VARCHAR (70)
);
insert tb_QUARTAS_aluno_6(TB_ALUNO_NOME) values('Adicione o primeiro aluno');

create table TB_QUARTAS_ALUNO_7(
TB_QUARTAS_ID INTEGER auto_increment primary KEY ,
TB_ALUNO_NOME VARCHAR (70)
);
insert tb_QUARTAS_aluno_7(TB_ALUNO_NOME) values('Adicione o primeiro aluno');

create table TB_QUARTAS_ALUNO_8(
TB_QUARTAS_ID INTEGER auto_increment primary KEY ,
TB_ALUNO_NOME VARCHAR (70)
);
insert tb_QUARTAS_aluno_8(TB_ALUNO_NOME) values('Adicione o primeiro aluno');

create table TB_SEMI_ALUNO_1(
TB_SEMI_ID INTEGER auto_increment primary KEY ,
TB_ALUNO_NOME VARCHAR (70)
);
insert tb_semi_aluno_1(TB_ALUNO_NOME) values('Adicione o primeiro aluno');

create table TB_SEMI_ALUNO_2(
TB_SEMI_ID INTEGER auto_increment primary KEY,
TB_ALUNO_NOME VARCHAR (70)
);
insert tb_semi_aluno_2(TB_ALUNO_NOME) values('Adicione o primeiro aluno');

create table TB_SEMI_ALUNO_3(
TB_SEMI_ID INTEGER auto_increment primary KEY ,
TB_ALUNO_NOME VARCHAR (70)
);
insert tb_semi_aluno_3(TB_ALUNO_NOME) values('Adicione o primeiro aluno');

create table TB_SEMI_ALUNO_4(
TB_SEMI_ID INTEGER auto_increment primary KEY ,
TB_ALUNO_NOME VARCHAR (70)
);
insert tb_semi_aluno_4(TB_ALUNO_NOME) values('Adicione o primeiro aluno');


create table TB_FINAL_ALUNO_1(
TB_FINAL_ID INTEGER auto_increment primary KEY ,
TB_ALUNO_NOME VARCHAR (70)
);
insert tb_final_aluno_1(TB_ALUNO_NOME) values('Adicione o primeiro aluno');

create table TB_FINAL_ALUNO_2(
TB_FINAL_ID INTEGER auto_increment primary KEY ,
TB_ALUNO_NOME VARCHAR (70)
);
insert tb_final_aluno_2(TB_ALUNO_NOME) values('Adicione o primeiro aluno');

create table TB_CAMPEOES(
 TB_CAMPEOES_ID INTEGER auto_increment primary KEY,
 TB_ALUNO_NOME VARCHAR (70) NOT NULL,
 TB_DT_FINAL VARCHAR (20) NOT NULL,
 TB_MODALIDADE_CAMP VARCHAR (10) NOT NULL,
 TB_NOME_ORGANIZADOR VARCHAR (23),
 TB_NOME_LOCAL VARCHAR (55)
);

/*update tb_alunos set tb_alunos_18_07_2020 = "falta" where tb_alunos_id;*/   
	    /* 
        select  tb_alunos_id as "Identificação", tb_alunos_nome as "Aluno",tb_basquete_turma as "Turma", tb_basquete_horario as "Horario", tb_professor_nome as "Professor"
		from tb_alunos inner join tb_basquete on
        tb_alunos.BASQuete_fk = tb_basquete.tb_basquete_id
        inner join tb_professor on
		tb_alunos.professor_fk = tb_professor.tb_professor_id
        where tb_basquete_turma = "turma 2"
        group by tb_alunos_nome; 
        */
	
                           
