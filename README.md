# BIO-AR
[![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)](https://travis-ci.org/joemccann/dillinger)

## Aplicação de realidade aumentada no ensino lúdico

Informações de build:
| Plugin | README |
| ------ | ------ |
| Unity 2021 | [https://unity3d.com/get-unity/download][PlGh] |
| .Net 4.x | [https://www.microsoft.com/pt-br/download/details.aspx?id=30653][PlGh] |
| Vuforia Engine 10.10 | [https://developer.vuforia.com/downloads/SDK][PlGh] |
| Blender 3D 3.3.0 | [https://www.blender.org/download/][PlGh] |
| Photoshop | [https://www.adobe.com/br/creativecloud/plans.html][PlGh] |


Requisitos de sistema para executar a aplicação:
 - Android 8

##  INTRODUÇÃO

BIO-AR é uma aplicação em desenvolvimento através da Unity 3D, que utiliza realidade aumentada para tornar o ensino mais lúdico, podendo ser utilizado em diversas disciplinas, esta versão foca na disciplina de biologia, com foco em vírus e bactérias. Para tornar atraente e não só lúdico com a realidade aumentada, a aplicação também é gamificada, utilizando o modelo de quiz para questionar o usuário sobre o objeto 3D que esta sendo apresentado.

## JUSTIFICATIVA

> O lúdico é muito importante para aprendizagem, pois desperta também a imaginação, criatividade, e interesse através do entusiasmo de cada um para desenvolver a atividade proposta.
 --Artigo sobre a importância do lúdico [Acessar](https://monografias.brasilescola.uol.com.br/educacao/a-importancia-ludico-na-educacao-infantil.htm#:~:text=As%20atividades%20l%C3%BAdicas%20auxiliam%20no,tornando%20o%20ensino%20de%20qualidade.)

Além do lúdico que já é bastante atrativo para os usuários, temos o incremento da gamificação, colaborando não só no desenvolvimento, mas também na participação com estímulos diversos para se obter conhecimentos.

> Gamificação é um termo adaptado do inglês – gamification – que define o emprego de técnicas comuns aos games em situações de não jogo. Ou seja, uma característica que, normalmente, aparece em jogos é adaptada para um contexto distinto, geralmente para motivar ou tornar uma tarefa mais prazerosa.
--Gamificação: o que é, vantagens e como implementar [Acessar](https://fia.com.br/blog/gamificacao/)

## OBJETIVOS

BIO-AR pode ser expandido para abordar diversas disciplinas, não só a biologia, como também na química, exibindo composição, estrutura, propriedades da matéria e reações químicas, as aplicações não têm um limite pré-definido.

Porem para o desenvolvimento inicial, foi selecionada a disciplina de biologia, com foco em vírus e bactérias, pois, há a necessidade de se criar modelos em três dimensões (3D) para cada modelo exibido na aplicação, além da criação de questões relacionadas a cada modelo, com suas páginas e imagens pré-definidas.

## IDEAÇÃO

Brainstorming, prototipagem.

A ideia inicial foi criar uma aplicação utilizando realidade aumentada, voltado para o ensino, sem foco em uma disciplina específica.
O que necessitaria de algo a mais para manter os usuários, surgindo a implementação da gamificação em conjunto da realidade aumentada.

O primeiro protótipo foi desenhado da seguinte forma:


## Development

Para começar o desenvolvimento, alguns softwares foram especificados:
- Unity 3D, para a construção principal de todo o ambiente da aplicação.
- Blender 3D, para criação de modelos para cada exibição da aplicação.
- Photoshop, para criação das artes necessárias.

Necessitando agora, definir o SDK de realidade aumentada que seria utilizado, as principais escolhas mais seus requisitos:
- ARFundation: Muito ampla e proprietária da Unity - não existe limite de modelos - Porem exige google play AR, que só é disponibilizado em dispositivos mais recentes.
- AReasy: Pouco atualizada comparada as outras opções - com limite de modelos -, desenvolvimento confuso e pouco conteúdo na comunidade.
- Vuforia: Não exige outras aplicações no dispositivo, apenas que possua android 8 ou superior - possui limite de modelos - muito conteúdo na comunidade.

A escolhida foi a Vuforia, por limitações de hardware no desenvolvimento, já que sua única exigência é possuir android 8 ou superior para executar a aplicação, também por sua ampla discussão na comunidade.

## Licença

MIT

**Free Software!**

[PlGh]: <https://github.com/joemccann/dillinger/tree/master/plugins/github/README.md>

