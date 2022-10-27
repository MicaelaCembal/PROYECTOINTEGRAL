
function TraeInfoPeli(id)
{
    $.ajax({
        url: '/peliculas/TraeInfoPeli',
        type: 'get',
        dataType: 'json',
        data: "idPelicula="+id,
        success:  MuestraPelicula
        });
}

function MuestraPelicula(pelicula)
    {
        console.log(pelicula);
        $('#info').show();
        $('#nombre').html( pelicula.nombre);    
        $('#nombre').html( pelicula.nombre);      
        
    }

    function TraeInfoSerie(id)
{
    $.ajax({
        url: '/series/TraeInfoSerie',
        type: 'get',
        dataType: 'json',
        data: "idSerie="+id,
        success:  MuestraSerie
        });
}

function MuestraSerie(serie)
    {
        console.log(serie);
        $('#info').show();
        $('#nombre').html( serie.nombre);       
        
    }
