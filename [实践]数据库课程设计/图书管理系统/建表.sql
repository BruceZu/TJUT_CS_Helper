CREATE DATABASE Library loan management system
create table Book
( Bno char(20) primary key,
  Bname char(20) not null,
  Btype char(20) not null,
  Bauthor char(20) not null,
  Bpublish char(20) not null,
  Bprice smallint not null,
  Bnumber smallint not null);

  create table Account
  ( ID char(20) primary key,
    Password char(50) check(len([Password])>=6 and len([Password])<=50) not null ,
	Atype smallint not null, /*1表示用户，2表示管理员；*/
	Borrownum smallint not null,
	Cost smallint not null);

	create table Borrow
	(ID char(20) not null,
	 Bno char(20) not null,
	 Borrowtime char(20) not null,
	 Returntime char(20) not null,
	 Borrowstate smallint not null,  /*0表示正常，1表示逾期；*/
	 primary key (ID,Bno),
	 foreign key(ID) references Account(ID),
	 foreign key(Bno) references Book(Bno),
	 ); 

	 create table Student
	 ( Sno char(20) primary key,
	   Sname char(20) not null,
	   Ssex char(2) check(Ssex in('男','女')) not null ,
	   Smajor char(20) not null,
	   Sclass char(20) not null,
	   Sphone char(11) check(len([Sphone])=11) not null,
	   Sdegree smallint not null); /*1表示本科，2表示硕士，3表示博士*/

	   create table Teacher
	   ( Tno char(20) primary key,
	     Tname char(20) not null,
		 Tsex char(2) check(Tsex in('男','女')) not null,
		 Tacademy char(20) not null,
		 Tphone char(11) check(len([Tphone])=11) not null);

		 create table Administrator
		 (Aid char(20) primary key,
		  Aname char(20) not null,
		  Asex char(2) check(Asex in('男','女')) not null,
		  Aphone char(11) check(len([Aphone])=11)  not null);





