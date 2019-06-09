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
	Atype smallint not null, /*1��ʾ�û���2��ʾ����Ա��*/
	Borrownum smallint not null,
	Cost smallint not null);

	create table Borrow
	(ID char(20) not null,
	 Bno char(20) not null,
	 Borrowtime char(20) not null,
	 Returntime char(20) not null,
	 Borrowstate smallint not null,  /*0��ʾ������1��ʾ���ڣ�*/
	 primary key (ID,Bno),
	 foreign key(ID) references Account(ID),
	 foreign key(Bno) references Book(Bno),
	 ); 

	 create table Student
	 ( Sno char(20) primary key,
	   Sname char(20) not null,
	   Ssex char(2) check(Ssex in('��','Ů')) not null ,
	   Smajor char(20) not null,
	   Sclass char(20) not null,
	   Sphone char(11) check(len([Sphone])=11) not null,
	   Sdegree smallint not null); /*1��ʾ���ƣ�2��ʾ˶ʿ��3��ʾ��ʿ*/

	   create table Teacher
	   ( Tno char(20) primary key,
	     Tname char(20) not null,
		 Tsex char(2) check(Tsex in('��','Ů')) not null,
		 Tacademy char(20) not null,
		 Tphone char(11) check(len([Tphone])=11) not null);

		 create table Administrator
		 (Aid char(20) primary key,
		  Aname char(20) not null,
		  Asex char(2) check(Asex in('��','Ů')) not null,
		  Aphone char(11) check(len([Aphone])=11)  not null);





