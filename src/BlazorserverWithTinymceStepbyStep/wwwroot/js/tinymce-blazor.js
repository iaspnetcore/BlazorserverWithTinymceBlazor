console.log('loading js tinymce-blazor');



window.blazeditorInit = function () {
    var html = document.getElementById(id).innerHTML;

    function setup(ed) {
        ed.on("init",
            function () {
                tinyMCE.get(id).setContent(html);
                tinyMCE.execCommand('mceRepaint');
            }
        );

        ed.on("change", function () {
            var content = ed.getContent();
            callback(content);
        });
    }

    var config = {
        selector: 'textarea#' + id,
        inline: false,
        setup: setup,
        default_link_target: '_blank',
        smart_paste: false,
    };

    for (var key in option) {
        if (option.hasOwnProperty(key)) {
            config[key] = option[key];
        }
    }

    if (option.inlineMode) {
        config.selector = '#' + id;
        config.inline = true;
    }

   

   return tinymce.init({
        selector: '#Blazorservertinymce'
    });
}


//获取文档编辑的内容
window.blazeditorgetContent= function () {
    const content = tinymce.activeEditor.getContent();

    return content;
}


