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
    ) AS OrdersCompleted
FROM users u
JOIN employees e ON u.user_id = e.user_id
LEFT JOIN lookups l ON l.lookup_id = e.designation_id
LEFT JOIN orders o ON o.employee_id = e.employee_id
GROUP BY e.employee_id;