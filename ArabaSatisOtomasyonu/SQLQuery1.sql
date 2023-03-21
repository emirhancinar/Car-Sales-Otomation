use ArabaSatis

Create Table ArabaMarka(
markaID int primary Key identity(1,1),
marka varchar(50) not null,

)
Create Table ArabaModeli(
modelID int primary Key identity(1,1),
markaID int not null,
model varchar(50) not null,
)

Create Table ArabaYil(
yilID int primary Key identity(1,1),
modelID int not null,
markaID int not null,
uretimyili varchar(50) not null,
fiyat int not null 
)

Create Table Yonetici(
yoneticiID int primary key identity(1,1),
kAdi nvarchar(50),
sifre nvarchar(50)
)

create table Musteriler
(
musteriID int primary key identity(1,1),
mKAdi varchar(50) not null,
sifre int not null,
adres varchar(30),
ceptel char(11) unique check(len(ceptel)=11 and ceptel like '05%'), --default('05%%%%%%%%%')
e_posta varchar(30) unique check(e_posta like('%@%'))
)

create table Satislar
(
satisID int primary key identity(1,1),
musteriID int,
yilID int,
satistarihi date default(getdate())
)

--alter table Cars ADD fiyat int;
alter table ArabaYil ADD resim nvarchar(150);
alter table ArabaYil Alter Column uretimyili nvarchar(10)

Select Marka.marka,Model.model From ArabaMarka Marka INNER JOIN ArabaModeli Model ON Marka.markaID = Model.markaID 

--ALTER TABLE ArabaModel
--ADD FOREIGN KEY (markaID) REFERENCES ArabaMarka(markaID);

--ALTER TABLE ArabaModeli
--ADD CONSTRAINT FK_marka1
--FOREIGN KEY (markaID) REFERENCES ArabaMarka (markaID);

--ALTER TABLE ArabaYil
--ADD CONSTRAINT FK_marka2
--FOREIGN KEY (markaID) REFERENCES ArabaMarka (markaID);

--ALTER TABLE ArabaYil
--ADD CONSTRAINT FK_model1
--FOREIGN KEY (modelID) REFERENCES ArabaModeli (modelID);

--ALTER TABLE ArabaYil
--DROP CONSTRAINT FK_marka2;

--select marka,model,uretimyili,fiyat from ArabaMarka inner join ArabaModeli on ArabaMarka.markaID=ArabaModeli.markaID 
--inner join ArabaYil on ArabaModeli.modelID=ArabaYil.modelID where ArabaModeli.markaID=1 and ArabaYil.modelID=3

--select marka,model from ArabaMarka inner join ArabaModeli on ArabaMarka.markaID=ArabaModeli.markaID 
--where ArabaMarka.marka='Mercedes'

--select marka,model,uretimyili,fiyat from ArabaMarka inner join ArabaModeli on ArabaMarka.markaID=ArabaModeli.markaID 
--inner join ArabaYil on ArabaModeli.modelID=ArabaYil.modelID where ArabaMarka.marka='Mercedes' and ArabaModeli.model='400D 3.0 AMG'

--Select * from ArabaYil

--Toplam Müþteri Harcamalarý
Select  Musteriler.mKAdi,Sum(fiyat) as [Toplam Müþteri Harcamalarý] from Satislar Inner Join Musteriler on Musteriler.musteriID=Satislar.musteriID inner join ArabaYil on 
ArabaYil.yilID=Satislar.yilID GROUP BY mKAdi 

--Markalarýn En Pahalý Arabalarý
select marka,MAX(fiyat)as [En Pahalý Araba] from ArabaMarka inner join ArabaModeli on ArabaMarka.markaID=ArabaModeli.markaID 
inner join ArabaYil on ArabaModeli.modelID=ArabaYil.modelID Group by marka

-- bugün alýþ veriþ yapan müþteriler
Select mKAdi from Satislar inner join Musteriler on Musteriler.musteriID=Satislar.musteriID 
where satistarihi=CONVERT(varchar, getdate(), 23)

--yýl ay gün e döndürür getdate ti
SELECT CONVERT(varchar, getdate(), 23)