# Veritabanı gereksinimleri

### Personel

- Personel nu. (PK)
- Ad
- Soyad
- Yetki  

### Muhasebe

- İşlem nu.
- İşlem tarihi (Datetime.now)
- İşlem türü (ALIŞ-SATIŞ)
- Miktar
- Döviz türü (fk)
- Döviz (alış/satış) değeri 
(Eğer işlem alışsa alış, satışsa satış bilgisi)
- Personel nu. (fk)

### Günsonu

- Tarih (PK) (DATETIME)
- Toplam alış
- Toplam satış
- Kar

### Kasa
- Döviz türü (EUR, TRY, USD...) (pk)
- Kasadaki miktar
(eğer kasada yeterli döviz yoksa işlem yapılamaz)

### Döviz
- Döviz türü (EUR, TRY, USD...) (pk)
- TL alış 
- TL satış
- Kar payı (makas)

<pre>
ör.
10
% 3 kar payı (makas)
</pre>

### Banka Kurları

- Banka (PK)
- Banka adı (tam ad)
- Alis
- Satis 