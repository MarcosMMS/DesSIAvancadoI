import xmlrpc.client

# Cria um proxy que se conecta ao servidor RPC em execução no endereço "localhost" na porta 8000.
proxy = xmlrpc.client.ServerProxy("http://localhost:8000/")

# Realiza chamadas de procedimento remoto (RPC) para as funções registradas no servidor.
# Cada chamada aqui é feita como se a função estivesse sendo executada localmente, mas, na verdade, ela é executada no servidor.

# Chama a função 'add' remotamente, que soma os valores 10 e 5.
print("Soma: 10 + 5 =", proxy.add(10, 5))

# Chama a função 'subtract' remotamente, que subtrai 5 de 10.
print("Subtração: 10 - 5 =", proxy.subtract(10, 5))

# Chama a função 'multiply' remotamente, que multiplica 10 por 5.
print("Multiplicação: 10 * 5 =", proxy.multiply(10, 5))

# Chama a função 'divide' remotamente, que divide 10 por 5.
print("Divisão: 10 / 5 =", proxy.divide(10, 5))

# Tenta dividir 10 por 0, o que resultará em um erro tratado pelo servidor.
print("Divisão por zero: 10 / 0 =", proxy.divide(10, 0))