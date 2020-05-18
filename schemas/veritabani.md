# Veritabanı gereksinimleri

dovizdb.drawio'yu kontrol et.

### Personel

- personel_id, PK
- yetki_id , FK
- ad
- soyad
- kullanici_adi , not null

### Yetki 
- yetki_id , PK
- yetki_adi

<pre>
yonetici
kasiyer
</pre>

### Doviz 
- doviz_id, PK
- doviz_adi
- doviz_tam_adi
- doviz_logo

<pre>
örnek:
(doviz_id, doviz_adi, doviz_tam_adi, doviz_logo)
1, TRY, Türk Lirası, ₺
2, USD, Amerikan Doları, $
3, EUR, , €
4, GBP, , £
5, KRW, , ₩
6, CHF, , ₣
7, RUB, , ₽
8, JPY, , ¥
</pre>

### Değer
- doviz_id, PK, FK
- alis_fiyat, NOT NULL
- makas (0-100 arası), DECIMAL, NOT NULL
- satis_fiyat (alis_fiyati + alis_fiyati*makas)


### Kasa
- doviz_id PK, FK 
- doviz_miktar (decimal)

<pre>
(1 (TRY), 2345)
</pre>

### Alışveriş
- a_id, PK, AUTO_INCREMENT
- tarih, DATE NOW, NOT NULL
(tarih ve saat, işlem anındaki, veritabanını Türkiye saatine göre ayarla)
- islem_id, FK
- doviz_id, FK
- personel_id, FK
- miktar

<pre>
örn:

Alışveriş nu: 21
19.05.2020 15:43:22
1 (ALIŞ)
3 (Euro)
(Ahmet) (Personel)
3453,5654
</pre>

### Alış / Satış
- islem_id, PK
- islem_adi