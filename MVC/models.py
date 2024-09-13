# models.py

class TaskModel:
    def __init__(self):
        self.tasks = ["Tarea 1", "Tarea 2", "Tarea 3"]

    def get_tasks(self):
        return self.tasks

    def add_task(self, task):
        self.tasks.append(task)
    