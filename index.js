const  express = require('express');
const  app = express();
var bodyParser = require('body-parser')

const  port = 8888;
app.use(bodyParser.urlencoded({extend :false}))
app.set('view engine', 'ejs');
app.post('/loginform', function (req, res) {
    res.send('hello /'+ req.body.name + req.body.password);
    res.render('')
});
app.get('/loginform',(req, res) => {
    res.send('hello /'+ req.body.name + req.body.password);
});


app.listen(port , () => {
    console.log(` node js ${port}`)
})