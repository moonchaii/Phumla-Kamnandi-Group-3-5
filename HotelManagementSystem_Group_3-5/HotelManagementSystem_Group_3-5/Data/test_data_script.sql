-- test data to be inserted into tables 

-- 10 guest records


insert into Guest (IdNo, Name, Email, Phone, Address)
values (0123589741,'John Smith','jsmith@hotmail.co.za','0458798542', ' 7 Main Rd, Rondebosch, 7700'),
(0598753245,' Nkosinathi Mthembu', 'nmthembu@gmail.co.za','0659872458', '14 Lungelo Drive, Mtimkhulu, Durban, 4001'),
(9788956321, 'Amy Fowler','afowler@kmail.com','0548958788', '7 Sunshine Lane, Lotus River, 7980'),
(0254789542, 'Sheldon Cooper'	,'scooper@gmail.com' ,'0202548795','8 William Road, Camton, 4510'),
(3652687512, 'Leonard Hofstadter','leonard@lmail.com','5454896972' ,'19 Ronddale Street, Rondebosch, 7700'),
(0257984625, 'Rajesh Koothrappali','rajkooth@hotmail.com','85956987423', '10 Rose Wale, Grassy Park, 7941'),
(7954865215, 'Howard Wolowitz','howwol@tmail.com','25459875698','4 Sunnyville Road, Goodwood, 7845'),
(5587446987, 'Penny Hofstadter','pennyhof@gmail.com','1235659897','21 Laney Lane, Toronto, Canada, 8741'),
(0025416987, 'Bernie Wolowitz','bernwol@yahoo.com','012547896','10 Bischops Road, Terryville, 7852'),
(0225698802, 'Will Wheaton','wheatonwill@gmail.com','3265987845','9 Riverstone Road, Claremont, 9087');

-- 5 rooms 

insert into Room (RoomType) values ('Single');
insert into Room (RoomType) values ('Single');
insert into Room (RoomType) values ('Single');
insert into Room (RoomType) values ('Single');
insert into Room (RoomType) values ('Single');

-- seasonalRates
insert into SeasonalRate (SeasonName, StartDate, EndDate, Rate)
values ('Low', '2025-12-01','2025-12-07',550),
('Mid', '2025-12-08','2025-12-15',750),
('High', '2025-12-16','2025-12-31',995);




-- booking records 
-- 24th - two rooms available

insert into Booking (RoomID, GuestID, SeasonID, BookingStatus,CheckIn, CheckOut, Payment, Deposit)
values (1,5,3,'Confirmed', '2025-12-24', '2025-12-25',995.00,99.50),
(2,3,3,'Confirmed','2025-12-24','2025-12-25',995.00,99.5),
(3,4,3,'Confirmed','2025-12-24','2025-12-25', 995.00,99.5);


-- hotel is fully booked from 25th to 26th
insert into Booking (RoomID, GuestID, SeasonID, BookingStatus,CheckIn, CheckOut, Payment, Deposit)
values (1,1,3,'Confirmed','2025-12-25','2025-12-26',995.00,99.5), -- johns booking
(2,8,3,'Confirmed','2025-12-25','2025-12-27',995.00,99.5),
(3,7,3,'Confirmed','2025-12-25','2025-12-27',995.00,99.5),
(4,5,3,'Confirmed','2025-12-25','2025-12-27',995.00,99.5),
(5,9,3,'Confirmed','2025-12-25','2025-12-27',995.00,99.5);

-- hotel has one room available (each day) from 27th to 28th
-- 4 rooms booked each day
insert into Booking (RoomID, GuestID, SeasonID, BookingStatus,CheckIn, CheckOut, Payment, Deposit)
values (1,7,3,'Confirmed','2025-12-27','2025-12-29',995.00,99.5),
(2,3,3,'Confirmed','2025-12-27','2025-12-29',995.00,99.5),
(3,4,3,'Confirmed','2025-12-27','2025-12-29',995.00,99.5),
(4,5,3,'Confirmed','2025-12-27','2025-12-29',995.00,99.5),
(5,6,3,'Confirmed','2025-12-27','2025-12-29',995.00,99.5);



