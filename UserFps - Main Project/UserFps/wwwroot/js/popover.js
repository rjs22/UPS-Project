$('.ups-top-navigation .thePopover .popoverMenu').html($('.ups-top-navigation .dropdown-toggle').html())
$('[data-toggle="popover"]').popover({ html: true });
$(document).ready(function () {
    $('.popoverMenu').popover({
        html: true,
        content: function () {
            return $('.dropdown-menu').html();
        },
        template: '<div class="popover popoverOffset" role="tooltip"><div class="arrow"></div><div class="popover-content"></div></div>'
    });
});
$(document).on('click', function (e) {
    $('.popoverMenu[data-original-title]').each(function () {
        if (!$(this).is(e.target) && $(this).has(e.target).length === 0 && $('.popover').has(e.target).length === 0) {
            (($(this).popover('hide').data('bs.popover') || {}).inState || {}).click = false;
        }
    });
});