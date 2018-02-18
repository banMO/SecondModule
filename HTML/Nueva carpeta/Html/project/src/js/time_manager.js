function resetTime()
{
	clearInterval(cronometer);
}
function startTime() {
	seconds = 0;
	s = document.getElementById("sec"); //devuelve la varibale sec coen s
	m = document.getElementById("min");

	cronometer = setInterval(function(){
		seconds ++;	

		secs = seconds;
		mins = 0;
		while( secs >= 60){
			mins ++;
			secs -= 60;
		}

		if(mins < 10) m.innerHTML = "0" + mins
	    else m.innerHTML = mins;
		if(secs < 10) s.innerHTML = "0" + secs
		else s.innerHTML = secs;

		Total_secs = secs;
		Total_mins = mins;

	},1000);//funciona  a ejecutar 1000s
	//s.innerHTML = "50";// primero borra s y escribe 50
	//m.innerHTML = "02";
}