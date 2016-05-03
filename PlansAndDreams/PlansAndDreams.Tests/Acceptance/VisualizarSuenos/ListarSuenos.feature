Feature: VisualizarSuenos
	Para poder saber en que puedo invertir mis ahorros
	Como un soñador
	Quiero conocer cuanto dinero necesito para hacer mi sueño realidad.

@mytag
Scenario: Listar sueños de mis amigos
	Given Acceso a la pantalla de los sueños de mis amigos
	When Carga la pantalla
	Then Deberia aparecer la lista de sueños de todos mis amigos