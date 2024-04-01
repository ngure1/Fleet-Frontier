USE fleet_finder;
INSERT INTO vehicle (numberPlate, `fuel_cost/km`, created_at) 
VALUES 
('ABC123', 0.05, CURDATE()),
('DEF456', 0.06, CURDATE()),
('GHI789', 0.07, CURDATE()),
('JKL012', 0.08, CURDATE()),
('MNO345', 0.09, CURDATE()),
('PQR678', 0.1, CURDATE()),
('STU901', 0.11, CURDATE()),
('VWX234', 0.12, CURDATE()),
('YZA567', 0.13, CURDATE()),
('BCD890', 0.14, CURDATE()),
('EFG123', 0.15, CURDATE()),
('HIJ456', 0.16, CURDATE()),
('KLM789', 0.17, CURDATE()),
('NOP012', 0.18, CURDATE()),
('PQR345', 0.19, CURDATE()),
('STU678', 0.2, CURDATE()),
('VWX901', 0.21, CURDATE()),
('YZA234', 0.22, CURDATE()),
('BCD567', 0.23, CURDATE()),
('EFG890', 0.24, CURDATE());

-- Populate the employee table with 15 drivers
INSERT INTO employee (employee_name, employee_type, employee_phone_number, date_of_entry)
VALUES 
('John Smith', 'Driver', '1234567890', CURDATE()),
('Emma Johnson', 'Driver', '1234567891', CURDATE()),
('Michael Brown', 'Driver', '1234567892', CURDATE()),
('Jennifer Davis', 'Driver', '1234567893', CURDATE()),
('Christopher Wilson', 'Driver', '1234567894', CURDATE()),
('Jessica Martinez', 'Driver', '1234567895', CURDATE()),
('Matthew Anderson', 'Driver', '1234567896', CURDATE()),
('Elizabeth Taylor', 'Driver', '1234567897', CURDATE()),
('David Thomas', 'Driver', '1234567898', CURDATE()),
('Sarah Garcia', 'Driver', '1234567899', CURDATE()),
('James Rodriguez', 'Driver', '1234567800', CURDATE()),
('Linda Martinez', 'Driver', '1234567801', CURDATE()),
('William Brown', 'Driver', '1234567802', CURDATE()),
('Karen Wilson', 'Driver', '1234567803', CURDATE()),
('Robert Johnson', 'Driver', '1234567804', CURDATE());

-- Populate the employee table with 15 conductors
INSERT INTO employee (employee_name, employee_type, employee_phone_number, date_of_entry)
VALUES 
('Mark Brown', 'Conductor', '1234567916', CURDATE()),
('Lisa Davis', 'Conductor', '1234567917', CURDATE()),
('Richard Johnson', 'Conductor', '1234567918', CURDATE()),
('Susan Miller', 'Conductor', '1234567919', CURDATE()),
('Paul Wilson', 'Conductor', '1234567920', CURDATE()),
('Anna Martinez', 'Conductor', '1234567921', CURDATE()),
('Kevin Thompson', 'Conductor', '1234567922', CURDATE()),
('Rebecca Harris', 'Conductor', '1234567923', CURDATE()),
('Timothy Nelson', 'Conductor', '1234567924', CURDATE()),
('Carolyn Scott', 'Conductor', '1234567925', CURDATE()),
('George Green', 'Conductor', '1234567926', CURDATE()),
('Melissa Carter', 'Conductor', '1234567927', CURDATE()),
('Edward Baker', 'Conductor', '1234567928', CURDATE()),
('Laura Mitchell', 'Conductor', '1234567929', CURDATE()),
('Brian Perez', 'Conductor', '1234567930', CURDATE());