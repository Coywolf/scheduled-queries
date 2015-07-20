define(['jquery', 'knockout', 'text!./queries.html'], function ($, ko, htmlString) {
    function queriesViewModel(params) {

    }

    return {
        viewModel: queriesViewModel,
        template: htmlString
    }
});