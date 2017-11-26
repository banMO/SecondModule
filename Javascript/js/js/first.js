//BASICS
//ES5
var myNumber = 1214 //scope por funcion
myNumber = true 

//ES6
let myString = ':(' //scope por bloque
const myBoolean = false  //no cambian referncia array por referencia 

//hoisting como funciona el interprete de java script
//FUNCTION DECLARATION
function doSomething()
{
    if(true)
    {
        var a  = 123
    }
    console.log(a);
}
doSomething();

function sum(num1, num2)
{
    return num1 + num2
}
sum(10, 15)

const x = 'x'//por copia  fija la referencia
x = 'jjsjsjjs'

const a = []
a.push(a)

//FUNCTION EXPRESSION
var sum = function (num1, num2){//function como objetos funcion anonima
    return num1 + num2;
}




//named function expression 
var mysum = fucntion sum(num1, num2){
    //sum can be called
    return num1 + num2}

    mysum(3, 2);


//ARROW FUNCTION
var multiply = (a, b) =>{
    console.log('c')
    return a*b
}
var multiply  = (a, b) => a * b
var multiply = a => a* 100

function  calculate(cb, a, b){
    return cd(a, b)
}
calculate (multiply, 6, 8)


function divide(a){
    return function(b){
        return a /b
    }
}

var cd = divide(60)(6)
var cd = divide(60)
var a = cd(6)

//OBJECTS PLAIN-OBJECT, object-literal patrones para crear objetos ES5
//se puede crear objetos de la nada coleccion clave valor
var person = {
    name: 'RAUL',
    age: 10,
    sayHi: function(){
        console.log('I am' + this.name)
    }
    greet: fucntion()
    {
        this.sayHi()
    }
}

person.job = 'developer'
delete person.age

person['last-name'] = "gomez"

//factory function
function PersonaFactory(name, age){
    return {
        name: name
        age: age
        sayHi: function(){
            console.log('I am '+this.age)
        }
    }
}

var pedro = PersonaFactory('ilsen',20)



//object method shorthand
//object attribute shorthand
//computed  proterties
//https://developer.mozilla.org/en-US/docs/Learn/JavaScript/Objects/Basics