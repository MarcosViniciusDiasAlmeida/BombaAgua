# Sistema de Controle de Reservatório de Água

## O que foi utilizado:
- **Linguagem C#**: A linguagem principal usada para o desenvolvimento do sistema.
- **Classe `Random`**: Utilizada para gerar números aleatórios que simulam o nível de água e possíveis falhas nas boias.
- **Estruturas de controle**:
  - `if-else` para verificar o nível de água e tomar decisões automáticas.
  - `Console.ReadLine()` para captar a entrada do usuário na etapa de controle manual.
- **Variáveis**:
  - `nivelAgua`: Armazena o nível atual do reservatório (de 0% a 100%).
  - `bombaLigada`: Indica se a bomba está ligada (`true`) ou desligada (`false`).
  - `ciclosBomba`: Contador que monitora quantas vezes a bomba foi ligada.
  - `erroBoias`: Simula a chance de falha no sistema das boias.

## Etapas implementadas:
1. **Geração do nível de água**:
   - O programa gera um nível de água aleatório para o reservatório, variando entre 0% e 100%.

2. **Verificação das boias**:
   - **Boia A** é acionada quando o nível de água é baixo (<= 20%) e liga a bomba automaticamente.
   - **Boia B** é acionada quando o nível de água é alto (>= 80%) e evita que a bomba seja ligada.
   - Nível intermediário (21% a 79%) mantém a bomba desligada.

3. **Simulação de erro nas boias**:
   - Um erro pode ser gerado aleatoriamente (20% de chance), simulando a necessidade de manutenção no sistema de boias.

4. **Controle manual**:
   - Se não houver erro, o usuário é solicitado a ligar ou desligar a bomba manualmente, ou manter seu estado atual.

5. **Atualização do estado da bomba**:
   - Dependendo das condições ou da entrada do usuário, o programa atualiza o estado da bomba e exibe o número de ciclos que ela foi acionada.

## Backlog:
- **Registro de histórico**:
  - Implementar um sistema que registre o histórico de níveis de água, ciclos da bomba, e possíveis falhas.
  
- **Alertas e notificações**:
  - Incluir mensagens de alerta caso o reservatório atinja um nível crítico de água.

- **Melhoria no sistema de falha**:
  - Expandir o sistema de erro das boias para identificar falhas específicas, como falha na boia A ou B separadamente.

- **Interface gráfica**:
  - Evoluir o sistema de console para uma interface gráfica para monitoramento em tempo real.

- **Monitoramento remoto**:
  - Adicionar funcionalidades de controle remoto para ligar/desligar a bomba via um aplicativo ou web.

## Conclusão:
O código atual implementa um sistema básico de controle de um reservatório de água, usando condições automáticas baseadas no nível da água e permitindo o controle manual da bomba. Foi incluída uma simulação de erros no sistema de boias para garantir a detecção de falhas.

O sistema pode ser expandido para adicionar mais funcionalidades, como registro de histórico e interface gráfica, melhorando a usabilidade e o monitoramento do reservatório.

