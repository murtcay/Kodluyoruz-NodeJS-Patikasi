## Ödev 11

Aşağıdaki sorgu senaryolarını [dvdrental](https://www.postgresqltutorial.com/wp-content/uploads/2019/05/dvdrental.zip) örnek veri tabanı üzerinden gerçekleştiriniz.

1. **actor** ve **customer** tablolarında bulunan **first_name** sütunları için tüm verileri sıralayalım.
2. **actor** ve **customer** tablolarında bulunan **first_name** sütunları için kesişen verileri sıralayalım.
3. **actor** ve **customer** tablolarında bulunan **first_name** sütunları için ilk tabloda bulunan ancak ikinci tabloda bulunmayan verileri sıralayalım.
4. İlk 3 sorguyu tekrar eden veriler için de yapalım.

## Çözüm

1. 
``` sql

(SELECT first_name FROM actor)
UNION
(FROM first_name FROM customer);

```

2. 
``` sql

(SELECT first_name FROM actor)
INTERSECT
(FROM first_name FROM customer);

```

3. 
``` sql

(SELECT first_name FROM actor)
EXCEPT
(FROM first_name FROM customer);

```

4. 
``` sql

-- For Qustion 1: (UNION ALL)

(SELECT first_name FROM actor)
UNION ALL
(FROM first_name FROM customer);

-- For Question2: (INTERSECT ALL)

(SELECT first_name FROM actor)
INTERSECT ALL
(FROM first_name FROM customer);

-- For Question 3: (EXCEPT ALL)

(SELECT first_name FROM actor)
EXCEPT ALL
(FROM first_name FROM customer);


```