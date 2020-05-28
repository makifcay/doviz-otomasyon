var request = require('request');
var cheerio = require('cheerio');
var express = require('express');
var fs = require('fs');


var app = express();

module.exports = function(){
    fs.unlink('./API/kur.json', (err) => {
        if (err) throw err;
        console.log('successfully clear list');
      });
    
    
    //app.use(bodyParser.urlencoded({extended: true}));
    //app.use(bodyParser.json());
    
    
    request('https://api.exchangeratesapi.io/latest?base=TRY', (err, res, html) =>{
        if (!err){
            const $ = cheerio.load(html);
    
            const kurlist = $('body');
    
            var kur = (kurlist.text());
    
            
    
            fs.appendFileSync('./API/kur.json', `${kur}\r\n`, function(err) {
                if(err) {
                  return console.log(err);
                };
            });
            /*
            
            let data = JSON.stringify(kur, null, 4);
            fs.writeFile('./API/kur.json', data, {encoding : 'utf8'}, function(e){});
    
            */
    
            app.get('/api/deneme', function(request, response){
                response.send(json);
            });
            
            console.log("successfully generated list");
        }
    });
}


