//Lab 4 Exercise 3 by Alisher Yuldashev. Innotech College

'use strict';
debugger;
function verifySentence(){

	//get the sentence that user types in
	var sentenceTag = document.getElementById('sentence');
	if (sentenceTag != null) {
		var userInput = sentenceTag.value; 
		if (userInput != null && userInput.length > 0) {
			//call the Pangram function correctly
			var sentenceIsPangram = Pangram(userInput);

			//create a message that we'll write to the HTML page by checking a boolean condition. 
			var message = (sentenceIsPangram === false) ? "This is not a Pangram" : "The sentence '" + userInput + "'' is a Pangram";

			document.getElementById("sentenceOutcome").innerHTML = message;
		}
	}   
}

// This function removes all characters which are not in A to Z
//    it removes spaces, digits, punctuation, etc.
function RemoveBadCharacters(sentence) {
	var modifiedSentence = sentence;
	if (sentence != null && (typeof sentence == 'string') && sentence.length > 0) {
		var modifiedSentence = sentence.replace(/[^a-zA-Z]/g,""); //I used regular expression replace method to replace any characters that are not between the brackets with nothing "". Not sure if i had to also add [0-9] to replace any digits. 
	}
	
	// Replace all the non-alphabet characters with a blank
	return modifiedSentence;
}

// This function determines if the sentence is a pangram
function Pangram(sentence) {
    'use strict';
    
		var ispangram = true;	// initially all sentences will be considered pangrams until proven otherwise
		
        var alphabet = ["a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"];
		
		// Blank sentences are always false -- don't waste time testing it if the sentence is blank
        if(sentence.length<=0){
            ispangram = false;
		}
		else { 
		
			// Clean up the  sentence passed in to remove characters not in the a-z range
			sentence = RemoveBadCharacters(sentence);
			
			// Convert all uppercase A-Z to lowercase a-z
			sentence = sentence.toLowerCase();
			
			// Loop through the letters in the alphabet array, and test if that character is inside the
			// sentence variable passed in to you
			for (var idx=0; idx < alphabet.length; idx++) {
				var testAgainstCharacter = alphabet[idx];
				//var foundThisCharacter = false;
				var foundAt = false;
				for (var idx2=0; idx2 < sentence.length; idx2++) {
					// when each of the letters is being tested, you can determine if the sentence qualifies as
					// a Pagram using a condition (which you will need to write)
					if (testAgainstCharacter == sentence[idx2]) {
						//foundThisCharacter =true;
						foundAt = idx2;
						//I found it, don't test any more characters in the string. 
					}
				}
				//if (foundThisCharacter == false)
				if (foundAt == false) {
					ispangram = false;
					//don't test the rest of the alphabet
				}
			}
		}
    return ispangram;
}