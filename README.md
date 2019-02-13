## Forma de ejecución
	Ejecutar directamente desde visual studio utilizando IIS Express (recomendado) o creando un sitio en IIS y publicándolo en el.

## Datos
	El mock de los datos lo hago con una clase estática (DatosElementos) que contien una lista de elementos hardcodeados

## Validaciones y seguridad
	No hago ninguna validación de formatos y campos obligatorios por cuestiones de tiempo (Pero debería hacerlas tanto del lado del cliente como del servidor).
	Tampoco de seguridad por el mismo motivo, de todas formas modele un atributo que hereda de “AuthorizeAttribute” y se usa a la altura de la clase “ElementoController” 	

	
## Utilización de librerías externas
	Hago uso de moment.js una pequeña librería que me permite trabajar con formatos de tipo fecha mas fácilmente. 
	Mas que todo para enviar la fecha de caducidad a la acción "AgregarElemento" ya que si no tiene el formato MM-dd-yyyy el servidor no reconoce el formato e inicializa el parametro en DateTime.Min
	Probablemente haya soluciones mas robustas con respecto a la configuración del formato de fecha que esta esperando. Pero esta es la mas simple y rápida que decidí implementar.

## Asunciones del punto 1.3	
	Cuando se logra eliminar un elemento como indica en el punto 1.2, hago que la acción “QuitarElemento” retorne el numero de eliminaciones que hubo para notificarlo. Si hubo 0 eliminaciones no notifico.
