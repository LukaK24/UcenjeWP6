create database nogometniklub;


create table lopta(
sifra int,
velicina varchar (10),
naziv varchar (15),
cijena decimal (3,2)
);

create table kopacke(
sifra int,
velicina varchar (10)
cijena decimal (3,2)
boja int,
materijal int,
);

create table dres(
sifra int,
cijena decimal (3,2),
velicina varchar (10),
broj varchar (10),
boja int,
materijal int
);