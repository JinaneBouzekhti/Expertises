drop database expertises
--creation du base de donnée
create database expertises;
go
use expertises
go
----

--creation des Tables
create table typeUtilisateur(
 NumtypeUtilisateur int constraint pk_typeUtilisateur primary key identity (1,1),
 NomtypeUtilisateur Nvarchar(150),
);

go

create table Utilisateur(
login varchar(50) constraint pk_Utilisateur primary key,
password varchar(500),
Nom varchar(50),
Prenom varchar(50),
Email varchar(50)constraint uniqueMail unique ,
Validation bit,
Hash varchar(200),
type int constraint fk_Utilisateur_typeU foreign key  references typeUtilisateur(NumtypeUtilisateur)on delete cascade,
);

go



 create table DernierSession(
 login varchar(50) constraint pk_DernierSession primary key,
 password varchar(50),
 local varchar(50)
 );
 
go  


 create table CoursAppel(
 NumCoursAppel int constraint pk_CoursAppel primary key identity (1,1),
 NomCoursAppel Nvarchar(150),
 );
 
 go 
 
  create table TribunauxPremière(
 NumTribunalP int constraint pk_TribunalP primary key identity (1,1),
 NomTribunalP Nvarchar(150),
 NumCoursAppel int constraint fk_TribP_CoursAppel foreign key  references CoursAppel (NumCoursAppel)on delete cascade,
 );
 
 go 
 
 create table TypeExp(
 NumTypeExp int constraint pk_TypeExp primary key identity (1,1),
 typeExp Nvarchar(150),
 code int,
 );
 
  go
  
 create table Statut(
 NumStatut int constraint pk_Statut primary key identity (1,1),
 statut Nvarchar(150),
 );
  
  go

create table Expertise(
RefCabinet int constraint pk_Expertise primary key ,
RefRéféré Nvarchar(100),
NumTribunalP int constraint  fk_Exp_Trib foreign key  references TribunauxPremière(NumTribunalP)on delete cascade,
NomMagistrat Nvarchar(150),
NomJugeControleur Nvarchar(150),
NomGreffier Nvarchar(150),
TypeDécision Nvarchar(150),
DateDécision date,
DateDésignation date,
DateAcceptation date,
DateConsignation date,
MontantConsignation float,
LieuExp Nvarchar(200),
NumTypeExp int  constraint  fk_Exp_TypeExp foreign key  references TypeExp (NumTypeExp)on delete cascade,
DateConvPart date,
DateRvPart date,
HeureRvPart varchar(50),
RépertoireDoc Nvarchar(200),
NumStatut int constraint fk_Exp_Statut foreign key  references Statut (NumStatut)on delete cascade,
Terminé bit
);

 go
 
 create table Avocat(
 NumAv int constraint pk_Avocat primary key identity (1,1),
 NomCompletAv Nvarchar(150),
 Portable Nvarchar(50),
 );

go

 create table JudicialCommissioner(
 NumJC int constraint pk_JC primary key identity (1,1),
 NomCompletJC Nvarchar(150),
 Portable Nvarchar(50),
 );

go

 create table Demandeur(
 NumDem int constraint pk_Demandeur primary key identity (1,1),
 NomCompletDem Nvarchar(500),
 NumAv int constraint fk_Dem_Av foreign key  references Avocat (NumAv)on delete cascade,
 Adresse Nvarchar(500),
 Portable Nvarchar(50),
 RefCabinet int constraint fk_Dem_Exp foreign key  references Expertise (RefCabinet)on delete cascade,
 );

go

 create table Défenseur(
 NumDéf int constraint pk_Défenseur primary key identity (1,1),
 NomCompletDéf Nvarchar(150),
 NumAv int constraint fk_Déf_Av foreign key  references Avocat (NumAv)on delete cascade,
 Adresse Nvarchar(500),
 Portable Nvarchar(50),
 RefCabinet INT constraint fk_Déf_Exp foreign key  references Expertise (RefCabinet)on delete cascade,
 );
 
go  

-----
  select * from typeutilisateur
  insert into typeutilisateur values ('admin');
  insert into typeutilisateur values ('autre');

  select * from utilisateur
  insert into utilisateur values ('admin','123','Barhoun','Ibrahim','IbrahimBR@gmail.com',1,'',2);

  select * from CoursAppel
  insert into CoursAppel values (N'محكمة الإستئناف بالرباط')
  insert into CoursAppel values (N'محكمة الإستئناف بالدار البيضاء')
  insert into CoursAppel values (N'محكمة الإستئناف بأكادير')
  insert into CoursAppel values (N'محكمة الإستئناف بكلميم')
  insert into CoursAppel values (N'محكمة الإستئناف بورزازات')
  insert into CoursAppel values (N'محكمة الإستئناف بالحسيمة')
  insert into CoursAppel values (N'محكمة الإستئناف بتازة')
  insert into CoursAppel values (N'محكمة الإستئناف ببني ملال')
  insert into CoursAppel values (N'محكمة الإستئناف بفاس')
  insert into CoursAppel values (N'محكمة الإستئناف بالقنيطرة')
  insert into CoursAppel values (N'محكمة الإستئناف بالعيون')
  insert into CoursAppel values (N'محكمة الإستئناف بمراكش')
  insert into CoursAppel values (N'محكمة الإستئناف بمكناس')
  insert into CoursAppel values (N'محكمة الإستئناف بالرشيدية')
  insert into CoursAppel values (N'محكمة الإستئناف بوجدة')
  insert into CoursAppel values (N'محكمة الإستئناف بالناضور')
  insert into CoursAppel values (N'محكمة الإستئناف بآسفي')
  insert into CoursAppel values (N'محكمة الإستئناف بالجديدة')
  insert into CoursAppel values (N'محكمة الإستئناف بسطات')
  insert into CoursAppel values (N'محكمة الإستئناف بخريبكة')
  insert into CoursAppel values (N'محكمة الإستئناف بطنجة')
  insert into CoursAppel values (N'محكمة الإستئناف بتطوان')
  
  
   select * from TribunauxPremière
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بالرباط',1)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بسلا',1)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بتمارة',1)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بالخميسات',1)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بتيفلت',1)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بالرماني',1)
 
  insert into TribunauxPremière values (N'المحكمة الإبتدائية الزجرية بالدار البيضاء',2)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بالمحمدية',2)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية ببنسليمان',2)
  
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بأكادير',3)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بانزكان',3)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بتارودانت',3)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بتيزنيت',3)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بطاطا',3)
  
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بكلميم',4)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بطان طان',4)
  
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بورزازات',5)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بزاكورة',5)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بتنغير',5)
  
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بالحسيمة',6)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بتارجيست',6)
  
  insert into TribunauxPremière values (N'المحكمة الإبتدائية  بتازة',7)
  
  insert into TribunauxPremière values (N'المحكمة الإبتدائية ببني ملال',8)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بخنيفرة',8)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بقصبة تادلة',8)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بالفقيه بن صالح',8)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بسوق السبت أولاد النمة',8)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بأزيلال',8)
  
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بفاس',9)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بصفرو',9)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية لبولمان بميسور',9)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بتونات',9)
  
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بالقنيطرة',10)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بسيدي سليمان',10)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بسوق الأربعاء',10)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بسيدي قاسم',10)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بمشرع بلقصيري',10)
  
  
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بالعيون',11)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بالداخلة',11)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية  بالسمارة ',11)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية  ببوجدور',11)
  
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بمراكش',12)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بامنتانوت',12)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بقلعة السراغنة',12)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بابن جرير',12)
  insert into TribunauxPremière values (N'مركز القاضي المقيم بشيشاوة',12)
  insert into TribunauxPremière values (N'مركز القاضي المقيم بأيت أورير',12)
  
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بمكناس',13)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بآزرو',13)
  
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بميدلت',14)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بالرشيدية',14)
  
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بجرسيف',15)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بوجدة',15)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بتاوريرت',15)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية ببركان',15)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية لفجيج ببوعرفة',15)
  
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بالناضور',16)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بالدريوش',16)
  
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بآسفي',17)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية باليوسفية',17)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بالصويرة',17)
  
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بالجديدة',18)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بسيدي بنور',18)
  
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بسطات',19)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية ببرشيد',19)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بابن أحمد',19)
  
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بخريبكة',20)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بواد زم',20)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بأبي الجعد',20)
  
  
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بطنجة',21)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بأصيلة',21)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بالعرائش',21)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بالقصر الكبير',21)
  
  
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بوزان',22)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بتطوان',22)
  insert into TribunauxPremière values (N'المحكمة الإبتدائية بشفشاون',22)
  
  
  
  select *from TypeExp
  insert into TypeExp values(N'العقار العادي',1401)
  insert into TypeExp values(N'العقار المحفظ',1402)
  insert into TypeExp values(N'العقار في طور التحفيظ',1403)
  insert into TypeExp values(N'القضايا العقارية العينية المختلطة',1404)
  insert into TypeExp values(N'قضايا المشورة عقار',1405)
  insert into TypeExp values(N'العقار العبري',1406)
  insert into TypeExp values(N'العقار العادي المستأنف',1451)
  insert into TypeExp values(N'العقار المحفظ المستأنف',1452)
  insert into TypeExp values(N'العقار في طور التحفيظ المستأنف',1453)
  insert into TypeExp values(N'القضايا العقارية العينية المختلطة المستأنف',1454)
  insert into TypeExp values(N'قضايا المشورة عقار المستأنف',1455)
  insert into TypeExp values(N'العقار العبري المستأنف',1456)
  insert into TypeExp values(N'الميراث',1615)
  
  
  select * from Statut
  insert into Statut values(N'خبرة غير منجزة')
  
  
  select * from expertise
  insert into expertise values (1,'2021/1615/1153',75,N'التملالي عمر','','',N'مدني افتتاحي','28/02/2022','','','25/11/2021',5000,'',13,'','','4:30','E:\Exepertises\EXP-1-2022',1,0)
  insert into expertise values (2,'2021/1615/1153',75,N'التملالي عمر','','',N'مدني افتتاحي','28/02/2022','','','25/11/2021',5000,'',13,'','','4:30','E:\Exepertises\EXP-2-2022',1,0)

  select * from Avocat
  insert into Avocat values(N'الإدريسي مصطفى','+212600000000')
  
  select * from Demandeur
  insert into Demandeur values(N'أحمدأفتحو',1,'','+212600000000',1)
  insert into Demandeur values(N'فاطمة أفتحو',1,'','+212600000000',1)
  
  
  select * from Défenseur
  insert into Défenseur values(N'سعيد بومقضي',1,'','+212600000000',1)
  insert into Défenseur values(N'ارحيمو بومقضي',1,'','+212600000000',1)
  
  