<?php
require_once __DIR__ . '/../Modelos/TipoCita.php';
require_once __DIR__ . '/../Modelos/Conexion.php';

class TipoCitaController
{
    private $tipoCita;
    private $conexion;

    public function __construct()
    {
        // Crear una nueva instancia de la clase de conexión
        $this->conexion = new Conexion();
        // Crear una nueva instancia de la clase TipoCita
        $this->tipoCita = new TipoCita($this->conexion->getConexion());
    }

    // Método para obtener todos los tipos de cita
    public function obtenerTodos()
    {
        try {
            // Llamamos al método obtenerTodos de la clase TipoCita
            $tipos = $this->tipoCita->obtenerTodos();
            return $tipos; // Devuelve los datos de los tipos de cita
        } catch (Exception $e) {
            echo "Error al obtener los tipos de cita: " . $e->getMessage();
        }
    }
}

// Instanciamos el controlador
$controller = new TipoCitaController();
$tiposCita = $controller->obtenerTodos();

// Puedes utilizar los datos para procesarlos y mostrarlos en una vista
// Por ejemplo, puedes asignar los datos a una variable para mostrarlos en la vista.
?>
