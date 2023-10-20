const compressBtn = document.getElementById('compressBtn');

compressBtn.addEventListener('click', () => {
  const imageFile = document.getElementById('imageFile').files[0];
  const maxSize = document.getElementById('maxSize').value;

  if (!imageFile || !maxSize) {
    alert('Please select an image file and enter a maximum file size.');
    return;
  }

  const reader = new FileReader();

  reader.onload = () => {
    const img = new Image();

    img.onload = () => {
      const canvas = document.createElement('canvas');
      const ctx = canvas.getContext('2d');

      let width = img.width;
      let height = img.height;
      let ratio = 1;

      while (canvas.toDataURL('image/jpeg', 0.5).length / 1024 > maxSize) {
        ratio *= 0.9;
        width *= ratio;
        height *= ratio;
      }

      canvas.width = width;
      canvas.height = height;

      ctx.drawImage(img, 0, 0, width, height);

      const compressedImage = canvas.toDataURL('image/jpeg', 0.5);

      const resultDiv = document.getElementById('result');
      resultDiv.innerHTML = `
        <h2>Compressed Image</h2>
        <img src="${compressedImage}" alt="Compressed Image">
      `;
    };

    img.src = reader.result;
  };

  reader.readAsDataURL(imageFile);
});
function compressImage() {
    var inputImage = document.getElementById("inputImage");
    var inputSize = document.getElementById("inputSize").value;
  
    if (inputImage.files.length == 0 || inputSize == "") {
      alert("Please select an image and enter file size");
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
  
        canvas.width = width;
        canvas.height = height;
  
        ctx.drawImage(img, 0, 0, width, height);
  
        var quality = 1;
        var maxSize = inputSize * 1024;
  
        while (canvas.toDataURL("image/jpeg", quality).length > maxSize) {
          quality -= 0.01;
        }
  
        var compressedDataURL = canvas.toDataURL("image/jpeg", quality);
        var compressedImage = document.getElementById("compressedImage");
        var downloadLink = document.getElementById("downloadLink");
  
        compressedImage.innerHTML = '<img src="' + compressedDataURL + '" alt="Compressed Image">';
        compressedImage.style.display = "block";
  
        downloadLink.href = compressedDataURL;
        downloadLink.style.display = "block";
      };
    };
  }
  