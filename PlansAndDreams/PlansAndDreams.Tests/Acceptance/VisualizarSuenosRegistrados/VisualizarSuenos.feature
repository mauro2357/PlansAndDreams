Feature: VisualizarSuenosRegistrados
	Como soñador
	Quiero ver mis sueños registrados
	Para poder hacerlos realidad

@mytag
Scenario: Visualizar Suenos
	Given Acceder a la pantalla de visualización de sueños
	When cargue la página
	Then deberían mostrarse sueño viaje a europa de "Jose"

@mytag
Scenario: Descartar suenos mayores 3 meses
	Given Acceder a la pantalla de visualización de sueños	
	When cargue la página
	Then  no deberían mostrarse los sueños mayores a 3 meses

@mytag
Scenario: Mostrar suenos caducados en color rojo
	Given Acceder a la pantalla de visualización de sueños	
	When cargue la página
	Then  deberían mostrarse los sueños caducados en color rojo

