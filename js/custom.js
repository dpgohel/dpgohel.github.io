// Skillbar animation script
jQuery(document).ready(function(){
	// Author code here
	'use strict';
	jQuery('.skillbar').each(function(){
		jQuery(this).find('.skillbar-bar').animate({
			width:jQuery(this).attr('data-percent') // Fill color perticular width
		},6000);
	});
});

//Scroll bottom to top
$(window).scroll(function() {
	// Author code here
	'use strict';
	if ($(this).scrollTop() >= 70) {        // If page is scrolled more than 70px
		$('#return-to-top').fadeIn(200);    // Fade in the arrow
	} else {
		$('#return-to-top').fadeOut(200);   // Else fade out the arrow
	}
	return false;
});
$('#return-to-top').on('click',function() {      // When arrow is clicked
	// Author code here
	'use strict';
	$('body,html').animate({
		scrollTop : 0                       // Scroll to top of body
	}, 500);
	return false;
});


/* Home Page Ajax contact form with php */
$("#contactForm").submit(function(event){
	// Author code here
	'use strict';
    // cancels the form submission
    event.preventDefault();
    submitForm();
});
function submitForm(){
	// Author code here
	'use strict';
    // Initiate Variables With Form Content
    var name = $("#name").val();
    var email = $("#email").val();
    var message = $("#message").val();
 
    $.ajax({
        type: "POST",
        url: "process.php",
        data: "name=" + name + "&email=" + email + "&message=" + message,
        success : function(text){
            if (text == "success"){
                formSuccess();
            }
        }
    });
}
function formSuccess(){
	// Author code here
	'use strict';
    $("#msgSubmit").removeClass( "d-none" );
	$("#name").val('');
    $("#email").val('');
    $("#message").val('');
}


/* Contact Page Ajax contact form with php */
$("#secondcontactForm").submit(function(event){
	// Author code here
	'use strict';
    // cancels the form submission
    event.preventDefault();
    secondsubmitForm();
});
function secondsubmitForm(){
	// Author code here
	'use strict';
    // Initiate Variables With Form Content
    var scname = $("#scname").val();
    var scemail = $("#scemail").val();
	var scsubject = $("#scsubject").val();
    var scmessage = $("#scmessage").val();
 
    $.ajax({
        type: "POST",
        url: "process.php",
        data: "scname=" + scname + "&scemail=" + scemail + "&scsubject=" + scsubject + "&scmessage=" + scmessage,
        success : function(text){
            if (text == "success"){
                secondformSuccess();
            }
        }
    });
}
function secondformSuccess(){
	// Author code here
	'use strict';
    $("#scmsgSubmit").removeClass( "d-none" );
	$("#scname").val('');
    $("#scemail").val('');
    $("#scsubject").val('');
    $("#scmessage").val('');
}