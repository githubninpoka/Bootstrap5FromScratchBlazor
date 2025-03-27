
function switchDark(colorSetting){
    let element = document.getElementById("themeFromHere");
    element.setAttribute('data-bs-theme', colorSetting);
    
}

function switchSiteThemeToggle(colorSetting) {
    let element = document.getElementsByTagName("html")[0];
    element.setAttribute('data-bs-theme', colorSetting);
}