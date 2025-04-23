CREATE DATABASE IF NOT exists test;
USE test;

 -- 2. Lookups Table (for key-value pairs like designations, statuses, etc.)
CREATE TABLE Lookups (
    lookup_id INT PRIMARY KEY AUTO_INCREMENT,
    key_group VARCHAR(100) NOT NULL,   -- e.g., 'designation', 'order_status', 'platform'
    value VARCHAR(100) NOT NULL
);
 -- Services Table
CREATE TABLE Services (
    service_id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(255) UNIQUE NOT NULL,
    category_id INT DEFAULT 0,
    description TEXT NOT NULL,
    FOREIGN KEY (category_id) REFERENCES Lookups(lookup_id) ON DELETE SET NULL

);

 -- ServiceTechnologies Table (Handles Technologies List)
CREATE TABLE ServiceTechnologies (
    service_id INT,
    technology VARCHAR(255),
    PRIMARY KEY (service_id, technology),
    FOREIGN KEY (service_id) REFERENCES Services(service_id) ON DELETE CASCADE
);

 -- ServiceInvolved Table (Handles Sub-Services List)
CREATE TABLE ServiceInvolved (
    service_id INT,
    service_involved VARCHAR(255),
    PRIMARY KEY (service_id, service_involved),
    FOREIGN KEY (service_id) REFERENCES Services(service_id) ON DELETE CASCADE
);

 -- 1. Users Table (now includes 'employee' role)
CREATE TABLE Users (
    user_id INT PRIMARY KEY AUTO_INCREMENT,
    username VARCHAR(255) NOT NULL,
    email VARCHAR(255) UNIQUE NOT NULL,
    password VARCHAR(255) NOT NULL,
    role_id INT NOT NULL,
    FOREIGN KEY (role_id) REFERENCES Lookups(lookup_id) ON DELETE CASCADE
);
CREATE TABLE Department (
    department_id INT PRIMARY KEY AUTO_INCREMENT,
    department_name VARCHAR(100) NOT NULL,
    service_id INT NOT NULL,
    user_id INT NOT NULL,
    FOREIGN KEY (service_id) REFERENCES Services(service_id) ON DELETE CASCADE,
    FOREIGN KEY (user_id) REFERENCES Users(user_id) ON DELETE CASCADE,
    UNIQUE KEY (department_name)   -- Ensure department names are unique
);

 -- Default placeholder (lookup_id = 0)
INSERT INTO Lookups (lookup_id, key_group, value) VALUES
(0, 'default', 'default');   -- Reserved for orphaned references
INSERT INTO Lookups (key_group, value) VALUES
 -- Designations
('designation', 'Deleted Employee'),
('designation', 'Data Scientist'),
('designation', 'Full Stack Developer'),
('designation', 'FrontEnd Developer'),
('designation', 'BackEnd Developer'),
('designation', 'UI/UX Designer'),
('designation', 'QA Engineer'),
('designation', 'DevOps Engineer'),
('designation', 'Project Manager'),
('designation', 'Product Owner'),
 -- user roles
('user_role','Employee'),
('user_role','Admin'),
('user_role','Department Head'),
 -- Platforms
('platform', 'Web'),
('platform', 'Android'),
('platform', 'iOS'),
('platform', 'Windows'),
('platform', 'macOS'),
('platform', 'Linux'),
('platform', 'Cross-platform'),
('platform', 'Hybrid'),
 -- Order Statuses
('status', 'Pending'),
('status', 'In-Progress'),
('status', 'Completed'),
('status', 'Cancelled'),
('status', 'On-Hold'),
('status', 'Rejected'),
-- initial budget
('budget_type', '<$5000'),
('budget_type', '$5000-$20000'),
('budget_type', '$20000-$50000'),
('budget_type', '$50000+'),
 -- payment statuses
('payment_status', 'Pending'),
('payment_status', 'Partially Paid'),
('payment_status', 'Paid'),
('payment_status', 'Overdue'),
('payment_status', 'Cancelled'),
 -- Admin Roles
('admin_role', 'Super Admin'),
('admin_role', 'Support Admin'),
('admin_role', 'Billing Admin'),
 -- Service Categories (for filtering)
('service_category', 'Development'),
('service_category', 'Design'),
('service_category', 'Testing'),
('service_category', 'Consulting'),
 -- Priority Levels (for orders/tasks)
('priority', 'Low'),
('priority', 'Medium'),
('priority', 'High'),
('priority', 'Critical');

 -- 3. Employees Table (linked to Lookups for designation)
CREATE TABLE Employees (
    employee_id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(255) NOT NULL,
    phone VARCHAR(20),
    joined_date DATE NOT NULL DEFAULT (CURRENT_DATE),
    designation_id INT ,
    FOREIGN KEY (designation_id) REFERENCES Lookups(lookup_id) ON DELETE SET NULL
);
CREATE TABLE Salary (
    salary_id INT PRIMARY KEY AUTO_INCREMENT,
    employee_id INT NOT NULL,
    pay_date DATE NOT NULL,
    amount DECIMAL(12,2) NOT NULL,
    bonus DECIMAL(10,2) DEFAULT 0.00,
    FOREIGN KEY (employee_id) REFERENCES Employees(employee_id) ON DELETE CASCADE,
    INDEX idx_pay_date (pay_date)   -- For faster payroll queries
);
 -- 1. Orders Table
CREATE TABLE Orders (
    order_id INT PRIMARY KEY AUTO_INCREMENT,   -- Changed from VARCHAR
    employee_id INT DEFAULT 0,
    user_id INT DEFAULT 0,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    status_id INT DEFAULT 0,
    FOREIGN KEY (employee_id) REFERENCES Employees(employee_id) ON DELETE SET NULL,
    FOREIGN KEY (user_id) REFERENCES Users(user_id)  ON DELETE SET NULL,
    FOREIGN KEY (status_id) REFERENCES Lookups(lookup_id) ON DELETE SET NULL
);

 -- 2. OrderDetails Table (order_id now INT)
CREATE TABLE OrderDetails (
    order_detail_id INT PRIMARY KEY AUTO_INCREMENT,
    order_id INT NOT NULL, 
    service_id INT DEFAULT 0,
    initial_budget_id INT ,
    platform_id INT DEFAULT 0,
    FOREIGN KEY (initial_budget_id) REFERENCES Lookups(lookup_id) ON DELETE SET NULL,
    FOREIGN KEY (order_id) REFERENCES Orders(order_id) ON DELETE CASCADE,
    FOREIGN KEY (service_id) REFERENCES Services(service_id) ON DELETE SET NULL,
    FOREIGN KEY (platform_id) REFERENCES Lookups(lookup_id) ON DELETE SET NULL
);
CREATE TABLE Invoice (
    invoice_id INT PRIMARY KEY AUTO_INCREMENT,
    order_id INT NOT NULL,
    price DECIMAL(12,2) NOT NULL,
    payment_status_id INT DEFAULT 0,
    due_date DATE NOT NULL,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (order_id) REFERENCES Orders(order_id) ON DELETE CASCADE,
    FOREIGN KEY (payment_status_id) REFERENCES Lookups(lookup_id) ON DELETE SET NULL,
    INDEX idx_due_date (due_date)   -- For payment tracking
);
 -- Reviews Table
CREATE TABLE Reviews (
    review_id INT PRIMARY KEY AUTO_INCREMENT,
    order_id INT NOT NULL,
    reviewer_name VARCHAR(255) NOT NULL,
    stars INT NOT NULL CHECK (stars BETWEEN 1 AND 5),
    date DATE NOT NULL,
    description TEXT NOT NULL,
    FOREIGN KEY (order_id) REFERENCES Orders(order_id) ON DELETE CASCADE
);

 -- 3. SpecialProjects Table (order_id now INT)
CREATE TABLE SpecialProjects (
    sp_id INT PRIMARY KEY AUTO_INCREMENT,
    order_id INT NOT NULL,   -- Changed from VARCHAR
    title VARCHAR(255) NOT NULL,
    FOREIGN KEY (order_id) REFERENCES Orders(order_id) ON DELETE CASCADE
);

 -- 4. EmployeeAssignation Table (order_id now INT)
CREATE TABLE Employee_Assignation (
    assign_id INT PRIMARY KEY AUTO_INCREMENT,
    employee_id INT DEFAULT 0,
    order_id INT NOT NULL,   -- Changed from VARCHAR
    FOREIGN KEY (employee_id) REFERENCES Employees(employee_id) ON DELETE SET NULL,
    FOREIGN KEY (order_id) REFERENCES Orders(order_id) ON DELETE CASCADE,
    UNIQUE (employee_id, order_id)
);

 -- 5. Admins Table (added user_id as foreign key)
CREATE TABLE Admins (
    admin_id INT PRIMARY KEY AUTO_INCREMENT,
    user_id INT NOT NULL,   -- Added foreign key
    name VARCHAR(255) NOT NULL,
    phone VARCHAR(20),
    admin_role INT DEFAULT 0,
    FOREIGN KEY (admin_role) REFERENCES Lookups(lookup_id) ON DELETE SET NULL,
    FOREIGN KEY (user_id) REFERENCES Users(user_id) ON DELETE CASCADE   -- New constraint
);

 -- Create a view for department overview
CREATE VIEW DepartmentOverview AS
SELECT 
    d.department_id,
    d.department_name,
    s.name AS service_name,
    u.username AS head_name,
    COUNT(e.employee_id) AS employee_count
FROM Department d
JOIN Services s ON d.service_id = s.service_id
JOIN Users u ON d.user_id = u.user_id
LEFT JOIN Employees e ON e.designation_id IN (
    SELECT lookup_id FROM Lookups 
    WHERE key_group = 'designation'
)
GROUP BY d.department_id;

CREATE INDEX idx_username ON Users(username);
CREATE INDEX idx_services_category ON Services(category_id);
CREATE INDEX idx_orders_status ON Orders(status_id);
CREATE INDEX idx_orderdetails_service ON OrderDetails(service_id);