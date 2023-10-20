function resizeImage() {
    var inputImage = document.getElementById("inputImage");
  
    if (inputImage.files.length == 0) {
      alert("Please select an image");
      return;
    }
  
    var file = inputImage.files[0];
    var reader = new FileReader();
    reader.readAsDataURL(file);
  
    reader.onload = function() {
      var img = new Image();
      img.src = reader.result;
  
      img.onload = function() {
        var canvas = document.createElement("canvas");
        var ctx = canvas.getContext("2d");
  
        var inputWidth = document.getElementById("inputWidth").value;
        var inputHeight = document.getElementById("inputHeight").value;
  
        if (inputWidth == "" || inputHeight == "") {
          alert("Please enter a width and height");
          return;
        }
  
        canvas.width = inputWidth;
        canvas.height = inputHeight;
  
        ctx.drawImage(img, 0, 0, inputWidth, inputHeight);
  
        var resizedImage = document.getElementById("resizedImage");
        var downloadLink = document.getElementById("downloadLink");
  
        resizedImage.innerHTML = '<img src="' + canvas.toDataURL() + '" alt="Resized Image">';
        resizedImage.style.display = "block";
  
        downloadLink.href = canvas.toDataURL();
        downloadLink.style.display = "block";
      };
    };
  }
  