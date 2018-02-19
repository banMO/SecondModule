function clearBoard()
{
	for(i = 0; i< 8; i++){
		for(j = 0; j<8; j++){
			board[i][j] = 0;
		}
	}
}

functioin PaintCell(x, y, color){
	cell = document.getElementById("c"+x+y); //devuelve div con id
	cell.style.background = color;
}