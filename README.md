# TClicker
![Descrição da Imagem](./images/logo.png)

### Sobre o Projeto

O **TClicker** é uma ferramenta de clique automático, pensada para ser rápida e precisa. Seu objetivo é ajudar em tarefas que exigem cliques repetidos, como em jogos ou testes de software, oferecendo uma interface simples e personalizável.

A precisão do TClicker é assegurada pelo uso de cálculos rigorosos de intervalo de tempo, como podemos observar no método `Intervalo()`, que utiliza a função `Stopwatch` para garantir que os cliques sejam executados de maneira consistente. Mesmo no modo aleatório, os intervalos de tempo são calculados de forma exata, com base nas entradas mínimas e máximas fornecidas pelo usuário.

O TClicker é capaz de atingir uma velocidade de clique extremamente alta, processando múltiplos cliques por segundo sem interrupções. Isso é possível graças à implementação da **Thread em background**, que mantém o processo de clique ativo sem interferir na interface gráfica. Além disso, o uso de **loop otimizado** com `Stopwatch` garante que a latência entre os cliques seja mínima, tornando o TClicker extremamente eficiente.
O loop interno, dentro do método `Clicker()`, verifica o tempo decorrido a cada milissegundo, reiniciando o cronômetro a cada iteração e garantindo que os cliques sejam distribuídos com a maior rapidez e precisão possíveis.
