
$(document).ready(function () {

    
});

$(document).on("click", ".carousel", function () {

    if ($(event.target).is('.carousel-control-prev')) {
        return;
    } else if ($(event.target).is('.carousel-control-next')) {
        return;
    }
    else if ($(event.target).is('.carousel-control-prev-icon')) {
        return;
    } else if ($(event.target).is('.carousel-control-next-icon')) {
        return;
    }
       
    var id = $(this).prop("alt"); 
    openImage(id);

});

function openImage(id) {   
    var strMethodUrl = '@Url.Action("OriginalImageURL", "Home")';
    $.getJSON("Home/OriginalImageURL", { id: id }, receieveResponse);   
}

function receieveResponse(response) {

    if (response !== null) {        
            openModalWithImage(response);   
    }
}

function openModalWithImage(src) {
    // Get the modal
    $("#myCarousel").carousel('pause');
    $("#myModal").css("display", "block");
    $("#imgModal").attr("src", src);    
}

$(document).on("click", "span", function () {
    $("#myModal").css("display", "none");
    $("#myCarousel").carousel('cycle');
});
