-- Insert Guests (GuestID manually generated as 'GSTxxxxx')
INSERT INTO Guest (GuestID, ID, Name, Email, Phone, Address)
VALUES
('GST00001','0123589741','John Smith','jsmith@hotmail.co.za','0458798542','7 Main Rd, Rondebosch, 7700'),
('GST00002','0598753245','Nkosinathi Mthembu','nmthembu@gmail.co.za','0659872458','14 Lungelo Drive, Mtimkhulu, Durban, 4001'),
('GST00003','9788956321','Amy Fowler','afowler@kmail.com','0548958788','7 Sunshine Lane, Lotus River, 7980'),
('GST00004','0254789542','Sheldon Cooper','scooper@gmail.com','0202548795','8 William Road, Camton, 4510'),
('GST00005','3652687512','Leonard Hofstadter','leonard@lmail.com','5454896972','19 Ronddale Street, Rondebosch, 7700'),
('GST00006','0257984625','Rajesh Koothrappali','rajkooth@hotmail.com','85956987423','10 Rose Wale, Grassy Park, 7941'),
('GST00007','7954865215','Howard Wolowitz','howwol@tmail.com','25459875698','4 Sunnyville Road, Goodwood, 7845'),
('GST00008','5587446987','Penny Hofstadter','pennyhof@gmail.com','1235659897','21 Laney Lane, Toronto, Canada, 8741'),
('GST00009','0025416987','Bernie Wolowitz','bernwol@yahoo.com','012547896','10 Bischops Road, Terryville, 7852'),
('GST00010','0225698802','Will Wheaton','wheatonwill@gmail.com','3265987845','9 Riverstone Road, Claremont, 9087');
GO


-- Insert Rooms
INSERT INTO Room (RoomID, RoomType)
VALUES
('RM001','Single'),
('RM002','Single'),
('RM003','Single'),
('RM004','Single'),
('RM005','Single');
GO


-- Insert Seasonal Rates
INSERT INTO SeasonalRate (SeasonName, StartDate, EndDate, Rate)
VALUES 
('Low', '2025-12-01','2025-12-07',550),
('Mid', '2025-12-08','2025-12-15',750),
('High', '2025-12-16','2025-12-31',995);
GO


-- Insert Bookings (ReferenceNumber = primary key)
-- 24th - two rooms available
INSERT INTO Booking (ReferenceNumber, GuestID, RoomID, RoomNumber, TotalAmount, DepositAmount, DepositPaid, ArrivalDate, DepartureDate)
VALUES
('REF00001','GST00005','RM001',101,995.00,99.50,1,'2025-12-24','2025-12-25'),
('REF00002','GST00003','RM002',102,995.00,99.50,1,'2025-12-24','2025-12-25'),
('REF00003','GST00004','RM003',103,995.00,99.50,1,'2025-12-24','2025-12-25');
GO


-- Fully booked 25th–26th
INSERT INTO Booking (ReferenceNumber, GuestID, RoomID, RoomNumber, TotalAmount, DepositAmount, DepositPaid, ArrivalDate, DepartureDate)
VALUES
('REF00004','GST00001','RM001',101,995.00,99.50,1,'2025-12-25','2025-12-26'),
('REF00005','GST00008','RM002',102,995.00,99.50,1,'2025-12-25','2025-12-27'),
('REF00006','GST00007','RM003',103,995.00,99.50,1,'2025-12-25','2025-12-27'),
('REF00007','GST00005','RM004',104,995.00,99.50,1,'2025-12-25','2025-12-27'),
('REF00008','GST00009','RM005',105,995.00,99.50,1,'2025-12-25','2025-12-27');
GO


-- Partially booked 27th–28th
INSERT INTO Booking (ReferenceNumber, GuestID, RoomID, RoomNumber, TotalAmount, DepositAmount, DepositPaid, ArrivalDate, DepartureDate)
VALUES
('REF00009','GST00007','RM001',101,995.00,99.50,1,'2025-12-27','2025-12-29'),
('REF00010','GST00003','RM002',102,995.00,99.50,1,'2025-12-27','2025-12-29'),
('REF00011','GST00004','RM003',103,995.00,99.50,1,'2025-12-27','2025-12-29'),
('REF00012','GST00006','RM005',105,995.00,99.50,1,'2025-12-27','2025-12-29');
GO


-- Payments (linked to ReferenceNumber)
INSERT INTO Payment (ReferenceNumber, AmountPaid, DatePaid, DepositPaid)
VALUES
('REF00001',995.00,'2025-12-23','Yes'),
('REF00002',995.00,'2025-12-23','Yes'),
('REF00003',995.00,'2025-12-23','Yes'),
('REF00004',995.00,'2025-12-24','Yes'),
('REF00005',995.00,'2025-12-24','Yes'),
('REF00006',995.00,'2025-12-24','Yes'),
('REF00007',995.00,'2025-12-24','Yes'),
('REF00008',995.00,'2025-12-24','Yes'),
('REF00009',995.00,'2025-12-26','Yes'),
('REF00010',995.00,'2025-12-26','Yes');
GO


