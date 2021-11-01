# SQL Ödev 9

1- city tablosu ile country tablosunda bulunan şehir (city) ve ülke (country) isimlerini birlikte görebileceğimiz INNER JOIN sorgusunu yazınız.

```bash
select city, country from city inner join country on country.country_id = city.country_id;
```

2- customer tablosu ile payment tablosunda bulunan payment_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz INNER JOIN sorgusunu yazınız.

```bash
select payment_id, first_name, last_name from customer inner join payment on payment.customer_id = customer.customer_id;
```

3- customer tablosu ile rental tablosunda bulunan rental_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz INNER JOIN sorgusunu yazınız.

```bash
select rental_id, first_name, last_name from customer inner join rental on customer.customer_id = rental.customer_id;
```
