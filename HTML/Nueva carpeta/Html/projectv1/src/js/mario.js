
function movMario(tecla){

		console.log(tecla);

		if(tecla.key == "d"){
			mov_der();
		}else if(tecla.key == "a"){
			mov_izq();
		}else if(tecla.key == "w"){
			mov_arriba();
		}else if(tecla.key == "s"){
			mov_abajo();
		}		
}

function mov_der() {
	//if(mario_ang == 0){
		mario = document.getElementById("mario");
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
		mario = document.getElementById("mario");
		console.log("hola mundo");
		mario_x -= 10;
		mario_ang = 180;
		//translateX(439px) rotateY(180deg)
		var mov_x = `translateX(${mario_x}px) rotateY(180deg)`;
		mario.style.WebkitTransform = mov_x ;
		//mario_ang += 180;
}

function mov_arriba() {
		mario = document.getElementById("mario");
		if(mario_ang == 0){
			document.getElementById("mario").animate([
	 		 // keyframes
			  { transform: `translateX(${mario_x}px) translateY(0px)` }, 
			  { transform: `translateX(${mario_x+40}px) translateY(-170px)` },
			  { transform: `translateX(${mario_x+70}px) translateY(-50px)` }
			], { 
			  // timing options
			  duration: 800,
			  iterations: 1
			},8000);

			mario_x += 80;
			var mov_x = `translateX(${mario_x}px) rotateY(0deg)`;
			mario.style.WebkitTransform = mov_x;//"translateX(mov_x)"; 
		}else{
			document.getElementById("mario").animate([
			  // keyframes
			  { transform: `translateX(${mario_x}px) translateY(0px) rotateY(180deg)` }, 
			  { transform: `translateX(${mario_x-40}px) translateY(-170px) rotateY(180deg)` },
			  { transform: `translateX(${mario_x-70}px) translateY(-50px) rotateY(180deg)` }
			], { 
			  // timing options
			  duration: 800,
			  iterations: 1
			},800);

			mario_x -= 80;
			var mov_x = `translateX(${mario_x}px) rotateY(180deg)`;
			mario.style.WebkitTransform = mov_x;//"translateX(mov_x)"; 
		}	
}

function mov_abajo(){
	
}

/*
function tecla (e)
{
    var evt = e ? e : event;
    var key = window.Event ? evt.which : evt.keyCode;
    alert (key);
}

*/