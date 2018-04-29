﻿//设置导航条高亮
(function () {
    let menu = location.pathname.split('/')[1];
    $(".navbar-nav li").each(function () {
        if ($(this).children("a").attr("href") == "/" + menu)
            $(this).addClass("active").siblings().removeClass("active");
    });
})();

function getLastParameter() {
    return location.pathname.split('/').pop();
}