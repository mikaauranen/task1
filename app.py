from flask import Flask

app = Flask(__name__)

@app.route('/')
def hello_world():
    return '<p>Terve ja heipä hei.</p>'

if __name__ == '__main__':
    app.run()
