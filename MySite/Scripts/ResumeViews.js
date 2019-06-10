var download = (function () {
    var module = function () { }

    module.onReady = function () {
        gtag('config', 'UA-141716608-1');
        gtag('event', 'download', { 'send_to': 'UA-141716608-1' });
    }

    return module;
}());