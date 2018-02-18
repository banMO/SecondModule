var Total_secs;
var Total_min;
var cronometer;

var total_lives;
var total_coins;

var board = new Array(8); 

var mario_x = 0;
var mario_y = 0;

var mario_ang = 0;

/*
function selectCell(){
	board[x][y] = 1;
	paintCell(x, y, "green");
	paintHorseCell(x, y, "green");
}

var Cellselected_x = x;
var Cellselected_y = y;
function checkCell(x, y){ // funcion que se pasa dos ccordenadas
	selectCell(x, y);
}
*/
function autoplay() {

	//alert("hola");
	for(var i = 0; i<8 ; i++){
		board[i] = new Array(8);//matriz de 8x8	
	}

	resetTime();
	startTime();

	resetCoins();
	calculateCoins(400);

	resetLives();
	calculateLives(2, "suma");

	x = Math.round(Math.random()*7); //numero aleatorio de 0 a7
	y = Math.round(Math.random()*7);

	//selectCell(x,y);

}

autoplay();