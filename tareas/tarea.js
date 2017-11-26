function reduce(arr, num, callback)
{
    var aux = 0
    aux += num
    arr.forEach((el, index)=>{
        aux += callback(arr[index])
    })
    return aux  
}

reduce([1, 2, 4, 5], 15, (el, index, arr) =>{
    console.log(el, index, arr)
        return el
})
