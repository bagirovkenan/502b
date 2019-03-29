

    $(function () {

        $(document).ready(function () {
            $(".FaqHiddeColDiv").hide(),
                $(".ShowFaqtitleFaq").click(function () {
    
                    var HiddendDiv = $(this).parent().children(".FaqHiddeColDiv");
                    var c = $(this).parent().children(".FaqHiddeColDiv").children("p").css("height")
                    var HiddenDivDisplay = $(this).parent().children(".FaqHiddeColDiv").css("display");
                   
                     console.log(c)
                if (HiddenDivDisplay === "none") {
    
    
                        $(this).addClass("yourClass");
                        HiddendDiv.show(500)
    
    
                    }
                    else {
    
                        $(this).removeClass("yourClass");
                        HiddendDiv.hide(500)
                        // c.removeClass("show")
                    }
    
    
    
                })
    
        })
    })