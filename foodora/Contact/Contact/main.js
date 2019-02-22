$(function(){
    $(".fa-bars").click(function(){
      $(".rightNav").css({"top":"0px","right":"0px"});
      $(".contentDiv").css("display","block");
    })
    $(".fa-times-circle").click(function(){
        $(".rightNav").css("right","-250px");
        $(".contentDiv").css("display","none");
        
    })
});