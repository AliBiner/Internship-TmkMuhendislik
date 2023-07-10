var myButton = document.getElementById('myButton');
myButton.addEventListener('click', function () {
    var img = myButton.querySelector('img');
    var isExist = img.src.split("/").slice(-1)[0];

    if (isExist === "icons8-close-50.png") {
        img.src = '../Images/Icons/icons8-menu-50.png';
    } else {
        img.src = '../Images/Icons/icons8-close-50.png';
    }

});