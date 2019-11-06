# GoalSystems Prueba

## Forma de ejecución
Para probar los 4 puntos hay unit test por cada punto.
Si se desea probar el punto 1.1 y 1.2 con una interfaz, ejecutar directamente desde visual studio utilizando IIS Express (recomendado) o creando un sitio en IIS y publicándolo en el.

## Arquitectura
Una simple arquitectura en capas, la capa de presentación, y la de datos se han modelado. 

No se implemento la capa de negocios para simplificar un poco, ya que casi no hay logica de negocios y seria solo un pasa manos, 
pero estoy consciente que el front no debería conocer a los provider ni a las entidades y se deberían usar Services/DTO respectivamente que serian estructurado en la capa de negocio.

##Patron de diseño
Usea inyecion de dependencia, y también metí un singleton para el Notificador (Si la app va a ser uso intensivo de notificaciones tal vez un patrón de tipo observador sea mas interesante)

## Notificador
Hice que el notificador sea su propio proyecto para poder escalarlo y reutilizarlo mas fácilmente, por ahora notificaría solo a través de httpClient, pero también se podrían mandar mails o cualquier otro medio de comunicación.

## Datos
El mock de los datos se encuentran en InventarioProvider en una propiedad estática.

## Validaciones y seguridad
Asumo que puede haber nombres repetidos en la lista de inventario.

No hago ninguna validación de formatos y campos obligatorios por cuestiones de tiempo (Pero debería hacerse tanto del lado del cliente como del servidor).

Tampoco de seguridad por el mismo motivo, de todas formas, modele un atributo que hereda de “AuthorizeAttribute” y se usa a la altura de la clase “ElementoController” 	

## Punto 1.4
Entiendo que lo que se pedía era la notificación en si. No la lógica de estar validando cada X tiempo si algún elemento del inventario ya caduco.

## Utilización de librerías externas en el front
Hago uso de moment.js una pequeña librería que me permite trabajar con formatos de tipo fecha mas fácilmente. 
Mas que todo para enviar la fecha de caducidad a la acción "AgregarElemento" ya que si no tiene el formato MM-dd-yyyy el servidor no reconoce el formato e inicializa el parametro en DateTime.Min

Probablemente haya soluciones mas robustas con respecto a la configuración del formato de fecha que esta esperando. Pero esta es la mas simple y rápida que decidí implementar.
