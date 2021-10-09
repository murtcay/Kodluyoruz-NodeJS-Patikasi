## Ödev 8

1. **test** veritabanınızda **employee** isimli sütun bilgileri id(INTEGER), name VARCHAR(50), birthday DATE, email VARCHAR(100) olan bir tablo oluşturalım.
2. Oluşturduğumuz **employee** tablosuna 'Mockaroo' servisini kullanarak 50 adet veri ekleyelim.
3. Sütunların her birine göre diğer sütunları güncelleyecek 5 adet UPDATE işlemi yapalım.
4. Sütunların her birine göre ilgili satırı silecek 5 adet DELETE işlemi yapalım.

## Çözüm

1. 
``` sql
    CREATE TABLE employee(
        id INTEGER PRIMARY KEY,
        name VARCHAR(50) NOT NULL,
        birthday DATE,
        email VARCHAR(100)	
    );

```

2. 
``` sql
    insert into employee (id, name, birthday, email) values (1, 'Katlin Klain', '1949-03-06', 'kklain0@china.com.cn');
    insert into employee (id, name, birthday, email) values (2, 'Adelaide McCorkindale', '1913-07-25', 'amccorkindale1@weather.com');
    insert into employee (id, name, birthday, email) values (3, 'Bernadette Gadney', '1978-10-03', 'bgadney2@hp.com');
    insert into employee (id, name, birthday, email) values (4, 'Baxy Durrans', '1984-07-14', 'bdurrans3@friendfeed.com');
    insert into employee (id, name, birthday, email) values (5, 'Haven Cragell', null, 'hcragell4@theatlantic.com');
    insert into employee (id, name, birthday, email) values (6, 'Conrado Sam', '1951-09-25', 'csam5@i2i.jp');
    insert into employee (id, name, birthday, email) values (7, 'Eb Teece', null, 'eteece6@earthlink.net');
    insert into employee (id, name, birthday, email) values (8, 'Madlin Fairclough', null, 'mfairclough7@marriott.com');
    insert into employee (id, name, birthday, email) values (9, 'Hillie Coppeard', null, 'hcoppeard8@phpbb.com');
    insert into employee (id, name, birthday, email) values (10, 'Marco Burchett', '1900-11-07', 'mburchett9@jigsy.com');
    insert into employee (id, name, birthday, email) values (11, 'Frederik Swidenbank', '1977-08-07', null);
    insert into employee (id, name, birthday, email) values (12, 'Sheffie Bolton', null, null);
    insert into employee (id, name, birthday, email) values (13, 'Vanessa Gulston', '1954-05-26', 'vgulstonc@elpais.com');
    insert into employee (id, name, birthday, email) values (14, 'Kirby Peile', '1923-07-26', 'kpeiled@java.com');
    insert into employee (id, name, birthday, email) values (15, 'Car Kabos', '1925-08-06', null);
    insert into employee (id, name, birthday, email) values (16, 'Sven McCurtin', '1910-02-05', 'smccurtinf@de.vu');
    insert into employee (id, name, birthday, email) values (17, 'Colas Rubra', '1903-01-21', 'crubrag@is.gd');
    insert into employee (id, name, birthday, email) values (18, 'Damara Leteurtre', '1941-01-09', 'dleteurtreh@psu.edu');
    insert into employee (id, name, birthday, email) values (19, 'Hillary Dunstall', '1920-11-06', 'hdunstalli@pen.io');
    insert into employee (id, name, birthday, email) values (20, 'Zorina Bilbie', '1932-12-17', 'zbilbiej@eventbrite.com');
    insert into employee (id, name, birthday, email) values (21, 'Crosby McGilroy', '1914-05-17', null);
    insert into employee (id, name, birthday, email) values (22, 'Polly Logan', '1986-05-22', 'ploganl@timesonline.co.uk');
    insert into employee (id, name, birthday, email) values (23, 'Will Rohloff', null, 'wrohloffm@furl.net');
    insert into employee (id, name, birthday, email) values (24, 'Xaviera Pentycost', null, 'xpentycostn@sitemeter.com');
    insert into employee (id, name, birthday, email) values (25, 'Sheff Greig', '1967-11-13', 'sgreigo@ask.com');
    insert into employee (id, name, birthday, email) values (26, 'Barrie Guiness', '1925-08-20', 'bguinessp@weebly.com');
    insert into employee (id, name, birthday, email) values (27, 'Lazare Bathoe', '1911-12-17', 'lbathoeq@jugem.jp');
    insert into employee (id, name, birthday, email) values (28, 'Katinka Alderton', null, 'kaldertonr@seesaa.net');
    insert into employee (id, name, birthday, email) values (29, 'Chaim Elloway', '1947-07-21', 'celloways@state.gov');
    insert into employee (id, name, birthday, email) values (30, 'Krystal Benson', '1919-03-24', 'kbensont@pagesperso-orange.fr');
    insert into employee (id, name, birthday, email) values (31, 'Romonda Beinisch', '1933-04-03', 'rbeinischu@storify.com');
    insert into employee (id, name, birthday, email) values (32, 'Imelda Buff', '1926-08-23', 'ibuffv@cmu.edu');
    insert into employee (id, name, birthday, email) values (33, 'Griffith Grimsdell', null, 'ggrimsdellw@gravatar.com');
    insert into employee (id, name, birthday, email) values (34, 'Burr Buttrey', '1960-08-31', 'bbuttreyx@illinois.edu');
    insert into employee (id, name, birthday, email) values (35, 'Marie Forgan', '1991-12-20', 'mforgany@hibu.com');
    insert into employee (id, name, birthday, email) values (36, 'Barri Christaeas', '1939-09-14', 'bchristaeasz@ustream.tv');
    insert into employee (id, name, birthday, email) values (37, 'Alexine Pieter', '1901-08-15', 'apieter10@sphinn.com');
    insert into employee (id, name, birthday, email) values (38, 'Dolf Burkwood', '1919-11-03', 'dburkwood11@stumbleupon.com');
    insert into employee (id, name, birthday, email) values (39, 'Dierdre Cockshott', '1971-09-09', 'dcockshott12@icio.us');
    insert into employee (id, name, birthday, email) values (40, 'Blondy Aingel', '1987-08-18', 'baingel13@youtube.com');
    insert into employee (id, name, birthday, email) values (41, 'Angele Le Marchant', '1967-06-11', 'ale14@g.co');
    insert into employee (id, name, birthday, email) values (42, 'Ruby Room', '1952-09-07', null);
    insert into employee (id, name, birthday, email) values (43, 'Hadrian Manton', '1938-12-08', 'hmanton16@sphinn.com');
    insert into employee (id, name, birthday, email) values (44, 'Tammie Lochrie', '1991-05-31', 'tlochrie17@techcrunch.com');
    insert into employee (id, name, birthday, email) values (45, 'Connor Fierro', '1969-09-16', null);
    insert into employee (id, name, birthday, email) values (46, 'Perice Dodswell', '1925-03-19', null);
    insert into employee (id, name, birthday, email) values (47, 'Sullivan Coggins', '1922-09-08', 'scoggins1a@vimeo.com');
    insert into employee (id, name, birthday, email) values (48, 'Bastian Nunns', '1933-01-17', 'bnunns1b@trellian.com');
    insert into employee (id, name, birthday, email) values (49, 'Britt Hellicar', '1984-11-22', 'bhellicar1c@google.co.uk');
    insert into employee (id, name, birthday, email) values (50, 'Curran Wines', '1969-08-29', 'cwines1d@spiegel.de');

```

3. 
``` sql
    UPDATE employee SET name = 'Unknown Birth Date' WHERE birthday IS NULL RETURNING *;

    UPDATE employee SET name = 'Unknown Email' WHERE email IS NULL RETURNING *;

    UPDATE employee SET name = 'Unknown Birth Date and Email' WHERE (birthday IS NULL) AND (email IS NULL) RETURNING *;

    UPDATE employee 
    SET name = 'John Doe', 
        birthday = '1900-01-01',
        email = 'john@doe.com'	
    WHERE (birthday IS NULL) AND (email IS NULL) RETURNING *;

    UPDATE employee 
    SET name = 'Old Guy',
        email = 'oldguy@history.com'
    WHERE birthday = (SELECT MIN(birthday) from employee WHERE birthday IS NOT NULL) RETURNING *;

```

4. 
``` sql
    DELETE FROM employee WHERE birthday > '1949-01-01' RETURNING *;

    DELETE FROM employee WHERE id BETWEEN 10 AND 20 RETURNING *;
    
    DELETE FROM employee WHERE name like 'C%' RETURNING *;
    
    DELETE FROM employee WHERE email IS NULL RETURNING *;
    
    DELETE FROM employee WHERE birthday IS NULL RETURNING *;

```