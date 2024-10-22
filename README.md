# TorneoAPI
Proyecto de desarrollo de WebApi para un torneo de Fútbol.


1. Rama main o master
Esta es la rama principal del proyecto y debe estar siempre estable. Contiene el código que está listo para ser lanzado o desplegado en producción.
Ningún programador debe trabajar directamente en main. Todas las nuevas funcionalidades, mejoras o correcciones de errores se fusionan a main después de haber sido probadas y revisadas.
Protege esta rama estableciendo reglas en GitHub que requieren revisiones de código antes de poder fusionar cambios (Pull Requests).

2. Rama develop
La rama develop es la que contiene las últimas funcionalidades que están siendo desarrolladas. Aquí se integran todas las ramas de características o tareas antes de pasarlas a main.
Es un punto intermedio entre el código en desarrollo y el código que va a producción.
Los desarrolladores pueden trabajar en develop cuando se necesitan integrar varios cambios o probar nuevas funcionalidades juntas antes de fusionarlas a main.

3. Ramas por tarea o funcionalidad (feature branches)
Cada programador trabajará en su propia rama para cada tarea o funcionalidad. Estas ramas pueden tener nombres como:
feature/nueva-funcionalidad
fix/bug-correccion
feature/login
Estas ramas se crean a partir de develop y, una vez que se completa el trabajo, se abre un Pull Request (PR) para fusionarlas de nuevo en develop.

4. Cómo manejar el flujo de trabajo
Inicio de desarrollo: Todos los desarrolladores deben clonar el repositorio y trabajar en ramas basadas en develop.
Cada tarea en una rama: Cada tarea, mejora o corrección de errores se desarrolla en una rama independiente basada en develop.
Revisiones de código: Una vez completada la tarea, se abre un Pull Request desde la rama de la tarea hacia develop. Alguien del equipo revisará el código.
Fusionar en main: Cuando las funcionalidades están listas para ser lanzadas, se fusiona develop en main, asegurándote de que todo funciona correctamente antes del despliegue.



Ejemplo visual del flujo de trabajo:

Empiezas con la rama main estable.

Creas una rama develop desde main para el desarrollo continuo.

Cada vez que haya una nueva tarea o funcionalidad, creas una rama feature/mi-tarea desde develop.

Trabajas en la rama feature hasta completar la tarea, luego creas un Pull Request hacia develop.

Una vez que todas las funcionalidades estén listas, se fusiona develop en main.








































