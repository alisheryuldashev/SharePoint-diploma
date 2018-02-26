//Lab 4 Exercise 4 by Alisher Yuldashev. Innotech College

'use strict';

// This function will find all the checkboxes in the table, and add a eventhandler for onclick that
// calls our function tht adds the text entry box
//	 We need to wait for the page to load completely because we can't determine when our JavaScript will run
window.onload = function () {
	// Uncomment the following line if you want to drop into the debugger automatically when the F12 window is open
//	debugger;

	// Find all the check boxes
	var selectBoxes = document.getElementsByClassName('checkme');
	// Make sure we found something
	if (selectBoxes != null && selectBoxes.length > 0) {
		// Loop through all the matches on the web page with a class='checkme'
		for (var idx=0; idx < selectBoxes.length; idx++) {
			// Get the specific match we want to work on
			var currentSelectBox = selectBoxes[idx];
			// We need to get the identify of this item to pass it to the function that will be our onclick event handler
			var identity = currentSelectBox.value;
			// use the DOM to add an event handler for onclick
			currentSelectBox.addEventListener("click",function (identity) {AddQtyBox(identity);});
		}	// for loop
	}	// if statement
}

// This function adds a textbox in the Qty column of the table whenever it is called
function AddQtyBox(caller) {
	debugger;
	// remove row- from the front of identity of this checkbox
	var selector = "row-" + caller.srcElement.value;
	var cellRow = document.getElementById(selector);
	// Make sure we found something
	if (cellRow != null) {
		// Within the row, find the checkbox cell
		var checkboxCell = cellRow.getElementsByClassName("checkme");
		// Make sure we found at least one
		if (checkboxCell != null && checkboxCell.length > 0) {
			// Determine if the user checked the box or unchecked it when they clicked on it
			var isChecked = checkboxCell[0].checked;
			
			// Find the class that represents out <input type='number'> text entry box
			var cell = cellRow.getElementsByClassName("qtyBox");
			if (isChecked) {
				// Add the Qty text input box
				if (cell != null) {
					for (var idx=0; idx < cell.length; idx++) {
						//create a span with a $ symbol in it
						//<span class="currencysymbol">$</span>
						var currencysymbolNode = document.createElement("span");
						currencysymbolNode.setAttribute("class", "currencysymbol");
						var textNode = document.createTextNode("$");
						currencysymbolNode.appendChild(textNode);
						cell[0].appendChild(currencysymbolNode);
						// Create a new input text box that looks like this
						//	<input type='number' class='qty' min=0 max=32000 name='quantity' value=0></input>
						var qtyElementNode = document.createElement('input');
						qtyElementNode.setAttribute('class','qty');
						qtyElementNode.setAttribute('type','number');
						qtyElementNode.setAttribute('min',0);
						qtyElementNode.setAttribute('max',32000);						
						qtyElementNode.setAttribute('name','quantity');
						qtyElementNode.setAttribute('value',0);
						// Add an event handler when the text box changes
						qtyElementNode.addEventListener('change', function(){UpdateTotal()});
						// inject our <input> as a child of the qtyBox for this row
						cell[0].appendChild(qtyElementNode);
					}
				}
			}
			else {
//				debugger;
				// Remove the Qty text input box
				if (cell != null) {
					for (var idx=0; idx < cell.length; idx++) {
						var hasChild = cell[idx].childElementCount;
						if (hasChild > 0) {
							// we loop through backwards (highest number first otherwise the childElementCount will be destroyed
							for (var idx2 = cell[idx].childElementCount -1; idx2 >= 0; idx2--) {
								cell[idx].removeChild(cell[idx].childNodes[idx2]);
							}
						}
					}
				}
				// Force the totals to update
				UpdateTotal();
			}
		}
	}
}

// This function updates the onscreen total for this table
function  UpdateTotal() {
//	debugger;
	var totalsBoxes = null;
	var totalQty = 0;		// The running total
	
	// Find all the qty boxes
	var qtyBoxes = document.getElementsByClassName('qty');
	// Make sure some existed
	if (qtyBoxes != null && qtyBoxes.length > 0) {
		// Loop through all the qty text fields we found
		for (var idx=0; idx < qtyBoxes.length; idx++) {
			// Get the value from the text box
			var qtyValue = Number(qtyBoxes[idx].value);
			// If the value is a number, add it to our running total
			if (qtyValue != NaN) {
				totalQty += qtyValue;
			}
		}
	}
	
	// Now we need to find the corect place to update the screen
	totalsBoxes = document.getElementsByClassName('totalqty');
	// Make sure we found something
	if (totalsBoxes != null && totalsBoxes.length > 0) {
		// Update the value to be the totalQty sum
		totalsBoxes[0].innerHTML = totalQty;
	}
}