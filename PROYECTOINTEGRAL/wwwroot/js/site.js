function TraeInfoPeli(id)
{
    $.ajax({
        url: '/peliculas/TraeInfoPeli',
        type: 'get',
        dataType: 'json',
        data: "idPelicula="+id,
        success:  MuestraPelicula
        });

        $.ajax({
            url: '/peliculas/TraePersonajesPeli',
            type: 'get',
            dataType: 'json',
            data: "idPelicula="+id,
            success:  MuestraPersonajesPelicula
            });
}

function MuestraPelicula(pelicula)
    {
        agregarPersonajesNuevos="";
        console.log(pelicula);
        $('#infopelicula').show();
        $('#infoserie').hide();

        $('#MostrarDescripcionPeli').show();
        $('#MostrarCantPeliculas').show();
        $('#MostrarFechaCreacionPeli').show();
        $('#nombrep').html( pelicula.nombre);    
        $('#descripcionp').html( pelicula.descripcion); 
        $('#fechaCreacionp').html( pelicula.fechaCreacion); 
        $('#duracionp').html( pelicula.duracion); 
        $('#cantPeliculasp').html( pelicula.cantPeliculas);    
        $('#imagen1p').attr('src','/' +pelicula.imagen1);    
        $('#imagen2p').attr('src','/' +pelicula.imagen2);    
        
    }

    var mostroDescsPeli = 0;
    var mostroCantPelis = 0;
    var mostroFechaCreacionsPeli = 0;
    
    function MostrarInfoDescp(){
    
        
        if(mostroDescsPeli == 0){
            mostroDescsPeli = 1;
            $('#descripcionp').show();  
           
        }else{
            mostroDescsPeli = 0;
            $('#descripcionp').hide();  
        }
    }
    function MostrarInfoCantPelis(){
        if(mostroCantPelis == 0){
            mostroCantPelis = 1;
            $('#cantPeliculasp').show();  
          
        }
        else{
            mostroCantPelis = 0;
            $('#cantPeliculasp').hide();   
    }
    }
    function MostrarInfoFechaCreacionsPeli(){
        if(mostroFechaCreacionsPeli == 0){
            mostroFechaCreacionsPeli = 1;
            $('#fechaCreacionp').show(); 
            
            
        }
        else{
            mostroFechaCreacionsPeli = 0; 
            $('#fechaCreacionp').hide(); 
    }
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

    $.ajax({
        url: '/series/TraePersonajesSerie',
        type: 'get',
        dataType: 'json',
        data: "idSerie="+id,
        success:  MuestraPersonajesSerie
        });
}


function MuestraPersonajesSerie(personajesSerie)
{
    textopersonajes= "";
    
    personajesSerie.forEach(perso => {
        console.log(perso);

        textopersonajes= textopersonajes + "<div class='col-md-3 col-6 img-circle-container'>"
        
        vermas="/Home/UnPersonaje?idPersonaje="+perso.idPersonaje;
        textopersonajes= textopersonajes + " <a href="+vermas+" ><img class='img-circle' style='left:20px' src='/" + perso.imagen1  + "' /> </a>"; 
       // textopersonajes= textopersonajes + "<b>" + perso.nombre  + "</b>"; 
        textopersonajes= textopersonajes +"</a>";
        textopersonajes= textopersonajes + "</div>"
        
        
    });
    //aca recorrer el foreach y armar el html y guardarlo en textopersonajes
    
    $('#personajesSerie').html(textopersonajes); 
    


                    
}

function MuestraPersonajesPelicula(personajesPelicula)
{
    textopersonajes= "";
    
    personajesPelicula.forEach(perso => {
        console.log(perso);

        textopersonajes= textopersonajes + "<div class='col-md-3 col-6 img-circle-container'>"
        
        vermas="/Home/UnPersonaje?idPersonaje="+perso.idPersonaje;
        textopersonajes= textopersonajes + " <a href="+vermas+" ><img class='img-circle' style='left:20px' src='/" + perso.imagen1  + "' /> </a>"; 
       // textopersonajes= textopersonajes + "<b>" + perso.nombre  + "</b>"; 
        textopersonajes= textopersonajes +"</a>";
        textopersonajes= textopersonajes + "</div>"
        
        
    });
    //aca recorrer el foreach y armar el html y guardarlo en textopersonajes
    
    $('#personajesPelicula').html(textopersonajes); 
    


                    
}
function MuestraSerie(serie)
    {
        agregarPersonajesNuevos="";
        console.log(serie);
        $('#infopelicula').hide();
        $('#infoserie').show();

        $('#MostrarDescripcion').show();
        $('#MostrarCantCapitulos').show();
        $('#MostrarFechaCreacion').show();
        $('#nombres').html( serie.nombre);  
        $('#descripcions').html(serie.descripcion);  
        $('#cantCapituloss').html(serie.cantCapitulos);
        $('#idSeries').html(serie.idSerie);
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

