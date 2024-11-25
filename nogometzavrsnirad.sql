--use master;
go

--drop database if exists nogomet;
go


--create database nogomet collate Croatian_CI_AS;
go 

--use nogomet;
go

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
domaci_klub int  not null references klub(sifra),
gostojuci_klub int  not null references klub(sifra)
);

create table igrac(
sifra int not null primary key identity (1,1),
ime varchar (40) not null,
prezime varchar (30) not null,
pozicija int not null,
klub int not null references klub(sifra),
oib char (11)
);


--insert into trener (ime,prezime,klub,iskustvo )
--values 
--('Carlo','Anchelotti','Real Madrid',29),
--('Pep','Guardiola','Manchester City',17),
--('Hansi','Flick','Barcelona',18),
--('Xavi','Alonso','Bayern Leverkusen',6);

--select * from trener;

insert into klub (naziv,osnovan,stadion,drzava,liga )
values 
('Real Madrid',1902,'Santiago Bernabéu','Španjolska','LaLiga'),
('Manchester City',1880,'Etihad','Engleska','Premier League'),
('Barcelona',1899,'Spotify Camp','Španjolska','LaLiga'),
('Bayern Leverkusen',1904,'BayArena','Njemačka','Bundesliga');

select * from klub