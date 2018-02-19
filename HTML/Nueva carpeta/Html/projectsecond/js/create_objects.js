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
		if(Total_secs_obj%5 == 0){
			createObject("enemies5");
		}
		if(Total_secs_obj%7 == 0){
			createObject("enemies1");
		}
		if(Total_secs_obj%10 == 0){
		 	createObject("enemies4");
		}		
		Total_mins_obj = objmins;
		if(Total_secs_obj%2 == 0){
			createObject("objcoins");
		}
		if(Total_secs_obj%2 == 0 && duration_animate > 200){
			duration_animate -= 200;
		}

	},1000);
}

function createObject(nameObject){
		//x = Math.round(Math.random()*); //numero aleatorio de 0 a7

		main_y = Math.round(Math.random()*90);
		let y = Math.round(Math.random()*70);
		for(let i = 0; i<5 ; i++){

			var newObject = document.createElement("div");
			newObject.setAttribute("class",nameObject);
			if(y < 80){
				newObject.style.top = `${y+=5}%`;
			}
			
			document.getElementById('page').appendChild(newObject);
			newObject.animate([
				  {right: '0%',
				  	top: `${y}%`
					},
				/*  {
				 	right: '50%',
				 	top: `${main_y}%`
				  },*/
				  {right: '100%',
				  	top: `${y}%`}
				 ], { 
				  // timing options
				  duration: duration_animate,
				  iterations: 1},
				  function(){
				  	console.log("hola mundo");
				  	newObject.remove();
				  } 
				);
			if(nameObject == 'objcoins'){
				console.log("push coin")
				coins.push(newObject);
			}else{
			   enemies.push(newObject);
			}
		}
}
