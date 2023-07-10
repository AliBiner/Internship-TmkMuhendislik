////document.addEventListener('DOMContentLoaded', function () {
////    var elems = document.querySelectorAll('.sidenav');
////    M.Sidenav.init(elems);
////});

//document.addEventListener('DOMContentLoaded', function () {
//    var elems = document.querySelectorAll('.sidenav');
//    var instances = M.Sidenav.init(elems);

//    var navbar = document.querySelector('.nav-wrapper');
//    var hamburger = document.querySelector('.sidenav-trigger');

//    hamburger.addEventListener('click', function () {
//        navbar.classList.toggle('nav-expanded');
//    });
//});

//const hamburger = document.querySelector(".hamburger");
//const navMenu = document.querySelector(".nav-menu");

//hamburger.addEventListener("click", () => {
//    hamburger.classList.toggle("active");
//    navMenu.classList.toggle("active");
//})

//document.querySelectorAll(".nav-link").forEach(n => n.addEventListener("click", () => {
//    hamburger.classList.remove("active");
//    navMenu.classList.remove("active");
//}))

$(document).ready(function () {
    $('.navbar-toggler').click(function () {
        $('navbar-collapse').toggleClass('show');
    });
});





