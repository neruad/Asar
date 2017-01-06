
$("span.menu").click(function () {
    $(".top-menu ul").slideToggle("slow", function () {
    });
});

$("#slider").responsiveSlides({
    auto: true,
    nav: true,
    speed: 500,
    namespace: "callbacks",
    pager: true,
});

jQuery(document).ready(function ($) {
    $(".scroll").click(function (event) {
        event.preventDefault();
        $('html,body').animate({ scrollTop: $(this.hash).offset().top }, 1200);
    });
});

jQuery(document).ready(function ($) {
    $(".scroll").click(function (event) {
        event.preventDefault();
        $('html,body').animate({ scrollTop: $(this.hash).offset().top }, 1200);
    });
});

$(function () {

    var filterList = {

        init: function () {

            // MixItUp plugin
            // http://mixitup.io
            $('#portfoliolist').mixitup({
                targetSelector: '.portfolio',
                filterSelector: '.filter',
                effects: ['fade'],
                easing: 'snap',
                // call the hover effect
                onMixEnd: filterList.hoverEffect()
            });

        },

        hoverEffect: function () {

            // Simple parallax effect
            $('#portfoliolist .portfolio').hover(
                function () {
                    $(this).find('.label').stop().animate({ bottom: 0 }, 200, 'easeOutQuad');
                    $(this).find('img').stop().animate({ top: -30 }, 500, 'easeOutQuad');
                },
                function () {
                    $(this).find('.label').stop().animate({ bottom: -40 }, 200, 'easeInQuad');
                    $(this).find('img').stop().animate({ top: 0 }, 300, 'easeOutQuad');
                }
            );

        }

    };

    // Run the show!
    filterList.init();


});

$(document).ready(function () {
    $('.popup-with-zoom-anim').magnificPopup({
        type: 'inline',
        fixedContentPos: false,
        fixedBgPos: true,
        overflowY: 'auto',
        closeBtnInside: true,
        preloader: false,
        midClick: true,
        removalDelay: 300,
        mainClass: 'my-mfp-zoom-in'
    });

});

$(document).ready(function () {
    $("#owl-demo").owlCarousel({
        items: 4,
        lazyLoad: true,
        autoPlay: true,
        navigation: false,
        navigationText: false,
        pagination: true,
    });
});

$(document).ready(function () {
    /*
    var defaults = {
        containerID: 'toTop', // fading element id
        containerHoverID: 'toTopHover', // fading element hover id
        scrollSpeed: 1200,
        easingType: 'linear' 
    };
    */

    $().UItoTop({ easingType: 'easeOutQuart' });

});