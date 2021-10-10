const http = require('http');
const port = 5000;

const server = http.createServer((req, res) => {

    const url = req.url;

    if(url === '/'){
        res.writeHead(200, {'Content-Type': 'text/html'})
        res.write('<h2>Welcome to INDEX page</h2>');
    }
    else if(url === '/about'){
        res.writeHead(200, {'Content-Type': 'text/html'})
        res.write('<h2>Welcome to ABOUT page</h2>');
    }
    else if(url === '/contact'){
        res.writeHead(200, {'Content-Type': 'text/html'})
        res.write('<h2>Welcome to CONTACT page</h2>');
    }
    else {
        res.writeHead(404, {'Content-Type': 'text/html'})
        res.write(`<h2>404 Page Not Found</h2>`);
    }
    res.end();
})

server.listen(5000, () => {
    console.log(`Server is listening on port ${port}...`);
})