function CreateList(name, sizeList) {
	return {
		name: name,
		name: sizeList,
		contenedor: [],
		sayHi: function () {
			console.log('I am ' + this.name)
		}
	}
}