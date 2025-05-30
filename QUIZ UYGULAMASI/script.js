let score = 0;
let currentQuestion;

// İşlem türleri ve karşılık gelen hesaplamalar
const operations = [
    { symbol: '+', calc: (a, b) => a + b },
    { symbol: '-', calc: (a, b) => a - b },
    { symbol: '*', calc: (a, b) => a * b },
    { symbol: '/', calc: (a, b) => (a / b).toFixed(2) }
];

function generateQuestion() {
    const num1 = Math.floor(Math.random() * 10) + 1;
    const num2 = Math.floor(Math.random() * 10) + 1;
    const op = operations[Math.floor(Math.random() * operations.length)];

    const questionText = `${num1} ${op.symbol} ${num2} = ?`;
    const correctAnswer = op.calc(num1, num2);

    currentQuestion = { questionText, correctAnswer };
    document.getElementById('question').textContent = questionText;
}

function checkAnswer() {
    const userAnswer = parseFloat(document.getElementById('answer').value);
    const correct = parseFloat(currentQuestion.correctAnswer);
    const resultDiv = document.getElementById('result');

    if (userAnswer === correct) {
        score++;
        resultDiv.textContent = 'Doğru Cevap!';
    } else {
        resultDiv.textContent = `Yanlış Cevap! Doğru cevap: ${correct}`;
    }

    document.getElementById('score').textContent = score;
    document.getElementById('answer').value = '';
    generateQuestion();
}

window.onload = generateQuestion;
