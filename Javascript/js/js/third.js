//clave y valor
//no implementa clases y la hernecnia esta basada en prototipos
//solo puedes tener un prototype
var person = 
{
	sayHi(){
		console.log('hi')
	},
	sayBye()
	{
		console.log('Bye')
	}
}
var pedro = {
	name: "pedro",
	age: 30

}

Object.setPrototypeOf(pedro, person)
pedro.sayBye()
pedro.__proto__
Object.getPrototypeOf(pedro)

function PersonFactory(name){
	return{
		name,
		sayHi(){
			console.log('Hi')
		}
	}
}
//ES5 -Constructor functions
function Person(name){
	this.name = name,
	this.sayHi = function(){
		console.log('Hi')
	}
}
var pedro = new Person('Pedro')
var raul = new Person('Raul')
var ilsen = new Person('Ilsen')
///
function Person(name){
	this.name = name
}
Person.prototype.sayHi = function(){
		console.log('Hi')
	}
var pedro = new Person('Pedro')
var raul = new Person('Raul')
var ilsen = new Person('Ilsen')
///
function Person(name){
	this.name = name
}
Person.prototype = {
	sayHi: function(){
		console.log('Hi')
	}
}

Person.someStaticVAlue = 'XD'
function Employee(name, salary){
	this.salary = salary
	Person.call(this, name)
}
Employee.prototype.pay = function(){
  
}
var pedro = new Person('Pedro')
var raul = new Person('Raul')
var ilsen = new Person('Ilsen')

//ES6 classes
class Person{
	constructor(name)//atributos dentro del constructor
	{
		this.name = name
		this.sayBye = function(){
		}
	}

	sayHi(){
		console.log('HI')
	}
}
Person.someStaticValue = 'XD'
var pedro = new Person('Pedro')
var raul = new Person('Raul')
var ilsen = new Person('Ilsen')


class Person {
	constructor(name)
	{
		this.name = name
		this.sayBye = function(){
		}
	}

	sayHi(){
		console.log('HI')
	}
}
Person.someStaticValue = 'XD'
function Employee(salary){
	this.salary = salary
}
var pedro = new Person('Pedro')

Employee.prototype = Object.create(Person.prototype)
Employee.Constructor = Employee