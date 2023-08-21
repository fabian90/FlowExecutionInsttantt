Encriptacion de conexion string base datos 
Paso No 1

Ejecutar ConnectionStringEncryptionConsoleApp

Paso No2

Ingresar la siguiente conexion en proceso del paso No 1
****base datos FlowExecutionDB*****
Server=DESKTOP-776KT05\SQLEXPRESS;Database=FlowExecutionDB;Trusted_Connection=true;MultipleActiveResultSets=true;Application Name=Monitoreo;

Paso No3

Copia la cadena encriptada en blanco en la linea 11 del appsetting.json

Paso No 4 generar toke

usuario: usuarioPrueba
contraseña:123

# Ejecutable FlowExecutionInsttantt.sl
# FlowExecutionInsttantt
En el presente repositorio se crea con el propósito para subir el codigo fuente de la aplicación web FlowExecutionInsttantt con la siguiente estructura.
Estructura de la FlowExecutionInsttantt 
1.Capa de presentación 
•	Controlador
•	Modelo
•	Dtos
•	Vistas
Estructura de la monitoreoService.Api
1.Capa Core:
•	Models
•	Interfaces 
•	Servicios
•	UnitOfWork
•	Enumerations
2.Capa Infraestructura:
•	Data
•	Repositories implementación
•	UnitOfWork
•	Mapping
3.Capa API:
•	Controllers
•	Models
•	DTOs (Data Transfer Objects)
•	Program
•	Validaciones
4.Capa Common
•	Helpers
•	Extensions
•	Constants
•	Enums
•	Logging