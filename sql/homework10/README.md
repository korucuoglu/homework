# SQL Ödev 10

1- city tablosu ile country tablosunda bulunan şehir (city) ve ülke (country) isimlerini birlikte görebileceğimiz LEFT JOIN sorgusunu yazınız.

```bash
select country, city from country left join city on country.country_id = city.country_id;
```

2- customer tablosu ile payment tablosunda bulunan payment_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz RIGHT JOIN sorgusunu yazınız.

```bash
select payment_id, first_name, last_name from customer right join payment on payment.customer_id = customer.customer_id ;
```

3- customer tablosu ile rental tablosunda bulunan rental_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz FULL JOIN sorgusunu yazınız.

```bash
select rental_id, first_name, last_name from customer full join rental on rental.rental_id = customer.customer_id;
```
