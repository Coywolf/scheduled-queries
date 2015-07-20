define(['knockout', 'text!./nav-bar.html'], function (ko, htmlString) {
    function navBarViewModel(params) {
        this.route = params.route;
    }

    return {
        viewModel: navBarViewModel,
        template: htmlString
    }
});