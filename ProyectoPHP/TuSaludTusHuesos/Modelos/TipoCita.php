<?php
class TipoCita
{
    private $conexion;

    public function __construct($conexion)
    {
        $this->conexion = $conexion;
    }
    // Obtener todos los tipos de citas
    public function obtenerTodos()
    {
        try {
            $sql = "SELECT * FROM TipoCita";
            $stmt = $this->conexion->query($sql);
            return $stmt->fetchAll(PDO::FETCH_ASSOC);
        } catch (PDOException $e) {
            echo "Error: " . $e->getMessage();
        }
    }
}
?>
