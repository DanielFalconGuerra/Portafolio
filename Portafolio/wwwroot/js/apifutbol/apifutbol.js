let jsonDisplay = document.getElementById('jsonDisplay');

$(document).ready(function () {
    $(".url-cell").click(function () {
        var url = $(this).text();
        let pathname = new URL(url).pathname;
        //var input = $(this).next().find('input').val();
        let img;
        let respuesta = document.getElementById('respuesta');
        respuesta.innerText = ' ' + url;
        switch (pathname) {
            case "/players/GetPlayers":
                removeIMG();
                showJSON(jsonDisplay, exampleResponseGetPlayers);
                break;
            case "/players/GetPlayersFromDB":
                removeIMG();
                showJSON(jsonDisplay, exampleResponseGetPlayersFromDB);
                break;
            case "/players/GetImage":
                /*if (input) {
                    
                }*/
                respuesta.innerText += "/?nombre_imagen=gol.sergio.ramos.jpg";
                showImage(jsonDisplay, api_futbol_player_image);
                break;
            default:
                break;
        }
    });
});

function removeIMG() {
    //Si hay un img eliminarlo
    let img = document.querySelector('img');
    if (img) {
        img.remove();
    }
}

function showJSON(jsonDisplay, data) {
    //Hacer visible el jsonDisplay
    jsonDisplay.style.display = "block";
    jsonDisplay.innerText = JSON.stringify(data, null, 4);
}

function showImage(jsonDisplay, image_name) {
    //Ocultar el jsonDisplay
    jsonDisplay.style.display = "none";
    // Crear un img para mostrar una imagen
    img = document.createElement("img");
    img.src = `images/apifutbol/${image_name}`
    img.style.width = "100%";
    img.style.height = "auto";
    img.style.display = "block";
    img.style.margin = "auto";
    img.style.marginTop = "20px";
    img.style.borderRadius = "5px";
    img.style.boxShadow = "0px 0px 10px 0px rgba(0,0,0,0.75)";
    // Agregar la imagen al div
    jsonDisplay.parentNode.appendChild(img);
    //document.getElementById('jsonDisplay').innerText = JSON.stringify(data, null, 4);
}
