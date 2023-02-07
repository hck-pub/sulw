function reveal() {
let reveals = document.querySelectorAll('.ani');

for (let i = 0; i < reveals.length; i++) {
  let windowHeight = window.innerHeight;
  let elementTop = reveals[i].getBoundingClientRect().top + windowHeight;
  console.log(elementTop);
  let elementVisible = 150;

  if(elementTop < windowHeight) {
    console.log(this.innerHeight);
    reveals[i].classList.add('active');
  } else {
    reveals[i].classList.remove('active');
  }
}
}

window.addEventListener('load', () => {
reveal();
  window.addEventListener('scroll', () => {
      reveal();
  });
});

