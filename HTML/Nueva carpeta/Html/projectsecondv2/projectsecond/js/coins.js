function resetCoins(){
	total_coins = 0;
	c = document.getElementById("coins");
	c.innerHTML = total_coins;
}

function calculateCoins(points){
	c = document.getElementById("coins");
	total_coins += points;
	c.innerHTML = total_coins;
}