#chris dworczyk
#15/03/2018

UPDATE patient
    SET PatientName = 'Jane Rochester'
    WHERE PatientName = 'Jane Eyre';

UPDATE patient
    SET PatientPostcode = 'EH37 9BC'
    WHERE PatientName = 'Jon Anderssen';

UPDATE patient
    SET PatientTelNo = '01592 - 231094'
    WHERE PatientName = 'Sophie Berrys';

UPDATE invoice
    SET Total = 138.50
    WHERE InvoiceNo = 17790;