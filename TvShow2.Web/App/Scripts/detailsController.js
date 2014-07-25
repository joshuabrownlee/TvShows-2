App.controller('detailsController', function ($scope, $http, $routeParams) {
    $scope.show = {};
    $http({ method: 'Get', url: '/api/v1/TvShow/' + $routeParams.id })
    .success(function (data) {
        $scope.show = data;
    })
})