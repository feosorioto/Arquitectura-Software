import socket

# Crear un socket para el cliente
client_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

# Conectar el cliente al servidor
client_socket.connect(('localhost', 8080))  # Asegúrate de que la IP y el puerto coincidan con los del servidor

# Enviar un mensaje al servidor
client_socket.send("¡Hola desde el cliente!".encode('utf-8'))

# Recibir la respuesta del servidor
response = client_socket.recv(1024).decode('utf-8')
print(f"Respuesta del servidor: {response}")

# Cerrar la conexión
client_socket.close()
