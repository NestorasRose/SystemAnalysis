$(document).ready(function () {
    $('#dtableStories').DataTable({
        dom: 'Bfrtip',
    });
});

$(document).ready(function () {
    $('#dtableTasks').DataTable({
        dom: 'Bfrtip',
    });
});

$(document).ready(function () {
    $('#dtableFiles').DataTable({
        dom: 'Bfrtip',
    });
});

$(function () {
    $(".fa-pencil-square-o").tooltip({
        placement: "top",
        title: "Edit"
    });
    $(".fa-trash-o").tooltip({
        placement: "top",
        title: "Delete"
    });
    $(".fa-tasks").tooltip({
        placement: "top",
        title: "Tasks"
    });
    $(".fa-bar-chart").tooltip({
        placement: "top",
        title: "Diagram"
    });
    $(".fa-file-code-o").tooltip({
        placement: "top",
        title: "Files"
    });
    $(".fa-info-circle").tooltip({
        placement: "top",
        title: "Details"
    });
});
