--use master;
--go

--drop database if exists eravjezba1;
--go


--create database eravjezba1;
--go

--use eravjezba1;
--go


create table sport(
sifra int not null primary key identity (1,1),
ime varchar (30) not null,
broj_posjetitelja int not null,
teren varchar (20) not null,
mjesto int not null,
lopta int not null
);


create table nogomet(
sifra int not null primary key identity (1,1),
ime varchar (30) not null references ime(sifra),
stadion varchar (50) not null,
mjesto int not null references mjesto (sifra),
broj_posjetitelja int not null,
lopta int not null,
teren varchar (30) not null
);


create table kosarka(
sifra int not null primary key identity (1,1),
ime varchar (30) not null references ime(sifra),
teren varchar (20) not null,
broj_igraca int not null,
lopta int not null,
broj_posjetitelja int not null 
);



create table tenis(
sifra int not null primary key identity (1,1),
ime varchar (30) not null references ime (sifra),
teren varchar (30) not null ,
lopta int not null,
broj_igraca int not null,
broj_posjetitelja int not null references broj_posjetitelja (sifra)
);

 