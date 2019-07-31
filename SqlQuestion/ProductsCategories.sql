/*На основе условия между таблицами установлена связь многие-ко-многим.
Связь многие-ко-многим создается с помощью трех таблиц.
Таблица Products
(IdProduct, Name, ...)

Таблица Categories
(IdCategory, Name, ...)

Таблица ProductsCategories
(IdProductCategory, IdProduct, IdCategory)*/

SELECT
	Products.Name
	,Categories.Name
FROM Products 						AS Products
	LEFT JOIN ProductsCategories	AS ProductsCategories
		ON Products.IdProduct = ProductsCategories.IdProduct
	LEFT JOIN Categories			AS Categories
		ON ProductsCategories.IdCategory = Categories.IdCategory