## Ödev 12

Aşağıdaki sorgu senaryolarını [dvdrental](https://www.postgresqltutorial.com/wp-content/uploads/2019/05/dvdrental.zip) örnek veri tabanı üzerinden gerçekleştiriniz.

1. **film** tablosunda film uzunluğu **length** sütununda gösterilmektedir. Uzunluğu ortalama film uzunluğundan fazla kaç tane film vardır?
2. **film** tablosunda en yüksek **rental_rate** değerine sahip kaç tane film vardır?
3. **film** tablosunda *en düşük* **rental_rate** ve en *düşük* **replacement_cost** değerlerine sahip filmleri sıralayınız.
4. **payment** tablosunda en fazla sayıda alışveriş yapan müşterileri(customer) sıralayınız.

## Çözüm

1. 
``` sql

SELECT COUNT(*) FROM film
WHERE length > (SELECT AVG(length) FROM film);

```

2. 
``` sql

SELECT COUNT(*) FROM film
WHERE rental_rate = (SELECT MAX(rental_rate) FROM film);

```

3. 
``` sql

SELECT * FROM film
WHERE rental_rate = (SELECT MIN(rental_rate) FROM film)
	AND 
	replacement_cost = (SELECT MIN(replacement_cost) FROM film);

```

4. 
``` sql

SELECT SUM(amount), customer.first_name, customer.last_name
FROM payment
JOIN customer on customer.customer_id = payment.customer_id
GROUP BY payment.customer_id, customer.first_name, customer.last_name
ORDER BY SUM(amount) DESC;

```