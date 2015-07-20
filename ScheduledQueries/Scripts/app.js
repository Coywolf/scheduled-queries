requirejs.config({
    baseUrl: '/Scripts/app',
    paths: {
        'jquery': '/Scripts/lib/jquery-2.1.4.min',
        'knockout': '/Scripts/lib/knockout-3.3.0',
        'semantic': '/Scripts/lib/semantic.min',
        'text': '/Scripts/lib/text',
        'crossroads': '/Scripts/lib/crossroads.min',
        'hasher': '/Scripts/lib/hasher.min',
        'signals': '/Scripts/lib/signals.min'
    },
    shim: {
        'semantic': {
            deps: ['jquery']
        }
    }
});

define(['jquery', 'knockout', 'router',
    'semantic', 'componentLoader'], function ($, ko, router) {
    ko.applyBindings({route: router.currentRoute});
});