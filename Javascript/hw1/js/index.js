const greeting_el = document.getElementById('greeting-el')
const time_el = document.getElementById('time-el')
const course_info_el = document.getElementById('course-info-el')
const days = ["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"]

function askName() {return prompt('What is your name?')}
function calcTime()
{
    let date = new Date()
    let h = date.getHours()
    let m = date.getMinutes()
    let s = date.getSeconds()
    let session =  days[date.getDay()]

    h = h < 10 ? "0" + h : h
    m = m < 10 ? "0" + m : m
    s = s < 10 ? "0" + s : s

    time_el.innerHTML = `<b>${h}:${m}:${s} ${session}!</b>`
}

function dispTime() {
    calcTime()
    setInterval(calcTime,1000)
}

const user_name = askName()
dispTime()  
greeting_el.innerHTML = `Hello, <b><span >${user_name}</span>!</b> Welcome!`
course_info_el.innerHTML = `This is the 1th Javascript Home Work of <b>Kodluyoruz Frontend Web Development Patikası</b>.`