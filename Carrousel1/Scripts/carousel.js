
$(document).ready(function () {
    log(1, "Document ready");
    
});

$(document).on("click", ".carousel", function () {
    log(1, "Carrousel Item clicked");
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
    log(1, "Opening Image");
    var strMethodUrl = '@Url.Action("OriginalImageURL", "Home")';
    $.getJSON("Home/OriginalImageURL", { id: id }, receieveResponse);   
}

function receieveResponse(response) {
    log(1, "Response received");
    if (response !== null) {        
            openModalWithImage(response);   
    }
}

function openModalWithImage(src) {
    log(1, "Opening modal image");
    // Get the modal
    $("#myCarousel").carousel('pause');
    $("#modalImage").css("display", "block");
    $("#imgModal").attr("src", src);    
}

$(document).on("click", "span", function () {
    log(1, "Closing modal image");
    $("#modalImage").css("display", "none");
    $("#myCarousel").carousel('cycle');
});
