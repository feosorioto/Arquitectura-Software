# app.py

from flask import Flask, render_template, request, redirect
from models import TaskModel

app = Flask(__name__)
model = TaskModel()

@app.route('/')
def index():
    tasks = model.get_tasks()
    return render_template('index.html', tasks=tasks)

@app.route('/add', methods=['POST'])
def add_task():
    new_task = request.form.get('task')
    if new_task:
        model.add_task(new_task)
    return redirect('/')

if __name__ == '__main__':
    app.run(debug=True)
