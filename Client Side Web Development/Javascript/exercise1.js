//JavaScript Lab 4 Exercise 1 by Alisher Yuldashev. 
//Programming Diploma - SharePoint Specialization. Innotech College

'use strict';	// this turns on strict for all the JavaScript code on the web page


// This function is called by the Input Button when the user clicks the button
function calculate()
{
	var pi = 3.1415926535897932;
	var radius = 0;
	var volume = 0;
	
    // Obtain the values from the text box for radius  id='radius'
	radius = document.getElementById('radius').value;
	
	// Convert it to a number so we can do math against it
	radius = parseFloat(radius);
	
	// Obtain the value from the text box for volume	id='height'
	volume = document.getElementById('height').value;
	
	// Convert it to a number so we can do math against it
	volume = parseFloat(volume);
	
	// Apply the formula    pi * radius^2 * volume
	var  volumeOfCircle = pi * radius * radius * volume;
	
	// Update the onscreen area identified as id 'answer1'
	var answerToUpdate = document.getElementById('answer1');
	answerToUpdate.innerHTML = 'The volume of the circle is ' + volumeOfCircle.toLocaleString('en', {minimumFractionDigits: 3}); //result formatted as a string with representation of the number with 3 decimals points.
}
