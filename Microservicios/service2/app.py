from flask import Flask, jsonify

app = Flask(__name__)

@app.route('/service2', methods=['GET'])
def get_data():
    data = {"message": "Hello from Service 2"}
    return jsonify(data), 200

if __name__ == '__main__':
    app.run(port=5002)
