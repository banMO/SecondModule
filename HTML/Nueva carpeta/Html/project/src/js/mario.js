
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
		var mov_x = `translateX(${mario_x}px) `;
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
		var mov_x = `translateX(${mario_x}px) rotateY(180deg)`;
		mario.style.WebkitTransform = mov_x ;
		mario_ang += 180;
}

function mov_arriba() {

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