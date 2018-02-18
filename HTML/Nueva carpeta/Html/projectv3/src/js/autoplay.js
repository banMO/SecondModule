var Total_secs;
var Total_min;
var cronometer;
var cronometerObjects;
var total_lives;
var total_coins;

var board = new Array(8);

var mario = document.getElementById('mario');

var mario_x = 0;
var mario_y = 0;
var mario_state = 'none'
var mario_ang = 0;
var Total_secs_obj ;
var Total_mins_obj ;


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

document.onkeydown = movMario;
document.onkeyup = stopAnimation;



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

	resetTimeObjects()
	startTimeObjects();



	x = Math.round(Math.random()*7); //numero aleatorio de 0 a7
	y = Math.round(Math.random()*7);

	//selectCell(x,y);

}

autoplay();
