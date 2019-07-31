var mainDiv = document.getElementById('mainDiv');
var screen = document.createElement('div');
screen.className = 'screen';
screen.innerText = 0;
mainDiv.appendChild(screen);

var firstNumber = 0;
var secondNumber = 0;
var sun = 0;
var Operator = '';


var btns = [7, 8, 9, 'C', 4, 5, 6, '/', 1, 2, 3, 'x', '.', 0, '+', '-', '=']
for (var i = 0; i < btns.length; i++)

{
    var btn = document.createElement('div');
    btn.className = 'button';
    btn.id = 'btn' + btns[i];
    btn.innerText = btns[i];
    mainDiv.appendChild(btn);


    if (btns[i] >= 0) {
        btn.classList.add('number')
    } else if (btns[i] === '+' || btns[i] === '-' || btns[i] === 'x' || btns[i] === '/') {
        btn.classList.add('operator');
    } else if (btns[i] === 'C') {
        btn.classList.add('update');

    } else if (btns[i] === '=') {
        btn.classList.add('equals');

    } else {
        btn.classList.add('colon');

    }

}

// Update.click

var Update = document.querySelector('.update');
Update.addEventListener('click', function () {
    screen.innerText = 0;
    secondNumber = 0;
    firstNumber = 0;
    Operator = '';
    sun = 0;
})



// btnNumber click

var btnNumber = document.querySelectorAll('.number');

for (var i = 0; i < btnNumber.length; i++) {

    btnNumber[i].addEventListener('click', function () {

        if (screen.innerText == 0 || screen.innerText == '' ) {

            screen.innerText = this.innerText;
        } else {
            screen.innerText += this.innerText;
        }
    })
}

// btnOperator click

var btnOperator = document.querySelectorAll('.operator');

for (var j = 0; j < btnOperator.length; j++) {

    btnOperator[j].addEventListener('click', function () {
        firstNumber = parseFloat(screen.innerText);
        Operator = this.innerText;
        screen.innerText = '';
        console.log(firstNumber + " " + Operator)

    })
}

// // colonClick

// var Colon = document.querySelector('.colon');

// Colon.addEventListener('click',function(){
//     screen.innerText+=this.innerText;
// })

// Equals click

// var Equals = document.querySelector('.equals');

// Equals.addEventListener('click', function () {

// })


var Equals = document.querySelector('.equals');

Equals.addEventListener('click', function () {

    if (firstNumber != 0 && screen.innerText != '' && Operator != '') {

        if (Operator === '+') {
            
            screen.innerText = parseFloat(firstNumber) + parseFloat(screen.innerText);
            sun = screen.innerText;
            firstNumber=sun;
            Operator='';
        } 

        else if(Operator === '-') {
            secondNumber = screen.innerText;
            screen.innerText = parseFloat(firstNumber) - parseFloat(screen.innerText);
            sun = screen.innerText;
            firstNumber = sun;
            Operator='';
        } 
        
        else if(Operator === 'x') {
            secondNumber = screen.innerText;
            screen.innerText = parseFloat(screen.innerText) * parseFloat(firstNumber);
            sun = screen.innerText;
            firstNumber = sun;
            Operator='';
        } 
        
        else if(Operator === '/' ) {
            secondNumber = screen.innerText;
            screen.innerText = parseFloat(firstNumber) / parseFloat(screen.innerText);
            firstNumber = sun;
            sun = screen.innerText;
            Operator='';
        } 

       
        else {
            alert('emeliyyatda xeta var basdan birde yoxla ');

        }
    }
})