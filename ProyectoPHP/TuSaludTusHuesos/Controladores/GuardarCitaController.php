
<?php
// Incluir el autoload de Composer
require_once __DIR__ . '/../vendor/autoload.php';

// Incluir el espacio de nombres para PHPMailer
use PHPMailer\PHPMailer\PHPMailer;
use PHPMailer\PHPMailer\Exception;

session_start(); // Iniciar sesión para manejar mensajes

require_once __DIR__ . '/../Modelos/Conexion.php';
require_once __DIR__ . '/../Modelos/Persona.php';
require_once __DIR__ . '/../Modelos/Paciente.php';
require_once __DIR__ . '/../Modelos/Cita.php';
require_once __DIR__ . '/../Modelos/TipoCita.php';
require_once __DIR__ . '/../Modelos/Doctor.php';

class GuardarCitaController
{
    private $conexion;

    public function __construct($conexion)
    {
        $this->conexion = $conexion;
    }

    // Función para guardar persona, paciente y cita
    public function guardarCita($nombre, $apellido, $telefono, $email,  $fechaCita, $horaCita, $idTipoCita, $idDoctor)
    {
        // 1. Guardar Persona
        $persona = new Persona($this->conexion);
        $idPersona = $persona->crear($nombre, $apellido, $telefono, $email);
        if (!$idPersona) {
            $_SESSION['mensaje_error'] = "Error al registrar la persona.";
            header("Location: ../Vistas/Index.php");
            exit();
        }

        // 2. Guardar Paciente
        $paciente = new Paciente($this->conexion);
        $idPaciente = $paciente->crear($idPersona, 4);
        if (!$idPaciente) {
            $_SESSION['mensaje_error'] = "Error al registrar el paciente.";
            header("Location: ../Vistas/Index.php");
            exit();
        }

        // 3. Guardar Cita
        $cita = new Cita($this->conexion);
        $resultadoCita = $cita->crear($fechaCita, $horaCita, $idTipoCita, $idDoctor, $idPaciente);

        if ($resultadoCita === "El doctor ya tiene más de 2 citas en este lapso de tiempo, por favor elija otro horario o doctor.") {
            $_SESSION['mensaje_error'] = $resultadoCita;
            header("Location: ../Vistas/Index.php");
            exit();
        }elseif($resultadoCita === "Ya existe una cita a las $horaCita para el doctor el día $fechaCita. Por favor, elija otro horario.") {
            $_SESSION['mensaje_error'] = $resultadoCita;
            header("Location: ../Vistas/Index.php");
            exit();
        }elseif ($resultadoCita === true) {  // Verificar si se insertó correctamente
            $_SESSION['mensaje_exito'] = "Cita registrada exitosamente.";
            // Enviar correo de confirmación
            $this->enviarCorreoConfirmacion($nombre, $apellido, $email, $fechaCita, $horaCita);
            
            header("Location: ../Vistas/Index.php");
            exit();
        } else {
            $_SESSION['mensaje_error'] = "Error al registrar la cita.";
            header("Location: ../Vistas/Index.php");
            exit();
        }

    }
    // Función para enviar el correo de confirmación
    private function enviarCorreoConfirmacion($nombre, $apellido, $email, $fechaCita, $horaCita)
    {
        $mail = new PHPMailer(true);

        try {
            // Configuración del servidor SMTP
            $mail->isSMTP();
            $mail->Host = 'smtp.gmail.com'; // Servidor SMTP de Gmail
            $mail->SMTPAuth = true;
            $mail->Username = 'alexazf060@gmail.com'; 
            $mail->Password = 'hhqs wlah drhv etab'; 
            $mail->SMTPSecure = PHPMailer::ENCRYPTION_STARTTLS;
            $mail->Port = 587;

            // Receptores
            $mail->setFrom('alexazf060@gmail.com', 'Tu Salud en Tus Huesos');
            $mail->addAddress($email, "$nombre $apellido");

            // Contenido del correo
            $mail->isHTML(true);
            $mail->Subject = 'Confirmacion de Cita';
            $mail->Body    = "¡Buen día $nombre $apellido!<br><br>
                             Este correo es para confirmar tu cita para el día $fechaCita, a las $horaCita.<br>
                             ¡Te esperamos en nuestra consulta!<br><br>
                             Atentamente,<br>
                             Tu Salud en Tus Huesos, porque tu bienestar comienza desde adentro.";

            // Enviar correo
            $mail->send();
        } catch (Exception $e) {
            $_SESSION['mensaje_error'] = "Error al enviar el correo: {$mail->ErrorInfo}";
            header("Location: ../Vistas/Index.php");
            exit();
        }
    }
}

// Lógica para manejar la solicitud POST
if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    // Crear la conexión a la base de datos
    $conexion = new Conexion();
    $guardarCitaController = new GuardarCitaController($conexion->getConexion());

    // Verificar que los datos necesarios estén presentes en el POST
    if (isset($_POST['nombre'], $_POST['apellido'], $_POST['telefono'], $_POST['email'],  $_POST['fechaCita'], $_POST['horaCita'], $_POST['idTipoCita'], $_POST['idDoctor'])) {
        $nombre = $_POST['nombre'];
        $apellido = $_POST['apellido'];
        $telefono = $_POST['telefono'];
        $email = $_POST['email'];
        $fechaCita = $_POST['fechaCita'];
        $horaCita = $_POST['horaCita'];
        $idTipoCita = $_POST['idTipoCita'];
        $idDoctor = $_POST['idDoctor'];

        // Llamar al método para guardar la persona, paciente y cita
        $guardarCitaController->guardarCita($nombre, $apellido, $telefono, $email,  $fechaCita, $horaCita, $idTipoCita, $idDoctor);
    } else {
        $_SESSION['mensaje_error'] = "Faltan datos en el formulario.";
        header("Location: ../Vistas/Index.php");
        exit();
    }
}
?>
