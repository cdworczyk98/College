DROP TABLE invoice;
DROP TABLE patient;
DROP TABLE treatment;
DROP TABLE consultationsession;

CREATE TABLE invoice (
InvoiceNo int(6) NOT NULL,
PatientID varchar(4) NOT NULL,
ConsultationDate date NOT NULL,
DoctorName varchar(20) NOT NULL,
Total double,
PRIMARY KEY (InvoiceNo)
);

CREATE TABLE patient (
PatientID varchar(4) NOT NULL,
PatientName varchar(20) NOT NULL,
PatientAddress1 varchar(20) NOT NULL,
PatientAddress2 varchar(20) NOT NULL,
PatientPostcode varchar(8)NOT NULL,
PatientTel varchar(20) NOT NULL,
PRIMARY KEY (PatientID)
);

CREATE TABLE treatment (
ProcedureCode varchar(6) NOT NULL,
ProcedureDescription varchar(20) NOT NULL,
ProcedureCost double NOT NULL,
PRIMARY KEY (ProcedureCode)
);

CREATE TABLE consultationsession (
InvoiceNo int(6) ,
ProcedureCode varchar(6)
);

