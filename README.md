№1 Библиотека классов с юнит-тестами

№2 Select Product.name AS "Product", Category.name AS "Category"
From Product
Left Join ProductCategory ON ProductCategory.product_id = Product.id
Left Join Category ON ProductCategory.category_id = Category.id
