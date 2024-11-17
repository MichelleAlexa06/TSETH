-- Creación de la base de datos
CREATE DATABASE TuSaludETH;
USE TuSaludETH;

-- Tabla Persona
CREATE TABLE Persona (
    idPersona INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    apellido VARCHAR(100) NOT NULL,
    direccion VARCHAR(255),
    telefono VARCHAR(15),
    email VARCHAR(100)
);

-- Tabla Rol
CREATE TABLE Rol (
    idRol INT AUTO_INCREMENT PRIMARY KEY,
    nombreRol VARCHAR(50) UNIQUE
);

-- Tabla Administrador
CREATE TABLE Administrador (
    idAdministrador INT AUTO_INCREMENT PRIMARY KEY,
    idPersona INT,
    idRol INT,
    usuario VARCHAR(50) UNIQUE,
    contrasena VARCHAR(255),
    FOREIGN KEY (idPersona) REFERENCES Persona(idPersona),
    FOREIGN KEY (idRol) REFERENCES Rol(idRol)
);

-- Tabla Doctor
CREATE TABLE Doctor (
    idDoctor INT AUTO_INCREMENT PRIMARY KEY,
    idPersona INT,
    idRol INT,
    usuario VARCHAR(50) UNIQUE,
    contrasena VARCHAR(255),
    especialidad VARCHAR(100),
    FOREIGN KEY (idPersona) REFERENCES Persona(idPersona),
    FOREIGN KEY (idRol) REFERENCES Rol(idRol)
);

-- Tabla Recepcionista
CREATE TABLE Recepcionista (
    idRecepcionista INT AUTO_INCREMENT PRIMARY KEY,
    idPersona INT,
    idRol INT,
    usuario VARCHAR(50) UNIQUE,
    contrasena VARCHAR(255),
    FOREIGN KEY (idPersona) REFERENCES Persona(idPersona),
    FOREIGN KEY (idRol) REFERENCES Rol(idRol)
);

-- Tabla Paciente
CREATE TABLE Paciente (
    idPaciente INT AUTO_INCREMENT PRIMARY KEY,
    idPersona INT,
    idRol INT,
    FOREIGN KEY (idPersona) REFERENCES Persona(idPersona),
    FOREIGN KEY (idRol) REFERENCES Rol(idRol)
);

-- Tabla TipoCita
CREATE TABLE TipoCita (
    idTipoCita INT AUTO_INCREMENT PRIMARY KEY,
    nombreTipo VARCHAR(50) UNIQUE
);

-- Tabla Cita
CREATE TABLE Cita (
    idCita INT AUTO_INCREMENT PRIMARY KEY,
    fecha DATE NOT NULL,
    hora TIME NOT NULL,
    idTipoCita INT,
    idDoctor INT,
    idPaciente INT,
    FOREIGN KEY (idTipoCita) REFERENCES TipoCita(idTipoCita),
    FOREIGN KEY (idDoctor) REFERENCES Doctor(idDoctor),
    FOREIGN KEY (idPaciente) REFERENCES Paciente(idPaciente)
);

-- Tabla RegistroLlegada
CREATE TABLE RegistroLlegada (
    idRegistro INT AUTO_INCREMENT PRIMARY KEY,
    idCita INT,
    fechaLlegada DATE,
    horaLlegada TIME,
    FOREIGN KEY (idCita) REFERENCES Cita(idCita)
);

-- Tabla Expediente
-- Tabla Expediente con campos que permiten nulos
CREATE TABLE Expediente (
    idExpediente INT AUTO_INCREMENT PRIMARY KEY,
    idRegistroLlegada INT,
    idPaciente INT,
    idRecepcionista INT NULL,
    idDoctor INT NULL,
    edad INT NULL,
    sexo VARCHAR(10) NULL,
    estadoCivil VARCHAR(50) NULL,
    grupoSanguineo VARCHAR(3) NULL,
    factorRH VARCHAR(1) NULL,
    alergiasConocidas VARCHAR(255) NULL,
    condicionesPreexistentes VARCHAR(255) NULL,
    medicamentosActuales VARCHAR(255) NULL,
    vacunasRecibidas VARCHAR(255) NULL,
    historialEnfermedades VARCHAR(255) NULL,
    cirugiasPrevias VARCHAR(255) NULL,
    hospitalizacionesPrevias VARCHAR(255) NULL,
    historialFamiliar VARCHAR(255) NULL,
    nombreContactoEmergencia VARCHAR(100) NULL,
    relacionContactoEmergencia VARCHAR(50) NULL,
    telefonoContactoEmergencia VARCHAR(15) NULL,
    direccionContactoEmergencia VARCHAR(255) NULL,
    motivoConsulta VARCHAR(255) NULL,
    sintomasActuales VARCHAR(255) NULL,
    diagnosticoPreliminar VARCHAR(255) NULL,
    tratamientoRecomendaciones VARCHAR(255) NULL,
    fechaCreacion DATE NULL,
    FOREIGN KEY (idRegistroLlegada) REFERENCES RegistroLlegada(idRegistro),
    FOREIGN KEY (idPaciente) REFERENCES Paciente(idPaciente),
    FOREIGN KEY (idRecepcionista) REFERENCES Recepcionista(idRecepcionista),
    FOREIGN KEY (idDoctor) REFERENCES Doctor(idDoctor)
);

-- Insertar tipos de cita
INSERT INTO TipoCita (nombreTipo) VALUES ('General');
INSERT INTO TipoCita (nombreTipo) VALUES ('Fisioterapia');

-- Insertar los tipos de roles en la tabla Rol
INSERT INTO Rol (nombreRol) VALUES ('Administrador');
INSERT INTO Rol (nombreRol) VALUES ('Doctor');
INSERT INTO Rol (nombreRol) VALUES ('Recepcionista');
INSERT INTO Rol (nombreRol) VALUES ('Paciente');

-- Insertar datos en la tabla Persona
INSERT INTO Persona (nombre, apellido, direccion, telefono, email) 
VALUES 
('Carlos', 'Gómez', 'Calle 123', '555123456', 'carlos.gomez@hospital.com'),
('Ana', 'López', 'Avenida 456', '555654321', 'ana.lopez@hospital.com'),
('Michelle', 'Zelada', 'Plaza 789', '555987654', 'michelle.zelada@hospital.com');

-- Insertar datos en la tabla Doctor
INSERT INTO Doctor (idPersona, idRol, usuario, contrasena, especialidad)
VALUES 
(1, 2, 'carlosg', '1234', 'Medicina General'), -- idRol 2 corresponde al 'Doctor'
(2, 2, 'ana', '1234', 'Fisioterapia');

INSERT INTO Administrador (idPersona, idRol, usuario, contrasena)
VALUES
(3,1,'admin','admin')


