-- 1
SELECT AVG(rental_rate) FROM film

-- 2
SELECT SUM(CASE WHEN title LIKE 'C%' THEN 1 ELSE 0 END) FROM film

-- 3
SELECT MAX(length) FROM film WHERE rental_rate = 0.99

-- 4 
SELECT COUNT(DISTINCT replacement_cost) FROM film WHERE length > 150
