(function () {
    //jquery uses css selectors as it's selector syntax'
    //jquery ensures users get the same experience across browsers
    //var ele = $("#username");
    //ele.innerHTML = "";

    //var main = document.getElementById("main");

    //main.on("mouseenter",  function () {
    //    main.style.backgroundColor = "#888";
    //});

    //main.on("mouseleave", function () {
    //    main.style.backgroundColor = "";
    //});

    //var menuItems = $("ul.menu li a");
    //menuItems.on("click", function () {
    //    var me = $(this);
    //});

    var sidebarAndWrapper = $("#sidebar, #wrapper");
    var $icon = $("#sidebarToggle i.fa");

    $("#sidebarToggle").on("click", function () {
        sidebarAndWrapper.toggleClass("hide-sidebar");
        if (sidebarAndWrapper.hasClass("hide-sidebar")) {
            $icon.removeClass("fa-angle-left");
            $icon.addClass("fa-angle-right");
        }
        else {
            $icon.addClass("fa-angle-left");
            $icon.removeClass("fa-angle-right");
            //$(this).text("Hide Sidebar");
        }
    });
    
})();//immediately executed function;

//jquery exposes a single object to the global scope, $ (dollar sign) aka JQuery

