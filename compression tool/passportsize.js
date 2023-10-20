function convertToPassportSize() {
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
  
        var width = img.width;
        var height = img.height;
        var size = Math.min(width, height);
  
        canvas.width = size;
        canvas.height = size;
  
        var x = (width - size) / 2;
        var y = (height - size) / 2;
  
        ctx.drawImage(img, x, y, size, size, 0, 0, size, size);
  
        var passportSizePhoto = document.getElementById("passportSizePhoto");
        var downloadLink = document.getElementById("downloadLink");
  
        passportSizePhoto.innerHTML = '<img src="' + canvas.toDataURL() + '" alt="Passport Size Photo">';
        passportSizePhoto.style.display = "block";
  
        downloadLink.href = canvas.toDataURL();
        downloadLink.style.display = "block";
      };
    };
  }
  