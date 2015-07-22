define(['jquery', 'knockout', 'text!./tasks.html'], function($, ko, htmlString) {
    function tasksViewModel(params) {
        var self = this;

        self.Tasks = ['one', 'two', 'three']
    }

    return {
        viewModel: tasksViewModel,
        template: htmlString
    }
});