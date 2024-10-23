function validateTorneo(){
    var name = document.getElementById("nombreTorneo").value;
    var fechaInicio = document.getElementById("fechaInicio").value;
    var fechaFin = document.getElementById("fechaFin").value;

    var isValid = true;

    if (name === ""){
        alert("Es obligatorio ingresar nombre");
        isValid = false;
    }

    var today = new Date();
    var beginDate = new Date("fechaInicio");
    var endDate = new Date("fechaFin");

    if(beginDate === "" || beginDate <= today){
        alert("El torneo debe empezar en el futuro.");
        isValid = false;
    }

    if(endDate === "" || beginDate >= endDate){
        alert("Fechas ingresadas inválidas");
        isValid = false;
    }

    if (isValid){
        alert("Torneo generado correctamente!")
    }

    return isValid;
}