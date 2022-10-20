using System;
using System.Collections.Generic;
namespace PROYECTOINTEGRAL.Models{

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
 
    public Pelicula(int idPelicula,string nombre, string descripcion, datetime fechaCreacion, int _duracion, int _cantPeliculas,string _imagen1, string _imagen2)
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
     public string Camiseta
    {
        get
        {
            return _camiseta;
        }
        set{
            _camiseta = value;
        }
    }
    public string Continente
    {
        get
        {
            return _continente;
        }
        set{
            _continente = value;
        }
    }
     public int CopasGanadas
    {
        get
        {
            return _copasGanadas;
        }
        set{
            _copasGanadas = value;
        }

    }


    

}
}