# Задание №3

Всего три таблицы: **Products** (ID и Name), **Categories** (ID и Name) и **Entries** (ProductID и CategoryID) — общая таблица. Запрос будет вытаскивать из таблицы 
Продуктов имена, даже если ID этих продуктов нет в общей таблице. Получается немного не однозначно. Если общая таблица нужна только для сопоставления продуктов 
с категориями, то нужно выводить все. Если же это таблица чего-то имеющегося, допустим, на складе, то, конечно, первый Left join некорректен. 

```
SELECT Products.Name, Categories.Name FROM products
LEFT OUTER JOIN Entries ON (Products.ID = Entries.ProductID ) 
LEFT OUTER Join Categories ON (Entries.CategoryID = Categories.ID);
```
