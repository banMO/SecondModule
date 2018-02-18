var imgSprite = new Image();

imgSprite.src = '.././images/mapstage1.png';


var bgDrawX = 0;
var bgDrawX2 = 800;

function moveBg(){
	bgDrawX -= 5;
	bgDrawX2 -=5;

	if(bgDrawX <= -800){
		bgDrawX = 800;
	}else if(bgDrawX2 <= -800){
		bgDrawX2 = 800;
	}
	drawBg();
}

