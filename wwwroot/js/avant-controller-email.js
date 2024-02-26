"use strict";
angular.module("app-email")
    .controller("emailController", emailController);

function emailController($scope, $http) {

    var vm = this;

    var onSendComplete = function (response) {
        $scope.user = response.data;
    };

    vm.SendGridAlphaInterested = function (who) {
        $http.get("http://www.cuisinecuration.com/api/sendgrid/send", { params: { "who": who } })
            .then(onSendComplete);
    };

    //vm.alphaEmail = {
    //    From: "stevem@avanttek.com",
    //    Subject: "AlphaInterested",
    //    Text: "MessageText",
    //    To: "alphauser@avanttek.com"
    //};
    vm.alphaEmail = {
        From: "stm@avanttek.com",
        Subject: "AlphaInterested",
        Text: "MessageText",
        To: "alphauser@avanttek.com"
    };
    // vm.email = {
    //     text: "steve.mintz@gmail.com"
    //     //    sender:   document.getElementById("ValidEmail")
    // };

    vm.SendGridAlphaInterested = function (me) {

        if ($scope.myForm.$invalid)
            return;

        // var me = "zozo@ff.noq";
        $http.get("http://www.cuisinecuration.com/api/sendgrid/send/?", { params: { "who": me } })
            // $http.get("http://www.cuisinecuration.com/api/sendgrid/send?who=xx@yy.ets")
            .then(onSendComplete);


    };
        
    }

