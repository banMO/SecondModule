var options = {
    method: 'POST',
    uri: 'http://api.wordnik.com/v4/word.json/tie/definitions',
    qs: {
        ?limit=200&includeRelated=true&useCanonical=false&includeTags=false&api_key=a2a73e7b926c924fad7001ca3111acd55af2ffabf50eb4ae5
    }
    json: true // Automatically stringifies the body to JSON
};

rp(options)
    .then(function (htmlString) {
        // POST succeeded...
        console.log(htmlString)
    })
    .catch(function (err) {
        // POST failed...
        console.log(err)
    });


Request URL:http://api.wordnik.com/v4/word.json/tie/definitions
?limit=200&includeRelated=true&useCanonical=false&includeTags=false&api_key=a2a73e7b926c924fad7001ca3111acd55af2ffabf50eb4ae5


function search (word)
{
    const options
}


var options = {
    method: 'POST',
    uri: 'http://api.wordnik.com/v4/word.json/tie/definitions',
    qs: {
        ?limit=200&includeRelated=true&useCanonical=false&includeTags=false&api_key=a2a73e7b926c924fad7001ca3111acd55af2ffabf50eb4ae5
    }
    json: true // Automatically stringifies the body to JSON
};

rp(options)
    .then(function (definitions) {
        // POST succeeded...
        console.log(htmlString)
    })
    .catch(function (err) {
        // POST failed...
        console.log(err)
    });


Request URL:http://api.wordnik.com/v4/word.json/tie/definitions
?limit=200&includeRelated=true&useCanonical=false&includeTags=false&api_key=a2a73e7b926c924fad7001ca3111acd55af2ffabf50eb4ae5


function search (word)
{
    const options
}