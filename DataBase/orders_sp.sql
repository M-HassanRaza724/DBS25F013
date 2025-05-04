-- add orders
{DELIMITER $$
CREATE DEFINER =`root`@`localhost` PROCEDURE `sp_add_order`(IN employeeid INT, IN custid INT, IN createdate timestamp, IN statusid INT, IN serviceid INT, IN initialbudgetid INT, IN platformid INT)
BEGIN
    INSERT INTO orders(employee_id, customer_id, created_at, status_id) VALUES(employeeid, custid, createdate, statusid);
    INSERT INTO orderdetails(order_id, service_id, initial_budget_id, platform_id) VALUES((select order_id from orders where  (employee_id, customer_id, created_at, status_id) = (employeeid, custid, createdate, statusid)), serviceid, initialbudgetid, platformid);
END$$

DELIMITER ;


-- update orders
DELIMITER $$
CREATE DEFINER =`root`@`localhost` PROCEDURE `sp_update_order`(IN orderId INT, IN employeeid INT, IN custid INT, IN statusid INT, IN serviceid INT, IN initialbudgetid INT, IN platformid INT)
BEGIN
    Update orders SET employee_id= employeeid , customer_id = custid, status_id = statusid where order_id = orderId;
    Update orderdetails SET service_id = serviceid, initial_budget_id = initialbudgetid, platform_id = platformid where order_id = orderId;
END$$
DELIMITER ;

-- delete orders

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_delete_order`(IN orderId INT)
BEGIN
	Delete from orders where order_id = orderId;
END$$

DELIMITER ;
;