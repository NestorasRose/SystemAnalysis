$(document).ready(function () {
    $('#dtable').DataTable({
        dom: 'Bfrtip',
        buttons: [
            {
                text: 'Create New',
                className: 'btn btn-warning',
                action: function (e, dt, node, config) {
                    window.location.href = nextLocation;
                }
            }
        ]
    });
});

$(function () {
    $(".fa-pencil").tooltip({
        placement: "top",
        title: "Edit"
    });
    $(".fa-info-circle").tooltip({
        placement: "top",
        title: "Details"
    });
    $(".fa-trash-o").tooltip({
        placement: "top",
        title: "Delete"
    });
});
