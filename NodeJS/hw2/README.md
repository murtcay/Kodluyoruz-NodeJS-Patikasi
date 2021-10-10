Ready to create a blog? Let's list our posts on the console screen, then add a new post. After that list all posts again.

## Common Parts:

``` javascript
const posts = [
    {title:'Lorem Ipsum Sentences-1', content: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.', author: 'John Doe'},
    {title:'Lorem Ipsum Sentences-2', content: 'At volutpat diam ut venenatis tellus in metus vulputate eu.', author: 'John Doe'},
    {title:'Lorem Ipsum Sentences-3', content: 'Non quam lacus suspendisse faucibus interdum. ', author: 'John Doe'}
];

const listPosts= () => {
    console.log('Blog Post List:');
    posts.map(post => {
        console.log(post);
    });
}

```

## Callback

``` javascript
const addPost = (new_post, callback) => {
    
    if( 
        ((typeof new_post.title) === 'string') &&
        ((typeof new_post.content) === 'string') &&
        ((typeof new_post.author) === 'string')
    ){
        new_post.title = new_post.title.trim();
        new_post.content = new_post.content.trim();
        new_post.author = new_post.title.trim();

        if(new_post.title && new_post.content && new_post.author)
        {
            posts.push(new_post);
            callback();
        }
        else
        {
            console.log('Post cannot added.');
        }
    }
    else
    {
        console.log('Post cannot added.');
    }
};

listPosts();

addPost({title:'Lorem Ipsum Sentences-4', content: 'Sollicitudin tempor id eu nisl nunc mi.', author: 'John Doe'}, listPosts);

```

## Promise

``` javascript
const addPost = (new_post) => {

    return new Promise((resolve, reject) => {
       
        if( 
            ((typeof new_post.title) === 'string') &&
            ((typeof new_post.content) === 'string') &&
            ((typeof new_post.author) === 'string')
        ){
            new_post.title = new_post.title.trim();
            new_post.content = new_post.content.trim();
            new_post.author = new_post.title.trim();

            if(new_post.title && new_post.content && new_post.author)
            {
                posts.push(new_post);
                resolve(posts);
            }
            else
            {
                reject('Post cannot added.');
            }
        }
        else
        {
            reject('Post cannot added.');
        }
        
    })
};

listPosts();

addPost({title:'Lorem Ipsum Sentences-4', content: 'Sollicitudin tempor id eu nisl nunc mi.', author: 'John Doe'})
    .then(() => {
        
        listPosts();
    }).catch((error) => {
        console.log(error);
    })

```

## Async - Await

``` javascript
const addPost = (new_post) => {

    return new Promise((resolve, reject) => {
       
        if( 
            ((typeof new_post.title) === 'string') &&
            ((typeof new_post.content) === 'string') &&
            ((typeof new_post.author) === 'string')
        ){
            new_post.title = new_post.title.trim();
            new_post.content = new_post.content.trim();
            new_post.author = new_post.title.trim();

            if(new_post.title && new_post.content && new_post.author)
            {
                posts.push(new_post);
                resolve(posts);
            }
            else
            {
                reject('Post cannot added.');
            }
        }
        else
        {
            reject('Post cannot added.');
        }
        
    })
};

async function showBlogList() {
    try {
        await addPost({title:'Lorem Ipsum Sentences-4', content: 'Sollicitudin tempor id eu nisl nunc mi.', author: 'John Doe'});
        listPosts();
    } catch (error) {
        console.log(error);
    }
}

listPosts();

showBlogList();

```