CREATE PROCEDURE [dbo].Add_movies
   @movieName VARCHAR(45),
   @length_minutes TIME,
   @AgeLimit varchar(15),
   @MovieGenre varchar(100)
AS
BEGIN
   INSERT INTO Movie(movieName,length_minutes,AgeLimit,MovieGenre) values(@movieName ,@length_minutes ,
					        @AgeLimit,@MovieGenre)
END