AOS.init({
    offset: 400, // offset (in px) from the original trigger point
    delay: 0, // values from 0 to 3000, with step 50ms
    duration: 1000 // values from 0 to 3000, with step 50ms
});
$("#animalName").on("change", function () {
    var optionSelected = $("option:selected", this);
    var valueSelected = this.value;
    switch (valueSelected) {



        case "Japanese Spider Crab":
            $("#CarouselImg1").attr("src", "/Images/crab1.jpg");
            $("#CarouselImg2").attr("src", "/Images/crab2.jpg");
            $("#CarouselImg3").attr("src", "/Images/crab3.jpg");
            break;

        case "Blue Whale":
            $("#CarouselImg1").attr("src", "/Images/bw1.jpg");
            $("#CarouselImg2").attr("src", "/Images/bw2.jpg");
            $("#CarouselImg3").attr("src", "/Images/bw3.jpg");
            break;
        case "Blood Belly Comb Jelly":
            $("#CarouselImg1").attr("src", "/Images/comb1.jpg");
            $("#CarouselImg2").attr("src", "/Images/comb2.png");
            $("#CarouselImg3").attr("src", "/Images/comb3.jpg");
            break;
        case "Clownfish":
            $("#CarouselImg1").attr("src", "/Images/cf1.jpg");
            $("#CarouselImg2").attr("src", "/Images/cf2.jpg");
            $("#CarouselImg3").attr("src", "/Images/cf3.jpg");
            break;
        case "Green Turtle":
            $("#CarouselImg1").attr("src", "/Images/tur1.jpg");
            $("#CarouselImg2").attr("src", "/Images/tur2.jpg");
            $("#CarouselImg3").attr("src", "/Images/tur3.jpg");
            break;
        

    }

    
        
});
