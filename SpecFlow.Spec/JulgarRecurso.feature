Feature: JulgarRecurso
	Como Coordenador
	Eu gostaria de julgar recursos

@JulgarRecurso
Scenario: Julgar recurso
	Given Eu informei o Recurso:
	| Id | Parecer |
	| 1  | Parecer de teste |
	When Eu julgar ele
	Then O resultado deverá ser a mensagem de "Sucesso"

@JulgarRecurso
Scenario: Listar recursos somente ativos
	When Eu listar os recursos ativos
	Then O resultado não poderá ter recursos inativos