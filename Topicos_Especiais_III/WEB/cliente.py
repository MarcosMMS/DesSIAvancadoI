import asyncio
import websockets

# Função principal responsável por se comunicar com o servidor WebSocket.
async def communicate():
    # Estabelece uma conexão com o servidor WebSocket no endereço ws://localhost:8765.
    async with websockets.connect("ws://localhost:8765") as websocket:
        print("Conectado ao servidor WebSocket")

        # Envia uma mensagem ao servidor solicitando a operação de soma (10 + 5).
        message = "soma 10 5"
        print(f"Enviando: {message}")
        await websocket.send(message)  # A função `send` envia a mensagem ao servidor.

        # Aguarda e recebe a resposta do servidor.
        response = await websocket.recv()
        print(f"Resposta do servidor: {response}")

        # Envia uma segunda mensagem solicitando a operação de subtração (10 - 5).
        message = "subtracao 10 5"
        print(f"Enviando: {message}")
        await websocket.send(message)

        # Aguarda e recebe a resposta da operação de subtração.
        response = await websocket.recv()
        print(f"Resposta do servidor: {response}")

# Inicia a execução do cliente chamando a função `communicate` usando a biblioteca asyncio.
asyncio.run(communicate())