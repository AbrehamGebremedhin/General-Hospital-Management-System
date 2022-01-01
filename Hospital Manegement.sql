CREATE database HospitalManagement
GO

USE HospitalManagement
GO

-- create the tables
create table tblPatient(
    Patient_GUID AS 'HMS-' + RIGHT(REPLICATE('0', 8) + CONVERT(VARCHAR, Patient_ID), 10),
    Patient_ID INT PRIMARY KEY IDENTITY(1, 1),
    FirstName varchar(100) not null,
	Lastname varchar(100) not null,
	Age int not null,
	Weight float not null,
	PhoneNumber varchar(13) not null,
	Email varchar(45),
	Address varchar(50) not null,
	Gender varchar(1),
	AlternativePhone varchar(13) not null,
	MartialStatus varchar(7),
	Disease varchar(50) not null,
	doctor_id varchar(20) not null,
	Medicine varchar(100),
	Diagnosis varchar(Max)
)

GO
create table tblDoctor(
    doctor_id varchar(20) primary key not null,
	doctor_FirstName varchar(100) not null,
	doctor_Lastname varchar(100) not null,
	doctor_phone varchar(13) not null,
    doctor_Address varchar(50) not null,
	doctor_gender varchar(1)
)

GO
create table tblLab(
   lab_no varchar(10) primary key not null,
   patient_id int not null,	
   doctor_id varchar(20) not null,
   patient_type varchar(20),
   category varchar(20),
   [Date] date,	
   amount int
)

GO
create table tblinPatient(
    Patient_GUID AS 'HMS-' + RIGHT(REPLICATE('0', 8) + CONVERT(VARCHAR, Patient_ID), 10),
    Patient_ID INT primary key IDENTITY(1, 1),
	room_no varchar(10),
	date_of_adm date,
	date_of_dis date,
	lab_no varchar(10)
)

GO
create table tbloutPatient(
    Patient_GUID AS 'HMS-' + RIGHT(REPLICATE('0', 8) + CONVERT(VARCHAR, Patient_ID), 10),
    Patient_ID INT primary key IDENTITY(1, 1),
	date_out date,
	lab_no varchar(10)
)

GO
create table tblRoom(
    room_Id varchar(10) primary key not null,
	room_type varchar(50),
    room_status varchar(5) not null,
)

GO
create table tblBill(
    bill_id varchar(10) primary key not null,
	Patient_GUID AS 'HMS-' + RIGHT(REPLICATE('0', 8) + CONVERT(VARCHAR, Patient_ID), 10),
    Patient_ID INT IDENTITY(1, 1) not null,
	doctor_charge float not null,
	room_charge float not null,
	no_of_days int not null,
	lab_charge float not null,
	medicine_charge float not null,
	operation_charge float,
	card_charge int not null,
	total_bill float
)
GO

--Add relationships
ALTER TABLE tblPatient  WITH CHECK ADD  CONSTRAINT FK_tblPatient_tblDoctor FOREIGN KEY(doctor_id)
REFERENCES tblDoctor (doctor_id)
GO
ALTER TABLE tblPatient CHECK CONSTRAINT FK_tblPatient_tblDoctor
GO

ALTER TABLE tbloutPatient  WITH CHECK ADD  CONSTRAINT FK_tbloutPatient_tblPateint FOREIGN KEY(patient_id)
REFERENCES tblPatient (Patient_ID)
GO
ALTER TABLE tbloutPatient CHECK CONSTRAINT FK_tbloutPatient_tblPateint
GO

ALTER TABLE tbloutPatient  WITH CHECK ADD  CONSTRAINT FK_tbloutPatient_tblLab FOREIGN KEY(lab_no)
REFERENCES tblLab (lab_no)
GO
ALTER TABLE tbloutPatient CHECK CONSTRAINT FK_tbloutPatient_tblLab
GO

ALTER TABLE tblinPatient  WITH CHECK ADD  CONSTRAINT FK_tblinPatient_tblLab FOREIGN KEY(lab_no)
REFERENCES tblLab (lab_no)
GO
ALTER TABLE tblinPatient CHECK CONSTRAINT FK_tblinPatient_tblLab
GO

ALTER TABLE tblinPatient  WITH CHECK ADD  CONSTRAINT FK_tblinPatient_tblRoom FOREIGN KEY(room_no)
REFERENCES tblRoom (Room_Id)
GO
ALTER TABLE tblinPatient CHECK CONSTRAINT FK_tblinPatient_tblRoom
GO

ALTER TABLE tblinPatient  WITH CHECK ADD  CONSTRAINT FK_tblinPatient_tblPatient FOREIGN KEY(patient_id)
REFERENCES tblPatient (Patient_ID)
GO
ALTER TABLE tblinPatient CHECK CONSTRAINT FK_tblinPatient_tblPatient
GO

ALTER TABLE tblLab WITH CHECK ADD  CONSTRAINT FK_tblLab_tblPatient FOREIGN KEY(patient_id)
REFERENCES tblPatient (Patient_ID)
GO
ALTER TABLE tblLab CHECK CONSTRAINT FK_tblLab_tblPatient
GO

ALTER TABLE tblLab WITH CHECK ADD  CONSTRAINT FK_tblLab_tblDoctor FOREIGN KEY(doctor_id)
REFERENCES tblDoctor (doctor_id)
GO
ALTER TABLE tblLab CHECK CONSTRAINT FK_tblLab_tblPatient
GO

ALTER TABLE tblBill WITH CHECK ADD  CONSTRAINT FK_tblBill_tblinPatient FOREIGN KEY(Patient_ID)
REFERENCES tblinPatient (Patient_ID)
GO
ALTER TABLE tblBill CHECK CONSTRAINT FK_tblBill_tblinPatient
GO

ALTER TABLE tblBill WITH CHECK ADD  CONSTRAINT FK_tblBill_tblPatient FOREIGN KEY(Patient_ID)
REFERENCES tblPatient (Patient_ID)
GO

--Creating Functions
create function[Total_stay]
(@id int)
returns int
with encryption
as
begin
   declare @total_day int
   set @total_day = (select datediff(DAY,date_of_adm,date_of_dis) from tblinPatient where Patient_ID = @id)

   return @total_day
end
GO


--Store Procedures
create proc[New_patient]
@id int,
@firstname varchar(100),
@lastname varchar(100),
@age int,
@weight float,
@bloodgroup varchar(2),
@phone varchar(13),
@email varchar(45),
@address varchar(50),
@gender varchar(1),
@phone_2 varchar(13),
@martial varchar(7),
@disease varchar(50),
@doctor varchar(20)
with encryption
as  
begin 
  SET IDENTITY_INSERT tblPatient ON
  
  insert tblPatient(Patient_ID,FirstName,LastName,Age,Weight,BloodGroup,PhoneNumber,Email,Address,Gender,AlternativePhone,MartialStatus,Disease,doctor_id) values
  (@id,LTRIM(RTRIM(UPPER(LEFT(@firstname,1))+LOWER(SUBSTRING(@firstname,2,LEN(@firstname))))),LTRIM(RTRIM(UPPER(LEFT(@lastname,1))+LOWER(SUBSTRING(@lastname,2,LEN(@lastname))))),@age,@weight,LTRIM(RTRIM(UPPER(@bloodgroup))),LTRIM(RTRIM(@phone)),LTRIM(RTRIM(@email)),LTRIM(RTRIM(@address)),LTRIM(RTRIM(Upper(@gender))),LTRIM(RTRIM(@phone_2)),LTRIM(RTRIM(@martial)),LTRIM(RTRIM(@disease)),LTRIM(RTRIM(@doctor)))
  
  SET IDENTITY_INSERT tblPatient OFF
end
GO

--New Doctor
CREATE proc[New_Doctor]
@id varchar(20),
@firstname varchar(100),
@lastname varchar(100),
@phone varchar(13),
@address varchar(50),
@gender varchar(1)
with encryption
as
begin
  SET IDENTITY_INSERT tblDoctor ON
  
  insert tblDoctor(doctor_id,doctor_FirstName,doctor_LastName,doctor_phone,doctor_Address,doctor_gender) values
  (@id,LTRIM(RTRIM(UPPER(LEFT(@firstname,1))+LOWER(SUBSTRING(@firstname,2,LEN(@firstname))))),LTRIM(RTRIM(UPPER(LEFT(@lastname,1))+LOWER(SUBSTRING(@lastname,2,LEN(@lastname))))),LTRIM(RTRIM(@phone)),LTRIM(RTRIM(@address)),LTRIM(RTRIM(Upper(@gender))))
  
  SET IDENTITY_INSERT tblDoctor OFF
end
GO

--Timed Backup Procedure
CREATE proc[Backup]
with encryption
as
begin
   BACKUP DATABASE HospitalManagement
   TO DISK = 'D:\backups\testDB.bak'
   WITH DIFFERENTIAL;
end
GO

--Doctor findings
create proc[Doctor_diagonsis]
@patient_id int,
@Med varchar(100),
@Diagnosis varchar(max),
@symptoms varchar(max)
with encryption
as
begin
  SET IDENTITY_INSERT tblPatient ON
     UPDATE tblPatient
     SET Medicine = @Med,
	 Diagnosis = @Diagnosis, Symptoms = @symptoms 
     WHERE Patient_ID = @patient_id;
  SET IDENTITY_INSERT tblPatient OFF
end
GO
