
$(document).ready(function () {
    SelfConsole.log("Document ready :");
    
});

$(document).on("click", ".carousel", function () {
    SelfConsole.debug("Carrousel Item clicked");
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
    SelfConsole.debug("Opening Image");
    SelfConsole.info("Id " + id);
    var strMethodUrl = '@Url.Action("OriginalImageURL", "Home")';
    $.getJSON("Home/OriginalImageURL", { id: id }, receieveResponse);   
}

function receieveResponse(response) {
    SelfConsole.debug( "Response received");
    if (response !== null) {      
        SelfConsole.info("URL: " + response);
            openModalWithImage(response);   
    }
}

function openModalWithImage(src) {
    SelfConsole.debug("Opening modal image");
    // Get the modal
    $("#myCarousel").carousel('pause');
    $("#modalImage").css("display", "block");
    $("#imgModal").attr("src", src);    
}

$(document).on("click", "span", function () {
    SelfConsole.debug("Closing modal image");
    $("#modalImage").css("display", "none");
    $("#myCarousel").carousel('cycle');
});
