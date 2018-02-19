function resetTimeObjects()
{
	clearInterval(cronometerObjects);
}
function startTimeObjects() {
	objseconds = 0;

	cronometer = setInterval(function(){
		objseconds ++;	

		objsecs = objseconds;
		objmins = 0;
		while( objsecs >= 60){
			objmins ++;
			objsecs -= 60;
		}

		Total_secs_obj = objsecs;

		if(Total_secs_obj == 5){
			createObject("tube");
		}
		if(Total_secs_obj == 7){
			createObject("tube_large");
		}
		Total_mins_obj = objmins;

	},1000);//funciona  a ejecutar 1000s
	//s.innerHTML = "50";// primero borra s y escribe 50
	//m.innerHTML = "02";
}

function createObject(nameObject){
		var newObject = document.createElement("div");
		newObject.setAttribute("class",nameObject);
		document.getElementById('page').appendChild(newObject);
		console.log('created');
}
