# Principio GRASP: Experto en Información (C#)

Este repositorio contiene un ejemplo de código en C# que demuestra la aplicación del principio **Experto en Información**, uno de los patrones de diseño GRASP (General Responsibility Assignment Software Patterns).

---

## 💡 ¿Qué es el Principio Experto en Información?

El principio **Experto en Información** establece que la responsabilidad de realizar una tarea debe ser asignada a la clase que posee la información necesaria para llevarla a cabo.

Este patrón promueve:
* **Alta Cohesión:** Las responsabilidades de una clase están estrechamente relacionadas con sus datos.
* **Bajo Acoplamiento:** Las clases interactúan entre sí de forma mínima, reduciendo las dependencias.

---

## 💻 El Ejemplo

El código incluye dos clases principales:

1.  **`Empleado.cs`**: La clase **"experta"**. Es responsable de almacenar los datos de un empleado (salario base, horas extras, etc.) y de realizar el cálculo del salario neto. Al ser la dueña de la información, tiene la responsabilidad de procesarla.

2.  **`Program.cs`**: El punto de entrada de la aplicación. Su única tarea es crear instancias de la clase `Empleado` y solicitarle que muestre los detalles de su salario. No conoce la lógica de cálculo interna, lo que demuestra un **bajo acoplamiento**.

Este diseño asegura que si las reglas de cálculo del salario cambian, solo se debe modificar la lógica dentro de la clase `Empleado`, sin afectar a ninguna otra parte del sistema.

---

## 🚀 Cómo ejecutar el código

Para ejecutar este ejemplo, simplemente:

1.  Clona este repositorio.
2.  Abre la solución en un entorno de desarrollo como Visual Studio o Visual Studio Code.
3.  Ejecuta el proyecto.
