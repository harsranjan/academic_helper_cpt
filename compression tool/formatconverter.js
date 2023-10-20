function convertImage() {
    var imageInput = document.getElementById('imageInput');
    var formatSelect = document.getElementById('formatSelect');
    var convertedImg = document.getElementById('convertedImg');
    var downloadLink = document.getElementById('downloadLink');
  
    var file = imageInput.files[0];
    var reader = new FileReader();
  
    reader.addEventListener('load', function() {
      var image = new Image();
      image.src = reader.result;
  
      image.addEventListener('load', function() {
        var canvas = document.createElement('canvas');
        var ctx = canvas.getContext('2d');
  
        canvas.width = image.width;
        canvas.height = image.height;
        ctx.drawImage(image, 0, 0);
  
        var convertedImage = canvas.toDataURL('image/' + formatSelect.value);
        convertedImg.src = convertedImage;
        downloadLink.href = convertedImage;
        downloadLink.innerHTML = 'Download Converted ' + formatSelect.value.toUpperCase() + ' Image';
      });
    });
  
    if (file) {
      reader.readAsDataURL(file);
    }
  }
  