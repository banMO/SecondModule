function CreateList(name, sizeList) {
    return {
            name: name,
            sizeList: sizeList,
            list: [],
            AddTask: function (id, title, description) {

                if(this.list.length < this.sizeList)
                {
                    var task = {
                        id: id,
                        title: title,
                        description: description,
                        state: "Created"
                    }
                    this.list.push(task)    
                }
                else
                {
                    console.log("The list is full")
                }
            },

            DeleteTask: function(id){
                
                var task = this.FindTask(id)
                this.list.splice(this.list.indexOf(task))
                console.log("DELETE")
            },

            FindTask: function(id){
                for(i = 0; i < this.list.length; i++)
                {
                    var auxTask = this.list[i]
                    if(auxTask.id == id)
                    {
                        return auxTask
                    }
                }
            },

            ReziseList: function(newSize){
                this.sizeList = newSize
            },

            ChangeState(id, newState){

                this.state = newState
            },

            Show(){
                this.list.forEach(function (elemento, indice, array) {
                console.log(elemento, indice);
                });
            }
        }
}

var newL = CreateList("First", 2)
console.log(newL.name)
newL.AddTask(1, "Breakfast", "With friens")
console.log(newL.list.length)
newL.AddTask(2, "Breakfast", "en la cafeteria desde la ma;na")
console.log(newL.list.length)
newL.DeleteTask(1)
newL.Show()
console.log(newL.list.length)
newL.ReziseList(100)
newL.AddTask(2, "Breakfast", "en la cafeteria desde la ma;na")
console.log(newL.sizeList)
newL.Show()