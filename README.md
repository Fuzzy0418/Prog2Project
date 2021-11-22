# Shop Management System
  - Login system
  - Register System
  - Products/Categories  (create, edit, delete)
  - Statistics

# V0.1
  - Close button
  - Login panel design

# V0.2
  - Add config file
    - cString => connectionString
    - onlyAdmin => true/false (Only admin can log in)
  - Add MSSQL connection
    - With dbConnect class
  - Add Feedback messages
  - Add User class

# V0.3
  - Add Product class
  - Add Categories class

# V0.4
  - Fix dbConnect class
  - Add get/set methods to Product class
  - Add get/set methods to Categories class
  - Add get/set methods to User class

# V0.5
  - changed product and categories gridview design
  - Create product design
  - Create categories design

# V0.6
  - Add createProduct function
  - Add createCategory function
  - Fix the insert method of the dbConnect class

# V0.7
  - PRODUCTS, CATEGORIES, CONNECTION, CONFIG variables are now global
  - Fixed Product and Category gridview update, when you create a new element
  - dbConnect has been optimized

# V0.8
  - products, categories, users class convert to struct
  - PRODUCTS, CATEGORIES loading fixed
  - Add productModify function
  - Add categoryModify function
  - Add categoryDelete function

# V0.9
  - Fixed productModify function
  - Fixed categoryDelete function
  - Add productDelete function
  - Add password hash function
  - Windows are draggable
