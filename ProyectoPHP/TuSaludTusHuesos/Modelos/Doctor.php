<?php
class Doctor
{
    private $conexion;

    public function __construct($conexion)
    {
        $this->conexion = $conexion;
    }

    public function obtenerTodos()
    {
        try {
            // Seleccionamos idDoctor y el nombre desde la tabla Persona
            $sql = "SELECT Doctor.idDoctor, Persona.nombre 
                    FROM Doctor
                    INNER JOIN Persona ON Doctor.idPersona = Persona.idPersona
                    ORDER BY Doctor.idDoctor ASC";
            $stmt = $this->conexion->query($sql);
            return $stmt->fetchAll(PDO::FETCH_ASSOC);
        } catch (PDOException $e) {
            echo "Error: " . $e->getMessage();
        }
    }

}
?>
