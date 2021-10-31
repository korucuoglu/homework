# SQL Ödev 8

1- test veritabanınızda employee isimli sütun bilgileri id(INTEGER), name VARCHAR(50), birthday DATE, email VARCHAR(100) olan bir tablo oluşturalım.

```bash
create table employee  ( id serial primary key,  name VARCHAR(50),  email VARCHAR(50), date DATE );
```

2- Sütunların her birine göre diğer sütunları güncelleyecek 5 adet UPDATE işlemi yapalım.

```bash
update employee  set name = 'Halit' where id = 50;
```

3- Sütunların her birine göre ilgili satırı silecek 5 adet DELETE işlemi yapalım.

```bash
delete from employee  where id = 10
```
