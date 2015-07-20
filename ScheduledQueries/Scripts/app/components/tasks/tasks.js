define(['jquery', 'knockout', 'text!./tasks.html'], function($, ko, htmlString) {
    function tasksViewModel(params) {
        console.log('new vm');
    }

    return {
        viewModel: tasksViewModel,
        template: htmlString
    }
});