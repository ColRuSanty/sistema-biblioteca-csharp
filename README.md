
# Sistema de Biblioteca en C#

Proyecto académico desarrollado en C# para la materia Programación II de la Tecnicatura Universitaria en Programación (UTN).

## Descripción

Aplicación de consola que simula la gestión de materiales y préstamos de una biblioteca.

Permite registrar y buscar materiales, gestionar préstamos y devoluciones, administrar listas de espera y calcular multas por atrasos.

## Funcionalidades

- Registro de libros, revistas y materiales audiovisuales.
- Validación de códigos de inventario duplicados.
- Búsqueda de materiales por código.
- Préstamo de libros y materiales audiovisuales.
- Restricción de retiro de revistas, disponibles solo para consulta en sala.
- Lista de espera cuando un material está prestado.
- Asignación del material al primer socio en espera después de una devolución.
- Cálculo de multas por atrasos.
- Cálculo del total de multas y del promedio de días de atraso.
- Validación de devoluciones duplicadas y días de atraso negativos.

## Conceptos aplicados

- Programación orientada a objetos (POO).
- Clases abstractas y herencia.
- Polimorfismo.
- Interfaces.
- Encapsulamiento.
- Manejo de excepciones.
- Colecciones: List y Dictionary.

## Tecnologías

- C#
- .NET
- Aplicación de consola

## Ejecución

Es necesario tener instalado el SDK de .NET.

Desde la carpeta principal del proyecto:

```bash
dotnet run --project src/ConsoleApp
```

## Estructura

- `src/ConsoleApp`: aplicación de consola y ejemplos de ejecución.
- `src/MisClases`: clases y lógica del sistema de biblioteca.

## Contexto académico

Proyecto realizado como trabajo práctico de Programación II en la Universidad Tecnológica Nacional (UTN).
