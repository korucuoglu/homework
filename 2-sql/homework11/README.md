# SQL Ödev 11

1- actor ve customer tablolarında bulunan first_name sütunları için tüm verileri sıralayalım.

```bash
(select first_name from actor) union all (select first_name from customer);
```

2- actor ve customer tablolarında bulunan first_name sütunları için kesişen verileri sıralayalım.

```bash
(select first_name from actor) intersect all (select first_name from customer);
```

3- actor ve customer tablolarında bulunan first_name sütunları için ilk tabloda bulunan ancak ikinci tabloda bulunmayan verileri sıralayalım.

```bash
(select first_name from actor) except all (select first_name from customer);
```
