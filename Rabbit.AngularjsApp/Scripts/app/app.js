(function (angular) {
    var app = angular.module('app', ['ngRoute']);

    app.config(['$routeProvider', function ($routeProvider) {
        $routeProvider
            .when('/', {
                controller: 'WelcomeController',
                templateUrl: '/Demo/Welcome',
            }).when('/test', {
                controller: 'TestController',
                templateUrl: '/Demo/Test',
            }).otherwise({
                redirectTo: '/'
            });
    }]);
})(angular);