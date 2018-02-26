//Lab 4 Exercise 2 by Alisher Yuldashev. Innotech College

'use strict';

/* Original 
	var nystories = document.querySelector("p").offsetTop;
	window.onscroll = function() {
		if (window.pageYOffset > 0) {
		var opac = (window.pageYOffset / nystories);
		console.log(opac);
		document.body.style.background = "linear-gradient(rgba(255, 255, 255, " + opac + "), rgba(255, 255, 255, " + opac + ")), url(https://s3-us-west-2.amazonaws.com/s.cdpn.io/4273/times-square-perspective.jpg) no-repeat";
		}
	}
*/

	// We have to make sure the web page is completely loaded and ready before
	// we can run this code.  Otherwise it won't work because of timing issues
    window.onload = function () {
		// If you uncomment the following line,
		//		it will drop into the debugger only if F12 window is open
//		debugger;

		// Get the element on the web page that contains the image
		var nystories = document.getElementsByClassName('scrollToReveal');
		// Make sure we actually found a class on the page
		if (nystories != null && nystories.item.length > 0 ) {
			// iterate through all the possible matches for the class and apply the change
			for (var idx=0; idx < nystories.item.length; idx++) {
				// This gets the specific match
				var nyimage = nystories[idx];
				
				// If the match wasn't null, then we want to apply the gradient
				if (nyimage != null) {
					// Get the offset to where the image is on the page so that we only
					// process the area where the image is
					var nystoriesoffset = nyimage.offsetTop;
					
					// Attach an onscroll event to the web browser window so that any scrolling calls this function
					window.onscroll = function() {
						// we only care about the vertical scrolling, not the horizontal scrolling
						if (window.pageYOffset > 0) {
							// Move the opaque box to reflect the scroll amount they have done
							var opaque = (window.pageYOffset / nystoriesoffset);
							console.log(opaque);		// just for debugging purposes
							
							// do we need to alter the text color (since it is white now?)
							nyimage.style.color = "black";
							// What minor changes to the code are required from the original from codepen.io?
							nyimage.style.background = "linear-gradient(rgba(255, 255, 255, " + opaque + "), rgba(255, 255, 255, " + opaque + ")), url(https://s3-us-west-2.amazonaws.com/s.cdpn.io/4273/times-square-perspective.jpg) no-repeat";
						}
					}
				}
			}
		}
	}