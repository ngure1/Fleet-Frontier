CREATE DATABASE fleet_finder;
USE fleet_finder;

CREATE TABLE user (
    id INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(50) NOT NULL,
    password VARCHAR(50) NOT NULL
);

CREATE TABLE vehicle(
    vehicle_id INT AUTO_INCREMENT NOT NULL,
    numberPlate  VARCHAR(20) NOT NULL,
    `fuel_cost/km` DECIMAL NOT NULL,
    is_available BOOLEAN DEFAULT TRUE NOT NULL,
    created_at DATE,

    PRIMARY KEY(vehicle_id)
);

CREATE TABLE hire(
    hire_id INT AUTO_INCREMENT,
    vehicle_id INT,
    customer_name VARCHAR(50) NOT NULL,
    customer_phone_number VARCHAR(20) NOT NULL,
    is_returned BOOLEAN DEFAULT FALSE NOT NULL,

    PRIMARY KEY(hire_id),
    FOREIGN KEY(vehicle_id) REFERENCES vehicle(vehicle_id)
    
);

CREATE TABLE trip(
    trip_id INT AUTO_INCREMENT,
    vehicle_id INT,
    trip_from VARCHAR(50) NOT NULL,
    trip_to VARCHAR(50) NOT NULL,
    trip_No INT NOT NULL,
    trip_start_time TIME NOT NULL,
    has_arrived BOOLEAN DEFAULT FALSE NOT NULL,

    PRIMARY KEY(trip_id),
    FOREIGN KEY(vehicle_id) REFERENCES vehicle(vehicle_id)
    
);

CREATE TABLE employee(
    employee_id INT AUTO_INCREMENT,
    employee_name VARCHAR(50) NOT NULL,
    employee_type VARCHAR(50) NOT NULL,
    employee_phone_number VARCHAR(20) NOT NULL,
    is_available BOOLEAN DEFAULT TRUE NOT NULL,
    date_of_entry DATE,

    PRIMARY KEY(employee_id)
);

CREATE TABLE trip_employee(
    trip_employee_id INT AUTO_INCREMENT,
    trip_id INT,
    employee_id INT,

    PRIMARY KEY(trip_employee_id),
    FOREIGN KEY(trip_id) REFERENCES trip(trip_id),
    FOREIGN KEY(employee_id) REFERENCES employee(employee_id)  
);

CREATE TRIGGER update_vehicle_availability_on_update_hire
AFTER UPDATE ON hire
FOR EACH ROW
BEGIN
    IF NEW.is_returned = TRUE THEN
        UPDATE vehicle
        SET is_available = TRUE
        WHERE vehicle_id = NEW.vehicle_id;
    END IF;
END;