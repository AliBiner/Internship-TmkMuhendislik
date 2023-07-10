function rearrangeDivs() {
    var denemeDiv = document.getElementById('deneme');
    var childDivs = Array.from(denemeDiv.children);
    var container = denemeDiv.parentNode;

    if (window.innerWidth < 576) { // Küçük ekranlarda
        for (var i = childDivs.length - 1; i >= 0; i--) {
            var childDiv = childDivs[i];
            container.insertBefore(childDiv, denemeDiv.nextSibling);
        }
    } else { // Büyük ekranlarda
        childDivs.forEach(function (childDiv) {
            denemeDiv.appendChild(childDiv);
        });
    }
}

function applyRearrangeOnLoad() {
    rearrangeDivs();
    window.removeEventListener('DOMContentLoaded', applyRearrangeOnLoad);
}

window.addEventListener('resize', rearrangeDivs);
window.addEventListener('DOMContentLoaded', applyRearrangeOnLoad);