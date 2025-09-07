const express = require('express');
const IndexController = require('../controllers/indexCotroller')

class IndexRoutes {
    constructor(){
        this.router = express.Router();
        this.config()
    }

    config(){
        // endpoints
        // CRUD
        // C -> create -> crear
        // R -> read  -> leer/obtener
        // U -> update -> actualizar los datos
        // D -> delete -> eliminarlos
        // Get -> obtener
        this.router.get('/', IndexController.index)
        // Post -> registrar
        // this.router.post('/', IndexController.index2)
        // Put -> actualizar
        // this.router.put('/', IndexController.index2)
        // delete -> Eliminar
        // this.router.elimina('/', IndexController.index2)

    }
}

const indexRoutes = new IndexRoutes();
module.exports = indexRoutes.router;