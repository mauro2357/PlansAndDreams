Feature: ListarSuenosAmigos
	como soñador quiero visualizar los sueños
	de mis amigos para ayudar a cumplir mis sueños

@mytag
Scenario: Listar los sueños de mis amigos
	Given Ingresar a la pantalla de visualizar sueños de amigos
	When Cargue la pantalla de visualizar sueños de amigos
	Then Carga en una tabla la lista de sueños de mis amigos
