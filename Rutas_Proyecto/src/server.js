const express = require('express');
const app = express();

app.set('port', process.env.PORT||3000);

app.use(express.json());

app.use('/api/burguer',require('./routes/burguer_town'));

app.listen(app.get('port'), () => {
    console.log('Burguer Town Servidor Activado', app.get('port'));
});