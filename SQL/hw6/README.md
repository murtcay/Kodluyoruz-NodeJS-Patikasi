## Ödev 6

Aşağıdaki sorgu senaryolarını [dvdrental](https://www.postgresqltutorial.com/wp-content/uploads/2019/05/dvdrental.zip) örnek veri tabanı üzerinden gerçekleştiriniz.

1. **film** tablosunda bulunan **rental_rate** sütunundaki değerlerin ortalaması nedir?
2. **film** tablosunda bulunan filmlerden kaçtanesi 'C' karekteri ile başlar?
3. **film** tablosunda bulunan filmlerden rental_rate değeri 0.99 a eşit olan en uzun (length) film kaç dakikadır?
4. **film** tablosunda bulunan filmlerin uzunluğu 150 dakikadan büyük olanlarına ait kaç farklı replacement_cost değeri vardır?

## Çözüm

1. 
``` sql
    SELECT AVG(rental_rate) FROM film;

```

2. 
``` sql
    SELECT COUNT(*) FROM film WHERE title LIKE 'C%';

```

3. 
``` sql
    SELECT MAX(length) FROM film WHERE rental_rate = 0.99;

```

4. 
``` sql
    SELECT COUNT(DISTINCT replacement_cost) FROM film WHERE length > 150;

```
