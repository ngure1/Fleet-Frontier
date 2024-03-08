USE fleet_finder;
INSERT INTO vehicle (numberPlate, `fuel_cost/km`, is_available, created_at) 
VALUES 
('ABC123', 10.5, 1, '2024-03-08'),
('XYZ789', 12.2, 0, '2024-03-08'),
('DEF456', 8.8, 0, '2024-03-08'),
('GHI789', 9.7, 1, '2024-03-08'),
('JKL012', 11.3, 1, '2024-03-08');

INSERT INTO employee (employee_name, employee_type, employee_phone_number, is_available, date_of_entry) 
VALUES 
('John Doe', 'Driver', '1234567890', 1, '2024-03-08'),
('Alice Smith', 'Conductor', '0987654321', 1, '2024-03-08'),
('Bob Johnson', 'Driver', '5556667777', 1, '2024-03-08'),
('Emma Brown', 'Conductor', '1112223333', 0, '2024-03-08'),
('Michael Wilson', 'Driver', '4445556666', 0, '2024-03-08'),
('Sarah Lee', 'Conductor', '7778889999', 1, '2024-03-08'),
('David Clark', 'Driver', '8889990000', 1, '2024-03-08');