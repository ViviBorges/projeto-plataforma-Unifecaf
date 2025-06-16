**Portfólio Átomo: Jogo de Plataforma 2D na Unity**

---

## 1. Visão Geral do Projeto

**Objetivo:** Demonstrar um jogo de plataforma 2D, construído na Unity, com mecânicas de movimento, interação e progressão de níveis, utilizando como exemplo o build disponibilizado (Projeto Plataforma Unifecaf).

* **Controles:** andar, correr, pular e coletar itens.
* **Feedback:** áudio e HUD exibindo pontuação.
* **Níveis:** 3 fases distintas com aumento de dificuldade: tutorial, obstáculos móveis e pontos de checkpoint.

**Ferramentas:**

* Build Windows fornecido em `.exe` (Projeto Plataforma Unifecaf.exe).
* Dependências: UnityPlayer.dll, UnityCrashHandler64.exe.
* Git/GitHub (planejado para versionar o projeto-fonte).


## 2. README.md (Visão Pública)

### 2.1 Título e Descrição

`Projeto Plataforma Unifecaf – Jogo 2D de Plataforma`

> Executável Windows demonstrando mecânicas de plataforma 2D: movimento, pulo, coleta de itens e checkpoints.

### 2.2 Instalação e Execução

1. Clone o repositório:

   ```bash
   ```

git clone (https://github.com/ViviBorges/projeto-plataforma-Unifecaf.git)

```
2. Navegue até a pasta `Build`.  
3. Certifique-se de que `Projeto Plataforma Unifecaf.exe`, `UnityPlayer.dll` e `UnityCrashHandler64.exe` estejam juntos.  
4. Execute o arquivo `Projeto Plataforma Unifecaf.exe` em Windows.

### 2.3 Controles
- **A/D ou ←/→:** Andar horizontalmente  
- **Shift:** Correr  
- **Espaço:** Pular  
- **E:** Coletar itens

### 2.4 Mecânicas Observadas no Build
- Movimento e corrida responsivos.  
- Pulso simples, permitindo saltos precisos.  
- Coleta de cristais que incrementam pontuação e aparecem no HUD.  
- Checkpoints em fase 3, posicionados em plataformas móveis.

### 2.5 Fases no Build
- **Fase 1 (Tutorial):** Plataforma estática sem inimigos.  
- **Fase 2 (Obstáculos Móveis):** Plataformas que se movem verticalmente e horizontalmente.  
- **Fase 3 (Checkpoint):** Inclusão de pontos de salvamento e desafios de plataforma dinâmicos.

### 2.6 Licença
[MIT License](LICENSE.md)

---

## 3. Documentação Interna (fonte planejada)

### 3.1 Game Design Document (GameDesignDocument.md)

- **Narrativa:** Personagem navega por ambientes repletos de estrelas e plataformas móveis.  
- **Mapas de Fase:** Diagrama das quatro fases, indicando spawn de itens e localização de checkpoints.  
- **Mecânicas:** Parâmetros ajustados (velocidade = 5 unidades/s, força de pulo = 7 unidades).

### 3.2 Design Técnico (TechnicalDesign.md)
- **Scripts Planejados:** `PlayerController.cs`, `CheckpointManager.cs`, `Collectible.cs`, `AudioManager.cs`.  
- **Componentes Unity:** Rigidbody2D, Collider2D, Animator Controller, Tilemap.  
- **Build Pipeline:** Configurações de Player Settings para Windows Standalone.

### 3.3 Plano de Testes (TestPlan.md)
- **Testes de Jogabilidade:**  
  - Andar e correr em diversas plataformas.  
  - Saltos em bordas (garantir `isGrounded` antes de pular).  
  - Coleta de itens e atualização imediata do HUD.  
  - Validação de checkpoints (retorno ao checkpoint após queda).  
- **Enviroment Test:** Garantir que o executável não gere erros no Windows 10/11.

---

## 4. Versionamento no GitHub (planejamento)

- **Branch `main`:** código-fonte estável (build atual).  
- **Branches de feature:** `feature/<nome>`, ex: `feature/collectibles`.  
- **Commits:** estilo `feat: adicionar coleta de itens`.  
- **Pull Requests:** revisar alterações antes de merge em `main`.

---

## 5. Próximos Passos

1. Obter o projeto-fonte Unity para inclusão em `/Assets` e scripts originais.  
2. Preencher a documentação interna com diagramas e detalhes de implementação.  
3. Automatizar builds via GitHub Actions.  
4. Atualizar README com badges de build e cobertura de testes.

---

*Este guia foi atualizado para refletir os arquivos do build disponíveis na pasta "Projeto Plataforma Unifecaf" e planejar a inclusão do código-fonte no repositório.*

```
