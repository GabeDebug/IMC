# 📊 Calculadora de IMC - C#

Aplicação de console desenvolvida em C# para cálculo do **IMC (Índice de Massa Corporal)** com classificação automática conforme os padrões da Organização Mundial da Saúde (OMS).

---

## 📌 Sobre o Projeto

O programa solicita:

- Altura (em metros)
- Peso (em kg)

Em seguida:

- Calcula o IMC
- Exibe o valor arredondado para 2 casas decimais
- Mostra a classificação correspondente

---

## 🧮 Fórmula Utilizada

IMC = peso / (altura × altura)

---

## 📋 Classificação Utilizada

| IMC | Classificação |
|------|--------------|
| < 16 | Magreza grave |
| 16 – 16.9 | Magreza moderada |
| 17 – 18.4 | Magreza leve |
| 18.5 – 24.9 | Peso normal |
| 25 – 29.9 | Sobrepeso |
| 30 – 34.9 | Obesidade Grau I |
| 35 – 39.9 | Obesidade Grau II |
| ≥ 40 | Obesidade Grau III |

---

## ⚙️ Tecnologias Utilizadas

- C#
- .NET Console Application
- `System.Globalization` para padronização de leitura decimal

---

## 🚀 Como Executar

1. Clone o repositório:

´´
git clone https://github.com/GabeDebug/IMC

´´

2. Acesse a pasta do projeto:

3. Execute:

- Dotnet run


---

## 📥 Entrada Esperada

- Altura em metros (ex: `1.70`)
- Peso em quilogramas (ex: `80`)

> O programa utiliza `CultureInfo.InvariantCulture`, portanto utilize **ponto (.)** como separador decimal.

---

## 🖥 Exemplo de Uso

---
Qual e a sua altura?
1.70
Qual e seu peso?
80
Classificação: Sobrepeso 27.68


---

## 🎯 Objetivo do Projeto

Projeto criado para prática de:

- Estruturas condicionais (`if / else`)
- Manipulação de tipos numéricos (`double`)
- Formatação de saída (`{valor:F2}`)
- Uso de `CultureInfo`
- Estrutura básica de aplicação console em C#

---

## 📚 Possíveis Melhorias Futuras

- Validação com `double.TryParse`
- Separação da lógica em métodos
- Interface gráfica
- Testes unitários
- Versão web com ASP.NET

---

## 👨‍💻 Autor

Desenvolvido para fins de estudo e prática em C#.