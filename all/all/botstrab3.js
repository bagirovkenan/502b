
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

///navbar

$("#page1").mouseover(function(){
    $(".dropdown1").show()
})

$("#page1").mouseout(function(){
    $(".dropdown1").hide()
})
// //////
$("#page2").mouseover(function(){
    $(".dropdown2").show()
})

$("#page2").mouseout(function(){
    $(".dropdown2").hide()
})
// ///////////////
$("#page3").mouseover(function(){
    $(".dropdown3").show()
})

$("#page3").mouseout(function(){
    $(".dropdown3").hide()
})
/////////////////////////
$("#page4").mouseover(function(){
    $(".dropdown4").show()
})

$("#page4").mouseout(function(){
    $(".dropdown4").hide()
})
////////////////


// navbar son

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


//////
////// $("#material-span-Id").click(function(){
//     $(".all-2").hide(),$(".all-3").hide(),$(".all-5").hide(),$(".all-6").hide()
// })
//////
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


    // $("#reqem1").animate({innerText:"49"},5000);
     
    var i=0;

    if($("#reqem1").text() !="49"){
        var interval = setInterval(function() {                // delay and 
            $("#reqem1").text(i);  
            i++;
            if(i==50){
             clearInterval(interval);
            }
        }, 50);
}

    // $("#reqem2").animate({innerText:"26"});
    // $("#reqem3").animate({innerText:"144"});
    // $("#reqem4").animate({innerText:"48"});
    // $("#reqem5").animate({innerText:"100"})
});

$("#reqem-esas-div-Id").mouseover(function(){


    // $("#reqem1").animate({innerText:"49"},5000);
     
    var j=0;

    if($("#reqem2").text() !="26"){
        var interval2 = setInterval(function() {                // delay and 
            $("#reqem2").text(j);  
            j++;
           
            if(j==27){
           
                clearInterval(interval2);
            }
        }, 50);
}

    // $("#reqem2").animate({innerText:"26"});
    // $("#reqem3").animate({innerText:"144"});
    // $("#reqem4").animate({innerText:"48"});
    // $("#reqem5").animate({innerText:"100"})
});

// //
$("#reqem-esas-div-Id").mouseover(function(){


    // $("#reqem1").animate({innerText:"49"},5000);
     
    var l=0;

    if($("#reqem3").text() !="144"){
        var interval2 = setInterval(function() {                // delay and 
            $("#reqem3").text(l);  
            l++;
           
            if(l==145){
           
                clearInterval(interval2);
            }
        }, 10);
}

    // $("#reqem2").animate({innerText:"26"});
    // $("#reqem3").animate({innerText:"144"});
    // $("#reqem4").animate({innerText:"48"});
    // $("#reqem5").animate({innerText:"100"})
});

$("#reqem-esas-div-Id").mouseover(function(){


    // $("#reqem1").animate({innerText:"49"},5000);
     
    var j=0;

    if($("#reqem4").text() !="53"){
        var interval2 = setInterval(function() {                // delay and 
            $("#reqem4").text(j);  
            j++;
           
            if(j==54){
           
                clearInterval(interval2);
            }
        }, 30);
}

    // $("#reqem2").animate({innerText:"26"});
    // $("#reqem3").animate({innerText:"144"});
    // $("#reqem4").animate({innerText:"48"});
    // $("#reqem5").animate({innerText:"100"})
});


$("#reqem-esas-div-Id").mouseover(function(){


    // $("#reqem1").animate({innerText:"49"},5000);
     
    var j=0;

    if($("#reqem5").text() !="100"){
        var interval2 = setInterval(function() {                // delay and 
            $("#reqem5").text(j);  
            j++;
           
            if(j==101){
           
                clearInterval(interval2);
            }
        }, 20);
}

    // $("#reqem2").animate({innerText:"26"});
    // $("#reqem3").animate({innerText:"144"});
    // $("#reqem4").animate({innerText:"48"});
    // $("#reqem5").animate({innerText:"100"})
});





// ------------------------------------------------------------------------


$("#workResult-Container-Id").mouseover(function(){
    $("#workResult-1-clm2-div2").animate({height:"125px"},500),
    $("#workResult-2-clm2-div2").animate({height:"155px"},500),
    $("#workResult-3-clm2-div2").animate({height:"115px"},500),
    $("#workResult-4-clm2-div2").animate({height:"140px"},500),
    $("#workResult-5-clm2-div2").animate({height:"180px"},500)
})

// progres barlar
$("#progresBaresasdiv-Id").mouseover(function(){
$("#progres1").animate({ width:"320px"},300),$("#progresnoqte1-id").animate({left: "325px"},1000),//$("#prgbar-design-faiz1").animate({innerText:"74"},500),
$("#progres2").animate({ width:"350px"},300),$("#progresnoqte2-id").animate({left: "355px"},1000),//$("#prgbar-design-faiz2").animate({innerText:"80"},500),
$("#progres3").animate({ width:"270px"},300),$("#progresnoqte3-id").animate({left: "275px"},1000),//$("#prgbar-design-faiz3").animate({innerText:"61"},500),
$("#progres4").animate({ width:"400px"},200),$("#progresnoqte4-id").animate({left: "405px"},1000)//$("#prgbar-design-faiz4").animate({innerText:"89"},500)

})

$("#progresBaresasdiv-Id").mouseover(function(){

    var j=0;

    if($("#prgbar-design-faiz1").text() !="74"){
        var interval2 = setInterval(function() {          
            $("#prgbar-design-faiz1").text(j);  
            j++;
           
            if(j==75){
           
                clearInterval(interval2);
            }
        }, 10);
}


})

$("#progresBaresasdiv-Id").mouseover(function(){

    var j=0;

    if($("#prgbar-design-faiz2").text() !="80"){
        var interval2 = setInterval(function() {                
            $("#prgbar-design-faiz2").text(j);  
            j++;
           
            if(j==81){
           
                clearInterval(interval2);
            }
        }, 10);
}


})

$("#progresBaresasdiv-Id").mouseover(function(){

    var j=0;

    if($("#prgbar-design-faiz3").text() !="61"){
        var interval2 = setInterval(function() {                
            $("#prgbar-design-faiz3").text(j);  
            j++;
           
            if(j==62){
           
                clearInterval(interval2);
            }
        }, 10);
}


})

$("#progresBaresasdiv-Id").mouseover(function(){

    var j=0;

    if($("#prgbar-design-faiz4").text() !="89"){
        var interval2 = setInterval(function() {                
            $("#prgbar-design-faiz4").text(j);  
            j++;
           
            if(j==90){
           
                clearInterval(interval2);
            }
        }, 10);
}


})





// $("#progresBaresasdiv-Id").mouseover(function(){
//  $("#progresnoqte-id").animate({left: "345px"},1500)

// }0)

// progresbarlar son


// 4 lu slider
$(document).on('ready', function() {
   
    $(".regular").slick({
      dots: true,
      infinite: true,
      slidesToShow: 3,
      slidesToScroll: 1
    });   
  });



// 4 lu slider son

// footer 
// $("#input-name").click(function(){
//     $("#input-name").css("border"," solid 2px #black")
//  })
 

$("#input-name").click(function(){
   $("#input-name").css("border-bottom","3px solid #ffffff "),$("#input-email").css("border-bottom","1px solid #2b2939"), $("#contactUs-message").animate({height:"40px"})
})

$("#input-email").click(function(){
    $("#input-email").css("border-bottom","3px solid #ffffff "), $("#input-name").css("border-bottom","1px solid #2b2939"), $("#contactUs-message").animate({height:"40px"})
 })

 $("#contactUs-message").click(function(){
    $("#contactUs-message").animate({height:"200px"}),$("#input-email").css("border-bottom","1px solid #2b2939"),$("#input-name").css("border-bottom","1px solid #2b2939")  
 })

 $("#categories-clmd3-div-id").click(function(){
    $("#input-email").css("border-bottom","1px solid #2b2939"), $("#contactUs-message").animate({height:"40px"}), $("#input-name").css("border-bottom","1px solid #2b2939")
 })

 

// footerr son