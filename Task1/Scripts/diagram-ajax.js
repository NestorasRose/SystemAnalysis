if (diagram != "") {
    localStorage.setItem(diagramName, diagram);
}

window.onstorage = (event) => {
    console.log(event);

    // Delete diagram from DB
    if (event.newValue == null) {
        $.ajax({
            type: "POST",
            url: "/Diagram/Delete",
            data: { id: storyId },
            success: function (response) {
                if (response != null) {
                    localStorage.removeItem(event.key);
                    alert("Drawing deleted!");
                } else {
                    alert("Something went wrong");
                }
            },
            failure: function (response) {
                alert(response.responseText);
            },
            error: function (response) {
                alert(response.responseText);
            }
        });
        return;
    }


    //Save Diagram to DB
    newDiagram = event.newValue
    $.ajax({
        type: "POST",
        url: "/Diagram/Create",
        data: { id: storyId, diagramXML: newDiagram },
        success: function (response) {
            if (response != null) {
                localStorage.removeItem(event.key);
                location.reload();
            } else {
                alert("Something went wrong");
            }
        },
        failure: function (response) {
            alert(response.responseText);
        },
        error: function (response) {
            alert(response.responseText);
        }
    });
};

// Delete diagram from local storage when user leaves the page
window.onbeforeunload = () => localStorage.removeItem(diagramName);