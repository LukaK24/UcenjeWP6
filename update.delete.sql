select * from smjerovi

-- UPDATE NAREDBA

update smjerovi set cijena =1100
where sifra=2 --ako mijenjamo po PRIMARNOM KLJUCU tada mijenjamo 1 red

update smjerovi set
izvodiseod='2021-12-05', 
vaucer=0
where sifra=2;


select * from polaznici where sifra=16;


update polaznici set prezime='Franjić' where sifra=16


select * from polaznici where sifra=16;


insert into smjerovi (naziv, cijena, izvodiseod, vaucer)
values ('webprogramiranje',1000,'2024-04-05 14:00',1);

insert into smjerovi (naziv, cijena, izvodiseod, vaucer)
values ('programiranje',1200,'2024-11-06 17:00',1);

insert into smjerovi (naziv, cijena, izvodiseod, vaucer)
values ('webdizajn',800,'2024-02-06 10:00',1);


select * from smjerovi;
update smjerovi set cijena = cijena *0.9;
select * from smjerovi;


--uvećajte sve cijene za 35&


select * from smjerovi;
update smjerovi set cijena = cijena *1.35;
select * from smjerovi;

--smanjiti svim msjerovima cijenu za 10e 


select * from smjerovi;
update smjerovi set cijena = cijena - 10;
select * from smjerovi;



-- uvjet vanjskog kljuca
update grupe set smjer=6 where sifra=1;

--DELET naredba
select * from smjerovi;
delete from smjerovi where sifra>5;
select * from smjerovi;


select * from grupe;
update grupe set smjer=1 where sifra=1;

delete grupe where sifra=1;

select * from clanovi;


update clanovi set grupa=2 where grupa=1;