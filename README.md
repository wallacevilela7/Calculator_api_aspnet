# API de Operações Matemáticas Básicas

Bem-vindo ao projeto da API de Operações Matemáticas Básicas! Esta API, desenvolvida com ASP.NET 8, oferece operações matemáticas básicas por meio de endpoints simples e eficientes.

## Endpoints Disponíveis

### 1. Adição
- **Endpoint:** `/api/calculadora/adicao`
- **Método:** `GET`
- **Parâmetros de Consulta:**
  - `numero1` (float): O primeiro número.
  - `numero2` (float): O segundo número.
- **Exemplo de Requisição:**
  ```
  GET /api/calculadora/adicao?numero1=5&numero2=10
  ```
- **Exemplo de Resposta:**
  ```
  {
    "resultado": 15
  }
  ```

### 2. Subtração
- **Endpoint:** `/api/calculadora/subtracao`
- **Método:** `GET`
- **Parâmetros de Consulta:**
  - `numero1` (float): O primeiro número.
  - `numero2` (float): O segundo número.
- **Exemplo de Requisição:**
  ```
  GET /api/calculadora/subtracao?numero1=10&numero2=5
  ```
- **Exemplo de Resposta:**
  ```
  {
    "resultado": 5
  }
  ```

### 3. Multiplicação
- **Endpoint:** `/api/calculadora/multiplicacao`
- **Método:** `GET`
- **Parâmetros de Consulta:**
  - `numero1` (float): O primeiro número.
  - `numero2` (float): O segundo número.
- **Exemplo de Requisição:**
  ```
  GET /api/calculadora/multiplicacao?numero1=5&numero2=10
  ```
- **Exemplo de Resposta:**
  ```
  {
    "resultado": 50
  }
  ```

### 4. Divisão
- **Endpoint:** `/api/calculadora/divisao`
- **Método:** `GET`
- **Parâmetros de Consulta:**
  - `numero1` (float): O primeiro número.
  - `numero2` (float): O segundo número (não pode ser zero).
- **Exemplo de Requisição:**
  ```
  GET /api/calculadora/divisao?numero1=10&numero2=2
  ```
- **Exemplo de Resposta:**
  ```
  {
    "resultado": 5
  }
  ```

### 5. Média
- **Endpoint:** `/api/calculadora/media`
- **Método:** `GET`
- **Parâmetros de Consulta:**
  - `numeros` (array de floats): Lista de números para calcular a média.
- **Exemplo de Requisição:**
  ```
  GET /api/calculadora/media?numeros=10,20,30,40,50
  ```
- **Exemplo de Resposta:**
  ```
  {
    "resultado": 30
  }
  ```

### 6. Raiz Quadrada
- **Endpoint:** `/api/calculadora/raizquadrada`
- **Método:** `GET`
- **Parâmetros de Consulta:**
  - `numero` (float): O número para calcular a raiz quadrada (deve ser maior ou igual a zero).
- **Exemplo de Requisição:**
  ```
  GET /api/calculadora/raizquadrada?numero=25
  ```
- **Exemplo de Resposta:**
  ```
  {
    "resultado": 5
  }
  ```
