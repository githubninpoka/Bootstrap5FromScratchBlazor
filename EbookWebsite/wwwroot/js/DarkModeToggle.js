
function switchDarkThemeFromThisComponent(colorSetting){
    let element = document.getElementById("themeFromHere");
    element.setAttribute('data-bs-theme', colorSetting);
    
}

function switchSiteThemeToggleForSite(colorSetting) {
    let element = document.getElementsByTagName("html")[0];
    element.setAttribute('data-bs-theme', colorSetting);
}