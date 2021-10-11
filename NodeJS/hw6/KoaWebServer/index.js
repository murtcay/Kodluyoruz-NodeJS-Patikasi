const Koa = require('koa');
const app = new Koa();

app.use(ctx => {

    if (ctx.url === '/') {
        ctx.response.type = 'text/html; charset=utf-8';
        ctx.response.status = 200;
        ctx.response.body = '<h1>Welcome to INDEX page</h1>';
    }
    else if (ctx.url === '/about') {
        ctx.response.type = 'text/html; charset=utf-8';
        ctx.response.status = 200;
        ctx.response.body = '<h1>Welcome to ABOUT page</h1>';
    }
    else if (ctx.url === '/contact') {
        ctx.response.type = 'text/html; charset=utf-8';
        ctx.response.status = 200;
        ctx.response.body = '<h1>Welcome to CONTACT page</h1>';
    }
    else {
        
        ctx.response.type = 'text/html; charset=utf-8';
        ctx.response.status = 200;
        ctx.response.body = '<h1>404 - Page Not Found...</h1>';
    }

})

app.listen(3000);
