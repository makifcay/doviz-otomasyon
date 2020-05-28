const mysql = require('mysql');
var fs = require('fs');

module.exports = function(){
    var mysqlConnection = mysql.createConnection({
        host: '127.0.0.1',
        port: '3306',
        user: 'root',
        password: '12345',
        database: 'dovizotomasyon'
    });
    
    mysqlConnection.connect((err) => {
        if(!err)
        {
            console.log('DB Connected');
        }
        else
        {
            console.log('DB Connection failed \n Error:' + JSON.stringify(err,undefined,2));   
        }
    });
    
    fs.readFile('./API/kur.json', (err, data) => {
        const kur_deger = JSON.parse(data);
        
        var isimler = ['Amerikan Doları','Euro','Birleşik Krallık Sterlini','İsviçre Frangı','Rus Rublesi','Güney Kore Wonu','Japon Yeni']
        var kurkisalt = ['USD','EUR','GBP','CHF','RUB','KRW','JPY'];
        var kurlar = [kur_deger.rates.USD,kur_deger.rates.EUR,kur_deger.rates.GBP,kur_deger.rates.CHF,kur_deger.rates.RUB,kur_deger.rates.KRW,kur_deger.rates.JPY];
        var logo = ['$','€','£','₣','₽','₩','¥']
    
        //var kurlenght = kurlar.length;
    
        kurlar.forEach(function calback(item,index){
    
    
            //Database de doviz tablosunu kontrol eder 0 değerine sahipse tabloya değer ekler
            let postdoviz = {doviz_id:parseInt([index+1]), doviz_adi:kurkisalt[index],  doviz_tam_adi:isimler[index], doviz_logo:logo[index]};
            let sqldoviz = 'INSERT INTO doviz SET ?'; // ? 
            let querydoviz = mysqlConnection.query(sqldoviz,postdoviz, (err, result) => {
                if(err){
                    console.log('zaten bu değer ekli');
                };
                console.log('Doviz Datasi Eklendi');
            });
    
            //Doviz kuru degerlerini isim sıralaması ile eşit olarak database yoklaması yapıp eğer tablo 0 değerine sahipse tablo ya değer atar değilse günceller
    
            let postdeger = {satis_fiyat:kurlar[index], alis_fiyat:((kurlar[index])-(kurlar[index])*(3/100))}
            let sqldeger = 'INSERT INTO deger SET ?';
            let querydeger = mysqlConnection.query(sqldeger,postdeger, (err, result) => {
                if(err){
                    let postdeger = {satis_fiyat:kurlar[index], alis_fiyat:((kurlar[index])-(kurlar[index])*(3/100))}
                    let sqldeger = 'UPDATE deger SET ? WHERE doviz_id = '+parseInt([index+1])+'';;
                    let querydeger = mysqlConnection.query(sqldeger,postdeger, (err, result) => {
                        if(err) throw err;
                        console.log('Deger Datasi Guncellendi');
                    });
                };
                console.log('Deger Datasi Eklendi');
            });
    
        });
    });
}