import socket

# Crear un socket para el servidor
server_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

# Enlazar el socket a una dirección IP y puerto
server_socket.bind(('localhost', 8080))  # Asegúrate de que 'localhost' y el puerto estén bien

# Poner al servidor en modo de escucha para aceptar conexiones
server_socket.listen(1)
print("Servidor a la espera de conexiones...")  # Este mensaje debería aparecer aquí

# Aceptar la conexión de un cliente
connection, address = server_socket.accept()  # El servidor se bloquea aquí hasta que un cliente se conecte
print(f"Conexión establecida con {address}")

# Recibir datos del cliente
data = connection.recv(1024).decode('utf-8')
print(f"Mensaje del cliente: {data}")

# Enviar una respuesta al cliente
connection.send("¡Hola desde el servidor!".encode('utf-8'))

# Cerrar la conexión
connection.close()
server_socket.close()

