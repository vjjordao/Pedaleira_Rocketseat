# Pedaleira_Rocketseat
Pedaleira para dar Play/Pause nos vídeos da Rocketseat

Como o próprio Diego já disse, ele fala naturalmente no 2x. E eu digito como um idoso...  
A intenção desse projeto é poder dar Play/Pause nas video aulas do curso Gostack da Rocketseat com o pé, assim é possível copiar as aulas sem ter que tirar a mão do teclado.


## Funcionamento
Existem algums Arduinos que conseguem simular um teclado USB, porém eu não tenho nenhum desses e como este projeto foi criado em uma sexta feira de feriado durante a quarentena, sair para comprar componentes estava fora de questão.  
  
Ao pressionar um simples push button ligado em uma porta digital do arduino, este envia um comando por serial para uma aplicação em VB.net que por sua vez simula o comando de Play/Pause.
