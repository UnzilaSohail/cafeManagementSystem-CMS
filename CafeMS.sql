----  Creation  Queries


---- Creation Queries

---- Employees table
--CREATE TABLE Employees (
--    Employee_ID INT PRIMARY KEY IDENTITY(1,1),
--    Username NVARCHAR(100) NOT NULL,
--    Password NVARCHAR(100) NOT NULL,
--    Is_Manager BIT NOT NULL DEFAULT 0,
--    First_Name NVARCHAR(50) NOT NULL,
--    Last_Name NVARCHAR(50),
--    Email NVARCHAR(100),
--    PhoneNumber NVARCHAR(20),
--    Address NVARCHAR(255),
--    Join_Date DATE,
--    Shift_StartTime TIME,
--    Shift_EndTime TIME,
--    Salary DECIMAL(10, 2),
--    Hourly_Rate DECIMAL(8, 2)
--);

---- Customers table
--CREATE TABLE Customers (
--    Customer_ID INT PRIMARY KEY IDENTITY(1,1),
--    Username NVARCHAR(50) NOT NULL,
--    Password NVARCHAR(50) NOT NULL,
--    First_Name NVARCHAR(50) NOT NULL,
--    Last_Name NVARCHAR(50),
--    Email NVARCHAR(100),
--    PhoneNumber NVARCHAR(20),
--    Address NVARCHAR(255),
--    JoinDate DATE
--);

---- Suppliers table
--CREATE TABLE Suppliers (
--    Supplier_ID INT PRIMARY KEY IDENTITY(1,1),
--    Name NVARCHAR(200) NOT NULL,
--    ContactPerson NVARCHAR(100),
--    Phone NVARCHAR(20),
--    Email NVARCHAR(100),
--    Address NVARCHAR(255)
--);

---- ProductCategories Table
--CREATE TABLE ProductCategories (
--    CategoryId INT PRIMARY KEY IDENTITY(1,1),
--    CategoryName NVARCHAR(50) NOT NULL,
--    Description NVARCHAR(255)
--);

---- Products Table
--CREATE TABLE Products (
--    Product_ID INT PRIMARY KEY IDENTITY(1,1),
--    Name NVARCHAR(100) NOT NULL,
--    Description NVARCHAR(255),
--    Price DECIMAL(10, 2) NOT NULL,
--    Quantity INT NOT NULL,
--    CategoryId INT NOT NULL,
--    SupplierId INT,
--    FOREIGN KEY (CategoryId) REFERENCES ProductCategories(CategoryId),
--    FOREIGN KEY (SupplierId) REFERENCES Suppliers(Supplier_ID)
--);

---- Orders table
--CREATE TABLE Orders (
--    Order_ID INT PRIMARY KEY IDENTITY(1,1),
--    CustomerID INT,
--    EmployeeID INT,
--    OrderDate DATETIME,
--    FOREIGN KEY (CustomerID) REFERENCES Customers(Customer_ID),
--    FOREIGN KEY (EmployeeID) REFERENCES Employees(Employee_ID)
--);

---- OrderDetails table
--CREATE TABLE OrderDetails (
--    OrderID INT,
--    ProductID INT,
--    Quantity INT,
--    Subtotal DECIMAL(10, 2),
--    PRIMARY KEY (OrderID, ProductID),
--    FOREIGN KEY (OrderID) REFERENCES Orders(Order_ID),
--    FOREIGN KEY (ProductID) REFERENCES Products(Product_ID)
--);

---- EmployeeSchedule table
--CREATE TABLE EmployeeCheckInOuts (
--    CheckInOutId INT PRIMARY KEY IDENTITY(1,1),
--    EmployeeID INT,
--    CheckInTime DATETIME,
--    CheckOutTime DATETIME,
--    DateCheckInOut DATE,
--    FOREIGN KEY (EmployeeID) REFERENCES Employees(Employee_ID)
--);

---- Feedback Table
--CREATE TABLE Feedback (
--    FeedbackID INT PRIMARY KEY IDENTITY(1,1),
--    CustomerID INT,
--    FeedbackText NVARCHAR(MAX),
--    Rating INT,
--    FeedbackDate DATETIME,
--    FOREIGN KEY (CustomerID) REFERENCES Customers(Customer_ID)
--);

---- Promotions Table
--CREATE TABLE Promotions (
--    PromotionID INT PRIMARY KEY IDENTITY(1,1),
--    Name NVARCHAR(100) NOT NULL,
--    Description NVARCHAR(255),
--    StartDate DATE,
--    EndDate DATE,
--    Discount DECIMAL(5, 2),
--    ProductCategory INT,
--    FOREIGN KEY (ProductCategory) REFERENCES ProductCategories(CategoryId)
--);



---- Insertion Queries


------ Inserting data into Employees table
----INSERT INTO Employees (Username, Password, Is_Manager, First_Name, Last_Name, Email, PhoneNumber, Address, Join_Date, Shift_StartTime, Shift_EndTime, Salary, Hourly_Rate)
----VALUES 
----('emp1', 'pass1', 1, 'Ahmed', 'Ali', 'ahmed@example.com', '03001234567', '123 Main St', '2023-01-01', '09:00', '17:00', 50000.00, 500.00),
----('emp2', 'pass2', 0, 'Fatima', 'Khan', 'fatima@example.com', '03111234567', '456 Oak St', '2023-01-02', '10:00', '18:00', 40000.00, 400.00),
----('emp3', 'pass3', 0, 'Ali', 'Raza', 'ali.raza@example.com', '03221234567', '789 Pine St', '2023-01-03', '11:00', '19:00', 35000.00, 350.00),
----('emp4', 'pass4', 0, 'Sana', 'Ahmed', 'sana@example.com', '03331234567', '101 Elm St', '2023-01-04', '12:00', '20:00', 30000.00, 300.00),
----('emp5', 'pass5', 0, 'Usman', 'Khan', 'usman@example.com', '03441234567', '222 Oak St', '2023-01-05', '13:00', '21:00', 25000.00, 250.00),
----('emp6', 'pass6', 0, 'Zara', 'Ali', 'zara@example.com', '03551234567', '333 Maple St', '2023-01-06', '14:00', '22:00', 20000.00, 200.00),
----('emp7', 'pass7', 0, 'Farhan', 'Ahmed', 'farhan@example.com', '03661234567', '444 Pine St', '2023-01-07', '15:00', '23:00', 18000.00, 180.00),
----('emp8', 'pass8', 0, 'Ayesha', 'Khan', 'ayesha@example.com', '03771234567', '555 Elm St', '2023-01-08', '16:00', '00:00', 16000.00, 160.00),
----('emp9', 'pass9', 0, 'Tariq', 'Raza', 'tariq@example.com', '03881234567', '666 Oak St', '2023-01-09', '17:00', '01:00', 14000.00, 140.00),
----('emp10', 'pass10', 0, 'Aisha', 'Ali', 'aisha@example.com', '03991234567', '777 Maple St', '2023-01-10', '18:00', '02:00', 12000.00, 120.00),
----('emp11', 'pass11', 0, 'Raza', 'Khan', 'raza@example.com', '03101234567', '888 Pine St', '2023-01-11', '19:00', '03:00', 10000.00, 100.00),
----('emp12', 'pass12', 0, 'Sara', 'Ahmed', 'sara@example.com', '03111234568', '999 Elm St', '2023-01-12', '20:00', '04:00', 9000.00, 90.00),
----('emp13', 'pass13', 0, 'Bilal', 'Ali', 'bilal@example.com', '03121234569', '111 Oak St', '2023-01-13', '21:00', '05:00', 8000.00, 80.00),
----('emp14', 'pass14', 0, 'Hina', 'Khan', 'hina@example.com', '03131234560', '222 Maple St', '2023-01-14', '22:00', '06:00', 7000.00, 70.00),
----('emp15', 'pass15', 0, 'Hamza', 'Ahmed', 'hamza@example.com', '03141234561', '333 Pine St', '2023-01-15', '23:00', '07:00', 6000.00, 60.00);

------ Inserting data into Customers table
----INSERT INTO Customers (Username, Password, First_Name, Last_Name, Email, PhoneNumber, Address, JoinDate)
----VALUES 
----('customer1', 'passcust1', 'Ali', 'Hassan', 'ali@example.com', '03211234567', '789 Elm St', '2023-01-05'),
----('customer2', 'passcust2', 'Sana', 'Khan', 'sana@example.com', '03331234567', '101 Pine St', '2023-01-08'),
----('customer3', 'passcust3', 'Hassan', 'Ahmed', 'hassan@example.com', '03451234567', '456 Oak St', '2023-01-10'),
----('customer4', 'passcust4', 'Nadia', 'Raza', 'nadia@example.com', '03561234567', '222 Elm St', '2023-01-12'),
----('customer5', 'passcust5', 'Farhan', 'Ali', 'farhan@example.com', '03671234567', '777 Maple St', '2023-01-15'),
----('customer6', 'passcust6', 'Ayesha', 'Khan', 'ayesha@example.com', '03781234567', '888 Oak St', '2023-01-20'),
----('customer7', 'passcust7', 'Zara', 'Ahmed', 'zara@example.com', '03891234567', '111 Pine St', '2023-01-22'),
----('customer8', 'passcust8', 'Saad', 'Ali', 'saad@example.com', '03991234567', '444 Elm St', '2023-01-25'),
----('customer9', 'passcust9', 'Sara', 'Khan', 'sara@example.com', '03101234568', '999 Maple St', '2023-01-28'),
----('customer10', 'passcust10', 'Bilal', 'Ahmed', 'bilal@example.com', '03111234569', '666 Oak St', '2023-02-01'),
----('customer11', 'passcust11', 'Hina', 'Ali', 'hina@example.com', '03121234560', '123 Pine St', '2023-02-05'),
----('customer12', 'passcust12', 'Ahmed', 'Khan', 'ahmed@example.com', '03131234561', '333 Elm St', '2023-02-10'),
----('customer13', 'passcust13', 'Sana', 'Ahmed', 'sana@example.com', '03141234562', '444 Maple St', '2023-02-15'),
----('customer14', 'passcust14', 'Hamza', 'Ali', 'hamza@example.com', '03151234563', '555 Oak St', '2023-02-20'),
----('customer15', 'passcust15', 'Nadia', 'Khan', 'nadia@example.com', '03161234564', '666 Pine St', '2023-02-25');

------ Inserting data into ProductCategories table
----INSERT INTO ProductCategories (CategoryName, Description)
----VALUES 
----('Drinks', 'Tea/Coffee/Juices/Soft Drinks'),
----('Food', 'Paratha/Sandwich/Biryani/Pizza/Burger'),
----('Desserts', 'Cake/Ice Cream/Pastries');

------ Inserting data into Suppliers table
----INSERT INTO Suppliers (Name, ContactPerson, Phone, Email, Address)
----VALUES 
----('National Tea', 'Asad', '03121234567', 'asad@nationaltea.com', '786, Tea Avenue'),
----('Pizza Perfect', 'Saima', '03441234567', 'saima@pizzaperfect.com', '888, Pizza Plaza'),
----('Bakery Delights', 'Ali', '03351234567', 'ali@bakerydelights.com', '123, Bakery Street'),
----('Fresh Farm', 'Sana', '03561234567', 'sana@freshfarm.com', '456, Farm Road'),
----('Ice Cream Factory', 'Bilal', '03771234567', 'bilal@icecreamfactory.com', '789, Ice Cream Lane');

------ Inserting data into Products table
----INSERT INTO Products (Name, Description, Price, Quantity, CategoryId, SupplierId)
----VALUES 
----('Green Tea', 'Refreshing green tea', 100.00, 50, 1, 1),
----('Chicken Tikka Pizza', 'Spicy chicken tikka pizza', 800.00, 20, 2, 2),
----('Chocolate Cake', 'Rich chocolate cake', 500.00, 30, 3, 3),
----('Lamb Biryani', 'Flavorful lamb biryani', 600.00, 25, 2, 4),
----('Cold Coffee', 'Chilled coffee with ice cream', 200.00, 40, 1, 5),
----('Chicken Burger', 'Grilled chicken burger', 400.00, 35, 2, 1),
----('Vanilla Ice Cream', 'Classic vanilla ice cream', 150.00, 60, 3, 5),
----('Masala Paratha', 'Spicy flatbread', 50.00, 100, 2, 4),
----('Mango Juice', 'Fresh mango juice', 120.00, 45, 1, 3),
----('Cheese Sandwich', 'Cheesy sandwich', 300.00, 30, 2, 2),
----('Strawberry Pastry', 'Delicious strawberry pastry', 180.00, 40, 3, 4),
----('Cappuccino', 'Foamy cappuccino', 180.00, 30, 1, 1),
----('Beef Pizza', 'Succulent beef pizza', 900.00, 15, 2, 2),
----('Fruit Salad', 'Healthy fruit salad', 250.00, 20, 3, 3),
----('Lemonade', 'Refreshing lemonade', 80.00, 50, 1, 4);

------ Inserting data into Orders table
----INSERT INTO Orders (CustomerID, EmployeeID, OrderDate)
----VALUES 
----(1, 1, '2023-02-15 10:30:00'),
----(2, 2, '2023-02-18 12:00:00'),
----(3, 3, '2023-02-20 09:45:00'),
----(4, 4, '2023-02-22 13:15:00'),
----(5, 5, '2023-02-25 11:30:00'),
----(6, 6, '2023-02-28 14:00:00'),
----(7, 7, '2023-03-02 10:00:00'),
----(8, 8, '2023-03-05 12:45:00'),
----(9, 9, '2023-03-07 09:30:00'),
----(10, 10, '2023-03-10 14:30:00'),
----(11, 11, '2023-03-12 11:15:00'),
----(12, 12, '2023-03-15 13:45:00'),
----(13, 13, '2023-03-17 10:30:00'),
----(14, 14, '2023-03-20 12:00:00'),
----(15, 15, '2023-03-22 09:45:00');

-------- Inserting data into OrderDetails table
----INSERT INTO OrderDetails (OrderID, ProductID, Quantity, Subtotal)
----VALUES 
----(1, 1, 2, 200.00),
----(1, 2, 1, 800.00),
----(2, 2, 3, 2400.00),
----(3, 3, 1, 500.00),
----(3, 4, 2, 1200.00),
----(4, 5, 2, 400.00),
----(4, 6, 1, 400.00),
----(5, 7, 1, 150.00),
----(5, 8, 3, 150.00),
----(6, 9, 2, 240.00),
----(6, 10, 1, 300.00),
----(7, 11, 1, 180.00),
----(7, 12, 2, 600.00),
----(8, 13, 1, 180.00),
----(8, 14, 1, 900.00),
----(9, 15, 2, 500.00),
----(9, 1, 1, 100.00),
----(10, 2, 2, 1600.00),
----(10, 3, 1, 250.00),
----(11, 4, 2, 1200.00),
----(11, 5, 1, 200.00),
----(12, 6, 1, 400.00),
----(12, 7, 2, 300.00),
----(13, 8, 1, 150.00),
----(13, 9, 1, 120.00),
----(14, 10, 2, 600.00),
----(14, 11, 1, 180.00),
----(15, 12, 1, 300.00),
----(15, 13, 3, 540.00);

------ Inserting data into EmployeeCheckInOuts table
----INSERT INTO EmployeeCheckInOuts (EmployeeID, CheckInTime, CheckOutTime, DateCheckInOut)
----VALUES 
----(1, '2023-02-15 09:00:00', '2023-02-15 17:00:00', '2023-02-15'),
----(2, '2023-02-18 10:00:00', '2023-02-18 18:00:00', '2023-02-18'),
----(3, '2023-02-20 09:00:00', '2023-02-20 17:00:00', '2023-02-20'),
----(4, '2023-02-22 10:00:00', '2023-02-22 18:00:00', '2023-02-22'),
----(5, '2023-02-25 09:00:00', '2023-02-25 17:00:00', '2023-02-25'),
----(6, '2023-02-28 10:00:00', '2023-02-28 18:00:00', '2023-02-28'),
----(7, '2023-03-02 09:00:00', '2023-03-02 17:00:00', '2023-03-02'),
----(8, '2023-03-05 10:00:00', '2023-03-05 18:00:00', '2023-03-05'),
----(9, '2023-03-07 09:00:00', '2023-03-07 17:00:00', '2023-03-07'),
----(10, '2023-03-10 10:00:00', '2023-03-10 18:00:00', '2023-03-10'),
----(11, '2023-03-12 09:00:00', '2023-03-12 17:00:00', '2023-03-12'),
----(12, '2023-03-15 10:00:00', '2023-03-15 18:00:00', '2023-03-15'),
----(13, '2023-03-17 09:00:00', '2023-03-17 17:00:00', '2023-03-17'),
----(14, '2023-03-20 10:00:00', '2023-03-20 18:00:00', '2023-03-20'),
----(15, '2023-03-22 09:00:00', '2023-03-22 17:00:00', '2023-03-22');

------ Inserting data into Feedback table
----INSERT INTO Feedback (CustomerID, FeedbackText, Rating, FeedbackDate)
----VALUES 
----(1, 'Great service and ambiance!', 5, '2023-02-20'),
----(2, 'Delicious food and fast service!', 4, '2023-02-21'),
----(3, 'Friendly staff and clean environment.', 5, '2023-02-23'),
----(4, 'Tasty biryani but slow service.', 3, '2023-02-24'),
----(5, 'Amazing desserts but limited options.', 4, '2023-02-26'),
----(6, 'Good experience overall.', 4, '2023-03-01'),
----(7, 'Excellent pizza and drinks!', 5, '2023-03-03'),
----(8, 'Quality of food could be better.', 3, '2023-03-06'),
----(9, 'Love the sandwiches and salads!', 5, '2023-03-08'),
----(10, 'Average experience, nothing special.', 3, '2023-03-11'),
----(11, 'Fast delivery and hot food.', 4, '2023-03-13'),
----(12, 'Disappointed with the service.', 2, '2023-03-16'),
----(13, 'Excellent value for money.', 5, '2023-03-18'),
----(14, 'Would love more variety in desserts.', 4, '2023-03-21'),
----(15, 'Great place for family gatherings.', 5, '2023-03-23');

------ Inserting data into Promotions table
----INSERT INTO Promotions (Name, Description, StartDate, EndDate, Discount, ProductCategory)
----VALUES 
----('Happy Hour', '50% off on all drinks from 4 PM to 6 PM', '2023-04-01', '2023-04-30', 50.00, 1),
----('Weekend Special', '20% off on all food items on weekends', '2023-04-01', '2023-04-30', 20.00, 2),
----('Summer Delight', 'Free ice cream with every meal in summer', '2023-05-01', '2023-05-31', 100.00, 3);











---- Stored procedures

---- stored procedure to retrieve all orders for a specific customer
----CREATE PROCEDURE GetOrdersForCustomer
----    @CustomerID INT
----AS
----BEGIN
----    SELECT * FROM Orders WHERE CustomerID = @CustomerID;
----END;

---- stored procedure to retrieve all orders for a specific customer
----CREATE PROCEDURE GetOrdersForCustomer
----    @CustomerID INT
----AS
----BEGIN
----    SELECT * FROM Orders WHERE CustomerID = @CustomerID;
----END;

---- Add a new employee to the database.
----CREATE PROCEDURE AddNewEmployee
----    @Username NVARCHAR(100),
----    @Password NVARCHAR(100),
----    @IsManager BIT,
----    @FirstName NVARCHAR(50),
----	@LastName NVARCHAR(50),
----    @Email NVARCHAR(100),
----    @PhoneNumber NVARCHAR(20),
----    @Address NVARCHAR(255),
----    @JoinDate DATE,
----    @Salary DECIMAL(10, 2),
----    @HourlyRate DECIMAL(8, 2)
----AS
----BEGIN
----    INSERT INTO Employees (Username, Password, Is_Manager, First_Name, Last_Name, Email, PhoneNumber, Address, Join_Date, Salary, Hourly_Rate)
----    VALUES (@Username, @Password, @IsManager, @FirstName, @LastName, @Email, @PhoneNumber, @Address, @JoinDate, @Salary, @HourlyRate);
----END;

---- Retrieve the total sales of a specific product.
----CREATE PROCEDURE GetTotalSalesByProduct
----    @ProductID INT
----AS
----BEGIN
----    SELECT p.Name AS ProductName, s.Name, SUM(od.Quantity) AS TotalSales
----    FROM OrderDetails od
----    INNER JOIN Products p ON od.ProductID = p.Product_ID
----    INNER JOIN Suppliers s ON p.SupplierId = s.Supplier_ID
----    WHERE od.ProductID = @ProductID
----    GROUP BY p.Name, s.Name;
----END;

----calculates payroll for employees
----CREATE PROCEDURE CalculateEmployeePayroll
----AS
----BEGIN
----    -- Variables to hold calculated values
----    DECLARE @TotalPayroll DECIMAL(12, 2);

----    -- Calculate payroll for non-managers based on hourly rates and working hours
----    SET @TotalPayroll = (
----        SELECT SUM((e.HourlyRate * DATEDIFF(HOUR, es.ShiftStart, es.ShiftEnd)) + e.Salary) AS TotalPay
----        FROM Employees e
----        LEFT JOIN EmployeeSchedule es ON e.EmployeeID = es.EmployeeID
----    );

----    -- Display the total payroll
----    SELECT @TotalPayroll AS TotalPayroll;
----END;

------ generates a bill receipt for a specific order
----CREATE PROCEDURE GenerateBillReceipt
----    @OrderID INT
----AS
----BEGIN
----    -- Variables to hold bill receipt information
----    DECLARE @CustomerName NVARCHAR(100);
----    DECLARE @CustomerEmail NVARCHAR(100);
----    DECLARE @OrderDate DATETIME;
----    DECLARE @ProductName NVARCHAR(100);
----    DECLARE @Quantity INT;
----    DECLARE @Subtotal DECIMAL(10, 2);
----    DECLARE @TotalAmount DECIMAL(10, 2);

----    -- Fetching order and customer details
----    SELECT @CustomerName = c.First_Name + ' ' + c.Last_Name,
----           @CustomerEmail = c.Email,
----           @OrderDate = o.OrderDate
----    FROM Orders o
----    INNER JOIN Customers c ON o.CustomerID = c.Customer_ID
----    WHERE o.Order_ID = @OrderID;

----    -- Creating a temporary table to store product details for the order
----    CREATE TABLE #TempBillReceipt (
----        ProductName NVARCHAR(100),
----        Quantity INT,
----        Subtotal DECIMAL(10, 2)
----    );

----    -- Fetching product details for the order and calculating subtotal for each product
----    INSERT INTO #TemporaryBillReceipt (ProductName, Quantity, Subtotal)
----    SELECT p.Name, od.Quantity, od.Subtotal
----    FROM OrderDetails od
----    INNER JOIN Products p ON od.ProductID = p.Product_ID
----    WHERE od.OrderID = @OrderID;

----    -- Fetching total amount for the order
----    SELECT @TotalAmount = SUM(Subtotal) FROM #TempBillReceipt;

----    -- Displaying the bill receipt
----    SELECT 
----        'Customer Name: ' + @CustomerName AS 'Customer Name',
----        'Customer Email: ' + @CustomerEmail AS 'Customer Email',
----        'Order Date: ' + CONVERT(NVARCHAR(30), @OrderDate, 120) AS 'Order Date';

----    SELECT '--- Product Details ---' AS 'Product Details';
----    SELECT * FROM #TemporaryBillReceipt;

----    SELECT '--- Total Amount ---' AS 'Total Amount';
----    SELECT @TotalAmount AS 'Total Amount';

----    -- Drop temporary table
----    DROP TABLE #TemporaryBillReceipt;
----END;


---- calculate total amount of a order
----CREATE PROCEDURE CalculateOrderTotal
----    @OrderID INT
----AS
----BEGIN
----    DECLARE @TotalAmount DECIMAL(10, 2);

----    SELECT @TotalAmount = SUM(Subtotal)
----    FROM OrderDetails
----    WHERE OrderID = @OrderID;

----    -- Displaying the calculated total amount for the order
----    SELECT @TotalAmount AS TotalAmount;
----END;











----Triggers 



----CREATE TRIGGER Update_ProductQty
----ON OrderDetails
----AFTER INSERT
----AS
----BEGIN
----    DECLARE @ProductID INT, @Quantity INT;
----    SELECT @ProductID = ProductID, @Quantity = Quantity FROM inserted;

----    UPDATE Products
----    SET Quantity = Quantity - @Quantity
----    WHERE Product_ID = @ProductID;
----END;



----Trigger to Check Product Quantity before Order
----CREATE TRIGGER PreventZeroQuantityOnOrderInsert
----ON Orders
----INSTEAD OF INSERT
----AS
----BEGIN
----    IF EXISTS (
----        SELECT 1
----        FROM inserted i
----        INNER JOIN OrderDetails od ON i.OrderID = od.OrderID
----        INNER JOIN Products p ON od.ProductID = p.ProductID
----        WHERE p.Quantity = 0
----    )
----    BEGIN
----        RAISERROR ('Cannot add order with items having zero quantity!', 16, 1);
----        ROLLBACK TRANSACTION;
----    END
----END;




---- update product quantity after an order is placed
----CREATE TRIGGER UpdateProductQuantity
----ON OrderDetails
----AFTER INSERT
----AS
----BEGIN
----    DECLARE @ProductID INT, @Quantity INT;
----    SELECT @ProductID = ProductID, @Quantity = Quantity FROM inserted;

----    UPDATE Products
----    SET Quantity = Quantity - @Quantity
----    WHERE ProductID = @ProductID;
----END;

---- Trigger to check product quantity before order insertion
----CREATE TRIGGER PreventZeroQuantityOnOrderInsert
----ON Orders
----INSTEAD OF INSERT
----AS
----BEGIN
----    IF EXISTS (
----        SELECT 1
----        FROM inserted i
----        INNER JOIN OrderDetails od ON i.Order_ID = od.OrderID
----        INNER JOIN Products p ON od.ProductID = p.Product_ID
----        WHERE p.Quantity = 0
----    )
----    BEGIN
----        RAISERROR ('Cannot add order with items having zero quantity!', 16, 1);
----        ROLLBACK TRANSACTION;
----    END;
----END;







----views


------ Example view to display order details along with product information
----CREATE VIEW OrderProductDetails AS
----    SELECT o.Order_ID, p.Name AS ProductName, od.Quantity, od.Subtotal
----    FROM OrderDetails od
----    INNER JOIN Orders o ON od.OrderID = o.Order_ID
----    INNER JOIN Products p ON od.ProductID = p.Product_ID;

---- display essential employee information
----CREATE VIEW EmployeeInformation AS
----    SELECT Employee_ID, First_Name, Last_Name, Email, PhoneNumber, Address, Join_Date, Salary, Is_Manager
----    FROM Employees;

------Extend the order details view to include customer and product details
----CREATE VIEW OrderDetailsExtended AS
----    SELECT o.Order_ID, c.First_Name, c.Last_Name AS CustomerName, p.Name AS ProductName, od.Quantity, od.Subtotal
----    FROM OrderDetails od
----    INNER JOIN Orders o ON od.OrderID = o.Order_ID
----    INNER JOIN Customers c ON o.CustomerID = c.Customer_ID
----    INNER JOIN Products p ON od.ProductID = p.Product_ID;


----CREATE VIEW CustomerOrderHistory AS
----SELECT c.Customer_ID, c.First_Name + ' ' + c.Last_Name AS CustomerName,
----       o.Order_ID, o.OrderDate, SUM(od.Subtotal) AS TotalAmount
----FROM Customers c
----INNER JOIN Orders o ON c.Customer_ID = o.CustomerID
----INNER JOIN OrderDetails od ON o.Order_ID = od.OrderID
----GROUP BY c.Customer_ID, c.First_Name, c.Last_Name, o.Order_ID, o.OrderDate;


----CREATE VIEW ProductSupplierDetails AS
----SELECT p.Product_ID, p.Name AS ProductName, s.Name AS SupplierName,
----       p.Price, p.Quantity, p.Description
----FROM Products p
----INNER JOIN Suppliers s ON p.SupplierId = s.Supplier_ID;



--select * from OrderDetails;

