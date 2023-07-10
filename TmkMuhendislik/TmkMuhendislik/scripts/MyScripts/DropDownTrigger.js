var dropdown = document.querySelector('.dropdown');

dropdown.addEventListener('mouseenter', function () {
    dropdown.classList.add('show');
});

dropdown.addEventListener('mouseleave', function () {
    dropdown.classList.remove('show');
});