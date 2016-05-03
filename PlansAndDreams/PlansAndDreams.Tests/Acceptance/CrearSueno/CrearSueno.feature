Feature: CrearSueno
	Como soñador del sueño
	Quiero dar a conocer mis sueños
	Para hacerlo realidad.

@mytag
Scenario: Crear sueno
	Given El sonador ingresa a la pantalla "suenos"
	And  crea el sueno: "comprar una bicicleta" fecha: "24-dic-2016" categoria: "juguete"
	When Cuando presione el boton grabar
	Then Deberia aparecer el siguiente mensaje "Sueno grabado con exito."

