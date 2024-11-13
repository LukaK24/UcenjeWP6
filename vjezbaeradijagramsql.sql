use master;
go

drop database if exists eravjezba;
go


create database eravjezba;
go

use eravjezba;
go

create table klub(
sifra int not null primary key identity(1,1),
naziv varchar (30) not null,
osnovan varchar (40) not null,
stadion int not null,
predsjednk int not null,
drzava int not null,
liga int not null,
);

create table utakmica(
sifra int not null primary key identity(1,1),
datum datetime not null,
vrijeme time not null,
lokacija varchar (40) not null,
stadion varchar (50) not null,
domaci_klub int  not null references klub(sifra),
gostojuci_klub int  not null references klub(sifra)
);

create table igrac(
sifra int not null primary key identity (1,1),
ime varchar (40) not null,
prezime varchar (30) not null,
datum_rodenja datetime not null,
pozicija int not null,
broj_dresa varchar (10) not null,
klub int not null references klub(sifra)
);

create table trener(
sifra int not null primary key identity (1,1),
ime varchar (20) not null,
prezime varchar (20) not null,
klub int not null references klub(sifra),
nacionalsnot int not null,
iskustvo int not null
);