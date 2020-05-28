var kur = require('./kur');
var sql = require('./sql');

kur();

setTimeout(() => {
    sql();
}, 3000);

function intervalFunc() {

    
    setTimeout(() => {
        kur();
    }, 1000);
    
    setTimeout(() => {
        sql();
    }, 3000);
    console.log('Güncelleme Başarılı');
  
  }
  
  setInterval(intervalFunc, 60000);
