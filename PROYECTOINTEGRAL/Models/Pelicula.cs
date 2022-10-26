using System;
using System.Collections.Generic;
namespace PROYECTOINTEGRAL.Models{

public class Pelicula
{
    private int _idPelicula;
    private string _nombre;
    private string _descripcion;
    private DateTime _fechaCreacion;
    private int _duracion;
    private int _cantPeliculas;
    private string _imagen1;
    private string _imagen2;
 
    public Pelicula(int IdPelicula,string Nombre, string Descripcion, DateTime FechaCreacion, int Duracion, int CantPeliculas,string Imagen1, string Imagen2)
    
        {
           _idPelicula= IdPelicula;
           _nombre= Nombre;
           _descripcion=Descripcion;
           _fechaCreacion= FechaCreacion;
           _duracion= Duracion;
           _cantPeliculas= CantPeliculas;
           _imagen1= Imagen1;
           _imagen2= Imagen2;


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
     public DateTime FechaCreacion
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