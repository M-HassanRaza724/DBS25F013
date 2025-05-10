CREATE VIEW get_services AS 
SELECT s.service_id, s.name, s.category_id, s.description, si.service_involved, st.technology
FROM services s 
LEFT JOIN serviceinvolved si ON si.service_id = s.service_id 
LEFT JOIN servicetechnologies st ON st.service_id = s.service_id;

DELIMITER //
CREATE PROCEDURE sp_get_user_by_role (IN user_role VARCHAR(50))
BEGIN
	IF user_role = 'admin' THEN
		SELECT * FROM users NATURAL JOIN admins;
	ELSEIF user_role = 'employee' THEN
		SELECT * FROM users NATURAL JOIN employees;
	ELSEIF user_role = 'customer' THEN
		SELECT * FROM users NATURAL JOIN customers;
	END IF;
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE sp_manage_user(
	IN operation_type VARCHAR(20),
    IN p_user_id INT,
    IN p_username VARCHAR(255),
    IN p_email VARCHAR(255),
    IN p_password VARCHAR(255),
    IN p_role_id INT
)
BEGIN
	IF operation_type = 'add' THEN
		INSERT INTO users(username, email, password, role_id) VALUES (p_username, p_email, p_password, p_role_id);
	ELSEIF operation_type = 'update' THEN
		UPDATE users SET users.email = p_email, users.password = p_password WHERE users.user_id = p_user_id;
	ELSEIF operation_type = 'delete' THEN
		DELETE FROM users WHERE users.user_id = p_user_id;
	END IF;
END //
DELIMITER ;


DELIMITER //
CREATE PROCEDURE sp_manage_service(
	IN operation_type VARCHAR(20),
    IN p_service_id INT,
    IN p_name VARCHAR(255),
    IN p_category_id INT,
    IN p_description TEXT
)
BEGIN 
	IF operation_type = 'add' THEN
		INSERT INTO services(name, category_id, description) VALUES (p_name, p_category_id, p_description);
	ELSEIF operation_type = 'update' THEN 
		UPDATE services SET name = p_name, description = p_description WHERE service_id = p_service_id;
	ELSEIF operation_type = 'delete' THEN
		DELETE FROM services WHERE service_id = p_service_id;
	END IF;
END //
DELIMITER ;


DELIMITER //
CREATE PROCEDURE sp_manage_subservice(
	IN operation_type VARCHAR(20),
    IN p_service_id INT,
    IN p_service_involved VARCHAR(255)
)
BEGIN
	IF operation_type = 'add' THEN
		INSERT INTO serviceinvolved VALUES (p_service_id, p_service_involved);
	ELSEIF operation_type = 'update' THEN
		UPDATE serviceinvolved SET service_involved = p_service_involved WHERE service_id = p_service_id;
	ELSEIF operation_type = 'delete' THEN
		DELETE FROM serviceinvolved WHERE service_id = p_service_id;
	END IF;
END //
DELIMITER ;



DELIMITER //
CREATE PROCEDURE sp_manage_technology(
	IN operation_type VARCHAR(20),
    IN p_service_id INT,
    IN p_technology VARCHAR(255)
)
BEGIN
	IF operation_type = 'add' THEN 
		INSERT INTO servicetechnologies VALUES (p_service_id, p_technology);
	ELSEIF operation_type = 'update' THEN
		UPDATE servicetechnologies SET technology = p_technology WHERE service_id = p_service_id;
	ELSEIF operation_type = 'delete' THEN 
		DELETE FROM servicetechnologies WHERE service_id = p_service_id;
	END IF;
END //
DELIMITER ;



DELIMITER //
CREATE PROCEDURE sp_get_lookup_id(IN p_key_group VARCHAR (100), IN p_value VARCHAR(100))
BEGIN
	SELECT lookup_id
    FROM lookups
    WHERE key_group = p_key_group AND value = p_value;
END //
DELIMITER ;



DELIMITER //
CREATE PROCEDURE sp_manage_customer (
	IN operation_type VARCHAR(20),
    IN p_customer_id INT,
    IN p_user_id INT, 
    IN p_name VARCHAR(45)
)
BEGIN
	IF operation_type = 'add' THEN 
		INSERT INTO customers(customer_id, user_id, name) VALUES(p_customer_id, p_user_id, p_name);
	ELSEIF operation_type = 'update' THEN
		UPDATE customers SET name = p_name WHERE customer_id = p_customer_id;
	ELSEIF operation_type = 'delete' THEN
		DELETE FROM customers WHERE customer_id = p_customer_id;
	END IF;
END //
DELIMITER ;


DELIMITER //
CREATE PROCEDURE sp_manage_admin(
	IN operation_type VARCHAR(20),
    IN p_admin_id INT,
    IN p_user_id INT,
    IN p_name VARCHAR(255),
    IN p_phone VARCHAR(20),
    IN p_admin_role INT
)
BEGIN
	IF operation_type = 'add' THEN
		INSERT INTO admins VALUES (p_admin_id, p_user_id, p_name, p_phone, p_admin_role);
	ELSEIF operation_type = 'update' THEN
		UPDATE admins SET name = p_name, phone = p_phone WHERE admin_id = p_admin_id;
	ELSEIF operation_type = 'delete' THEN
		DELETE FROM admins WHERE admin_id = p_admin_id;
	END IF;
END //
DELIMITER ;


DELIMITER //
CREATE PROCEDURE sp_manage_employee(
	IN operation_type VARCHAR(20),
    IN p_employee_id INT,
    IN p_name VARCHAR(255),
    IN p_phone VARCHAR(20),
    IN p_joined_date DATE,
    IN p_designation_id INT,
    IN p_user_id INT
)
BEGIN
	IF operation_type = 'add' THEN
		INSERT INTO employees VALUES(p_employee_id, p_name, p_phone, p_joined_date, p_designation_id, p_user_id);
	ELSEIF operation_type = 'update' THEN
		UPDATE employees SET name = p_name, phone = p_phone WHERE employee_id = p_employee_id;
	ELSEIF operation_type = 'delete' THEN
		DELETE FROM employees WHERE employee_id = p_employee_id;
	END IF;
END //
DELIMITER ;



DELIMITER //
CREATE PROCEDURE sp_manage_salary(
	IN operation_type VARCHAR (20),
    IN p_salary_id INT,
    IN p_employee_id INT,
    IN p_pay_date DATE,
    IN p_amount DECIMAL(12, 2),
    IN p_bonus DECIMAL(10, 2)
)
BEGIN 
	IF operation_type = 'add' THEN	
		INSERT INTO salary(employee_id, pay_date, amount, bonus) VALUES (p_employee_id, p_pay_date, p_amount, p_bonus);
	ELSEIF operation_type = 'update' THEN
		UPDATE salary SET pay_date = p_pay_date, amount = p_amount, bonus = p_bonus WHERE salary_id = p_salary_id;
	ELSEIF operation_type = 'delete' THEN
		DELETE FROM salary WHERE salary_id = p_salary_id;
	END IF;
END //
DELIMITER ;


DELIMITER //
CREATE PROCEDURE sp_get_employee_salary(IN p_employee_id INT)
BEGIN
	SELECT *
    FROM salary s
    WHERE s.employee_id = p_employee_id;
END //
DELIMITER ;

-- trigger on users for unique password and email


CREATE VIEW get_customers_info AS
SELECT c.name AS CustomerName, MIN(u.email) AS Email, COUNT(o.order_id) AS OrdersBooked, CAST(COALESCE(SUM(i.price), 0) AS DOUBLE) AS TotalSpending, CAST(COALESCE(AVG(r.stars), 0) AS DOUBLE) AS AverageRating
FROM users u
NATURAL JOIN customers c
LEFT JOIN orders o ON o.user_id = u.user_id
LEFT JOIN reviews r ON r.order_id = o.order_id
LEFT JOIN invoice i ON i.order_id = o.order_id
GROUP BY c.customer_id;



CREATE VIEW get_employees_info AS
SELECT 
	MIN(u.username) AS Username,
    MIN(e.name) AS EmployeeName,
    MIN(e.phone) AS Phone,
    MIN(e.joined_date) AS JoinedDate,
    MIN(l.value) AS Designation,
    MIN(
		(SELECT COUNT(o1.order_id)
		FROM orders o1
		WHERE o1.employee_id = e.employee_id AND o1.status_id = 13) -- completed
    ) AS OrdersCompleted,
    ROUND(AVG(s.amount), 2) AS Salary,
    ROUND(SUM(DISTINCT s.bonus), 2) AS TotalAmountPaidAsBonus
FROM users u
JOIN employees e ON u.user_id = e.user_id
LEFT JOIN lookups l ON l.lookup_id = e.designation_id
LEFT JOIN orders o ON o.employee_id = e.employee_id
LEFT JOIN salary s ON s.employee_id = e.employee_id
GROUP BY e.employee_id;


DELIMITER //
CREATE PROCEDURE sp_get_admin_role(IN p_admin_id INT)
BEGIN
	SELECT l.value
    FROM admins a
    JOIN lookups l ON l.lookup_id = a.admin_role
    WHERE a.admin_id = p_admin_id;
END //
DELIMITER ;


CREATE VIEW get_admins_info AS
SELECT u.username AS Username, u.email AS Email, a.name AS Name, a.phone AS Phone, l.value AS Role
FROM users u
JOIN admins a ON u.user_id = a.user_id
JOIN lookups l ON l.lookup_id = a.admin_role;


ALTER TABLE orders
ADD COLUMN service_id INT,
ADD CONSTRAINT FOREIGN KEY (service_id) REFERENCES services(service_id);


DELIMITER //
CREATE PROCEDURE sp_place_order(
    IN p_employee_id INT,
    IN p_user_id INT,
    IN p_service_id INT,
    IN p_price DECIMAL(12, 2),    
    IN p_due_date DATE
)
BEGIN 
	DECLARE new_order_id INT;

	START TRANSACTION;
    
	INSERT INTO orders(employee_id, user_id, created_at, status_id, service_id) 
    VALUES (p_employee_id, p_user_id, NOW(), 12, p_service_id); -- 12 = work-in-progress 
    
    SET new_order_id = LAST_INSERT_ID();
    
	INSERT INTO invoice(order_id, price, payment_status_id, due_date, created_at) 
    VALUES (new_order_id, p_price, 16, p_due_date, NOW()); -- 16 = pending
    
    INSERT INTO reviews(order_id, reviewer_name, stars, date, description)
    VALUES (new_order_id, p_reviewer_name, 1, NOW(), 'null');
    
END //
DELIMITER ;



DELIMITER //
CREATE PROCEDURE sp_cancel_order(IN p_order_id INT)
BEGIN
	START TRANSACTION;
	DELETE FROM invoice WHERE order_id = p_order_id;
    DELETE FROM orders WHERE order_id = p_order_id;
    COMMIT;
END //
DELIMITER ;


CREATE TABLE log_orders (
	log_id INT AUTO_INCREMENT PRIMARY KEY,
    order_id INT NOT NULL,
    employee_id INT NOT NULL,
    user_id INT NOT NULL,
    created_at TIMESTAMP,
    status_id INT NOT NULL,
    service_id INT NOT NULL,
    action_type ENUM('UPDATE', 'DELETE') NOT NULL,
    action_time TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

DELIMITER //
CREATE TRIGGER trg_orders_before_delete
BEFORE DELETE ON orders
FOR EACH ROW
BEGIN
	INSERT INTO log_orders(order_id, employee_id, user_id, created_at, status_id, service_id, action_type)
    VALUES (OLD.order_id, OLD.employee_id, OLD.user_id, OLD.created_at, OLD.status_id, OLD.service_id, 'DELETE');
END //
DELIMITER ;


DELIMITER //
CREATE TRIGGER trg_orders_before_update
BEFORE UPDATE ON orders
FOR EACH ROW
BEGIN
	INSERT INTO log_orders(order_id, employee_id, user_id, created_at, status_id, service_id, action_type)
    VALUES (OLD.order_id, OLD.employee_id, OLD.user_id, OLD.created_at, OLD.status_id, OLD.service_id, 'UPDATE');
END //
DELIMITER ;



CREATE TABLE log_invoice (
	log_id INT AUTO_INCREMENT PRIMARY KEY,
    invoice_id INT,
    order_id INT,
    price DECIMAL(12, 2),
    payment_status_id INT,
    due_date DATE,
    created_at TIMESTAMP,
    action_type ENUM('UPDATE', 'DELETE') NOT NULL,
    action_time TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);


DELIMITER //
CREATE TRIGGER trg_invoice_before_update
BEFORE UPDATE ON invoice
FOR EACH ROW
BEGIN
	INSERT INTO log_invoice(invoice_id, order_id, price, payment_status_id, due_date, created_at, action_type)
    VALUES (OLD.invoice_id, OLD.order_id, OLD.price, OLD.payment_status_id, OLD.due_date, OLD.created_at, 'UPDATE');
END //
DELIMITER ;


DELIMITER //
CREATE TRIGGER trg_invoice_before_delete
BEFORE DELETE ON invoice
FOR EACH ROW
BEGIN
	INSERT INTO log_invoice(invoice_id, order_id, price, payment_status_id, due_date, created_at, action_type)
    VALUES (OLD.invoice_id, OLD.order_id, OLD.price, OLD.payment_status_id, OLD.due_date, OLD.created_at, 'DELETE');
END //
DELIMITER ;


DELIMITER //
CREATE PROCEDURE sp_get_orders_of_customer(IN p_user_id INT)
BEGIN 
	SELECT 
		o.order_id AS OrderId,
		s.name AS ServiceName,
		o.created_at AS CreatedAt,
		l.value AS OrderStatus,
		l1.value AS PaymentStatus,
		r.stars AS Stars,
		COALESCE(r.description, 'null') AS Description 
	FROM orders o
	JOIN services s ON o.service_id = s.service_id
	JOIN lookups l ON l.lookup_id = o.status_id
	JOIN invoice i ON o.order_id = i.order_id
	JOIN lookups l1 ON l1.lookup_id = i.payment_status_id
	LEFT JOIN reviews r ON r.order_id = o.order_id
	WHERE o.user_id = p_user_id;
END //
DELIMITER ;


DELIMITER //
CREATE PROCEDURE sp_get_orders_not_paid_of_user(IN p_user_id INT)
BEGIN
	SELECT o.order_id, o.employee_id, o.user_id, o.created_at, o.status_id, o.service_id
	FROM orders o
	JOIN invoice i ON o.order_id = i.order_id
	WHERE i.payment_status_id = 16 AND o.user_id = p_user_id; -- 16 = pending
END //
DELIMITER ;



DELIMITER //
CREATE PROCEDURE sp_pay_order(IN p_order_id INT)
BEGIN
	UPDATE invoice SET payment_status_id = 16 WHERE order_id = p_order_id;
END //
DELIMITER ;



CREATE VIEW get_orders_for_admins_and_employees AS
SELECT 
	o.order_id AS OrderId,
	c.name AS CustomerName,
	s.name AS ServiceName,
	o.created_at AS CreatedAt,
	l.value AS OrderStatus,
	l1.value AS PaymentStatus,
	r.stars AS Stars,
	COALESCE(r.description, 'null') AS ReviewDescription 
FROM orders o
JOIN services s ON o.service_id = s.service_id
JOIN lookups l ON l.lookup_id = o.status_id
JOIN invoice i ON o.order_id = i.order_id
JOIN lookups l1 ON l1.lookup_id = i.payment_status_id
JOIN reviews r ON r.order_id = o.order_id
JOIN users u ON u.user_id = o.user_id
JOIN customers c ON c.user_id = u.user_id;