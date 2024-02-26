$(document).ready(function () {
    "use strict";
    $('#DevButton').click(function () {
        $('#collapseExample01').collapse('toggle');
        $('#collapseExample02').collapse('hide');
        $('#collapseExample03').collapse('hide');
    });
    $('#InfoButton').click(function () {
        $('#collapseExample02').collapse('toggle');
        $('#collapseExample01').collapse('hide');
        $('#collapseExample03').collapse('hide');
        
    });
    $('#CloudButton').click(function () {
        $('#collapseExample03').collapse('toggle');
        $('#collapseExample01').collapse('hide');
        $('#collapseExample02').collapse('hide');
        
    });
    $("#picTools").click(function() {
        $( "#DevButton" ).click();
      });
      $("#picEth01").click(function() {
        $( "#InfoButton" ).click();
      });
      $("#picCloud01").click(function() {
        $( "#CloudButton" ).click();
      });
  
      $('.cpoint').css('cursor', 'pointer');
        
}); 
