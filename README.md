# PlatformerSample2D
Um pequeno estágio de um jogo de plataforma 2D

Um pequeno estágio de um jogo de plataforma 2D

Um novo inimigo criado: Alien. 
Alien possui a habilidade de atirar um projétil no player.

"Bullet" é o objeto do projétil do Alien.

"AlienAim" e "AlienShooting" são scripts que fazem, respectivamente, o Alien mirar e atirar no player.

O script "AlienBullet" controla a velocidade e a range do projétil.

Um sistema de Checkpoint também foi implementado. 
O objeto "SpawnPoint" agora contém um script (de mesmo nome) que manipula sua posição no mapa quando o player atinge um checkpoint

Outros dois scripts foram criados para auxiliar: 
"SpawnSystem" verifica se o player passou num checkpoint e os conta.

O novo objeto "Flag" contém um trigger e o segundo script "SpawnFlag". 
Quando o player entra no collider do trigger, a flag muda de cor e toca um som. 
Assim q isto acontece, o SpawnSystem contabiliza o checkpoint, o script do SpawnPoint nota que sua posição está desatualizada, 
e então atualiza para a posição do player (que está no checkpoint).
