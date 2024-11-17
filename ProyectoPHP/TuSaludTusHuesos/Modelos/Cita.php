<?php
class Cita
{
    private $conexion;

    public function __construct($conexion)
    {
        $this->conexion = $conexion;
    }

    public function crear($fecha, $hora, $idTipoCita, $idDoctor, $idPaciente)
{
    try {
        // Verificar si ya hay una cita a la misma hora para el mismo doctor
        $sqlVerificarHora = "
            SELECT COUNT(*) 
            FROM Cita
            WHERE idDoctor = ? AND fecha = ? AND hora = ?
        ";
        $stmtVerificarHora = $this->conexion->prepare($sqlVerificarHora);
        $stmtVerificarHora->execute([$idDoctor, $fecha, $hora]);
        $cantidadCitasHora = $stmtVerificarHora->fetchColumn();

        if ($cantidadCitasHora > 0) {
            return "Ya existe una cita a las $hora para el doctor el día $fecha. Por favor, elija otro horario.";
        }

        // Verificar si el doctor tiene más de 2 citas en el mismo lapso de tiempo
        $sqlVerificarLapso = "
            SELECT COUNT(*) 
            FROM Cita
            WHERE idDoctor = ? AND fecha = ? AND hora BETWEEN ? AND ADDTIME(?, '01:00:00')
        ";
        $stmtVerificarLapso = $this->conexion->prepare($sqlVerificarLapso);
        $stmtVerificarLapso->execute([$idDoctor, $fecha, $hora, $hora]);
        $cantidadCitasLapso = $stmtVerificarLapso->fetchColumn();

        if ($cantidadCitasLapso >= 2) {
            return "El doctor ya tiene más de 2 citas en este lapso de tiempo, por favor elija otro horario o doctor.";
        }

        // Si no hay conflicto, proceder a insertar la cita
        $sql = "INSERT INTO Cita (fecha, hora, idTipoCita, idDoctor, idPaciente) VALUES (?, ?, ?, ?, ?)";
        $stmt = $this->conexion->prepare($sql);
        $stmt->execute([$fecha, $hora, $idTipoCita, $idDoctor, $idPaciente]);

        // Verificar si la cita fue insertada correctamente
        if ($stmt->rowCount() > 0) {
            return true;  // Cita registrada exitosamente
        } else {
            return false; // No se insertó la cita
        }

    } catch (PDOException $e) {
        echo "Error: " . $e->getMessage();
        return false;
    }
}


    // Obtener todas las citas de un doctor
    public function obtenerCitasPorDoctor($idDoctor)
    {
        try {
            $sql = "SELECT * FROM Cita WHERE idDoctor = ?";
            $stmt = $this->conexion->prepare($sql);
            $stmt->execute([$idDoctor]);
            return $stmt->fetchAll(PDO::FETCH_ASSOC);
        } catch (PDOException $e) {
            echo "Error: " . $e->getMessage();
        }
    }
}
?>
