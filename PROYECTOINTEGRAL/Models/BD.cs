using System;
using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;

namespace PROYECTOINTEGRAL.Models{
    public class BD {
        
     private static string _connectionString = 
        @"Server=A-PHZ2-CIDI-036;
        DataBase=DISNEY;Trusted_Connection=True;";

//a. ObtenerPersonajes(): Devuelve una lista con todos los personajes
    public static List<Personaje> ObtenerPersonajes(){
        List<Personaje>  lista = new List<Personaje> ();
        string sql = "SELECT * FROM  Personaje";
        using(SqlConnection db = new SqlConnection(_connectionString)){
                lista = db.Query<Personaje>(sql).ToList();
            }
        return lista;
    }

//b. ObtenerPeliculas(): Devuelve una lista con todas las peliculas
    public static List<Pelicula> ObtenerPeliculas(){
        List<Pelicula>  lista = new  List<Pelicula>  ();
        string sql = "SELECT * FROM  Pelicula";
        using(SqlConnection db = new SqlConnection(_connectionString)){
                lista = db.Query<Pelicula>(sql).ToList();
            }
        return lista;
    }

//c. ObtenerSerie(): Devuelve una lista con todas las series
    public static List<Serie> ObtenerSeries(){
        List<Serie>  lista = new  List<Serie>  ();
        string sql = "SELECT * FROM  Serie";
        using(SqlConnection db = new SqlConnection(_connectionString)){
                lista = db.Query<Serie>(sql).ToList();
            }
        return lista;
    }


//d. ObtenerUnPersonaje(): Devuelve un personaje
public static Personaje ObtenerUnPersonaje(int idPersonaje)
{
        Personaje UnPersonaje= null; 
         
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Personaje WHERE IdPersonaje = @pIdPersonaje";
                UnPersonaje=db.QueryFirstOrDefault<Personaje>(sql, new {pIdPersonaje=idPersonaje}); 
            }
            return UnPersonaje;
}

//e. ObtenerUnaPelicula(): Devuelve una pelicula
public static Pelicula ObtenerUnaPelicula(int idPelicula)
{
        Pelicula UnaPelicula= null; 
         
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Pelicula WHERE IdPelicula = @IdPelicula";
                UnaPelicula=db.QueryFirstOrDefault<Pelicula>(sql, new {pIdPelicula=idPelicula}); 
            }
            return UnaPelicula;
}

//f. ObtenerUnaSerie(): Devuelve una serie
public static Serie ObtenerUnaSerie(int idSerie)
{
        Serie UnaSerie= null; 
         
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Serie WHERE IdSerie = @IdSerie";
                UnaSerie=db.QueryFirstOrDefault<Serie>(sql, new {pIdSerie=idSerie}); 
            }
            return UnaSerie;
}

//g. AgregarPersonaje(): Agrega un personaje a la base de datos
public static void AgregarPersonaje(Personaje Perso){
        string sql = "INSERT INTO Personaje(nombre,descripcion,vestimenta,imagen1, imagen2,idPelicula,idSerie) VALUES (@pNombre,@pDescripcion,@pVestimenta,@pImagen1,@pImagen2,@pIdPelicula,@pIdSerie) ";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            db.Execute(sql, new { pNombre= Perso.Nombre, pDescripcion=Perso.Descripcion, pVestimenta=Perso.Vestimenta, pImagen1=Perso.Imagen1, pImagen2=Perso.Imagen2, pIdPelicula=Perso.IdPelicula, pIdSerie=Perso.IdSerie });
        }
    }

//h. EliminarPersonaje(): Elimina un personaje a la base de datos
     public static void EliminarPersonaje(int id){
        string sql = "DELETE FROM Personaje WHERE IdPersonaje = @pId";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            db.Execute(sql, new { pId = id });
        }
        
    }


    }
}
