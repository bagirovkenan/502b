
// /* <div id="myProgress">
//   <div id="myBar"></div>
// </div> */

// java script

// function move() {
//     var elem = document.getElementById("myBar"); 
//     var width = 1;
//     var id = setInterval(frame, 10);
//     function frame() {
//         if (width >= 100) {
//             clearInterval(id);
//         } else {
//             width++; 
//             elem.style.width = width + '%'; 
//         }
//     }
// }

// $("#iki").click(function(){
//     $("#div2").show(),$("#div1").hide(),$("#div2").animate({innerText:'80'})
// })
// busines-span-Idm/ desing-span-Id /material-span-Id

$("#all-categories-span-Id").click(function(){
    $("#all-categories").show(),$("#branding").hide(),$("#busines").hide(),$("#desing").hide(),$("#material").hide()
});

$("#branding-span-Id").click(function(){
    $("#branding").show(),$("#all-categories").hide(),$("#busines").hide(),$("#desing").hide(),$("#material").hide()
});

$("#busines-span-Id").click(function(){
    $("#busines").show(),$("#all-categories").hide(),$("#branding").hide(),$("#desing").hide(),$("#material").hide()
});

$("#desing-span-Id").click(function(){
    $("#desing").show(),$("#all-categories").hide(),$("#branding").hide(), $("#busines").hide(),$("#material").hide()
});

$("#material-span-Id").click(function(){
    $("#material").show(),$("#all-categories").hide(),$("#branding").hide(), $("#busines").hide(),$("#desing").hide()
});




// <!-- goy slider -->

$(document).ready(function(){
    var i = 0;


    var slider = [
        {
            title: "",
            description: "",
            imagUrl : ""

        },

        {
            title: "",
            description: "",
            imagUrl : ""
        },

        {
            title: "",
            description: "",
            imagUrl : ""
        },

        // {
        //     title: "",
        //     description: "",
        //     imagUrl : ""
        // }
    ]


    var n = slider.length;
    var sliderWidth = parseFloat($("#myId").css("width"));
    $("#slider").css("width",sliderWidth*n+"px");


    // Create item-slider
    for(var j=0; j < n; j++){
        $("<div class='item-slider' style='width:"+sliderWidth+"px;background-image:url("+slider[j].imagUrl+")'>"+
            "<h1>"+slider[j].title+"</h1>"+
            "<p>"+slider[j].description+"</p>"+
        "</div>")
            .appendTo("#slider");
    }


    // saga cevirmek
    $("#next").on("click",function(){
        i++;
        if(i > (n-1)){
            i=0;
        }
        $("#slider").animate({
            left: -i*sliderWidth+"px"
        },500);
    });


    // sola cevirmek
    $("#prev").on("click",function(){
        i--;
        if(i < 0){
            i = n;
        }
        $("#slider").animate({
            left: -i*sliderWidth+"px"
        },500);
    });

  

});
// <!-- goy slider son -->

// reqemlqer

$("#reqem-esas-div-Id").mouseover(function(){
    // $("#reqem1").animate({innerText:"49"}),$("#reqem2").animate({innerText:"26"}),$("#reqem3").animate({innerText:"144"}),
    // $("#reqem4").animate({innerText:"48"}),$("#reqem5").animate({innerText:"100"})
})


// reqemler son