
var lastPress = 0;
function movMario(tecla){
		var now = Date.now();
		console.log(now);
		console.log(tecla);
		console.log(mario_state);
		
		/*if(mario_state = 'none'){
			mario.style.background= "url('.././images/mario/optimize.gif')";
			mario.style.backgroundSize = "100% 100%";
		}
		*/
		if(tecla.key == "d"){
			mario_state = 'advance';
			mov_der();
			mario_state = 'none';
		}else if(tecla.key == "a"){
			mario_state = 'advance';
			mov_izq();
			mario_state = 'none';
		}else if(tecla.key == "w"){
			if (now - lastPress < 820) return; // less than a second ago, stop
    		lastPress = now;
			mario_state = 'jumping'
			mov_arriba();
		}else if(tecla.key == "s" && mario_state =='none'){
			mov_abajo();
			mario_state = 'none';
		}		
}

function mov_der() {
	//if(mario_ang == 0){
			if(mario_x >= 950){
				return;
			}
			mario.style.backgroundPosition = '-298px 264px';
			/*document.getElementById("mario").animate([
	 		 // keyframes
	 		  {background : "url('.././images/mariosprit.png')"},
			  {'background-position': '-585px 264px'}
			], { 
			  // timing options
			  duration: 800,
			  iterations: 1,
			  steps : 4
			})
			*/
		    mario.style.animation = 'der 0.3s steps(4) infinite'
            mario_x += 10;
			mario_ang = 0;
			var mov_x = `translateX(${mario_x}px)`;	
			mario.style.WebkitTransform = mov_x;//"translateX(mov_x)";
			 
		/*
		console.log("hola mundo");
		mario_x += 10;
		mario_ang = 0;
		var mov_x = `translateX(${mario_x}px) rotateY(0deg)`;
		mario.style.WebkitTransform = mov_x;//"translateX(mov_x)"; 
	/*}else{
		mario.style.WebkitTransform = "rotateY(180deg)";
		mario_ang -= 180;
	}*/
	
}

function mov_izq() {

		if(mario_x < 0){
				return;
		}
		   mario.style.backgroundPosition = '-230px 263px';
		//mario.style.animation = 'izq 0.3s steps(3) 1'
		//setTimeout(function() {
			mario.style.animation = 'izq 0.3s steps(3) infinite'
			mario_x -= 10;
			mario_ang = 180;
         //   mario.style.webkitAnimationName = '';
            var mov_x = `translateX(${mario_x}px)`;
			mario.style.WebkitTransform = mov_x ;
			mario.style.backgroundPosition = '-230px 263px';
      //  }, 400);

		//translateX(439px) rotateY(180deg)
		
		//mario_ang += 180;
}

function mov_arriba() {
		if(mario_x >= 1250){
				return;
		}
		//mario.style.background = 'url(.././images/jumpmario.png)';
	//	mario.style.backgroundSize = '100% 100%';

		if(mario_ang == 0){
			document.getElementById("mario").animate([
	 		 // keyframes
			  {transform: `translateX(${mario_x}px) translateY(0px)`},
			  //	backgroundPosition: '-299px 177px'
			  	//backgroundPosition : '-361px 178px' 
			   {transform: `translateX(${mario_x+50}px) translateY(-220px)`},
			   {transform: `translateX(${mario_x+80}px) translateY(-50px)`}
			  //	backgroundPosition : '-550px 178px'
			], { 
			  // timing options
			  duration: 800,
			  iterations: 1,
			  step: function( now, fx ) {
			  		fx.prop.backgroundPosition 
				    var data = fx.elem.id + " " + fx.prop + ": " + now;
				    $( "body" ).append( "<div>" + data + "</div>" );
				  }
			 // body...  
			})
				mario_x += 100;
				var mov_x = `translateX(${mario_x}px) rotateY(0deg)`;
				mario.style.WebkitTransform = mov_x;//"translateX(mov_x)";
				mario_state = 'none';
				//mario.style.background= "url('.././images/mario/optimize.gif')";
		}else{
			document.getElementById("mario").animate([
			  // keyframes
			  { transform: `translateX(${mario_x}px) translateY(0px) rotateY(180deg)` }, 
			  { transform: `translateX(${mario_x-50}px) translateY(-220px) rotateY(180deg)` },
			  { transform: `translateX(${mario_x-80}px) translateY(-50px) rotateY(180deg)` }
			], { 
			  // timing options
			  duration: 800,
			  iterations: 1
			});
			mario_x -= 100;
			var mov_x = `translateX(${mario_x}px) rotateY(180deg)`;
			mario.style.WebkitTransform = mov_x;//"translateX(mov_x)"; 
			mario_state = 'none';

		}	
		

}

function stopAnimation(){
	mario.style.animation = 'stay 0.3s steps(4) infinite'
}

/*
function tecla (e)
{
    var evt = e ? e : event;
    var key = window.Event ? evt.which : evt.keyCode;
    alert (key);
}

*/