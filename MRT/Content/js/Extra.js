$(document).ready(function () {

    $("#gender > .pdsa-radiobutton").on('click', function () {

        pdsaToggleRadioButtons("#gender", $(this));

    });

});



function pdsaToggleRadioButtons(groupName, current) {

    // Find currently checked radio button in the group   

    var chk = $(groupName +

        " .pdsa-radiobutton .glyphicon-record");



    // Remove 'record' glyph

    // Add 'unchecked' glyph

    $(chk).removeClass('glyphicon-record')

        .addClass('glyphicon-unchecked');



    // Remove the 'unchecked' glyph, add the 'record' glyph

    $(current).find(">:first-child")

        .removeClass('glyphicon-unchecked');

    $(current).find(">:first-child")

        .addClass('glyphicon-record');

}