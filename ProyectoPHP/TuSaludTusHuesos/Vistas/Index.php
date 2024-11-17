<?php
session_start(); // Iniciar sesión para manejar mensajes

// Verificar si hay mensajes de error o éxito en la sesión
if (isset($_SESSION['mensaje_error'])) {
    echo '<div class="alert alert-danger mb-3 text-center" style="max-width: 500px; margin: 0 auto;">' . $_SESSION['mensaje_error'] . '</div>';
    unset($_SESSION['mensaje_error']);
}

if (isset($_SESSION['mensaje_exito'])) {
    echo '<div class="alert alert-success mb-3 text-center" style="max-width: 500px; margin: 0 auto;">' . $_SESSION['mensaje_exito'] . '</div>';
    unset($_SESSION['mensaje_exito']);
}
?>


<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Registrar Cita</title>
    
    <!-- Enlace a Bootstrap CDN -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet">

    <!-- Enlace a tu archivo CSS adicional -->
    <link rel="stylesheet" href="CSS/css.css"> <!-- Enlace al archivo CSS personalizado -->
</head>
<body>
    <div class="container mt-5">
        <h2>Registrar Cita</h2>
        <form method="POST" action="../Controladores/GuardarCitaController.php">
            <!-- Datos de la persona -->
            <div class="mb-3">
                <label for="nombre" class="form-label">Nombre</label>
                <input type="text" id="nombre" name="nombre" class="form-control" required>
            </div>
            <div class="mb-3">
                <label for="apellido" class="form-label">Apellido</label>
                <input type="text" id="apellido" name="apellido" class="form-control" required>
            </div>
            <div class="mb-3">
                <label for="telefono" class="form-label">Teléfono</label>
                <input type="text" id="telefono" name="telefono" class="form-control" required>
            </div>
            <div class="mb-3">
                <label for="email" class="form-label">Correo</label>
                <input type="text" id="email" name="email" class="form-control" required>
            </div>

            <!-- Datos de la cita -->
            <div class="mb-3">
                <label for="fechaCita" class="form-label">Fecha de la Cita</label>
                <input type="date" id="fechaCita" name="fechaCita" class="form-control" required>
            </div>
            <div class="mb-3">
                <label for="horaCita" class="form-label">Hora de la Cita</label>
                <input type="time" id="horaCita" name="horaCita" class="form-control" required>
            </div>
            <div class="mb-3">
                <label for="idTipoCita" class="form-label">Tipo de Cita</label>
                <select id="idTipoCita" name="idTipoCita" class="form-control" required>
                    <?php
                    // Incluir el controlador y obtener los tipos de cita
                    require_once '../Controladores/TipoCitaController.php';
                    $controller = new TipoCitaController();
                    $tipos = $controller->obtenerTodos();

                    // Mostrar las opciones en el select
                    foreach ($tipos as $tipo) {
                        echo "<option value='" . $tipo['idTipoCita'] . "'>" . $tipo['nombreTipo'] . "</option>";
                    }
                    ?>
                </select>
            </div>

            <div class="mb-3">
                <label for="idDoctor" class="form-label">Seleccionar Doctor</label>
                <select id="idDoctor" name="idDoctor" class="form-control" required>
                    <?php
                    // Obtener los doctores desde la base de datos
                    require_once '../Modelos/Doctor.php';
                    $doctor = new Doctor($conexion->getConexion());
                    $doctores = $doctor->obtenerTodos();

                    foreach ($doctores as $doc) {
                        echo "<option value='" . $doc['idDoctor'] . "'>" . $doc['nombre'] . "</option>";
                    }
                    ?>
                </select>
            </div>

            <button type="submit" class="btn btn-primary">Registrar Cita</button>
        </form>
    </div>

    <!-- Enlace a la CDN de Bootstrap JS (opcional) -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>
