
var lastPress = 0;
function movMario(tecla){
		

		if(death == 'false' ){
			if(tecla.key == "ArrowRight"){
			mario_state = 'advance';
			mov_der();
			mario_state = 'none';
			}else if(tecla.key == "ArrowLeft"){
				mario_state = 'advance';
				mov_izq();
				mario_state = 'none';
			}else if(tecla.key == "ArrowUp"){
	    		lastPress = now;
				mario_state = 'jumping'
				mov_arriba();
			}else if(tecla.key == "ArrowDown"){
				mov_abajo();
				mario_state = 'none';
			}
			var now = Date.now();
			if(tecla.code == 'Space')
			{
				if (now - lastPress < 300) return;
				lastPress = now;
				shoot();
			}
		}	
	
}

function mov_der() {
			if(mario_x >= 1200){
				return;
			}
            mario_x += 10;
			mario_ang = 0;
			var mov_x = `translateX(${mario_x}px) translateY(${mario_y}px)`;	
			mario.style.WebkitTransform = mov_x;
}

function mov_izq() {

		if(mario_x < 0){
				return;
		}
		mario_x -= 10;
		mario_ang = 180;
        var mov_x = `translateX(${mario_x}px) translateY(${mario_y}px)`;
		mario.style.WebkitTransform = mov_x ;
}

function mov_arriba() {

		if(mario_y < -460){
			return;
		}
		mario.style.animation = 'arriba 2s steps(4) infinite'
		mario_y -= 10;
		mario_ang = 180;
        var mov_x = `translateX(${mario_x}px) translateY(${mario_y}px)`;
		mario.style.WebkitTransform = mov_x ;
		
}
function mov_abajo() {
		//console.log(mario_y)
		if(mario_y > 80){
				return;
		}
		mario.style.animation = 'abajo 2s steps(4) infinite';
		mario_y += 10;
		mario_ang = 180;
         //   mario.style.webkitAnimationName = '';
        var mov_x = `translateX(${mario_x}px) translateY(${mario_y}px)`;
		mario.style.WebkitTransform = mov_x ;
		
}

function stopAnimation(){
	if(death == 'false'){
		mario.style.animation = 'stay 0.3s steps(4) infinite';
	}	
}
function shoot(){
	var playerX = mario.offsetLeft;
    var playerY = mario.offsetTop;
    var playerWidth = mario.offsetWidth;
    var playerHeight = mario.offsetHeight;

	 var newObject = document.createElement("div");
		newObject.setAttribute("class",'shoot');
	    document.getElementById('page').appendChild(newObject);
		newObject.style.left = `$(mario_x+playerWidth}px`;
		newObject.style.top = `${playerY+mario_y}px`;
		newObject.animate([
			  {left: `${mario_x+playerWidth}px`},
			  {left: '100%',
			   display: 'none'}
			], { 
			  // timing options
			  duration: 2000,
			  iterations: 1},
			  function(){
			  	console.log("hola mundo");
			  	newObject.remove();
			  }
			 // body...,  
		);
		shoots.push(newObject);
}