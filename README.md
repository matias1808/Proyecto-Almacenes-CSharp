# 📦 Proyecto CS - Sistema de Gestión de Almacenes

Este proyecto es una aplicación de escritorio desarrollada en **C# con WinForms**, conectada a una base de datos relacional en **SQL Server (SSMS)**. Permite registrar, modificar, eliminar y visualizar almacenes y áreas logísticas, facilitando la gestión operativa.

---

## 🧩 Características principales

- 📁 Gestión de **Almacenes Generales**
- 🏭 Registro de áreas de **Recepción** y **Despacho**
- 🔎 Búsqueda rápida de almacenes
- 📊 Contador de almacenes registrados
- 🗃 Conexión a base de datos SQL Server mediante **Entity Framework**

---

## 🛠 Tecnologías utilizadas

| Herramienta       | Descripción                               |
|-------------------|-------------------------------------------|
| C# / .NET         | Lógica de aplicación y WinForms UI        |
| SQL Server (SSMS) | Base de datos relacional                  |
| Entity Framework  | ORM para interacción con la base de datos |
| Visual Studio     | Entorno de desarrollo                     |

---
## ⚙ Requisitos

- Visual Studio 2019 o superior
- .NET Framework 4.7.2
- SQL Server Management Studio (SSMS)
- Conexión configurada en `App.config`

---

## 🔌 Configuración de conexión

Revisa y actualiza la cadena de conexión en `App.config` con tus credenciales de SQL Server:

```xml
	<connectionStrings>
		<add name="db_proyecto_3Entities" connectionString="metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=DESKTOP-MK7TD1F;initial catalog=db_proyecto_3;integrated security=True;encrypt=False;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
	</connectionStrings>
