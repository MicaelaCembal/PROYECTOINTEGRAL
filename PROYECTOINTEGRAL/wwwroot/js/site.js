

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
        $('#infopelicula').show();
        $('#infoserie').hide();
        $('#nombrep').html( pelicula.nombre);    
        $('#descripcionp').html( pelicula.descripcion); 
        $('#fechaCreacionp').html( pelicula.fechaCreacion); 
        $('#duracionp').html( pelicula.duracion); 
        $('#cantPeliculasp').html( pelicula.cantPeliculas);    
        $('#imagen1p').attr('src','/' +pelicula.imagen1);    
        $('#imagen2p').attr('src','/' +pelicula.imagen2);    
        
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
        $('#infopelicula').hide();
        $('#infoserie').show();
        $('#MostrarDescripcion').show();
        $('#MostrarCantCapitulos').show();
        $('#MostrarFechaCreacion').show();
        $('#nombres').html( serie.nombre);  
        $('#descripcions').html(serie.descripcion);  
        $('#cantCapituloss').html(serie.cantCapitulos);   
        $('#fechaCreacions').html(serie.fechaCreacion);              
        $('#imagen1s').attr('src','/' +serie.imagen1);    
        $('#imagen2s').attr('src','/' +serie.imagen2);    
        
    
    }

var mostroDescs = 0;
var mostroCapituloss = 0;
var mostroFechaCreacions = 0;

function MostrarInfoDescs(){

    
    if(mostroDescs == 0){
        mostroDescs = 1;
        $('#descripcions').show();  
       
    }else{
        mostroDescs = 0;
        $('#descripcions').hide();  
    }
}
function MostrarInfoCantCapis(){
    if(mostroCapituloss == 0){
        mostroCapituloss = 1;
        $('#cantCapituloss').show();  
      
    }
    else{
        mostroCapituloss = 0;
        $('#cantCapituloss').hide();   
}
}
function MostrarInfoFechaCreacions(){
    if(mostroFechaCreacions == 0){
        mostroFechaCreacions = 1;
        $('#fechaCreacions').show(); 
        
        
    }
    else{
        mostroFechaCreacions = 0; 
        $('#fechaCreacions').hide(); 
}
}

