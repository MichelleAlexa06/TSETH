<?php
class Paciente
{
    private $conexion;

    public function __construct($conexion)
    {
        $this->conexion = $conexion;
    }

    public function crear($idPersona, $idRol = 4)
    {
        try {
            // Insertamos el paciente en la tabla paciente, asociando la persona y el rol
            $sql = "INSERT INTO Paciente (idPersona, idRol) VALUES (?, ?)";
            $stmt = $this->conexion->prepare($sql);
            $stmt->execute([$idPersona, $idRol]);
        
            // Obtener el ID del paciente insertado
            $idPaciente = $this->conexion->lastInsertId();
            return $idPaciente;  // Devolver el ID del paciente
        
        } catch (PDOException $e) {
            echo "Error: " . $e->getMessage();
        }
        
    }

}
?>
