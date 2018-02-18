var Total_secs;
var Total_min;
var cronometer;
var cronometerObjects;
var total_lives;
var total_coins;
var shoots= new Array();
var coins = new Array();
var enemies = new Array();
var mario_x = 0;
var mario_y = 0;
duration_animate = 10000;
var mario_state = 'none'
var death = 'false';
var mario_ang = 0;
var Total_secs_obj ;
var Total_mins_obj ;
var background = document.getElementById('page');

document.onkeydown = movMario;
document.onkeyup = stopAnimation;
window.addEventListener("load", function(event) {
      	Ready();
});


function Ready() {
 //   var mario = document.getElementById('mario');
 	detectCollisions();
  removeElements();
  detectCoins();
  collisionsShoots();
 // createElements();
}

function createElements(){
  //console.log(m.innerHTML);
    if(Total_secs == 5){
     // createObject("enemies1");
    }
    if(Total_secs == 7){
      //createObject("enemy2");
    }
     window.requestAnimationFrame(createElements);
}

function removeElements() {
    // Removes an element from the document
    for(var i=0; i<shoots.length;i++){
      //console.log(elements[i].offsetLeft);
      //var element = elements[i];
      if(shoots[i].offsetLeft > 900){
        //elements[i].style.display = 'none';
         background.removeChild(shoots[i]);
        //elements.splice(i,1);
      //  elements.splice(i,1);
      }
    }
    for(var j = 0;j< enemies.length;j++){
      if(enemies[j].offsetLeft < 10){
        enemies[j].style.display = 'none';
      //  background.removeChild(enemies[j]);
      }
    }
     for(var j = 0;j< coins.length;j++){
      if(coins[j].offsetLeft < 10){
        coins[j].style.display = 'none';
      //  background.removeChild(enemies[j]);
      }
    }
    //var element = document.getElementById(elementId);
    //element.parentNode.removeChild(element);
    window.requestAnimationFrame(removeElements);
}

function clearAll() {
    // Removes an element from the document
    for(var i = 0; i < shoots.length;i++){
        shoots[i].style.display = 'none';
         //background.removeChild(elements[i]);
    }
    for(var j = 0;j< enemies.length;j++){
        enemies[j].style.display = 'none';
    }
     for(var j = 0;j< coins.length; j++){
        coins[j].style.display = 'none';
    }
}

function detectCollisions(){

	for(let i = 0 ; i < enemies.length; i++){

		      var playerWidth = mario.offsetWidth;
          var playerHeight = mario.offsetHeight;
          var playerX = mario.offsetLeft;
          var playerY = mario.offsetTop;
          var tw = enemies[i].offsetWidth;
          var th = enemies[i].offsetHeight;
          var tx = enemies[i].offsetLeft;
          var ty = enemies[i].offsetTop;
           // console.log('enemie:'+ty);
          //  console.log(`${playerY+mario_y}`)
           // console.log(`${playerY+mario_y+playerHeight}`)
          if(((mario_x+playerWidth) > tx && mario_x < tx )&& 
            ((playerY+mario_y+playerHeight) > ty && (playerY+mario_y) < (ty+th))) {
              mario.style.animationPlayState = "paused";
              mario.style.animation = "paused";
              mario.style.background = "url('./images/explosion2.png')" ;
              mario.style.backgroundSize = "100% 100%";
              //mario.style.animation = "none";
              gameOver();
           // window.setTimeout(function() {window.alert("You were killed");}, 500);
             
          }
          if(mario_x < (tx+tw) && (mario_x+playerWidth)>(tx+tw) && 
            ((playerY+mario_y+playerHeight) > ty && (playerY+mario_y) < (ty+th))) {
             mario.style.animationPlayState = "paused";
             mario.style.animation = "paused";
             mario.style.background = "url('./images/explosion2.png')" ;
             mario.style.backgroundSize = "100% 100%";  
             mario.style.animation = "none";       
             gameOver();
          // window.setTimeout(function() {window.alert("You were killed");}, 500);
          } 
        } 
     window.requestAnimationFrame(detectCollisions); 	
}

function gameOver(){
  clearAll();
  death = 'true';
  document.getElementById('game-over').style.display = 'block';
  buttonrestart = document.getElementById('restart');
  buttonrestart.style.display = 'block';
  calculateLives(1,"resta");
  
}

function restart(){
  document.getElementById('game-over').style.display = 'none';
  buttonrestart = document.getElementById('restart');
  buttonrestart.style.display = 'none';
  background.removeChild(mario);
  mario = document.createElement("div");
  mario.setAttribute("id",'mario');
  document.getElementById('page').appendChild(mario);
//  mario.style.background = "url('./gradius.png')";
  mario_x = 0;
  mario_y = 0;
  duration_animate = 10000;
  mario_state = 'none'
  death = 'false';
  mario_ang = 0;
  reset();

}

function reset(){
  clearAll();
  //autoplay();
  calculateLives(1, "suma");

  Total_secs_obj = 0;
  Total_mins_obj = 0;
  Total_secs = 0;
  Total_min = 0;

 /* window.pause=0;
  window.count=0;
  window.stoped=0
*/
  resetTime();
  resetCoins();
  resetTimeObjects(); 
  startTimeObjects();
  startTime();
  //resetTime();
  
}

function detectCoins(){

  for(let i = 0 ; i < coins.length; i++){

          var playerWidth = mario.offsetWidth;
          var playerHeight = mario.offsetHeight;
          var playerX = mario.offsetLeft;
          var playerY = mario.offsetTop;
          var tw = coins[i].offsetWidth;
          var th = coins[i].offsetHeight;
          var tx = coins[i].offsetLeft;
          var ty = coins[i].offsetTop;
           // console.log('coins:'+ty);
            //console.log(`${playerY+mario_y}`)
           // console.log(`${playerY+mario_y+playerHeight}`)
          if(((mario_x+playerWidth) > tx && mario_x < tx )&& 
            ((playerY+mario_y+playerHeight) > ty && (playerY+mario_y) < (ty+th))) {
            coins[i].style.display = 'none';
            calculateCoins(1);
           // window.setTimeout(function() {window.alert("You were killed by ZERO");}, 500);
             
          }
          if(mario_x < (tx+tw) && (mario_x+playerWidth)>(tx+tw) && 
            ((playerY+mario_y+playerHeight) > ty && (playerY+mario_y) < (ty+th))) {
            coins[i].style.display = 'none';
            calculateCoins(1);            
           // window.setTimeout(function() {window.alert("You were killed by ZERO");}, 500);
          } 
        } 
     window.requestAnimationFrame(detectCoins);  
}


function collisionsShoots(){

for(let j = 0; j < shoots.length ; j++){
  for(let i = 0 ; i < enemies.length; i++){

          var playerWidth = shoots[j].offsetWidth;
          var playerHeight = shoots[j].offsetHeight;
          var playerX = shoots[j].offsetLeft;
          var playerY = shoots[j].offsetTop;
          var tw = enemies[i].offsetWidth;
          var th = enemies[i].offsetHeight;
          var tx = enemies[i].offsetLeft;
          var ty = enemies[i].offsetTop;
         // console.log(playerY);
         // console.log(ty);
           // console.log('coins:'+ty);
            //console.log(`${playerY+mario_y}`)
           // console.log(`${playerY+mario_y+playerHeight}`)
          if(((playerX+playerWidth) > tx && playerX < tx )&& 
            ((playerY+playerHeight) > ty && (playerY) < (ty+th))) {
            enemies[i].style.display = 'none';
            shoots[j].style.display = 'none';
          //  calculateCoins(1);
           // window.setTimeout(function() {window.alert("You were killed by ZERO");}, 500);
             
          }
          if(playerX < (tx+tw) && (playerX+playerWidth)>(tx+tw) && 
            ((playerY+playerHeight) > ty && (playerY) < (ty+th))) {
            coins[i].style.display = 'none';
            shoots[j].style.display = 'none';
           // calculateCoins(1);            
           // window.setTimeout(function() {window.alert("You were killed by ZERO");}, 500);
          } 
        }
  } 
   window.requestAnimationFrame(collisionsShoots);  
}


function autoplay() {

	//alert("hola");

	resetTime();
	startTime();

	resetCoins();
	//calculateCoins(400);

	resetLives();
	calculateLives(1, "suma");

	resetTimeObjects()
	startTimeObjects();

	//selectCell(x,y);

}


autoplay();