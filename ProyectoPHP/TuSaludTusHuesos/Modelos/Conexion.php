<?php
class Conexion
{
    private $host = "localhost";
    private $user = "root";
    private $pass = "1234"; // Cambia esto si usas otra contraseña
    private $db = "TuSaludETH";
    private $conBD = null; // Inicializar como null

    public function __construct()
    {
        $cadenaConexion = "mysql:host=" . $this->host . ";dbname=" . $this->db . ";charset=utf8";
        try {
            $this->conBD = new PDO($cadenaConexion, $this->user, $this->pass);
            $this->conBD->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
        } catch (PDOException $e) { 
            echo "Error: " . $e->getMessage();
        }
    }

    public function getConexion()
    {
        return $this->conBD; // Retorna la conexión si fue exitosa
    }
}

// Crear una instancia de la clase para probar la conexión
$conexion = new Conexion();
?>