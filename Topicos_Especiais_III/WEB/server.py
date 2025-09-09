import asyncio
import websockets

# Função que lida com a comunicação com o cliente. O servidor WebSocket recebe e processa as mensagens enviadas pelo cliente.
async def handle_client(websocket):
    print("Cliente conectado")
    try:
        while True:
            # Aguarda a mensagem do cliente.
            message = await websocket.recv()
            print(f"Mensagem recebida: {message}")

            # Tenta dividir a mensagem em operação, num1 e num2.
            try:
                op, num1, num2 = message.split()  # Divide a mensagem em partes: operação, número 1 e número 2.
                num1 = int(num1)  # Converte num1 para inteiro.
                num2 = int(num2)  # Converte num2 para inteiro.

                # Verifica qual é a operação solicitada e calcula o resultado.
                if op == "soma":
                    result = num1 + num2
                elif op == "subtracao":
                    result = num1 - num2
                elif op == "multiplicacao":
                    result = num1 * num2
                elif op == "divisao":
                    if num2 != 0:
                        result = num1 / num2
                    else:
                        result = "Erro: divisão por zero"
                else:
                    result = "Operação inválida"

                # Envia o resultado da operação de volta ao cliente.
                await websocket.send(f"Resultado: {result}")
            except ValueError:
                # Caso a mensagem esteja em formato inválido, envia uma mensagem de erro ao cliente.
                await websocket.send("Formato inválido. Use: <operacao> <num1> <num2>")
    except websockets.ConnectionClosed:
        print("Cliente desconectado")

# Função principal que inicializa o servidor WebSocket na porta 8765.
async def main():
    # O servidor é configurado para aceitar conexões no endereço 'localhost' e porta 8765.
    async with websockets.serve(handle_client, "localhost", 8765):
        print("Servidor WebSocket aguardando conexões...")
        await asyncio.Future()  # Mantém o servidor em execução.

# Inicia o servidor chamando a função `main` usando a biblioteca asyncio.
asyncio.run(main())