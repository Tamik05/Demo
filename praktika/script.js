document.addEventListener('DOMContentLoaded', () => {
    const btn = document.querySelector('.changeBackground');
    btn.addEventListener('click', ()=>{
        const bck = document.body.style.background;
        if (bck === 'gray') {
            document.body.style.background = 'white'
        } else {
            document.body.style.background = 'gray'
        }
    })
});