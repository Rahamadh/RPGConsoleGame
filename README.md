# ⚔️ RPG Battle Console

Um jogo de RPG em turnos desenvolvido em **C#** rodando via Console. O projeto simula um sistema de batalha clássico onde o jogador enfrenta inimigos aleatórios com mecânicas únicas.

![Badge em Desenvolvimento](http://img.shields.io/static/v1?label=STATUS&message=EM%20DESENVOLVIMENTO&color=GREEN&style=for-the-badge)

## 💻 Sobre o Projeto

Este projeto foi desenvolvido com o objetivo de estudar e aplicar conceitos fundamentais de **Programação Orientada a Objetos (POO)**. 

O jogo consiste em uma arena onde o jogador cria seu campeão e enfrenta inimigos sorteados aleatoriamente (Bandido, Orc ou Dragão). Cada inimigo possui comportamentos e habilidades especiais distintas, exigindo estratégia do jogador.

## ⚙️ Funcionalidades

- [x] **Criação de Personagem:** Escolha do nome do herói.
- [x] **Sistema de Turnos:** Jogador e Inimigo alternam ações.
- [x] **Ações de Combate:**
  - ⚔️ **Ataque Físico:** Dano base variável.
  - 🛡️ **Defesa:** Aumenta a esquiva e reduz o dano recebido no próximo turno.
  - ✨ **Magia:** Gasta mana para causar dano alto (ignora parte da defesa).
- [x] **Inimigos Inteligentes:**
  - **Bandido:** Inimigo padrão equilibrado.
  - **Orc:** Possui o ataque especial "Investida Brutal" (dano crítico).
  - **Dragão:** Possui o "Sopro Flamejante" (dano massivo em área).
- [x] **Gerador Aleatório:** Cada batalha traz um inimigo diferente.

## 🛠️ Tecnologias Utilizadas

- **C#** (Linguagem Principal)
- **.NET** (Framework)
- **Git & GitHub** (Versionamento)

## 📚 Conceitos de POO Aplicados

Este é o ponto forte do projeto. Para evitar repetição de código e criar um sistema flexível, utilizei:

1.  **Herança:** A classe `Personagem` serve de base para `Player`, `Orc` e `Dragon`, compartilhando atributos como Vida, Mana e métodos de movimentação.
2.  **Polimorfismo:**
    - Uso de métodos `virtual` e `override`.
    - O método `AcaoEspecial()` é executado de forma diferente dependendo se o inimigo é um Orc ou um Dragão, sem a necessidade de múltiplos `if/else` no código principal.
3.  **Encapsulamento:** Proteção da lógica de dano e defesa dentro das classes responsáveis.
4.  **Abstração:** O `Main` não precisa saber como o dano é calculado, ele apenas chama `inimigo.Atacar()`.

## 🚀 Como Executar

Para rodar o jogo na sua máquina, você precisa ter o [.NET SDK](https://dotnet.microsoft.com/download) instalado.

```bash
# Clone este repositório
git clone [https://github.com/SEU_USUARIO/NOME_DO_REPO.git](https://github.com/SEU_USUARIO/NOME_DO_REPO.git)

# Acesse a pasta do projeto no terminal/cmd
cd NOME_DO_REPO

# Execute o projeto
dotnet run
