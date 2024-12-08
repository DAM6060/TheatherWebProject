// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function initializeRemoveButtons() {
    document.querySelectorAll('.remove-Parent').forEach(button => {
        button.addEventListener("click", function () {
            const parent = button.parentNode;
            // Check if the parent exists
            if (parent) {
                parent.remove();
            }
        });
    });
}

document.addEventListener("DOMContentLoaded", function () {
    // Button's intent is to clone the element that's above it
    const clonePreviousSiblingButtons = document.querySelectorAll('button.clone-Previous-Sibling');

    clonePreviousSiblingButtons.forEach(function (clonePreviousSiblingButton) {
        clonePreviousSiblingButton.addEventListener("click", function () {
            const previousSibling = clonePreviousSiblingButton.previousElementSibling;

            // Check if the previous sibling exists
            if (previousSibling) {
                const clone = previousSibling.cloneNode(true);

                // Create and append remove button to clone if it doesn't exist already
                if (clone.querySelector('.remove-Parent') === null) {

                    const removeButton = document.createElement('button');
                    removeButton.classList.add('remove-Parent');
                    removeButton.type = 'button'; // Ensure it's a button and not a submit button
                    clone.appendChild(removeButton);
                    removeButton.textContent = 'Remove';
                }

                // Insert clone before the add button
                previousSibling.parentNode.insertBefore(clone, clonePreviousSiblingButton);
                initializeRemoveButtons(); // Initialize remove buttons for new clones
            }
        });
    });

    // Initialize remove buttons for existing elements
    initializeRemoveButtons();
});
