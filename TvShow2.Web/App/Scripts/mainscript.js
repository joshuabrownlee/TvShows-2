var App = angular.module('App', ['ngRoute']);
App.config(['$routeProvider', function ($routeProvider) {
    $routeProvider.when('/', {
        templateUrl: 'Views/Home.html',
        controller: 'homeController'
    }).when('/Details/:id', {
        templateUrl: 'Views/Details.html',
        controller: 'detailsController'
    }).otherwise({ redirectTo: '/' }) 
}]);
