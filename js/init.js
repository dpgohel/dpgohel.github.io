/*
 * Copyright (c) 2021 Marketify
 * Author: Marketify
 * This file is made for CURRENT TEMPLATE
*/

jQuery(document).ready(function(){

	"use strict";
	
	// here all ready functions
	
	know_tm_content_height();
	know_tm_menu_width();
	know_tm_portfolio();
	know_tm_portfolio_popup();
	know_tm_service_popup();
	know_tm_news_popup();
	know_tm_cursor();
	know_tm_imgtosvg();
	know_tm_popup();
	know_tm_data_images();
	know_tm_contact_form();
	know_tm_menubar();
	know_tm_hero_height();
	know_tm_intro_tab();
	if(jQuery('.know_tm_hero .main_menu, .know_tm_fixed_content .menubar').length){
		know_tm_circular_progress();
	}
	know_tm_extra_menu();
	
	jQuery(window).load('body', function(){
		know_tm_my_load();
	});
	
	jQuery(window).on('resize', function(){
		know_tm_hero_height();
	});
	
});

// -----------------------------------------------------
// ---------------   FUNCTIONS    ----------------------
// -----------------------------------------------------

// -----------------------------------------------------
// ---------------   HERO HEIGHT    --------------------
// -----------------------------------------------------

function know_tm_hero_height(){
	
	"use strict";
	
	var H 		= $('.know_tm_hero .main_menu').outerHeight();
	var WW		= jQuery(window).width();
	var topbarH = $('.know_tm_topbar').height();
	if(WW >= 1040){
		$('.know_tm_hero .main_info').css({minHeight: 'calc(100vh - '+H+'px)',paddingTop:topbarH+'px'});
	}
}

// -------------------------------------------------
// ------------    CONTENT HEIGHT    ---------------
// -------------------------------------------------

function know_tm_content_height(){
	
	"use strict";
	
	var ww				= jQuery(window).width();
	var wh				= jQuery(window).height();
	var topbarH			= jQuery('.know_tm_topbar').outerHeight();
	var footerH			= jQuery('.know_tm_copyright.fixed').outerHeight();
	var topPosition		= topbarH+62;
	var topPosition2	= topbarH+35;
	var topPosition3	= topbarH+25;
	var total			= wh-topbarH-footerH-62;
	var total2			= wh-topbarH-footerH-40;
	var total3			= wh-topbarH-footerH;
	
	if(ww > 1400){
		jQuery('.know_tm_fixed_content .fixed_content_inner').css({height:total+'px',top:topPosition+'px'});
	}
	else if(ww >= 1040){
		jQuery('.know_tm_fixed_content .fixed_content_inner').css({height:total3+'px',top:topPosition3+'px'});
	}else{
		jQuery('.know_tm_fixed_content .fixed_content_inner').css({height:total2+'px',top:topPosition2+'px'});
	}
}

// -------------------------------------------------
// -----------------    PORTFOLIO    ---------------
// -------------------------------------------------

function know_tm_portfolio(){

	"use strict";

	if(jQuery().isotope) {

		// Needed variables
		var filter		 = jQuery('.know_tm_portfolio .portfolio_filter ul');

		if(filter.length){
			// Isotope Filter 
			filter.find('a').on('click', function(){
				var element		= jQuery(this);
				var selector 	= element.attr('data-filter');
				var list		= element.closest('.know_tm_portfolio').find('.portfolio_list').children('ul');
				list.isotope({ 
					filter				: selector,
					animationOptions	: {
						duration			: 750,
						easing				: 'linear',
						queue				: false
					}
				});
				
				filter.find('a').removeClass('current');
				element.addClass('current');
				return false;
			});	
		}
	}
}

// -------------------------------------------------
// -----------  PORTFOLIO POPUP  -------------------
// -------------------------------------------------

function know_tm_portfolio_popup(){
	
	"use strict";
	
	var modalBox		= jQuery('.know_tm_modalbox');
	var button			= jQuery('.know_tm_portfolio .portfolio_popup');
	var closePopup		= modalBox.find('.close');
	
	button.off().on('click',function(){
		var element = jQuery(this);
		var parent 	= element.closest('.list_inner');
		var content = parent.find('.hidden_content').html();
		var image	= parent.find('.image .main').data('img-url');
		var details = parent.find('.details').html();
		modalBox.addClass('opened');
		modalBox.find('.description_wrap').html(content);
		modalBox.find('.popup_details').prepend('<div class="top_image"><img src="img/thumbs/4-2.jpg" alt="" /><div class="main" data-img-url="'+image+'"></div></div>');
		modalBox.find('.popup_details .top_image').after('<div class="portfolio_main_title">'+details+'<div>');
		know_tm_data_images();
		return false;
	});
	closePopup.on('click',function(){
		modalBox.removeClass('opened');
		modalBox.find('.description_wrap').html('');
		return false;
	});
}

// -------------------------------------------------
// -------------  SERVICE POPUP  -------------------
// -------------------------------------------------

function know_tm_service_popup(){
	
	"use strict";
	
	var modalBox		= jQuery('.know_tm_modalbox');
	var button			= jQuery('.know_tm_services .know_tm_full_link');
	var closePopup		= modalBox.find('.close');
	
	button.on('click',function(){
		var element = jQuery(this);
		var parent  = element.closest('.list_inner');
		var title	= parent.find('.title').text();
		var content = parent.find('.hidden_content').html();
		modalBox.addClass('opened');
		modalBox.find('.description_wrap').html(content);
		know_tm_data_images();
		modalBox.find('.service_informations .image').after('<div class="title"><h3>'+title+'</h3></div>');
		return false;
	});
	closePopup.on('click',function(){
		modalBox.removeClass('opened');
		modalBox.find('.description_wrap').html('');
		return false;
	});
}

// -------------------------------------------------
// ----------------  NEWS POPUP  -------------------
// -------------------------------------------------

function know_tm_news_popup(){
	
	"use strict";
	
	var modalBox		= jQuery('.know_tm_modalbox');
	var button			= jQuery('.know_tm_news .know_tm_full_link,.know_tm_news .news_list ul li .details .title a');
	var closePopup		= modalBox.find('.close');
	
	button.on('click',function(){
		var element  = jQuery(this);
		var parent 	 = element.closest('.list_inner');
		var content  = parent.find('.hidden_content').html();
		var image	 = parent.find('.image .main').data('img-url');
		var category = parent.find('.details .category a').text();
		var title	 = parent.find('.details .title a').text();
		modalBox.addClass('opened');
		modalBox.find('.description_wrap').html(content);
		modalBox.find('.news_informations').prepend('<div class="image"><img src="img/thumbs/4-2.jpg" alt="" /><div class="main" data-img-url="'+image+'"></div></div>');
		modalBox.find('.news_informations .image').after('<div class="details"><span>'+category+'</span><h3>'+title+'</h3><div>');
		know_tm_data_images();
		return false;
	});
	closePopup.on('click',function(){
		modalBox.removeClass('opened');
		modalBox.find('.description_wrap').html('');
		return false;
	});
}

// -----------------------------------------------------
// ---------------   MENU WIDTH   ----------------------
// -----------------------------------------------------

function know_tm_menu_width(){
	
	"use strict";
	
	var ww	= jQuery(window).width();
	var btn	= jQuery('.know_tm_hero .main_menu ul li a');
	
//	211->235 + 4 638 -> 654
	btn.on('mouseenter',function(){
		var element 	= jQuery(this);
		var li			= element.closest('li');
		if(li.hasClass('active') || li.hasClass('entered')){return false;}
		li.closest('ul').children().removeClass('entered');
		li.addClass('entered');
		var elWidth		= li.outerWidth();
		var textWidth	= li.find('span').outerWidth();
		li.css({width: elWidth+textWidth+'px'});
	}).on('mouseleave',function(){
		var element 	= jQuery(this);
		var li			= element.closest('li');
		var allLi		= li.closest('ul').children();
		var fixedLi		= li.closest('ul').children('.fixed');
		var activeLi	= li.closest('ul').children('.active');
		allLi.removeClass('entered').css({width:'135px'});
		if(ww <= 1400){
			allLi.removeClass('entered').css({width:'95px'});
		}
		
		if(activeLi.length){
			var elWidth		= 135;
			if(ww <= 1400){
				elWidth = 95;
			}
			var textWidth	= activeLi.find('span').outerWidth();
			activeLi.removeClass('fixed').addClass('active').css({width: elWidth+textWidth+'px'});
		}
	});
	
	btn.on('click',function(){
		var element 	= jQuery(this);
		var li			= element.closest('li');
		var href		= element.attr('href');
		if(li.hasClass('active') && !li.hasClass('entered')){
			return false;
		}
		li.addClass('active fixed');
		var mainMenu	= element.closest('.main_menu');
		
		if(ww <= 1040){
			$('html, body').animate({
				scrollTop: $('.know_tm_mainpart').offset().top - 30
			}, 1000);
		}else{
			$('html, body').animate({
				scrollTop: mainMenu.offset().top - 30
			}, 1000);
		}
		
		
		li.siblings().removeClass('active').css({width:'135px'});
		if(ww <= 1400){
			li.siblings().removeClass('active').css({width:'95px'});
		}
		$('.know_tm_main_section.active').removeClass('active');
		jQuery('.know_tm_mainpart').addClass('opened');
		jQuery('.know_tm_hero .background_shape').addClass('opened');
		jQuery('.know_tm_copyright.hidden').addClass('visible');
		$(href).addClass('active');
		
		if(!li.hasClass('entered')){
			var elWidth		= li.outerWidth();
			var textWidth	= li.find('span').outerWidth();
			li.css({width: elWidth+textWidth+'px'});
		}
		know_tm_owl_carousel();
		
		return false;
	});
	
	jQuery('.know_tm_hero .main_menu ul li.active').each(function(){
		var element 	= jQuery(this);
		var elWidth		= element.outerWidth();
		var textWidth	= element.find('span').outerWidth();
		var href		= element.find('a').attr('href');
		element.css({width: elWidth+textWidth+'px'});
		$(href).addClass('active');
	});
}

// -------------------------------------------------
// -------------  PROGRESS BAR  --------------------
// -------------------------------------------------

function tdProgress(container){
	
	"use strict";
		
	container.find('.progress_inner').each(function() {
		var progress 		= jQuery(this);
		var pValue 			= parseInt(progress.data('value'), 10);
		var pColor			= progress.data('color');
		var pBarWrap 		= progress.find('.bar');
		var pBar 			= progress.find('.bar_in');
		var number 			= progress.find('.number');
		var label 			= progress.find('.label');
		number.css({right:(100 - pValue)+'%'});
		setTimeout(function(){label.addClass('opened');},500);
		pBar.css({width:pValue+'%', backgroundColor:pColor});
		setTimeout(function(){pBarWrap.addClass('open');});
	});
}
function progress_by_frenify(wrapper){
	
	"use strict";
	
	var element;
	if(wrapper){
		element = wrapper.find('.dodo_progress');
	}else{
		element = jQuery('.dodo_progress');
	}
	element.each(function() {
		var pWrap = jQuery(this);
		pWrap.find('.number').css({right:'100%'});
		console.log(pWrap.find('.number').length);
		pWrap.waypoint({handler: function(){tdProgress(pWrap);},offset:'90%'});	
	});
}
if(!$('.know_tm_extra_menu').length){
	progress_by_frenify();
}

// -----------------------------------------------------
// ---------------   PRELOADER   -----------------------
// -----------------------------------------------------

function know_tm_preloader(){
	
	"use strict";
	
	var isMobile = /Android|webOS|iPhone|iPad|iPod|BlackBerry/i.test(navigator.userAgent) ? true : false;
	var preloader = $('#preloader');
	
	if (!isMobile) {
		setTimeout(function() {
			preloader.addClass('preloaded');
		}, 800);
		setTimeout(function() {
			preloader.remove();
		}, 2000);

	} else {
		preloader.remove();
	}
}

// -----------------------------------------------------
// -----------------   MY LOAD    ----------------------
// -----------------------------------------------------

function know_tm_my_load(){
	
	"use strict";
	
	var speed	= 500;
	setTimeout(function(){know_tm_preloader();},speed);
	setTimeout(function(){jQuery('body').addClass('opened');},speed+2000);
}

// -----------------------------------------------------
// ------------------   CURSOR    ----------------------
// -----------------------------------------------------

function know_tm_cursor(){
	
    "use strict";
	
	var myCursor	= jQuery('.mouse-cursor');
	
	if(myCursor.length){
		if ($("body")) {
        const e = document.querySelector(".cursor-inner"),
            t = document.querySelector(".cursor-outer");
        let n, i = 0,
            o = !1;
        window.onmousemove = function (s) {
            o || (t.style.transform = "translate(" + s.clientX + "px, " + s.clientY + "px)"), e.style.transform = "translate(" + s.clientX + "px, " + s.clientY + "px)", n = s.clientY, i = s.clientX
        }, $("body").on("mouseenter", "a,.know_tm_topbar .trigger, .cursor-pointer", function () {
            e.classList.add("cursor-hover"), t.classList.add("cursor-hover")
        }), $("body").on("mouseleave", "a,.know_tm_topbar .trigger, .cursor-pointer", function () {
            $(this).is("a") && $(this).closest(".cursor-pointer").length || (e.classList.remove("cursor-hover"), t.classList.remove("cursor-hover"))
        }), e.style.visibility = "visible", t.style.visibility = "visible"
    }
	}
};

// -----------------------------------------------------
// ---------------    IMAGE TO SVG    ------------------
// -----------------------------------------------------

function know_tm_imgtosvg(){
	
	"use strict";
	
	jQuery('img.html').each(function(){
		
		var jQueryimg 		= jQuery(this);
		var imgClass		= jQueryimg.attr('class');
		var imgURL			= jQueryimg.attr('src');

		jQuery.get(imgURL, function(data) {
			// Get the SVG tag, ignore the rest
			var jQuerysvg = jQuery(data).find('svg');

			// Add replaced image's classes to the new SVG
			if(typeof imgClass !== 'undefined') {
				jQuerysvg = jQuerysvg.attr('class', imgClass+' replaced-svg');
			}

			// Remove any invalid XML tags as per http://validator.w3.org
			jQuerysvg = jQuerysvg.removeAttr('xmlns:a');

			// Replace image with new SVG
			jQueryimg.replaceWith(jQuerysvg);

		}, 'xml');

	});
}

// -----------------------------------------------------
// --------------------   POPUP    ---------------------
// -----------------------------------------------------

function know_tm_popup(){
	
	"use strict";

	jQuery('.gallery_zoom').each(function() { // the containers for all your galleries
		jQuery(this).magnificPopup({
			delegate: 'a.zoom', // the selector for gallery item
			type: 'image',
			gallery: {
			  enabled:true
			},
			removalDelay: 300,
			mainClass: 'mfp-fade'
		});

	});
	jQuery('.popup-youtube, .popup-vimeo').each(function() { // the containers for all your galleries
		jQuery(this).magnificPopup({
			disableOn: 700,
			type: 'iframe',
			mainClass: 'mfp-fade',
			removalDelay: 160,
			preloader: false,
			fixedContentPos: false
		});
	});
	
	jQuery('.soundcloude_link').magnificPopup({
	  type : 'image',
	   gallery: {
		   enabled: true, 
	   },
	});
}

// -----------------------------------------------------
// ---------------   DATA IMAGES    --------------------
// -----------------------------------------------------

function know_tm_data_images(){
	
	"use strict";
	
	var data			= jQuery('*[data-img-url]');
	
	data.each(function(){
		var element			= jQuery(this);
		var url				= element.data('img-url');
		element.css({backgroundImage: 'url('+url+')'});
	});
}

// -----------------------------------------------------
// ----------------    CONTACT FORM    -----------------
// -----------------------------------------------------

function know_tm_contact_form(){
	
	"use strict";
	
	jQuery(".contact_form #send_message").off().on('click', function(){
		
		var name 		= jQuery(".contact_form #name").val();
		var email 		= jQuery(".contact_form #email").val();
		var message 	= jQuery(".contact_form #message").val();
		var subject 	= jQuery(".contact_form #subject").val();
		var success     = jQuery(".contact_form .returnmessage").data('success');
	
		jQuery(".contact_form .returnmessage").empty(); //To empty previous error/success message.
		//checking for blank fields	
		if(name===''||email===''||message===''){
			
			jQuery('div.empty_notice').slideDown(500).delay(2000).slideUp(500);
		}
		else{
			// Returns successful data submission message when the entered information is stored in database.
			jQuery.post("modal/contact.html",{ ajax_name: name, ajax_email: email, ajax_message:message, ajax_subject: subject}, function(data) {
				
				jQuery(".contact_form .returnmessage").append(data);//Append returned message to message paragraph
				
				
				if(jQuery(".contact_form .returnmessage span.contact_error").length){
					jQuery(".contact_form .returnmessage").slideDown(500).delay(2000).slideUp(500);		
				}else{
					jQuery(".contact_form .returnmessage").append("<span class='contact_success'>"+ success +"</span>");
					jQuery(".contact_form .returnmessage").slideDown(500).delay(4000).slideUp(500);
				}
				
				if(data===""){
					jQuery("#contact_form")[0].reset();//To reset form fields on success
				}
				
			});
		}
		return false; 
	});
}

// -----------------------------------------------------
// --------------------    WOW JS    -------------------
// -----------------------------------------------------

 new WOW().init();

// -----------------------------------------------------
// ----------------    OWL CAROUSEL    -----------------
// -----------------------------------------------------

function know_tm_owl_carousel(){

	"use strict";
	
	var carousel			= jQuery('.know_tm_testimonials .owl-carousel');
	var carousel2			= jQuery('.know_tm_fixed_content .know_tm_testimonials .owl-carousel');
	
	var rtlMode		= false;

	if(jQuery('body').hasClass('rtl')){
		rtlMode = 'true';
	}
	
	carousel2.owlCarousel({
		items: 1,
	});
	
	carousel.owlCarousel({
		loop: true,
		items: 2,
		lazyLoad: false,
		margin: 25,
		autoplay: true,
		autoplayTimeout: 7000,
		rtl: rtlMode,
		dots: true,
		nav: false,
		navSpeed: false,
		responsive : {
				0 : {
					items: 1
				},
				768 : {
					items: 2
				}
			}
	});
	know_tm_imgtosvg();
}

function know_tm_circular_progress(){
	"use strict";
	
	var ww		= jQuery(window).width();
	var circVal;
	
	if(ww > 1400){
		circVal = 213;
	}
	else if(ww >= 768){
		circVal = 170;
	}
	else{
		circVal = 120;
	}
	
	jQuery('.circular_progress_bar .myCircle').each(function(){
		var element	= jQuery(this);
		element.append('<h3 class="number"></h3>');
		var value	= element.data('value');
		element.circleProgress({
			size: circVal,
			value: 0,
			animation: {duration: 1400},
			thickness: 5,
			fill: "#ff451b",
			emptyFill: 'rgba(0,0,0,0)',
			startAngle: -Math.PI/2
		  }).on('circle-animation-progress', function(event, progress, stepValue) {
				element.find('h3').text(parseInt(stepValue.toFixed(2)*100) + '%');
		  });
		  element.circleProgress('value', 1.0);
		  setTimeout(function() { element.circleProgress('value', value); }, 1400);
	});
}

function by_frenify(wrapper,speed){
	"use strict";
	
	var ww		= jQuery(window).width();
	var circVal;
	
	if(ww > 1400){
		circVal = 213;
	}
	else if(ww >= 768){
		circVal = 170;
	}
	else{
		circVal = 120;
	}
	
	var element = wrapper.find('.myCircle');
	
	if(element.length > 0){
		
		element.each(function(){
			var e		= jQuery(this);
			var value	= e.data('value');
			var speed2 	= 1400;
			
			if(!e.find('.number').length){
				e.append('<h3 class="number"></h3>');
			}
			
			e.circleProgress({
				size: circVal,
				value: 0,
				animation: {duration: speed2},
				thickness: 5,
				fill: "#ff451b",
				emptyFill: 'rgba(0,0,0,0)',
				startAngle: -Math.PI/2
			}).on('circle-animation-progress', function(event, progress, stepValue) {
				e.find('h3').text(parseInt(stepValue.toFixed(2)*100) + '%');
			});
			
			setTimeout(function() { e.circleProgress('value', 1.0); }, speed);
			setTimeout(function() { e.circleProgress('value', value); }, speed2+speed);
		});
		
	}
}

// -----------------------------------------------------
// ---------------   EXTRA MENU    ---------------------
// -----------------------------------------------------

function know_tm_extra_menu(){
	
	"use strict";
	
	var item	= jQuery('.know_tm_extra_menu .unorderest_li');
	var speed	= 1000;
	item.each(function(){
		var element			= jQuery(this);
		var content			= jQuery(element.find('.know_tm_full_link').attr('href')).html();
		element.append('<div class="details_wrapper"></div>').find('.details_wrapper').html(content);
	});
	
	
	var button  = jQuery('.know_tm_extra_menu .know_tm_full_link');
	
	button.on('click',function(){
		var element			= jQuery(this);
		var li				= element.closest('li');
		
		var details			= li.find('.details_wrapper');
		var detailsH		= details.outerHeight() * 0.7;
		var min = 500, max = 1000;
		speed = detailsH < min ? min:detailsH;
		speed = speed > max ? max:speed;
		speed = parseInt(speed);
		
		if(li.hasClass('opened')){
			li.removeClass('opened').find('.details_wrapper').slideUp(speed);return false;
		}else{
			li.siblings().removeClass('opened');
			li.addClass('opened');
		}
		
		var index			= li.index();
		var marginBottom 	= parseInt(li.css("margin-bottom"));
		var liHeight		= li.find('.list_in').outerHeight();
		var parent			= li.closest('.menu_list');
		var top				= parent.offset().top + (liHeight + marginBottom) * index;
		
		/* Scroll the window to the selected element */
		$('html, body').animate({
			scrollTop: top - marginBottom
		},speed);
		
		li.siblings().find('.details_wrapper').slideUp(speed);
		li.find('.details_wrapper').slideDown(speed);
		by_frenify(li,speed);
		
		// reinitialization functions
		know_tm_owl_carousel();
		progress_by_frenify(li);
		know_tm_portfolio_popup();
		know_tm_service_popup();
		know_tm_news_popup();
		know_tm_popup();
		know_tm_portfolio();
		know_tm_contact_form();
		return false;
	});
}

// -----------------------------------------------------
// -------------------   MENUBAR    --------------------
// -----------------------------------------------------

function know_tm_menubar(){
	
	"use strict";
	
	var li		= jQuery('.know_tm_fixed_content .menubar ul li');
	var button	= li.find('.know_tm_full_link');
	
	button.on('click',function(){
		var element = jQuery(this);	
		var parent	= element.closest('li');
		var href	= element.attr('href');
		if(!parent.hasClass('active')){
			li.removeClass('active');
			parent.addClass('active');
			$('.know_tm_main_section').removeClass('active');
			$(href).addClass('active');
			$('.mainbar').animate({
				scrollTop: 0
			},300);
			know_tm_owl_carousel();
		}
	});
}

// -----------------------------------------------------
// -------------------   INTRO TAB    ------------------
// -----------------------------------------------------

function know_tm_intro_tab(){
	
	"use strict";
	
	var li		= jQuery('.know_tm_intro .filter ul li');
	var button	= li.find('a');
	
	button.on('click',function(){
		var element = jQuery(this);	
		var parent	= element.closest('li');
		var href	= element.attr('href');
		if(!parent.hasClass('active')){
			li.removeClass('active');
			parent.addClass('active');
			$('.know_tm_intro .demo ul li').removeClass('active');
			$(href).addClass('active');
		}
	});
}


