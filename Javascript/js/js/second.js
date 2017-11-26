//elementos de programacion funcional ->los programas limpios no con muchos estados variables no muten
//scala funciones sean como objetos
//estilo mas declarativo que imperativo
//IMPERATIVO
for (let i = 0; i < 10; i++)
{
	//...
}

//DECLARATIVO que queremos que haga
const arr = [1, 2, 3]
arr.forEach(function (el){
	console.log(el)
})
//currying //partial application
calculate(sum(getNumber()))
//FUNCION PURA
function doSomething(x)
{
	return  x * 10
}

//FUNCION NO PURA
var person = { name: 'JOrge'}
function doSomething(x)
{
	person.age = x
}

const arr1 = [1, 2, '',true, function(){}]
const arr1 = new Array()
arr1.push()
arr1.slice()
arr1.unshift()

const arr2 = [1,2,3,4]
arr2.forEach(el, index, arr)
arr2.forEach(el => console.log('el', el))
const arr2 = [1,2,3,4]
arr2.find(el => el === 33)
arr2.map(el => el ===3)
 const bb = arr2.map(el => ({n: el}))
 //pares
 const even = arr2.filter(el => el % 2 ===0)
 //numeros mayores que cero TODOS
 const biggerThanCero = arr2.every(el => el >0)//devuelve true or false
 //algunos
 arr2.some(el => el >3)
 const arr2 = [1,2,3,4]
 arr2.reduce((curr, next )=> curr += next)

 //argumento extra
 const arr2 = [1, 2, 3, 4, 5]
  arr2.reduce((curr, next )=> curr += next, 100)

arr2.//son concatenables

const arr2 = [1, 2, 3, 4, 5]
function filter(arr, cb)
{
	var aux = []
	arr.forEach(el, index ) =>{
		var res = cd(el, index, arr)
        if(res)
        {
        	aux.push(el)
        }
	}
	return cd;
}

function some(arr, cb)
{
	for(let i = 0)
}
function map(arr)
function a(n)
{
	if(n % 2 === 0)
		return true
	else
		return false
}

function map(){

}
filter([1,2,3,4,5], (el, index, arr) =>){
	console.log(el, index, arr)
	return el% 2 !==0
})

//reduce emular todo 