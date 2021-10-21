# Arquitectura_Software_Laboratorio_4
## Flyweight
Laboratorio 4 implementación de un patrón de diseño estructural.

Flyweight es un patrón de diseño estructural que nos permite ahorrar memoria RAM cuando los objetos que manejamos son demasiados.
Cuando tenemos un objeto con atributos pesados como arrays de elementos que puede ser la representación física del objeto como un mapa de bits, formas que adopta
o como se ve añade un importante peso en la memoria volátil siendo esta repetida varias veces para un objeto en concreto y ralentizando la memoria RAM.

Por este motivo se pensó en la idea de abstraer los atributos pesados de cada objeto para llevarlo a un nuevo objeto que los contenga y sea referenciado por varios
objetos de similares atributos, la única condición de este nuevo objeto es que los atributos son inmutables y mantendrán el estado de como fueron creados.
### Imagen 1
### Implementación del Flyweight

![diagrama_de_clases](https://github.com/AlvaroCori/Arquitectura_Software_Laboratorio_4/blob/main/img/FlyweightResumido.png)
### Elaboración propia

En la imagen se usa una fábrica que tiene la capacidad de crear un nuevo objeto cada vez que se lo pida, similar al Singleton pero en este no puede ser editado o eliminado
sino solo creado y obtenido. Cada objeto contendrá su tipo y la clase que contiene una colección de los objetos se encarga de llamar a la fábrica.

### Problema
Un observatorio recoge imágenes con sus telescopios, lo que los telescopios captan un mapa de 3 dimensiones los cuerpos celestiales hallados (planetas, estrellas, agujeros negros, etc). Al captar un cuerpo celestial se le asigna un nombre, coordenadas, a qué clase de cuerpo celestial pertenece y los colores de tal clase de cuerpo celestial.

El problema empieza en que a veces el telescopio capta mapas de 3 dimensiones con millones de cuerpos celestiales lo que ocasiona el punto muerto de la memoria RAM de la computadora y obligadamente reiniciarla perdiendo los datos, lo que se busca es optimizar el guardado de los datos de los cuerpos celestiales.

### Imagen 2
### Solución del mapa
![diagrama_de_clases](https://github.com/AlvaroCori/Arquitectura_Software_Laboratorio_4/blob/main/img/laboratorio_4.png)
### Elaboración propia

La solución está en guardar el nombre del cuerpo celestial más la combinación de colores que desprenden en una clase llamada CelestialBodyType la cual será añadida por referencia entre 1 o más veces a la clase CelestialBody la cual esta almacenada en SpaceMap y que contiene una clase fabrica llamada CelestialBodiesFactory que le proveerá de los tipos creándolos y devolviendo una referencia a los ya llamados si se los vuelve a llamar desde SpaceMap.
