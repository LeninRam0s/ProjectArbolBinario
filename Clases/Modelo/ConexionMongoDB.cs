using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;

namespace ProjectArbolBinario.Clases.Modelo
{
    class ConexionMongoDB
    {
        public static void conexionDB()
        {
            //CONEXION
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("dataArbol");
            var coleccionDB = database.GetCollection<ModelData>("arbolDB");

            //INSERTAR DATOS
            //var insertData = new ModelData() {Id = idDB, animal = "Gato", gesto = "miauuu" };//para actualizar y borrar
            //var insertData = new ModelData() {animal = "Perro", gesto = "guau"};
            //coleccionDB.InsertOne(insertData);
            //FIN INSERTA DATOS

            //OBTENER DATOS
            //List<ModelData> list = coleccionDB.Find(d => true).ToList();
            //FIN CONSULTA

            //UPDATE
            //coleccionDB.ReplaceOne(d => d.Id == idDB, insertData);
            //FIN ACTUALIZACION

            //ELIMINAR
            //coleccionDB.DeleteOne(d => d.Id == idDB);
            //FIN DELET

        }

        public static void insertarDatos(string animalIn, string gestoIn)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("dataArbol");
            var coleccionDB = database.GetCollection<ModelData>("arbolDB");

            //INSERTAR DATOS
            var insertData = new ModelData() { animal = animalIn, gesto = gestoIn };
            // List<ModelData> list = (List<ModelData>)coleccionDB.Find(d => d.animal != animalIn);          
            coleccionDB.InsertOne(insertData);
            //while (animalIn != insertData.animal)
            //{
                
            //}
            //Console.WriteLine("El animalito ya esta registrado en la BD");
        }

        public static void consultarDatos(String animalAct, string animalIn, string gestoIn)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("dataArbol");
            var coleccionDB = database.GetCollection<ModelData>("arbolDB");

            //INSERTAR DATOS
            var insertData = new ModelData() { animal = animalIn, gesto = gestoIn };
            coleccionDB.ReplaceOne(d => d.animal != animalAct, insertData);
        }

    }
}
        