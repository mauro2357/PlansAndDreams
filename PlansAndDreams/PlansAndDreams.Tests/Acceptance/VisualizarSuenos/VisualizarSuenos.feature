Feature: VisualizarSuenos
	Para poder saber en que puedo invertir mis ahorros
	Como un soñador
	Quiero conocer cuanto dinero necesito para hacer mi sueño realidad.

@mytag
Scenario: Sueño con comprar una casa
	Given Yo ingreso a la pantalla de sueños
	When Yo selecciono como sueño una casa en rionegro
	Then Deberia aparecer en pantalla 120000000
