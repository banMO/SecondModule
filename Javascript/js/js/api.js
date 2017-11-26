const rp = require('request-promise')

rp('https://www.google.com')
	.then(function(htmlstring)){
	console.log(htmlString)
	}
	.catch(fuction (err)){
	console.log(err)
	});
npm init
npm install <dependency> --save
npm install <dependency> --save-dev


npm uninstall <dependency>
npm uninstall  -g <dependency>

npm update <dependecy>

//app para q consuma un Api

a2a73e7b926c924fad7001ca3111acd55af2ffabf50eb4ae5

const rp = require('request-promise')

Request URL:http://api.wordnik.com/v4/word.json/tie/definitions
?limit=200&includeRelated=true&useCanonical=false&includeTags=false&api_key=a2a73e7b926c924fad7001ca3111acd55af2ffabf50eb4ae5