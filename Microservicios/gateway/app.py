import requests
from flask import Flask, jsonify

app = Flask(__name__)

@app.route('/gateway/service1', methods=['GET'])
def proxy_service1():
    response = requests.get('http://localhost:5001/service1')
    return jsonify(response.json()), response.status_code

@app.route('/gateway/service2', methods=['GET'])
def proxy_service2():
    response = requests.get('http://localhost:5002/service2')
    return jsonify(response.json()), response.status_code

if __name__ == '__main__':
    app.run(port=5000)
