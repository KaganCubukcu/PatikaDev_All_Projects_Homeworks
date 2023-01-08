-- 1
SELECT title FROM film WHERE title LIKE '%n' ORDER BY length DESC LIMIT 5

-- 2
SELECT title FROM film WHERE title LIKE '%n' ORDER BY length ASC LIMIT  5 OFFSET 5

-- 3
SELECT last_name,store_id FROM customer WHERE store_id = 1  ORDER BY last_name  DESC LIMIT 4