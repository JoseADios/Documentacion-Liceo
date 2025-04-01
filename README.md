# Documentación Liceo 📚

## 📌 Descripción

Sistema de gestión documental para instituciones educativas, desarrollado en .NET. Este proyecto facilita la creación, gestión y almacenamiento de documentos en un contexto educativo.

## 🏗️ Estructura del Proyecto

El proyecto sigue un patrón de arquitectura en capas:

- **CapaDatos**: Contiene la lógica de acceso a datos y la conexión con la base de datos SQL Server.
- **CapaNegocio**: Implementa la lógica de negocio del sistema.
- **CapaPresentacion**: Contiene la interfaz de usuario y la lógica de presentación.
- **PDocumentacionLiceo**: Proyecto principal que orquesta todas las capas.
- **img**: Directorio para almacenar recursos gráficos.

## 📄 Tipos de Documentos Soportados

El sistema permite crear y gestionar los siguientes tipos de documentos:

### 🔑 Cartas de Recomendación

- Cartas de recomendación académicas
- Cartas de recomendación para becas
- Cartas de recomendación para prácticas profesionales

### 📋 Documentos Administrativos

- Actas de matrícula
- Certificados de estudios
- Autorizaciones de padres/tutores

### 📚 Documentos Académicos

- Boletines de notas
- Certificados de promoción
- Historiales académicos

### 📅 Documentos de Gestión

- Solicitud de documentos
- Reportes de entrega
- Historial de solicitudes

## ⚙️ Requisitos del Sistema

- .NET Framework
- SQL Server LocalDB
- Windows

## 🛠️ Configuración de la Base de Datos

La aplicación utiliza una base de datos SQL Server LocalDB. La conexión está configurada en el archivo `DocumentacionConexion.cs` con la siguiente ruta:

```plaintext
Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\JoSoft\AppConsola\CapaDatos\DBDocumentacion.mdf
```

## 🚀 Funcionalidades

- 📝 Gestión completa de documentos educativos
- 📁 Creación y almacenamiento de documentos
- 🔄 Sistema de conexión a base de datos
- 🎨 Interfaz de usuario moderna y fácil de usar
- 📊 Reportes y estadísticas
- 🔄 Gestión de solicitudes de documentos

## 📂 Instalación

1. **Clonar el repositorio**:
   ```sh
   git clone https://github.com/usuario/documentacion-liceo.git
   cd documentacion-liceo
   ```
2. **Configurar la base de datos SQL Server LocalDB**
3. **Compilar y ejecutar el proyecto** en Visual Studio

