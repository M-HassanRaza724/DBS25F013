-- Users Table (Combines Admins & Customers)
CREATE TABLE Users (
    user_id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(255) NOT NULL,
    email VARCHAR(255) UNIQUE NOT NULL,
    password VARCHAR(255) NOT NULL,
    role ENUM('admin', 'customer') NOT NULL
);

-- Services Table
CREATE TABLE Services (
    service_id INT PRIMARY KEY AUTO_INCREMENT,
    type VARCHAR(255) UNIQUE NOT NULL,
    description TEXT NOT NULL
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

-- Orders Table
CREATE TABLE Orders (
    order_id VARCHAR(255) PRIMARY KEY,
    user_id INT NOT NULL,
    service_id INT NOT NULL,
    platform VARCHAR(255),
    budget_range VARCHAR(255),
    time_frame VARCHAR(255),
    description TEXT,
    status INT NOT NULL,
    revenue_generated DECIMAL(10, 2),
    title VARCHAR(255),
    is_special_project BOOLEAN GENERATED ALWAYS AS (title IS NOT NULL) STORED,
    FOREIGN KEY (user_id) REFERENCES Users(user_id) ON DELETE CASCADE,
    FOREIGN KEY (service_id) REFERENCES Services(service_id) ON DELETE CASCADE
);

-- Reviews Table
CREATE TABLE Reviews (
    review_id INT PRIMARY KEY AUTO_INCREMENT,
    order_id VARCHAR(255) NOT NULL,
    reviewer_name VARCHAR(255) NOT NULL,
    stars INT NOT NULL CHECK (stars BETWEEN 1 AND 5),
    date DATE NOT NULL,
    description TEXT NOT NULL,
    FOREIGN KEY (order_id) REFERENCES Orders(order_id) ON DELETE CASCADE
);