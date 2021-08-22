ALTER TABLE `cd_phcg`.`invoice` DROP FOREIGN KEY `invoiceFK`;
ALTER TABLE `cd_phcg`.`consultationsession` DROP FOREIGN KEY `consFK1`;
ALTER TABLE `cd_phcg`.`consultationsession` DROP FOREIGN KEY `consFK2`;

ALTER TABLE invoice
ADD CONSTRAINT invoiceFK
FOREIGN KEY(PatientID)
REFERENCES patient(PatientID);

ALTER TABLE consultationsession
ADD CONSTRAINT consFK1
FOREIGN KEY(InvoiceNo)
REFERENCES invoice(InvoiceNo);

ALTER TABLE consultationsession
ADD CONSTRAINT consFK2
FOREIGN KEY(ProcedureCode)
REFERENCES treatment(ProcedureCode);