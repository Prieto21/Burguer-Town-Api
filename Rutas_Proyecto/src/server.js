const express = require('express');
const app = express();

app.set('port', process.env.PORT||3000);

app.use(express.json());

app.use('/api/yuju',require('./routes/taller'));

app.listen(app.get('port'), () => {
    console.log('vamos a emular', app.get('port'));
});