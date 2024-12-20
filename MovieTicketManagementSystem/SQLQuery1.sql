create table movies 
(
id INT PRIMARY KEY IDENTITY(1,1),
movie_id VARCHAR(MAX) NULL,
movie_name VARCHAR(MAX) NULL,
genre VARCHAR(MAX) NULL,
price FLOAT NULL,
capacity INT NULL,
movie_image VARCHAR(MAX) NULL,
status VARCHAR(MAX) NULL,
created_at DATETIME NULL,
update_date DATE NULL,
delete_date DATE NULL,
)

SELECT * FROM movies

DROP TABLE movies