// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {

    hideBattery()

    $('#building_id').change(function () {
        $('#battery').show()
    })

    $('#battery_id').change(function () {
        $('#column').show()
    })

    $('#column_id').change(function () {
        $('#elevator').show()
    })

    function hideBattery() {
        $('#battery').hide()
        hideColumn()
    }

    function hideColumn() {
        $('#column').hide()
        hideElevator()
    }

    function hideElevator() {
        $('#elevator').hide()
    }


    

})
