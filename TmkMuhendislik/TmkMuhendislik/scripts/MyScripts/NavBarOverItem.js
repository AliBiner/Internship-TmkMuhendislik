function adjustNavbarHeight() {
    const navbarNav = document.querySelector('.navbar-nav');
    const navbarHeight = document.querySelector('.navbar').offsetHeight;
    const totalHeight = navbarNav.scrollHeight;
    navbarNav.style.maxHeight = totalHeight > navbarHeight ? `${navbarHeight}px` : '';
}

window.addEventListener('DOMContentLoaded', adjustNavbarHeight);
window.addEventListener('resize', adjustNavbarHeight);


//function adjustNavbarHeight() {
//    const navbar = document.querySelector('.navbar');
//    const navbarNav = document.querySelector('.navbar-nav');
//    const navbarItems = navbarNav.querySelectorAll('.nav-item');

//    let totalHeight = 0;
//    navbarItems.forEach(item => {
//        totalHeight += item.offsetHeight;
//    });

//    navbar.style.height = `${totalHeight}px`;
//}

//window.addEventListener('DOMContentLoaded', adjustNavbarHeight);
//window.addEventListener('resize', adjustNavbarHeight);