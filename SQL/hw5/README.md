## Ödev 5

Aşağıdaki sorgu senaryolarını [dvdrental](https://www.postgresqltutorial.com/wp-content/uploads/2019/05/dvdrental.zip) örnek veri tabanı üzerinden gerçekleştiriniz.

1. **film** tablosunda bulunan ve film ismi (title) 'n' karakteri ile biten en uzun (length) 5 filmi sıralayınız.
2. **film** tablosunda bulunan ve film ismi (title) 'n' karakteri ile biten en kısa (length) ikinci 5 filmi sıralayınız.
3. **customer** tablosunda bulunan last_name sütununa göre azalan yapılan sıralamada store_id 1 olmak koşuluyla ilk 4 veriyi sıralayınız.

## Çözüm

1. 
``` sql
    SELECT * FROM film WHERE title LIKE '%n' ORDER BY length DESC limit 5;

```

2. 
``` sql
    SELECT * FROM film WHERE title LIKE '%n' ORDER BY length ASC  OFFSET 5 LIMIT 5;

```

3. 
``` sql
    SELECT * FROM customer WHERE store_id = 1 ORDER BY last_name DESC LIMIT 4;

```