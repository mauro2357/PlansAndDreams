Feature: CrearSueno
	Como soñador del sueño
	Quiero dar a conocer mis sueños
	Para hacerlo realidad.

@mytag
Scenario: Crear sueno
	Given El sonador ingresa en una pantalla sueño: "comprar una bicicleta"
	And  fecha: "24-dic-2016" categoria: "juguete"	
	When  Cuando presione el boton grabar
	Then  El sistema debe decir que el sueño fue grabado exitosamente.
