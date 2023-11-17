function convertToPDF() {
    var inputImage = document.getElementById("inputImage");
  
    if (inputImage.files.length == 0) {
      alert("Please select at least one image");
      return;
    }
  
    var doc = new jsPDF();
    var totalImages = inputImage.files.length;
    var processedImages = 0;
  
    for (var i = 0; i < totalImages; i++) {
      var file = inputImage.files[i];
      var reader = new FileReader();
      reader.readAsDataURL(file);
  
      reader.onload = function(event) {
        var img = new Image();
        img.src = event.target.result;
  
        img.onload = function() {
          var canvas = document.createElement("canvas");
          var ctx = canvas.getContext("2d");
  
          canvas.width = img.width;
          canvas.height = img.height;
  
          ctx.drawImage(img, 0, 0, canvas.width, canvas.height);
  
          var dataURL = canvas.toDataURL("image/jpeg");
  
          doc.addImage(dataURL, "JPEG", 0, 0, doc.internal.pageSize.getWidth(), doc.internal.pageSize.getHeight());
          processedImages++;
  
          if (processedImages == totalImages) {
            var pdf = doc.output("blob");
            var pdfUrl = URL.createObjectURL(pdf);
            var pdfViewer = document.getElementById("pdf");
            var downloadLink = document.getElementById("downloadLink");
  
            pdfViewer.innerHTML = '<embed src="' + pdfUrl + '" type="application/pdf" width="100%" height="600px" />';
            pdfViewer.style.display = "block";
  
            downloadLink.href = pdfUrl;
            downloadLink.style.display = "block";
          }
        };
      };
    }
  }
  