// Function to add a new element
function addNewElement() {
    const table = document.querySelector('.table');

    const newElement = document.createElement('div');
    newElement.classList.add('element');
    newElement.textContent = 'New Element';

    table.appendChild(newElement);
}

// Add a click event to the "Add New Element" button
const addElementBtn = document.getElementById('addElementBtn');
addElementBtn.addEventListener('click', addNewElement);
