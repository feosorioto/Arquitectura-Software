from flask import Flask, jsonify

app = Flask(__name__)

@app.route('/service1', methods=['GET'])
def get_data():
    data = {"message": "Hello from Service 1"}
    return jsonify(data), 200

if __name__ == '__main__':
    app.run(port=5001)
