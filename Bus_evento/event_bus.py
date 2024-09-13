class EventBus:
    def __init__(self):
        self._subscribers = {}

    def subscribe(self, event_type, callback):
        if event_type not in self._subscribers:
            self._subscribers[event_type] = []
        self._subscribers[event_type].append(callback)

    def unsubscribe(self, event_type, callback):
        if event_type in self._subscribers:
            self._subscribers[event_type].remove(callback)

    def publish(self, event_type, data):
        if event_type in self._subscribers:
            for callback in self._subscribers[event_type]:
                callback(data)


# Eventos de ejemplo
def on_user_registered(data):
    print(f"Usuario registrado: {data['name']}")

def on_order_placed(data):
    print(f"Orden realizada: {data['order_id']}, Total: {data['total']}")


# Crear el bus de eventos
event_bus = EventBus()

# Suscribirse a los eventos
event_bus.subscribe('user_registered', on_user_registered)
event_bus.subscribe('order_placed', on_order_placed)

# Publicar eventos
event_bus.publish('user_registered', {'name': 'Fabian Osorio'})
event_bus.publish('order_placed', {'order_id': 'A123', 'total': 2500})
