## HW 6

Let's write our web server using Koa.js.

* Install koa package into our project.
* Let's create index, about and contact pages.
* Let's print h1 headers as **Welcome to xxx page** as content.
* Let's use 3000 as the port number. 

## Solution:

**Koa Installation**

``` console
    [murtcay@murtcay KoaWebServer]$ npm i koa
```

``` javascript
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
```


