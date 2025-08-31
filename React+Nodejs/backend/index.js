// PAQUETES
const express = require('express');
const morgan = require('morgan');
const cors = require('cors');
require('dotenv').config();

// RUTAS
const indexRouter = require('./routes/indexRouter')

// SERVIDOR
class Server {

  constructor() {
    this.app = express(); // inicializar el servidor
    // Conexión a base de datos
    this.config();
    this.middlewares();
    // this.routes();
  }

  config() {
    this.app.set('port', process.env.API_PORT || 7000);
  }

  middlewares(){
    this.app.use(express.json);      // para que todas las respuestas las entregue como json
    this.app.use(morgan('combied')); // default
    this.app.use(cors);
  }

  routes(){
    // http://localhost:8000/
    this.app.use('/', indexRouter)
    this.app.use('/login', indexRouter)
  }

  start(){
    this.app.listen(this.app.get('port'), '0.0.0.0', ()=>{
      console.log('Server is running on port:', this.app.get('port'))
    })
  }

}

const server = new Server();
server.start();