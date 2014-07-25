App.controller('homeController', function ($scope, $http) {
    $scope.shows = [];
    $scope.submitShow = function () {
        $http({ method: "POST", url: '/api/v1/TvShow', data: $scope.newShow })
        .success(function () {
            $scope.getShows();
           
        })
    };
    $scope.getShows = function () {

        $http({ method: 'GET', url: '/api/v1/TvShow' }).success(function (data) {
            $scope.shows = data;
        })
    }
    $scope.getShows();
})
