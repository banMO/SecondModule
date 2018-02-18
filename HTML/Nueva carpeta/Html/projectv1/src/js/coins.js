function resetCoins(){
	total_coins = 0;
}

function calculateCoins(points){
	c = document.getElementById("coins");
	total_coins += points;
	c.innerHTML = total_coins;
}