using System;
using System.Collections.Generic;
namespace PROYECTOINTEGRAL.Models{

public class Pelicula
{
    private int _idSerie;
    private string _nombre;
    private string _descripcion;
    private datetime _fechaCreacion;
    private int _cantCapitulos;
    private string _imagen1;
    private string _imagen2;
 
    public Pelicula(int idSerie,string nombre, string descripcion, datetime fechaCreacion, int cantCapitulos,string imagen1, string imagen2)
        {
           _idSerie= idSerie;
           _nombre= nombre;
           _descripcion=descripcion;
           _fechaCreacion= fechaCreacion;
           _cantCapitulos= cantCapitulos;
           _imagen1= imagen1;
           _imagen2= imagen2;


        }
    
    public int  IdSerie
    {
        get
        {
            return  _idSerie;
        }
        set{
             _idSerie = value;
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
    public int CantCapitulos
    {
        get
        {
            return _cantcapitulos;
        }
        set{
            _cantcapitulos = value;
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