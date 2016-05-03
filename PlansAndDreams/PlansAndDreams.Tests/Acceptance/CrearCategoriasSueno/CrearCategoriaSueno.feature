Feature: CrearCategoriaSueno
	Como Facilitador del sueño
	Quiero registrar las categorias de los sueños
	Para Poder cobrar dependiendo de la categoria.

@mytag
Scenario: Grabar categoria viajes
	Given Acceso a la pantalla de registro de categoria
	And ingreso la categoria "Viajes"
	When Presiono grabar
	Then Deberia aparecer el mensaje "Categoria grabada con exito."

Scenario: Validar categoria repetida
	Given Acceso a la pantalla de registro de categoria
	And ingreso la categoria "Juguetes"
	When Presiono grabar
	Then Deberia aparecer el mensaje "La categoria ya existe."