using System;
using System.Collections.Generic;
namespace TP06.Models{

public class Pelicula
{
    private int _idPelicula;
    private string _nombre;
    private string _descripcion;
    private datetime _fechaCreacion;
    private int _duracion;
    private int _cantPeliculas;
    private string _imagen1;
    private string _imagen2;
 
    public Pelicula(int idPelicula,string nombre, string descripcion, datetime fechaCreacion, int duracion, int cantPeliculas,string imagen1, string imagen2)
        {
           _idPelicula= idPelicula;
           _nombre= nombre;
           _descripcion=descripcion
           _fechaCreacion= fechaCreacion;
           _duracion= duracion;
           _cantPeliculas= cantPeliculas;
           _imagen1= imagen1;
           _imagen2= imagen2;


        }
    
    public int  IdPelicula
    {
        get
        {
            return  _idPelicula;
        }
        set{
             _idPelicula = value;
        }

    }

    public string Nombre
    {
        get
        {
            return _nombre;
        }
        set{
            _nombre = value;
        }
    }
    public string Descripcion
    {
        get
        {
            return _descripcion;
        }
        set{
            _descripcion = value;
        }
    }
     public datetime FechaCreacion
    {
        get
        {
            return _fechaCreacion;
        }
        set{
            _fechaCreacion = value;
        }
    }
    public int Duracion
    {
        get
        {
            return _duracion;
        }
        set{
            _duracion = value;
        }
    }
     public int CantPeliculas
    {
        get
        {
            return _cantPeliculas;
        }
        set{
            _cantPeliculas = value;
        }

    }
    public string Imagen1
    {
        get
        {
            return _imagen1;
        }
        set{
            _imagen1 = value;
        }
    }
    public string Imagen2
    {
        get
        {
            return _imagen2;
        }
        set{
            _imagen2 = value;
        }
    }


    

}
}