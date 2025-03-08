# Arquitectura Limpia en C#

## ¿Qué es este proyecto?

Este proyecto es una implementación de la arquitectura limpia (Clean Architecture) en C# con el propósito de ejemplificar las mejores prácitcas en el diseño de software.

La idea principal es demostrar cómo se puede organizar las dependencias de una aplicación de manera que el código sea mantenible, estable y flexible a cambios futuros.

Este repositorio puede servir como punto de partida para desarrollar aplicaciones siguiendo la filosofía de la Arquitectura Limpia.

## ¿Qué es la Arquitectura Limpia?

La Arquitectura Limpia es un modelo propuesto por Robert C. Martin (Uncle Bob), cuyo objetivo es estructurar los sistemas de software de tal forma que sean independientes de Framework, bases de datos, interfaces de usuario y cualquier otro detalle externo. Esto se logra mediante la separación de responsabilidades en capas bien definidas. La Arquitectura Limpia se basa en los siguientes principios.

-   Independencia de Frameworks: No depende de ninguna tecnología o Framework espécifico.
-   Testabilidad: El código es altamente testeable gracias a la separación de responsabilidades.
-   Independencia de UI: Se puede cambiar la interfaz de usuario sin afectar la lógica de negocio.
-   Independencia de Bases de Datos: La capa de acceso a datos puede cambiar sin alterar el dominio.
-   Independencia de detalles externos: Los detalles dependen del negocio, no al revés.

## Diagrama de la Arquitectura Limpia

A continuación, se muestra un diagrama típico de la Arquitectura Limpia:

### Explicación de las capas

1. Entidad (Entities o Domain): Contienen las reglas de negocio y entidades del dominio.
2. Caso de Uso (Use case o Application): Implementa la lógica de aplicación y orquesta las operaciones entre las entidades y las capas externas.
3. Infraestructura (Infrastructure): Implementa detalles como base de datos, servicios externos y Frameworks.
4. Interfaz de Usuario (Presentation): Incluye los controladores, vistas o cualquier interacción con el usuario.

## Contribuciones

Si quieres mejorar o extender este proyecto, ¡Las contribuciones son bienvenidas! Puedes hacer un fork, crear una rama y enviar un pull request.

## Licencia

Este proyecto está bajo la licencia MIT. Puedes usarlo libremente en tus proyectos.
