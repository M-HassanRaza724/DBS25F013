-- Insert Users
INSERT INTO Users (name, email, password, role) VALUES
('admin', 'admin@gmail.com', 'pass123#', 'admin'),
('ali', 'ali@gmail.com', 'pass123#', 'customer'),
('hassan', 'hassan@gmail.com', 'pass123#', 'customer');

-- Insert Services
INSERT INTO Services (type, description) VALUES
('IT Consulting and Support', 'We provide expert IT consulting to help you strategize, plan, and implement effective technology solutions.'),
('Quality Assurance & Testing', 'We conduct rigorous testing to ensure your software is bug-free, reliable, and optimized for performance.'),
('UI/UX Design', 'We craft intuitive, aesthetic, and functional user interfaces for your applications and websites, ensuring a great user experience.'),
('Mobile App Development', 'We specialize in developing user-friendly mobile applications for both iOS and Android platforms.'),
('Web Development', 'We build responsive, scalable, and engaging websites to help you establish a robust online presence.'),
('Custom Software Development', 'Our team creates custom software solutions to address your specific business requirements, improving productivity and streamlining operations.');

-- INSERT INTO ServiceTechnologies (service_id, technology) VALUES
(3, 'User research, wireframing, prototyping, testing'),
(4, 'Swift, Kotlin, Flutter, React Native'),
(5, 'HTML5, CSS3, JavaScript, React, Node.js, PHP'),
(6, 'C++, Java, Python, .NET');

-- Insert ServiceInvolved
INSERT INTO ServiceInvolved (service_id, service_involved) VALUES
(1, 'Regular maintenance, updates, troubleshooting, tech support'),
(2, 'Functional testing, performance testing, security testing, automation testing'),
(3, 'App design, web design, brand identity, product design'),
(4, 'Business apps, social networking apps, gaming apps, utility apps'),
(5, 'E-commerce sites, CMS solutions, landing pages, corporate websites'),
(6, 'Business applications, enterprise software, process automation, custom tool development');

-- Insert Orders (Add missing 'Data Analytics' service first)
INSERT INTO Services (type, description) VALUES ('Data Analytics', 'Service for analytics');
INSERT INTO Orders (order_id, user_id, service_id, platform, budget_range, time_frame, description, status, revenue_generated, title) VALUES
('HXA_ali@gmail.com_1', 2, 5, 'Web', '$20000 - $50000', '02/01/2024 to 04/01/2024', 'A simple light theme web site for my stationary store', 1, 35000, 'Statinary Store'),
('HXA_ali@gmail.com_2', 2, (SELECT service_id FROM Services WHERE type = 'Data Analytics'), 'Cross-platform', '<$5000', '12/12/2024 to 25/12/2024', 'Built a dashboard for analyzing sales across multiple regions', 0, NULL, NULL);

-- Insert Reviews (Linked to first order)
INSERT INTO Reviews (order_id, reviewer_name, stars, date, description) VALUES
('HXA_ali@gmail.com_1', 'John Doe', 5, '2024-10-12', 'The software house delivered beyond expectations. The project was managed seamlessly, and the team went above and beyond to meet our requirements.'),
('HXA_ali@gmail.com_1', 'Jane Smith', 5, '2024-09-25', 'I hired them for a website development project. The team was highly professional, communicative, and provided valuable insights throughout.'),
('HXA_ali@gmail.com_1', 'Robert Lee', 5, '2024-08-10', 'They delivered the app on time, and it performed flawlessly. The customer support was available even post-launch, which was incredibly helpful.');