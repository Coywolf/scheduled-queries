// defines and registers a custom component loader to automate the configuration of basic components through requirejs
define(['knockout'], function (ko) {
    var customLoader = {
        getConfig: function (name, callback) {
            // return a configuration object that points to a require module: 'components/NAME/NAME'
            callback({ require: 'components/' + name + '/' + name });
        }
    };

    ko.components.loaders.push(customLoader);
});