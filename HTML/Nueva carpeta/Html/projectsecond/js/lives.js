function resetLives() {
	total_lives = 0;
}

function calculateLives(live,type){
	if( type == "suma"){
		total_lives += live;
	}else{
		total_lives -= live;
	}
	
	l = document.getElementById("lives")
	l.innerHTML = total_lives;
}