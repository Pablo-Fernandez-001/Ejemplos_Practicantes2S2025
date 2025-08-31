
class IndexController{

    index(req, res){
        res.send("Hola")
    }

    /*index2(req, res){
        console.log("Hola")
    }*/

}

module.exports = new IndexController