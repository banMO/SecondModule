
var lastPress = 0;
function movMario(tecla){
		var now = Date.now();
		console.log(now);
		console.log(tecla);
		console.log(mario_state);
		
		if(tecla.key == "d"){
			mario_state = 'advance';
			mov_der();
			mario_state = 'none';
		}else if(tecla.key == "a"){
			mario_state = 'advance';
			mov_izq();
			mario_state = 'none';
		}else if(tecla.key == "w"){
			if (now - lastPress < 800) return; // less than a second ago, stop
    		lastPress = now;
			mario_state = 'jumping'
			mov_arriba();
		}else if(tecla.key == "s" && mario_state =='none'){
			mov_abajo();
			mario_state = 'none';
		}		
}

function mov_der() {
			if(mario_x >= 950){
				return;
			}
			mario.style.backgroundPosition = '-490px 330px';
		    mario.style.animation = 'der 0.5s steps(3) infinite'
            mario_x += 10;
			mario_ang = 0;
			//mario.style.left = (mario.offsetLeft += 5) + 'px';
			var mov_x = `translateX(${mario_x}px)`;	
			mario.style.WebkitTransform = mov_x;
}

function mov_izq() {

		if(mario_x < 0){
				return;
		}
		//mario.style.animation = 'izq 0.3s steps(3) 1'
		//setTimeout(function() {
			mario.style.backgroundPosition = '-420px 330px';
			mario.style.animation = 'izq 0.5s steps(3) infinite'
			mario_x -= 10;
			mario_ang = 180;
         //   mario.style.webkitAnimationName = '';
            var mov_x = `translateX(${mario_x}px)`;
			mario.style.WebkitTransform = mov_x ;
		   // mario.style.left = (mario.offsetLeft -= 5) + 'px';
         // player.style.animation = "walk-left 1s steps(4) infinite";
      //  }, 400);

		//translateX(439px) rotateY(180deg)
		
		//mario_ang += 180;
}

function mov_arriba() {

		if(mario_x >= 1250){
				return;
		}
		if(mario_ang == 0){

			document.getElementById("mario").animate([
			  {transform: `translateX(${mario_x}px) translateY(0px)`,
			  	backgroundPosition: '-864px 330px'},
			  {transform: `translateX(${mario_x +=50}px) translateY( ${d -= 220}px)`,
				backgroundPosition: '-864px 330px',
			  },
			  {transform: `translateX(${mario_x +=80}px) translateY(${mario_y += 150}px)`,
				backgroundPosition: '-864px 330px'},
			], { 
			  // timing options
			  duration: 800,
			  iterations: 1,
			 // body...  
			})
				mario_x += 20;
				mario_y = 0;
				var mov_x = `translateX(${mario_x}px) rotateY(0deg)`;
				mario.style.WebkitTransform = mov_x;//"translateX(mov_x)";
				mario_state = 'none';
		}else{
			document.getElementById("mario").animate([
			  // keyframes
			  { transform: `translateX(${mario_x}px) translateY(0px)`,
				backgroundPosition: '-65px 330px'}, 
			  { transform: `translateX(${mario_x -= 50}px) translateY(${mario_y = -220}px)`,
				backgroundPosition: '-65px 330px'},
			  { transform: `translateX(${mario_x -= 80}px) translateY(${mario_y = -50}px)`,
			  	backgroundPosition: '-65px 330px' }
			], { 
			  // timing options
			  duration: 800,
			  iterations: 1
			});
			mario_x -= 20;
			mario_y = 0;
			var mov_x = `translateX(${mario_x}px)`;
			mario.style.WebkitTransform = mov_x;//"translateX(mov_x)"; 
			mario_state = 'none';
		}	
		/*if(mario_ang == 0){
			mario.style.left = (mario.offsetLeft += 5) + 'px';
      	    mario.style.animation = "jump_right 0.8s infinite";
		}else{
			mario.style.left = (mario.offsetLeft -= 5) + 'px';
      	    mario.style.animation = "jump_left 0.8s infinite";
		}*/
		
}

function stopAnimation(){

	 if(mario_ang == 0){
		mario.style.animation = 'stay_right 0.3s steps(4) infinite'
	}else if(mario_ang == 180) {
		mario.style.animation = 'stay_left 0.3s steps(4) infinite'
	}
	
}
