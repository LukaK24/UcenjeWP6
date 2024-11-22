select * from smjerovi;

--minimalna select naredba

select 1;

--filtriranje kolona (izmedu select i front)
--* sve kolone 
--kolona 
--konstanta
--izraz
select naziv as n1, cijena as c1, naziv, 'Osijek' as Grad, cijena*1.25 as sPDV, getdate() as kada,* from smjerovi;


--izlistajte imena i prezimena polaznika

select * from polaznici

select ime, prezime from polaznici;


--filtriranje redova

select * from polaznici;

update polaznici set oib = '69813399630' where sifra=4;

select * from polaznici
where not (
sifra=4 and (sifra=9 or sifra=12));

 
 select * from polaznici where ime not like '%a';

 --ostali operatori: in

 select * from polaznici
 where sifra in (1,7,9);

 -- ostali operatori: between

select * from smjerovi
where izvodiseod between '2024-01-01' and '2024-12-31';

--slaganje rezultat
select prezime, ime from polaznici
order by prezime, 2;

--ograničivanje rezultat 
select top 10 percent * from polaznici;

select top 10 ime, prezime into nova from polaznici 

 
 select * from nova

 --brisanje tablice
 drop table nova;

 --prebacivanje tablice
 use knjiznica;

--ukupno redova
 select count(*) from autor;



select top 10 * from autor;

--unesite sebe kao autora

INSERT into autor (sifra, ime, prezime, datumrodenja) 
values (4,'Luka','Kordić','30-12-2000');



select top 10 * from katalog;


--spajanje tablica
select top 10 a.ime, a.prezime, b.naslov, c.naziv
from autor a inner join katalog b
on a.sifra = b.autor 
inner join mjesto c 
on c.sifra = b.mjesto;


select *
from autor a right join katalog b
on a.sifra=b.autor;



use svastara;

select count(*) from artikli; --52601
select distinct artikl from artiklinaprimci; --52599

select * from artikli where 
sifra not in (select distinct artikl from artiklinaprimci);


delete artikli where sifra=79102;