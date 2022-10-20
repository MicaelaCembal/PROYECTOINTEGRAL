// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function TraeInfoPeli(id)
{
    $.ajax({
        url: '/peliculas/traeinfo',
        type: 'get',
        dataType: 'json',
        data: "id="+id,
        success:  MuestraPelicula
        });
}

function MuestraPelicula(pelicula)
    {
        $('#nombrepelicula').html( pelicula.nombre);       
        
    }
