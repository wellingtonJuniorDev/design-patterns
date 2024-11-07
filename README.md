# Design Patterns GoF em C#

Este repositório contém exemplos práticos dos **23 padrões de design (Design Patterns)** descritos pelo **Gang of Four (GoF)**, implementados em **C#**.

Os exemplos foram construídos com base nos conceitos e práticas apresentadas no site [dofactory.com](https://www.dofactory.com/).

## Objetivo

O objetivo deste repositório é fornecer uma referência prática dos padrões de design GoF para desenvolvedores C#. Cada padrão foi implementado em seu próprio arquivo de exemplo, podendo ter uma breve explicação e código comentado para facilitar o entendimento.

## Conteúdo

Os 23 padrões estão divididos em três categorias principais:

1. **Padrões Criacionais**

   - **Abstract Factory**: Cria famílias de objetos relacionados sem especificar suas classes concretas.
   - **Builder**: Separa a construção de um objeto complexo da sua representação, permitindo a criação de diferentes representações.
   - **Factory Method**: Define uma interface para criar um objeto, mas permite que as subclasses decidam qual classe instanciar.
   - **Prototype**: Permite a criação de novos objetos pela clonagem de uma instância existente.
   - **Singleton**: Garante que uma classe tenha apenas uma instância e fornece um ponto global de acesso a ela.

2. **Padrões Estruturais**

   - **Adapter**: Converte a interface de uma classe em outra interface que o cliente espera.
   - **Bridge**: Desacopla uma abstração da sua implementação, permitindo que ambas variem independentemente.
   - **Composite**: Compor objetos em estruturas de árvore para representar hierarquias de parte-todo.
   - **Decorator**: Anexa responsabilidades adicionais a um objeto de forma dinâmica.
   - **Facade**: Fornece uma interface simplificada para um subsistema complexo.
   - **Flyweight**: Usa o compartilhamento para suportar grandes quantidades de objetos granulares de forma eficiente.
   - **Proxy**: Fornece um substituto ou marcador para controlar o acesso a um objeto.

3. **Padrões Comportamentais**
   - **Chain of Responsibility**: Evita o acoplamento entre o remetente de uma solicitação e seu receptor.
   - **Command**: Encapsula uma solicitação como um objeto, permitindo a parametrização de clientes.
   - **Interpreter**: Define uma representação gramatical para uma linguagem e um interpretador que usa a representação.
   - **Iterator**: Fornece uma maneira de acessar elementos de uma coleção sequencialmente.
   - **Mediator**: Define um objeto que encapsula como um conjunto de objetos interage.
   - **Memento**: Captura e externaliza o estado interno de um objeto.
   - **Observer**: Define uma dependência um-para-muitos entre objetos.
   - **State**: Permite que um objeto altere seu comportamento quando seu estado interno muda.
   - **Strategy**: Define uma família de algoritmos, encapsula cada um deles e os torna intercambiáveis.
   - **Template Method**: Define o esqueleto de um algoritmo e permite que subclasses redefinam etapas.
   - **Visitor**: Representa uma operação a ser realizada em elementos de uma estrutura de objeto.

## Estrutura do Projeto

Cada padrão está organizado em uma pasta com:

- **Generic**: Exemplo prático com os atores genéricos do pattern.
- **RealWorld**: Exemplo prático resolvendo um problema do mundo real.
