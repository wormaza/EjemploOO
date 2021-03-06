# Ejemplo Orientación Objeto

El siguiente ejemplo pretende ilustra algunos conceptos de la programación orientada a objeto. Para su desarrollo se utilizaro lo siguiente:

* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [.Net Core](https://dotnet.microsoft.com/download)
* [Docker](https://www.docker.com/)

Su desarrollo fue realizado para su uso en la asignatura INF236, del [Departamento de Informáctica](https://www.inf.utfsm.cl/) de la [Universidad Técnica Federico Santa María](https://www.usm.cl/), segundo semestre del 2020.

El video de la clase, [aquí](https://youtu.be/OPbdUUe8ClI).

Comentarios y observaciones a [wladimir.ormzabal@usm.cl](mailto:wladimir.ormazabal@usm.cl)

## Ejecución

Para su ejecución, se sugiere el uso de Docker para evitar instalar componentes adicionales.

Para esto, seguir lo siguientes pasos:

1. Descargar el proyecto
2. Acceder al directorio del proyecto **EjemploOO**
3. Generar las imagenes (con Docker, puede tardar la primera vez). Contruimos las imagenes en base a la señalado en el Dockerfile
```
docker build . -t ejemplo1
```
4. Ejecutar el proyecto (el contenedor se eliminará una vez finalizada la ejecución). Accede al ejemplo, donde se indican las instrucciones.
```
docker run --rm -it  ejemplo1
```
5. Se sugiere eliminar las imagenes asociadas al proyecto (indicar que si *y*):
```
docker image prune
```
6. Eliminar la imagen del proyecto
```
docker rmi $(docker images 'ejemplo1' -q)
```
## Uso del ejemplo

El ejemplo, permite revisar la ejecución de distintas implementaciones básicas. Cada situación analizada se encuentra en su propo archivo.

### [Ejemplo 1: Clase y objeto](Ejemplo1.cs)

Se revisa, la definición de lo que es una clase, y cual es la diferencia con un objeto.

* Concepto de *clase*
* Concepto de *objeto*

### [Ejemplo 2: Herencia](Ejemplo2.cs)

Se analiza un caso de implementación en un escenario sin herencia, y con herencia.

* Concepto de *herencia*
* Concepto de *polimorfismo dinámico*
* Concepto de *polimorfismo estático*

### [Ejemplo 3: Clases abstractas](Ejemplo3.cs)

Se parte del resultado final del ejemplo anterior, para introducir lo que es una clase abstracta.

* Concepto de *clase abstracta*

### [Ejemplo 4](Ejemplo4.cs)

Último ejemplo, donde se modifica la definición base y se utiliza una interfaz basandonos en los metodos identificados.

* Concepto de *interfaz*
