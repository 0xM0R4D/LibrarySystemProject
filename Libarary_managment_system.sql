// LibraryDataBase
create table Libarary_user
(
	fName varchar(100) not null, 
	lName varchar(100) not null ,
	country varchar(100) not null, 
	email varchar(100) primary key,
	Address varchar(100) not null , 
	role varchar(10) not null default 'user'
);


create table Libaray_login
(
	loginEmail varchar(100) primary key,
	loginPassword varchar(100) not null,
	constraint login_fk foreign key (loginEmail) references Libarary_user(email)
);

create table Category
(
	categoryID int primary key,
	categName varchar(100) not null

);

create table Publisher
(
	publisherID int primary key,
	publisherName varchar(100) not null,
	publisherAddress varchar(100) not null,
	publisherPhone varchar(100) ,
	publisherEmail varchar(100) not null

);
create table Author
(
	authorID int primary key,
	authorName varchar(100) not null,
	authorAddress varchar(100) not null,
	authorEmail varchar(100) not null

);
create table Libarary_book
(
	bookID int primary key,
	bookTitle varchar(100) not null, 
	bookPrice decimal(7,2) not null ,
	bookDesc varchar(1000) , 
	yearPublication date not null,
	bookLanguage varchar(100) not null,
	NumberOfCopies int not null,
	actualNumberOfCopies int not null,
	categID int ,
	authID int not null,
	pubID int not null,
	constraint book_author_fk foreign key (authID) references Author(authorID) on update cascade,
	constraint book_publisher_fk foreign key (pubID) references Publisher(publisherID) on update cascade,
	constraint book_category_fk foreign key (categID) references Category(categoryID) on update cascade

);

create table Buying_details
(
	transactionID int  primary key identity(1,1),
	transactionDate datetime default current_timestamp,
	BID int not null,
	userEmail varchar(100) not null,
	constraint book_Buy_fk foreign key (BID) references Libarary_book(bookID),
	constraint book_user_fk foreign key (userEmail) references Libarary_user(email)
);

create table Comment_details
(
	commentID int primary key identity(1,1),
	commentDesc varchar(8000) not null,
	commentTime datetime default current_timestamp ,
	userEmail varchar(100) not null,
	BID int not null,
	constraint book_comment_fk foreign key (BID) references Libarary_book(bookID),
	constraint user_comment_fk foreign key (userEmail) references Libarary_user(email)
)


-- book title that has max number of buyers
select Libarary_book.bookTitle ,NumberOfCopies-actualNumberOfCopies as totalSales
from libarary_book 
where Libarary_book.NumberOfCopies - Libarary_book.actualNumberOfCopies = (select max(y.totalBookSold) as MaxTotalBookSold 
																		from (select bookTitle ,(NumberOfCopies -actualNumberOfCopies) as totalBookSold 
																			  from Libarary_book )y);

-- book title that had not any buyers last month
select bookTitle
from Libarary_book 
where bookID not in (select distinct BID 
					from Buying_details 
					where  LEFT({fn monthname(transactionDate)},3) = 'May' and year(transactionDate)='2022');


-- names of authors that had not any buyers for ther books last month
select authorName , authorID 
from Author 
where authorID in (select authID 
				   from Libarary_book 
				   where bookID not in (select distinct BID 
									    from Buying_details 
										where  LEFT({fn monthname(transactionDate)},3) = 'May' and year(transactionDate)='2022'));  


-- the name and id of author who didnt upload any books 
select authorName , authorID
from Author
where authorID not in (select distinct authID 
						from Libarary_book )


-- name and number of books in the category with the min number of books
select categName , y.booksCategory
from (select categName,count(bookID) as booksCategory 
	  from Libarary_book right join Category on categID=categoryID 
	  group by categName )y
where y.booksCategory = (select min(z.booksInCategory) as minBooks from (select categName,count(bookID) as booksInCategory
						from Libarary_book right join Category on categID=categoryID 
						group by categName)z)



-- information of each user and the number of books he/she bought
select  Libarary_user.* , y.numberOFBooks
from Libarary_user ,  (select email, count(userEmail) as numberOFBooks
						from Libarary_user left join Buying_details
						on userEmail = email
						group by email)y

where Libarary_user.email = y.email
order by numberOFBooks desc


-- the books and the total money comes from them
select bookTitle ,sum((NumberOfCopies-actualNumberOfCopies)* bookPrice) as totalSalesMoney
from Libarary_book
where bookID in (select Buying_details.BID 
from Buying_details)
group by bookTitle

-- the total amount of money in my libarary
select sum((NumberOfCopies-actualNumberOfCopies)* bookPrice) as totalSalesMoney
from Libarary_book
where bookID in (select Buying_details.BID 
from Buying_details)

-- the total books titles and the number of copies that sold
select bookTitle , NumberOfCopies-actualNumberOfCopies as totalBSold , actualNumberOfCopies as remaningCopies
from Libarary_book
order by totalBSold