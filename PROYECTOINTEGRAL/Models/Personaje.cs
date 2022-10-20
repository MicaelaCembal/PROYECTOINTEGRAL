using System;
using System.Collections.Generic;
namespace PROYECTOINTEGRAL.Models{

public class Personaje
{
    private int _idPersonaje;
    private string _nombre;
    private string _descripcion;
    private string _vestimenta;
    private string _imagen1;
    private string _imagen2;
    private int _idPelicula;
    private int _idSerie;
   
    public Personaje(int idPersonaje, string nombre,string descripcion,string vestimenta,string imagen1, string imagen2,int idPelicula,int idSerie)
        {
           _idPersonaje= idPersonaje;
           _nombre=nombre;
           _descripcion=descripcion;
           _vestimenta=vestimenta;
           _imagen1=imagen1;
           _imagen2=imagen2;
           _idPelicula=idPelicula;
           _idSerie=idSerie;
           _personajes=personajes;
           
        }
        
    public int IdPersonaje
    {
        get
        {
            return _idPersonaje;
        }
        set{
            _idPersonaje = value;
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
    public string Vestimenta
    {
        get
        {
            return _vestimenta;
        }
        set{
            _vestimenta = value;
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
     public int IdPelicula
    {
        get
        {
            return _idPelicula;
        }
        set{
            _idPelicula = value;
        }

    }

     public string IdSerie
    {
        get
        {
            return _idSerie;
        }
        set{
            _idSerie = value;
        }
    }

  
}
}