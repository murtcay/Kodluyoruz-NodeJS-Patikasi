const task_el = document.getElementById('task')
const list_el = document.getElementById('list')

// element checked or unchecked
list_el.addEventListener('click', (event) => {
    if (event.target.tagName === 'LI') {
        event.target.classList.toggle('checked');
    }
}, false)

function newElement() {
  let input_value = task_el.value.trim();
  let li = document.createElement('li');
  li.appendChild(document.createTextNode(input_value));

  let span = document.createElement('span');
  span.className = 'close';
  span.onclick  = () => {
    li.style.display = 'none'; // deleteElement function
  };
  span.appendChild(document.createTextNode('x'));
  li.appendChild(span);

  if (input_value.length === 0) {
    $('.error').toast('show');
  } else {
    $('.success').toast('show');
    list_el.appendChild(li);
  }
  task_el.value = '';
}