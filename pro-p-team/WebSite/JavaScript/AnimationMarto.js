//Alerta code
var close = document.getElementsByClassName("closebtn");
var i;

for (i = 0; i < close.length; i++) {
    close[i].onclick = function(){
        var div = this.parentElement;
        div.style.opacity = "0";
        setTimeout(function(){ div.style.display = "none"; }, 600);
    }
}

 window.onload = openClip(document.getElementById("clip"));
 window.onload = openUp(document.getElementById("clip"));
function displayDate() {
  document.getElementById("Introduction").innerHTML = Date();
}

function closeClip() {

    a.style.width = "0";
    a.style.height = "0";
}
$(function(){
    jQuery.fn.center = function ()
    {
        this.css("position");
        this.css("top", ($(window).height() / 2) - (this.outerHeight() / 2));
        this.css("left", ($(window).width() / 2) - (this.outerWidth() / 2));
        return this;
    }

    $('.tr').center();
    $(window).resize(function(){
       $('.tr').center();
    });
});
  function openUp(a) {
   a.style.height = "100%";
   a.style.opacity = "100";
  }
  function openClip(a) {
    a.style.opacity = "100";
    a.style.width = "100%";
    a.style.height = "100%";
  }

var slideshow = (function(window, undefined) {

  'use strict';
  var navigation = {
    selector: '.navigationGallary',
    element: null,
    bullet: 'li',
    attrs: {
      active: 'active',
      index: 'data-index'
    }
  };
  var container = {
    selector: '.tr',
    element: null,
    sizes: {
      w: 1920,
      h: 1080
    }
  };
  var slides = [
    'Images/about_feature_03.jpg',
    'Images/fv.jpg',
    'Images/aa.png',
    'Images/Firewatch_20160209232346.jpg',
    'Images/cdcd.jpg',
  ];
  var masks = [
    {
      source: 'Images/Mask/triangle-a.svg',
      effects: {
        flip: 'Y',
        rotate: 167 // degrees
      }
    },
    {
      source: 'Images/Mask/triangle-b.svg',
      effects: {
        flip: 'X',
        rotate: 120// degrees
      }
    },
    {
      source: 'Images/Mask/triangle-c.svg',
      effects: {
        flip: 'Y',
        rotate: 13 // degrees
      }
    }
  ];
  var masks1 = [
    {
      source: 'Images/Mask/cube-a.svg',
      effects: {
        flip: 'Y',
        rotate: 180 // degrees
      }
    },
    {
      source: 'Images/Mask/cube-b.svg',
      effects: {
        flip: 'X',
        rotate: 180 // degrees
      }
    },
    {
      source: 'Images/Mask/cube-c.svg',
      effects: {
        flip: false,
        rotate: 23 // degrees
      }
    }
  ];
  var masks2 = [
    {
      source: 'Images/Mask/prism-a.svg',
      effects: {
        flip: 'X',
        rotate: 45 // degrees
      }
    },
    {
      source: 'Images/Mask/prism-b.svg',
      effects: {
        flip: false,
        rotate: 45 // degrees
      }
    },
    {

      source: 'Images/Mask/prism-c.svg',
      effects: {
        flip: false,
        rotate: 180 // degrees
      }
    }
  ];
  var easing = Easing.easeInOutQuint;
  var duration = 1000;
  var instances = {};
  function init() {
    getContainer_();
    initSlider_();
    initPrism_();
    addNavigation_();
    addEvents_();
  }
  function getContainer_() {
    container.element = document.querySelector(container.selector);
  }
  function initSlider_() {
      instances.slider = new PrismSlider({
      container: container,
      slides: slides,
      mask: false,
      duration: duration,
      easing: easing
    });
    instances.slider.init();
  }
  function initPrism_() {

    addMaskToSlide().forEach(function(mask, i) {
      var name = 'mask_' + i;

      instances[name] = new PrismSlider({
        container: container,
        slides: slides,
        mask: mask,
        duration: duration,
        easing: easing

      });
      instances[name].init();
    });
  }
function addMaskToSlide() {
  var random = Math.random();
  if (random <= 0.4) {
    return masks;
  }
  else if (random < 0.7 && random > 0.4) {
    return masks1;
  }
  else {
    return masks2;
  }
}

  function addNavigation_() {
    navigation.element = document.querySelector(navigation.selector);
    slides.forEach(function(slide, i) {
      var bullet = document.createElement(navigation.bullet);

      bullet.setAttribute(navigation.attrs.index, i);

      if (i === 0) bullet.className = navigation.attrs.active;

      navigation.element.appendChild(bullet);
    });
  }
  function addEvents_() {
    navigation.element.addEventListener('click', function(e) {
      var bullet = e.target;

      var isBullet = bullet.nodeName === navigation.bullet.toUpperCase();

      if (isBullet && !instances.slider.isAnimated) {
        for (var i = 0; i < navigation.element.childNodes.length; i++) {
          navigation.element.childNodes[i].className = '';
        }
        bullet.className = navigation.attrs.active;
        var index = Number(bullet.getAttribute(navigation.attrs.index));
        slideAllTo_(index);
      }


    });
  }
  function slideAllTo_(index) {
    for (var key in instances) {
      if (instances.hasOwnProperty(key)) {
        instances[key].slideTo(index);
      }
    }
  }
  return {
    init: init
  };
  navigation.element.addEventListener('', function(e){

    e.width(slides*slideWidth).draggable({
        axis: 'x',
        drag: function (event, slides) {
        if (slides.position.left > min) sildes.position.left = min;
        if (slides.position.left < max) slides.position.left = max;
        }
    });
 });


})(window);
window.onload = slideshow.init;
