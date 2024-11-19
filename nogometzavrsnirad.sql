use master;
go

drop database if exists nogomet;
go


create database nogomet;
go

use nogomet;
go

create table klub(
sifra int not null primary key identity(1,1),
naziv varchar (30) not null,
osnovan varchar (40) not null,
stadion int not null,
trener int not null,
drzava int not null,
liga int not null,
);

create table utakmica(
sifra int not null primary key identity(1,1),
datum datetime not null,
vrijeme time not null,
stadion varchar (50) not null,
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

create table trener(
sifra int not null primary key identity (1,1),
ime varchar (20) not null,
prezime varchar (20) not null,
klub int not null references klub(sifra),
iskustvo int not null,
);









