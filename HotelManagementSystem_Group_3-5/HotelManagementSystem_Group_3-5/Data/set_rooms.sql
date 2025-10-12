INSERT INTO Room (RoomID, RoomNumber, RoomType)
VALUES
('RM001', 1, 'Single'),
('RM002', 2, 'Single'),
('RM003', 3,'Single'),
('RM004', 4, 'Single'),
('RM005', 5, 'Single');

INSERT INTO SeasonalRate (SeasonName, StartDate, EndDate, Rate)
VALUES 
('Low', '2025-12-01','2025-12-07',550),
('Mid', '2025-12-08','2025-12-15',750),
('High', '2025-12-16','2025-12-31',995);
