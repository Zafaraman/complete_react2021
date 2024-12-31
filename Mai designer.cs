document.querySelectorAll('.hf-error').forEach(function (element) {
    const value = parseFloat(element.getAttribute('data-value')); // Get the value
    if (value === 0) {
        element.classList.add('red'); // Apply red if 0
    } else {
        element.classList.add('green'); // Apply green for other values
    }
});
