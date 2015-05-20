completeApp.controller("completeController", function ($scope) {

    //$scope.api = ngAutocomplete;

    $scope.update = function(details)
    {
        $scope.items = [1,2,3,4];

        $scope.info = details.address_components;
        $scope.members = details.address_components.length;

        $scope.address = {};

        for(i = 0; i < $scope.members; i++)
        {
            if ($scope.info[i].types[0] == "street_number")
                $scope.address.number = $scope.info[i].long_name;

            if ($scope.info[i].types[0] == "route")
                $scope.address.street = $scope.info[i].long_name;

            if ($scope.info[i].types[0] == "locality")
                $scope.address.city = $scope.info[i].long_name;

            if ($scope.info[i].types[0] == "administrative_area_level_1")
                $scope.address.state = $scope.info[i].long_name;

            if ($scope.info[i].types[0] == "postal_code")
                $scope.address.zip = $scope.info[i].long_name;
        }
    }

});