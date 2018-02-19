var Total_secs;
var Total_min;
var cronometer;
var cronometerObjects;
var total_lives;
var total_coins;

var board = new Array(8);

var mario_x = 0;
var mario_y = 0;
var mario_state = 'none'
var mario_ang = 0;
var Total_secs_obj ;
var Total_mins_obj ;
var background = document.getElementById('page');

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
var tube = new Array();
window.addEventListener("load", function(event) {
      	Ready();
});


function Ready() {
    var mario = document.getElementById('mario');
 		detectCollisions();
}
   var pr = true;
function detectCollisions(){
	//console.log('hola mundo');
//	console.log(tube);
	for(let i = 0 ; i < tube.length; i++){

		      var playerWidth = mario.offsetWidth;
          var playerHeight = mario.offsetHeight;
          var playerX = mario.offsetLeft;
          var playerY = mario.offsetTop;
          var tw = tube[i].offsetWidth;
          var th = tube[i].offsetHeight;
          var tx = tube[i].offsetLeft;
          var ty = tube[i].offsetTop;
          var result = window.getComputedStyle(mario,null).transform;
          var res = result.split(",")
          var resx = res[res.length-2].split(")");
          var res_x = parseInt(resx[0]);
          var resy = res[res.length-1].split(")");
          var res_y = parseInt(resy[0]);
        // console.log(res_x +"   " + res_y);
        //  console.log("mario:"+`${playerY-res_y}`);
        //  console.log(`tube: ${ty}`);

           if((res_x+playerWidth) > tx && (res_x+playerWidth) < (tx+tw) 
            && ((playerY-res_y) < (ty+th)))
           {
             mario_x -= 10;
             var mov_x = `translateX(${mario_x}px)`;
             mario.style.WebkitTransform = mov_x ;
             this.tube[i].style.animationPlayState = "paused";
             this.background.style.animationPlayState = "paused";
           }
           if((res_x) > (tx+tw) && (playerY-res_y) < (ty+th) && 
            (playerY-res_y+playerHeight) > ty)
           {
             this.tube[i].style.animationPlayState = "running";
             this.background.style.animationPlayState = "running";
           }
           if((res_x+playerWidth) >= tx && (res_x+playerWidth) <= (tx+tw)
            && (playerY-res_y) >= (ty+th))
           {
                mario_y = -(th);
                var mov = `translateY(${mario_y}) translateX(${mario_x})`;
                mario.style.WebkitTransform = mov ;
                this.tube[i].style.animationPlayState = "paused";
                this.background.style.animationPlayState = "paused"; 
                pr = false;         
           }
        } 
     window.requestAnimationFrame(detectCollisions); 	
}

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
