$(function () {
    var ajaxFormSubmit = function () {
        var $form = $("form[data-movies-ajax='true']");
        var options = {
            url: $form.attr("action"),
            type: $form.attr("methed"),
            data: $form.serialize()
        };
        $.ajax(options).done(function (data) {
            var $target = $($form.data('movies-target'));
            $target.replaceWith(data);
            console.log(data);
        });
        return false;
    };
    var createAutoComplete = function () {
        var $input = $("input[data-movies-autocompete]");
        var options = {
            source: $input.attr("data-movies-autocomplete")
        };
        $input.autocomplete(options);
        console.log("自动完成");
    };
    $("#up").click(ajaxFormSubmit);
    $("input[data-movies-autocompete]").each(createAutoComplete);
    $("#auto").each(createAutoComplete);
});