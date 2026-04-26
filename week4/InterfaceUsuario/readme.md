# Crear la interfaces de usuario para el IFTS

## Descripción
Usando la Solución llamada PrimerProyecto, que venimos diseñando en las semanas anteriores, cuyo entorno hace referencia a: “En un instituto terciario deben registrar el nombre, apellido y documento de los futuros postulantes para luego asignarles el curso y procesar la inscripción …”

## ¿Qué te proponemos hacer?
1. Agregar una ventana de Login con las siguientes características:
    - Debe tener en un `PictureBox` una imagen que haga referencia a un instituto terciario.
    - `TextBox` que permita ingresar el nombre de usuario (`txtUsuario`).
    - `TextBox` que permita ingresar una contraseña camuflada (`txtClave`).
    - `Button` con la leyenda “Ingresar” (`btnIngresar`).
2. Leer el documento “ventana de inicio de una solución” para que el formulario que acabas de agregar sea el primero en la ejecución.
3. El `btnIngresar` debe validar el ingreso del usuario y contraseña, como no hay registro externo de datos vamos a considerar que la información válida es **Usuario** = *Administrador* y **contraseña** = *Admin1234*. Quiere decir que en el evento click del botón con el uso de un if se valida los datos.
    - Respuesta = SI: debe llamar de manera No Modal al formulario cuyo diseño es el formulario de la Solución PrimerProyecto
    - Respuesta = NO: debe mostrar en un cuadro de diálogo un mensaje que muestre la leyenda usuario inexistente.
4. Al formulario de la Solución PrimerProyecto (recuerde que lo programaste en la semana 3): agregar un `DataGridView` con las columnas *Nombre*, *Apellido*, *Tipo* y *Documento*. La carga de valores a las celdas las debe hacer usando la clase “Postulante” (creada en la semana 3).
