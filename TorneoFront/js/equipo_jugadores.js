const jugadoresList = document.getElementById('jugadoresList');
const jugadorForm = document.getElementById('jugadorForm');
const equipoForm = document.getElementById('equipoForm');
let jugadores = []; // Array para almacenar los jugadores

// Manejar el envío del formulario de equipo
equipoForm.addEventListener('submit', function(event) {
    event.preventDefault();
    const nombreEquipo = document.getElementById('nombreEquipo').value;
    const fechaFundacion = document.getElementById('fechaFundacion').value;
    // Aquí agregarías la lógica para guardar el equipo en la base de datos

    // Resetear el formulario
    equipoForm.reset();
    alert(`Equipo ${nombreEquipo} agregado con éxito.`);
});

// Manejar el envío del formulario de jugador
jugadorForm.addEventListener('submit', function(event) {
    event.preventDefault();
    const nombreJugador = document.getElementById('nombreJugador').value;
    const apellidoJugador = document.getElementById('apellidoJugador').value;
    const dniJugador = document.getElementById('dniJugador').value;

    const jugador = { nombre: nombreJugador, apellido: apellidoJugador, dni: dniJugador };
    jugadores.push(jugador);
    updateJugadoresList();

    // Resetear el formulario
    jugadorForm.reset();
});

function updateJugadoresList() {
    jugadoresList.innerHTML = ''; // Limpiar la lista
    jugadores.forEach((jugador, index) => {
        const li = document.createElement('li');
        li.className = 'list-group-item';
        li.textContent = `${jugador.nombre} ${jugador.apellido} - DNI: ${jugador.dni}`;
        jugadoresList.appendChild(li);
    });
}
document.getElementById("equipoForm").addEventListener("submit", function(event) {
    event.preventDefault(); // Evita el envío del formulario

    // Obtener valores del formulario
    const nombreJugador = document.getElementById("nombreJugador").value;
    const apellidoJugador = document.getElementById("apellidoJugador").value;
    const dniJugador = document.getElementById("dniJugador").value;

    // Agregar el jugador a la lista
    const jugadoresList = document.getElementById("jugadoresList");
    const li = document.createElement("li");
    li.className = "list-group-item";
    li.textContent = `${nombreJugador} ${apellidoJugador}`;
    jugadoresList.appendChild(li);

    // Agregar el jugador a la tabla
    const jugadoresTableBody = document.getElementById("jugadoresTableBody");
    const row = document.createElement("tr");
    row.innerHTML = `
        <td>${nombreJugador}</td>
        <td>${apellidoJugador}</td>
        <td>${dniJugador}</td>
        <td>${/* Aquí puedes poner la lógica para la ficha médica */ "Sí"}</td>
    `;
    jugadoresTableBody.appendChild(row);

    // Limpiar los campos del formulario
    document.getElementById("nombreJugador").value = '';
    document.getElementById("apellidoJugador").value = '';
    document.getElementById("dniJugador").value = '';
});
