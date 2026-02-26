# Taller_Repaso_POO
INTEGRANTES:
- 🦄Carolina García Ortega | ID: 000528089
- 😝Juan Manuel Arcila Torres | ID: 000547026
- ⭐Sara Ruiz Arboleda | ID: 000542378

CONSIDERACIONES DE DISEÑO E IMPLEMENTACIÓN:

Para hacer este ejercicio Lo primero que hicimos fue crear una clase abstracta empleado la cual va a ser la super clase para las demás clases. A esto le agregamos dos atributos, uno que será el Id y lo pusimos tipo int ya que será el número lo represente y el nombre del empleado.

Estas clases las hicimos públicas ya que no hubo necesidad de que fuese privado. 

Después se creó el constructor para la clase del empleado y en este creamos los métodos solicitados, primero, el de calcular salario que es abstracto ya que necesitamos que en sus respectivas clases hijas se puedan definir por ellas mismas el método y el segundo que es mostrar la información es virtual ya que hay una base pero en caso de que se necesite cambiar se pueda hacer.

Luego se crean las dos clases hijas. Primero, la de tiempo completo tiene un nuevo atributo que es salario fijo que le atribuimos un valor y este va a ser el que devuelva en el momento de calcular su salario. Por otro lado en el método de mostrar la información, se uso, además de la base que muestra el ID y el nombre, dos líneas que muestran el tipo de trabajador y el salario. 

Después esta la clase de empleado por horas, que necesita otros dos atributos. Uno sobre las horas trabajadas y otro del valor por hora, a ese le pusimos un valor fijo. Entonces en el método de calcular salario ahora lo que devuelve es las horas trabajadas multiplicadas por el valor por hora y en el ultimo método de mostrar la información es lo mismo que en el anterior que también e muestra el salario y el tipo de empleado.

Por el lado del encapsulamiento aunque todas las variables sean publicas, algunas las pusimos de tal manera se pudieran leer pero que no se pudieran acceder para cambiar el valor, esto lo hicimos, por ejemplo, en los atributos encargados de asignar el salario.

Por ultimo en el main creamos una lista de empleados y dentro de esta lista instanciamos a todos los empleados añadiendo nuevos objetos de tipo empleado pero para que se pudieran instanciar fueran e las clases hijas. 

Finalmente, el ultimo for each es para mostrar todos los elementos de la lista. 
