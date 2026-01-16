--connection string to backend

Scaffold-DbContext "Server=tcp:ashfaqhussainserver.database.windows.net,1433;Initial Catalog=onlineVideoStreaming(Ashfaq);Persist Security Info=False;User ID=ashfaq;Password=Rain@asaa4;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -force


--Users Table

CREATE TABLE UsersData(
	userId INT PRIMARY KEY IDENTITY,
	userName VARCHAR(50),
	userEmail VARCHAR(50) NOT NULL UNIQUE,
	userPassword VARCHAR(50)
);


SELECT * FROM dbo.UsersData;



--videos table

CREATE TABLE videosData(
	videoId INT PRIMARY KEY IDENTITY,
	videoName VARCHAR(100),
	videoUrl VARCHAR(200)
);


INSERT INTO videosData (videoName, videoUrl) 
VALUES
('Shershaah - Audio Jukebox | Sidharth Malhotra, Kiara Advani', 'https://www.youtube.com/embed/2FRrtuu3Ljg?si=29ad3XVfGwt2LyD7'),
('Jag Ghoomeya Full Song | SULTAN | Salman Khan, Anushka Sharma', 'https://www.youtube.com/embed/t10sQb0Zmjs?si=nuK33VxUrw07LYBG'),
('Dekhha Tenu | Mr. & Mrs. Mahi | Rajkummar Rao, Janhvi Kapoor | Mohd. Faiz', 'https://www.youtube.com/embed/rMfugUZD2dA?si=Bc5kz6LlWOEcUtpf'),
('Bulleya Song with Lyrics | Sultan | Salman Anushka', 'https://www.youtube.com/embed/_51KXfwcPMs?si=06ttA5aN9KIX8jvf'),
('Tu Mera Koi Na Hoke Bhi Kuch Lage (Apna Bana Le Piya) Arijit Singh | Varun Dhawan', 'https://www.youtube.com/embed/r6dujv24KkQ?si=zPlB9GK9_w4Gm50K'),
('Tu Mera Koi Na Hoke Bhi Kuch Lage', 'https://www.youtube.com/embed/r6dujv24KkQ?si=dpE4mJZJo9kvKhui'),
('Naino Ne Baandhi - Lyrical | Gold | Akshay Kuma', 'https://www.youtube.com/embed/Y9ozt29tzgs?si=EZ-62rJwW8xp83rA'),
('Zaalima | Raees | Shah Rukh Khan & Mahira Khan | Arijit Singh', 'https://www.youtube.com/embed/AzPUuqLL2Oc?si=-krXjKPLAFn8e57i'),
('Angular Tutorial in Hindi', 'https://www.youtube.com/embed/0LhBvp8qpro?si=2qz2QuyoW1jwZBAV'),
('Angular Tutorial for Beginners', 'https://www.youtube.com/embed/k5E2AVpwsko?si=Hrp2xoQrVxw3Lokm'),
('Ecommerce App with Angular | Angular 17 Project | Admin Application', 'https://www.youtube.com/embed/hejR2GfFXiA?si=m-h3TX8LTemfQ3dU'),
('.Net Fundamentals | Introduction to .NET Framework | .NET for Beginners', 'https://www.youtube.com/embed/8ew1LgfWV6s?si=wxgZTq6Dn3MlhVkO'),
('.Net Tutorial | .Net Framework Tutorial | Asp.net Tutorial | Learn Dot Net', 'https://www.youtube.com/embed/kdPtNMb8tPw?si=JqxRCc0GSnY49f_S'),
('Taarak Mehta Ka Ooltah Chashmah | Ep 4109', 'https://www.youtube.com/embed/-5Lk8djC8W0?si=G9BT-KXFEMcpfTXF'),
('Taarak Mehta Ka Ooltah Chashmah', 'https://www.youtube.com/embed/mAWSWYlzIJU?si=NGtro8cZcB7102Qb'),
('Jetha & Taarak Under Arrest', 'https://www.youtube.com/embed/xnkp8AF4FTs?si=i-nv6ReWY2rog412'),
('Restless? | Taarak Mehta Ka Ooltah Chashmah | Comedy Lagataar', 'https://www.youtube.com/embed/zhPMawrJiqc?si=FkzNv98rqNgF3D6n');





CREATE TABLE bobVideosData(
	videoId INT PRIMARY KEY IDENTITY,
	videoName VARCHAR(100),
	videoUrl VARCHAR(200)
);

SELECT * FROM dbo.bobVideosData;

INSERT INTO bobVideosData(videoName,videourl) VALUES('Flowers','https://videoashfaqdata.blob.core.windows.net/newdata/Flowers.mp4'),
('Jungle','https://videoashfaqdata.blob.core.windows.net/newdata/Jungle-1.mp4'),
('Jungle','https://videoashfaqdata.blob.core.windows.net/newdata/Jungle.mp4'),
('Nature','https://videoashfaqdata.blob.core.windows.net/newdata/Nature-1.mp4'),
('Nature','https://videoashfaqdata.blob.core.windows.net/newdata/Nature-2.mp4'),
('Nature','https://videoashfaqdata.blob.core.windows.net/newdata/Nature-3.mp4'),
('Nature','https://videoashfaqdata.blob.core.windows.net/newdata/Nature-4.mp4'),
('Nature','https://videoashfaqdata.blob.core.windows.net/newdata/Nature-5.mp4'),
('Nature','https://videoashfaqdata.blob.core.windows.net/newdata/Nature-6.mp4'),
('Nature','https://videoashfaqdata.blob.core.windows.net/newdata/Nature.mp4'),
('Relaxation','https://videoashfaqdata.blob.core.windows.net/newdata/Relaxation.mp4'),
('Sea','https://videoashfaqdata.blob.core.windows.net/newdata/Sea-1.mp4'),
('Sea','https://videoashfaqdata.blob.core.windows.net/newdata/Sea.mp4');



--history Table

CREATE TABLE history(
	historyId INT PRIMARY KEY IDENTITY,
	videoName VARCHAR(200),
	videoUrl VARCHAR(200),
	videoId INT,
	userId INT,
	userName VARCHAR(200)
);


select * from dbo.bobVideosData;
select * from dbo.UsersData;
zonasha

select * from dbo.history
insert into history(videoName,videoUrl,videoId,userId,userName) values('Relaxation','https://videoashfaqdata.blob.core.windows.net/newdata/Relaxation.mp4','11','3','ashfaq');





--Liked Table

CREATE TABLE likes(
	likeId INT PRIMARY KEY IDENTITY,
	videoName VARCHAR(100),
	videoUrl VARCHAR(200),
	videoId INT,
	userId INT,
	userName VARCHAR(100)
);

select * from dbo.likes


-- Favourite Table

CREATE TABLE Favourite(
	favouriteId INT PRIMARY KEY IDENTITY,
	videoName VARCHAR(100),
	videoUrl VARCHAR(200),
	videoId INT,
	userId INT,
	userName VARCHAR(100)
);


SELECT * FROM dbo.Favourite;
truncate table dbo.Favourite;
SELECT * FROM dbo.bobVideosData;
select * from dbo.UsersData;
select * from dbo.Comments;




-- Comments

CREATE TABLE Comments(
	commentId INT PRIMARY KEY IDENTITY,
	commentName VARCHAR(100),
	videoId INT,
	videoUrl VARCHAR(200),
	userId INT,
	userName VARCHAR(100)
);


select * from dbo.Comments;
select * from dbo.bobVideosData;
select * from UsersData;

TRUNCATE table dbo.UsersData;



create table doing(
	id int primary key identity,
	name varchar(20)
);




--admin table

CREATE TABLE Admin(
	ID INT PRIMARY KEY IDENTITY,
	adminName VARCHAR(100),
	adminEmail VARCHAR(100),
	adminPassword VARCHAR(100)
);


INSERT INTO Admin(adminName,adminEmail,adminPassword) VALUES('Ashfaq Hussain','ashfaqhussainmd15@gmail.com','ashfaqAdmin@15');



SELECT * FROM dbo.Admin;


select * from dbo.Admin;
select * from dbo.bobVideosData;
truncate table dbo.bobVideosData;
select * from dbo.Comments;
truncate table dbo.Comments;
select * from dbo.Favourite;
truncate table dbo.Favourite;
select * from dbo.history;
truncate table dbo.history;
select * from dbo.likes;
truncate table dbo.likes;
select * from dbo.UsersData;


INSERT INTO bobVideosData(videoName,videoUrl) VALUES('The Latest on Material 3 in Angular', 'https://videoashfaqdata.blob.core.windows.net/newdata/Angular.mp4');



CREATE TABLE Rating(
	ratingId INT PRIMARY KEY IDENTITY,
	ratingNumber INT,
	videoId INT,
	videoUrl VARCHAR(200),
	videoName VARCHAR(100),
	userId INT,
	userName VARCHAR(100)
);



SELECT * FROM dbo.Rating;

