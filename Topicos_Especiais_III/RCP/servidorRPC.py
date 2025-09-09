from xmlrpc.server import SimpleXMLRPCServer

# Função que realiza a soma de dois números.
def add(x, y):
    return x + y

# Função que realiza a subtração de dois números.
def subtract(x, y):
    return x - y

# Função que realiza a multiplicação de dois números.
def multiply(x, y):
    return x * y

# Função que realiza a divisão de dois números, com tratamento para divisão por zero.
def divide(x, y):
    if y == 0:
        return "Erro: Divisão por zero"
    return x / y

# Cria um servidor RPC que escuta no endereço 'localhost' e na porta 8000.
server = SimpleXMLRPCServer(("localhost", 8000))
print("Servidor RPC aguardando requisições...")

# Registra as funções que estarão disponíveis para chamadas remotas.
server.register_function(add, "add")
server.register_function(subtract, "subtract")
server.register_function(multiply, "multiply")
server.register_function(divide, "divide")

# Mantém o servidor em execução, aguardando novas requisições indefinidamente.
server.serve_forever()