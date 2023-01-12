-- 1
CREATE TABLE employee (
  id INTEGER PRIMARY KEY,
  name VARCHAR(50) NOT NULL,
  birthday DATE,
  email VARCHAR(100)
);

-- 3
UPDATE employee
SET name = 'Berke Palamutçu', email = 'berkepalamutcu@example.com'
WHERE id = 2;

-- 
UPDATE employee
SET name = 'Dilek Çakmak', birthday = '1996-06-04', email = 'dilek@example.com'
WHERE id = 3;

--
UPDATE employee
SET name = 'Kağan Çubukçu'
WHERE id = 1;

--
UPDATE employee
SET birthday = '1992-10-30'
WHERE id = 1;

--
UPDATE employee
SET email = 'kagancancubukcu@gmail.com'
WHERE id = 1;

-- 4
DELETE FROM employee
WHERE name = 'Editha Hugli';

--
DELETE FROM employee
WHERE birthday = '1999-10-24';

--
DELETE FROM employee
WHERE email = 'ncorstorphine9@howstuffworks.com';

--
DELETE FROM employee
WHERE name = 'Arel Keigher' AND email = 'akeigherf@friendfeed.com';

--
DELETE FROM employee
WHERE id = 45;
