
CREATE DATABASE Друзья_человека;
USE Друзья_человека;

CREATE TABLE Домашние_животные_cat (
id INT AUTO_INCREMENT PRIMARY KEY,
Имя VARCHAR(255) NOT NULL UNIQUE,
Команды VARCHAR(255),
Дата_рождения DATE
); 
INSERT INTO Домашние_животные_cat (имя, команды, дата_рождения) VALUES
    ('Пушистик', 'Отдыхает, кушает', '2022-12-25'),
    ('Том', 'Идет', '2002-09-21'),
    ('Черныш', 'Пьет воду', '2017-11-20');
CREATE TABLE Домашние_животные_dog (
id INT AUTO_INCREMENT PRIMARY KEY,
Имя VARCHAR(255) NOT NULL UNIQUE,
Команды VARCHAR(255),
Дата_рождения DATE
); 
INSERT INTO Домашние_животные_dog (имя, команды, дата_рождения) VALUES
    ('Рекс', 'Отдыхает, кушает', '2021-02-15'),
    ('Белка', 'Бегает', '2009-09-11'),
    ('Лайка', 'Пьет воду', '2018-01-01');
CREATE TABLE Домашние_животные_hamster (
id INT AUTO_INCREMENT PRIMARY KEY,
Имя VARCHAR(255) NOT NULL UNIQUE,
Команды VARCHAR(255),
Дата_рождения DATE
); 
INSERT INTO домашние_животные_hamster (имя, команды, дата_рождения) VALUES
    ('Нюська', 'Отдыхает, кушает', '2022-9-12'),
    ('Шарик', 'Бегает в колесе', '2022-09-11'),
    ('Буся', 'Пьет воду', '2011-01-20');


CREATE TABLE Вьючные_животные_horse (
id INT AUTO_INCREMENT PRIMARY KEY,
Имя VARCHAR(255) NOT NULL UNIQUE,
Команды VARCHAR(255),
Дата_рождения DATE
); 
INSERT INTO Вьючные_животные_horse (имя, команды, дата_рождения) VALUES
    ('Буран', 'Сидеть, Лежать', '2020-05-15'),
    ('Снежка', 'Бежит', '2019-03-10'),
    ('Гроза', 'Прыгает через припятсвия', '2022-01-20');
CREATE TABLE Вьючные_животные_camel (
id INT AUTO_INCREMENT PRIMARY KEY,
Имя VARCHAR(255) NOT NULL UNIQUE,
Команды VARCHAR(255),
Дата_рождения DATE
); 
INSERT INTO Вьючные_животные_camel (имя, команды, дата_рождения) VALUES
    ('Алибаба', 'Отдыхает, кушает', '2022-12-25'),
    ('Альпака', 'Идет', '2019-09-11'),
    ('Саид', 'Пьет воду', '2012-11-20');
CREATE TABLE Вьючные_животные_donkey (
id INT AUTO_INCREMENT PRIMARY KEY,
Имя VARCHAR(255) NOT NULL UNIQUE,
Команды VARCHAR(255),
Дата_рождения DATE
); 
INSERT INTO Вьючные_животные_donkey (имя, команды, дата_рождения) VALUES
    ('Гром', 'Лежить, кушает', '2023-05-15'),
    ('Молния', 'Идет', '2021-07-20'),
    ('Пончик', 'Спит', '2012-01-20');


DROP TABLE IF EXISTS Вьючные_животные_camel;

CREATE TABLE Лошади_и_ослы (
id INT AUTO_INCREMENT PRIMARY KEY,
Имя VARCHAR(255) NOT NULL UNIQUE,
Команды VARCHAR(255),
Дата_рождения DATE
); 
INSERT INTO Лошади_и_ослы (имя, команды, дата_рождения)
SELECT имя, команды, дата_рождения FROM Вьючные_животные_horse
UNION ALL
SELECT имя, команды, дата_рождения FROM Вьючные_животные_donkey;

CREATE TABLE Молодые_животные (
id INT AUTO_INCREMENT PRIMARY KEY,
Имя VARCHAR(255) NOT NULL UNIQUE,
Команды VARCHAR(255),
Дата_рождения DATE
); 

INSERT INTO Молодые_животные (Имя, Команды, Дата_рождения)
SELECT имя, команды, Дата_рождения
FROM Домашние_животные_cat
WHERE DATEDIFF(NOW(), Дата_рождения) BETWEEN 365 AND 1095
UNION ALL
SELECT имя, команды, Дата_рождения
FROM Домашние_животные_dog
WHERE DATEDIFF(NOW(), Дата_рождения) BETWEEN 365 AND 1095
UNION ALL
SELECT имя, команды, Дата_рождения
FROM Домашние_животные_hamster
WHERE DATEDIFF(NOW(), Дата_рождения) BETWEEN 365 AND 1095
UNION ALL
SELECT имя, команды, Дата_рождения
FROM Вьючные_животные_horse
WHERE DATEDIFF(NOW(), Дата_рождения) BETWEEN 365 AND 1095
UNION ALL
SELECT имя, команды, Дата_рождения
FROM Вьючные_животные_donkey
WHERE DATEDIFF(NOW(), Дата_рождения) BETWEEN 365 AND 1095;

SELECT * FROM Молодые_животные;
DELETE FROM Общие_животные;

CREATE TABLE Общие_животные (
  id INT AUTO_INCREMENT PRIMARY KEY,
  Имя VARCHAR(255) NOT NULL UNIQUE,
  Команды VARCHAR(255),
  Дата_рождения DATE,
  Вид VARCHAR(255)
);
INSERT INTO Общие_животные (Имя, Команды, Дата_рождения, Вид)
SELECT Имя, Команды, Дата_рождения, 'Кошка' FROM Домашние_животные_cat
UNION ALL
SELECT Имя, Команды, Дата_рождения, 'Собака' FROM Домашние_животные_dog
UNION ALL
SELECT Имя, Команды, Дата_рождения, 'Хомяк' FROM Домашние_животные_hamster
UNION ALL
SELECT Имя, Команды, Дата_рождения, 'Лошадь' FROM Вьючные_животные_horse
UNION ALL
SELECT Имя, Команды, Дата_рождения, 'Осел' FROM Вьючные_животные_donkey;

Select * from Общие_животные;




