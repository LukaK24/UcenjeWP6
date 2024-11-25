--use master;
--go

--drop database if exists nogomet;
--go


--create database nogomet collate Croatian_CI_AS;
--go 

--use nogomet;
--go

create table trener(
sifra int not null primary key identity (1,1),
ime varchar (20) not null,
prezime varchar (20) not null,
klub varchar (50) not null references klub (sifra),
iskustvo int not null
);

create table klub(
sifra int not null primary key identity(1,1),
naziv varchar (30) not null,
osnovan varchar (40) not null,
stadion Varchar (50) not null,
drzava varchar (50) not null,
liga varchar (50) not null
);

create table utakmica(
sifra int not null primary key identity(1,1),
datum datetime not null,
vrijeme time not null,
domaci_klub varchar (40)  not null references klub(sifra),
gostojuci_klub varchar (40)  not null references klub(sifra)
);

create table igrac(
sifra int not null primary key identity (1,1),
ime varchar (40) not null,
prezime varchar (30) not null,
pozicija varchar (30) not null,
klub varchar (50) not null references klub(sifra),
oib char (11)
);


insert into trener (ime,prezime,klub,iskustvo )
values 
('Carlo','Anchelotti','Real Madrid',29),
('Pep','Guardiola','Manchester City',17),
('Hansi','Flick','Barcelona',18),
('Xavi','Alonso','Bayern Leverkusen',6);

select * from trener;

insert into klub (naziv,osnovan,stadion,drzava,liga )
values 
('Real Madrid',1902,'Santiago Bernabéu','Španjolska','LaLiga'),
('Manchester City',1880,'Etihad','Engleska','Premier League'),
('Barcelona',1899,'Spotify Camp','Španjolska','LaLiga'),
('Bayern Leverkusen',1904,'BayArena','Njemačka','Bundesliga');

select * from klub

-- Invalid object name 'utakimca'.
insert into utakimca (datum,vrijeme,domaci_klub,gostojuci_klub)
values 
('20-05-2024','16:00','Real Madrid','Barcelona'),
('14-06-2024','19:00','Manchester City','Bayern Leverkusen'),
('24-04-2024','18:00','Barcelona','Bayer Leverkusen'),
('25-05-2024','17:00','Manchester City','Bayer Leverkusen'),
('23-03-2024','19:00','Barcelona','Manchester City'),
('01-04-2024','18:00','Real Madrid','Bayer Leverkusen'),
('05-03-2024','18:00','Real Madrid','Barcelona');

select * from utakmica

drop table utakmica;


insert into igrac (ime,prezime,pozicija,klub,oib)
values
('Federico','Valverde','obrana','Real Madrid',08057077736),
('Luka','Modrić','veza','Real Madrid',07837540514),
('Mateo','Kovačić','veza','Manchester City',26981510319),
('Joško','Gvardiol','Manchester City','obrana',44021291244),
('Dani','Olmo','Barcelona','veza',44337232806),
('Lamine','Yamal','Barcelona','napad',25169325706),
('Jeremine','Frimpong','Bayern Leverkusen','obrana',99598162856),
('Florian','Wirtz','Bayern Leverkusen','veza',38124701663);


drop table igrac;