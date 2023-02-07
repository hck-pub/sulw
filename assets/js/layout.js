let flowBoxW = 0; // flowBox Width
    let flowLastW = 0; // flowList - last Width
    let historyBoxW = 0; // historyBoxW Width
    let lastScroll = 0;
    let slideIn = true;
	  let timer = 500;
    let pageIdx = 0;
    let scrOn = false;
    let aiai = 0
    let nowStatus = ''
    let nowPage = ''
    function init() {
      fullSlide()
    }
    init()

    const intro = $('.intro')
    const introOffset = $('.intro').offset().top
    const introH = $('.intro').innerHeight()

    const cont1 = $('.cont1')
    const cont1offset = $('.cont1').offset().top
    const cont1TopH = $('.cont1-top').innerHeight()
    const cont1Bottom = $('.cont1-full').offset().top
    const cont1BotH = $('.cont1-top').innerHeight()

    const cont2 = $('.cont2')
    const cont2offset = $('.cont2').offset().top
    const cont2H = $('.cont2').innerHeight()
    const flowBoxoffset = $('.cont2-flow').offset().top

    const cont3 = $('.cont3')
    const cont3offset = $('.cont3').offset().top
    const cont3H = $('.cont3').innerHeight()

    const cont4 = $('.cont4')
    const cont4offset = $('.cont4').offset().top
    const cont4Boxoffset = $('.cont4-box').offset().top
    const cont4H = $('.cont4').innerHeight()

    const cont5 = $('.cont5')
    const cont5offset = $('.cont5').offset().top
    const cont5H = $('.cont5').innerHeight()

    const cont6 = $('.cont6')
    const cont6offset = $('.cont6').offset().top
    const cont6H = $('.cont6').innerHeight()

    const cont7 = $('.cont7')
    const cont7offset = $('.cont7').offset().top
    const cont7H = $('.cont7').innerHeight()

    /* cont1 - fullSlide */
    function fullSlide() {
      $('.film-next-btn').click(function() {
        $('.cont1-film').css({'left':'-' + 100 + '%'})
        $('html, body').animate({scrollTop:cont1offset}, 500)
        $('.cont1-film').on('scroll touchmove mousewheel', function(e){
            e.preventDefault();
            e.stopPropagation(); 
            return false;
          })
      })
      $('.film-prev-btn').click(function() {
        $('.cont1-film').css({'left':0});
        $('.cont1-film').off('scroll touchmove mousewheel'); 
      })
    }

    function pageStart() {
      $('.intro').addClass('intro-on')
      $('.intro1').addClass('intro-start')
      return
    }


    $(document).ready(function() {
      pageStart()
    })
    /*
    $(document).scroll(function() {
  
      let winH = $(document).scrollTop()

      scrollFixed(winH)

      if (winW > 640) {
      } else {
      }
    })*/

    $(document).scroll(function() {
      const winHeight = $(window).innerHeight();
      let nowScroll = $(this).scrollTop();

      //event.preventDefault();
		  //event.stopPropagation();	

      if (nowScroll > 0 && scrOn == false) {
        if ($('html, body').is(':animated') == false) {
          if (nowScroll > aiai) { //mousedown
            nowStatus = 'down'
            scrOn = true
            pageIdx = pageIdx + 1
            aiai = winHeight * pageIdx
            console.log(nowStatus)
          } else if (nowScroll < aiai) {
            nowStatus = 'up'
            scrOn = true
            pageIdx = pageIdx - 1
            aiai = winHeight * pageIdx
            console.log(nowStatus)
          }

          console.log(nowScroll)

          if (nowScroll == cont1offset) {
            nowPage = 'cont1'
            cont1Intro()
          } else if (nowScroll == cont1Bottom) {
            nowPage = 'cont1Full'
            cont1FullFc()
          }
          
          $('html,body').animate({scrollTop: aiai}, timer, function(){scrOn = false});
          lastScroll = nowScroll
          return;

        } else {
          return;
        }
      } 
      
      if(nowScroll >= introOffset && nowScroll <= introOffset + introH) {
        if (nowScroll == 0) {
          $('.intro-video').removeClass('video-show')
          $('.intro').addClass('intro-on')
          $('.intro').removeClass('now-intro2')
          $('.intro1').addClass('intro-start')
        } else if (nowScroll >= 0 && nowScroll <= introOffset + (introH / 4)) {
          $('.intro').addClass('now-intro2')
          $('.intro1').removeClass('intro-start')
          $('.intro2').removeClass('intro2-focus')
          $('.intro-video').addClass('video-show')
        } else if (nowScroll >= introOffset + (introH / 4) && lastScroll <= introOffset + (introH / 4) * 2) {
          console.log('2번')
          $('.intro').removeClass('now-intro3')
          $('.intro').addClass('now-intro2')
          $('.intro2').addClass('intro2-focus')
          $('.intro3').removeClass('intro3-start')
        } else if (nowScroll >= introOffset + (introH / 4) * 2 && nowScroll <= introOffset + (introH / 4) * 3) {
          $('.intro').addClass('intro-on')
          $('.intro').removeClass('now-intro2')
          $('.intro').addClass('now-intro3')
          $('.intro-list').removeAttr('style')
          $('.intro-video').removeAttr('style')
        } else if (nowScroll >= introOffset + (introH / 4) * 3) {
          $('.intro').removeClass('intro-on')
          $('.intro-list').css({'top':'auto','bottom':0})
          $('.intro-video').css({'position':'absolute','top':'auto'})
          $('.cont1-top').removeClass('cont1-top-focus')
        } 
      }else if (nowScroll >= cont1offset && nowScroll <= cont1offset + cont1TopH) {
        $('.cont1-top').addClass('cont1-top-focus')
        $('.cont1-full').removeClass('cont1-full-focus')
        if(nowStatus == 'down') {
          $('.cont1-back-img').addClass('scale-orig')
        } else {
          $('.cont1-back-img').removeClass('scale-orig')
        }
      }
    });

    function cont1Intro() {
      $('.cont1-top').addClass('cont1-top-focus')
      $('.cont1-full').removeClass('cont1-full-focus')
    }
    function cont1FullFc() {
      $('.cont1-full').addClass('cont1-full-focus')
    }
    function Motion(winH, contTop, contHeight, content) {
      let scrollMin = contTop
      let scrollMax = contTop + contHeight
  
      let min = 1 / (scrollMax - scrollMin)
      let max = -(min * scrollMin)
      let totalRange = (min * winH) + max
    }
