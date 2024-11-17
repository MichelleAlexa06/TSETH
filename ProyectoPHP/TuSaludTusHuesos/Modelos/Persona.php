<?php
class Persona
{
    private $conexion;

    public function __construct($conexion)
    {
        $this->conexion = $conexion;
    }

    public function crear($nombre, $apellido, $telefono, $email)
    {
        try {
            // Insertamos la persona en la tabla Persona
            $sql = "INSERT INTO Persona (nombre, apellido, telefono, email) VALUES (?, ?, ?, ?)";
            $stmt = $this->conexion->prepare($sql);
            $stmt->execute([$nombre, $apellido, $telefono, $email]);
            return $this->conexion->lastInsertId(); // Retorna el idPersona insertado
        } catch (PDOException $e) {
            echo "Error: " . $e->getMessage();
        }
    }
}
?>
