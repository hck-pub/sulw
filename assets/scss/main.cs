* {
  margin: 0;
  padding: 0;
  font: inherit;
  color: inherit;
}

*,
:after,
:before {
  box-sizing: border-box;
  flex-shrink: 0;
}

:root {
  -webkit-tap-highlight-color: transparent;
  -webkit-text-size-adjust: 100%;
  text-size-adjust: 100%;
  cursor: default;
  line-height: 1.5;
  overflow-wrap: break-word;
  -moz-tab-size: 4;
  tab-size: 4;
}

html,
body {
  height: 100%;
}

img,
picture,
video,
canvas,
svg {
  display: block;
  max-width: 100%;
}

button {
  background: none;
  border: 0;
  cursor: pointer;
}

a {
  text-decoration: none;
}

table {
  border-collapse: collapse;
  border-spacing: 0;
}

ul,
ol {
  list-style: none;
}

html {
  font-size: 62.5%;
  overflow-x: hidden;
}

.hidden {
  position: absolute;
  clip: rect(0 0 0 0);
  width: 1px;
  height: 1px;
  margin: -1px;
  overflow: hidden;
}

@keyframes fade-in {
  0% {
    opacity: 0;
    visibility: hidden;
  }
  100% {
    opacity: 1;
    visibility: visible;
  }
}
header {
  position: absolute;
  top: 0;
  left: 0;
  z-index: 10;
  width: 100%;
}
header .left-logo {
  position: absolute;
  left: 5%;
  color: #fff;
}
header .left-logo a {
  display: block;
  font-size: 2.4rem;
}
header .left-logo p {
  font-size: 1.4rem;
}
header .top-wrap, header nav {
  width: 120rem;
  margin: 0 auto;
  padding: 1rem 0;
}
header .top-wrap {
  display: flex;
  justify-content: space-between;
  color: #fff;
}
header .top-wrap .rang {
  font-size: 1.2rem;
  height: 3.4rem;
  overflow: hidden;
}
header .top-wrap .rang a {
  display: block;
  padding: 0.5rem 1rem 0.5rem 0rem;
}
header .top-wrap .logo {
  font-size: 3.2rem;
}
header .top-wrap .right a {
  display: inline-block;
  font-size: 1.2rem;
  padding: 0 0.5rem;
}
header nav .menu-wrap {
  display: flex;
  justify-content: center;
  align-items: center;
  color: #fff;
  border-bottom: 1px solid #fff;
}
header nav .menu-wrap > li {
  position: relative;
}
header nav .menu-wrap > li > a {
  display: block;
  padding: 0.5rem 3rem;
  font-size: 1.4rem;
  text-align: center;
}
header nav .menu-wrap > li:hover > a {
  font-weight: 700;
}
header nav .menu-wrap > li:hover .sub-menu {
  opacity: 1;
  visibility: visible;
}
header nav .sub-menu {
  opacity: 0;
  visibility: hidden;
  position: absolute;
  white-space: nowrap;
  left: 50%;
  transform: translateX(-50%);
  bottom: -2.4rem;
}
header nav .sub-menu li {
  display: inline-block;
}
header nav .sub-menu a {
  display: block;
  font-size: 1.2rem;
  padding: 0 1rem;
}

html, body {
  width: 100%;
  height: 100%;
}

#wrap {
  width: 100%;
  height: 100%;
}

.hidden {
  font-size: 0px;
}

.rebloom {
  position: relative;
  width: 100%;
  height: auto;
}
.rebloom img {
  width: 100%;
}
.rebloom .cont {
  padding: 0 30px;
}
.rebloom .tit01 {
  font-size: 22px;
  line-height: 40px;
  letter-spacing: 0.1em;
}
.rebloom .tit02 {
  font-size: 20px;
  font-weight: 400;
  line-height: 40px;
  letter-spacing: 0.1em;
  color: #F26E25;
}
.rebloom .cont-txt-tit {
  margin-top: 10px;
  font-size: 28px;
  line-height: 34px;
  letter-spacing: 0.08em;
}
.rebloom .cont-txt-sub {
  margin-top: 22px;
  font-size: 20px;
  line-height: 30px;
  letter-spacing: 0.005em;
}
.rebloom .scroll-box {
  position: fixed;
  bottom: 53px;
  left: 50%;
  transform: translateX(-50%);
  color: #FFFFFF;
  background: url(../../assets/img/scroll_down.png) no-repeat center bottom/17px auto;
  z-index: 99;
}
.rebloom .scroll-box .scroll-down {
  display: inline-block;
  padding-bottom: 17px;
  font-size: 16px;
  line-height: 40px;
  letter-spacing: 0.1em;
}
.rebloom .scroll-box .scroll-down-mo {
  display: none;
}
.rebloom .scroll-box.scroll-inpro {
  width: 50px;
  height: 36px;
  background: url(../../assets/img/scroll_top.png) no-repeat center center/100% auto;
}
.rebloom .scroll-box.scroll-inpro .scroll-down {
  display: none;
}
.rebloom .scroll-box.back-white {
  background-image: url(../../assets/img/scroll_top2.png);
}
.rebloom .intro {
  position: relative;
  width: 100%;
  height: 400vh;
  background: #000000;
}
.rebloom .intro .tit02 {
  color: #FFFFFF;
}
.rebloom .intro .intro-list {
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  width: 100%;
  height: 100vh;
  font-size: 50px;
  color: #FFFFFF;
  z-index: 10;
}
.rebloom .intro .intro-list .intro-tit {
  position: relative;
  padding: 0 30px;
  color: #FFFFFF;
  text-align: center;
  z-index: 1;
}
.rebloom .intro .intro-list .intro-sub {
  padding: 0 30px;
  font-size: 20px;
  line-height: 30px;
  color: #FFFFFF;
  letter-spacing: 0.01em;
  text-align: center;
}
.rebloom .intro .intro1 {
  position: relative;
  background: transparent;
  background: url(../../assets/img/intro_bg.png) no-repeat center 7%/150%;
}
.rebloom .intro .intro1 .intro-tit-sub {
  font-size: 62px;
  line-height: 68px;
  letter-spacing: 0.08em;
}
.rebloom .intro .intro1 .intro-dim {
  position: absolute;
  width: 100%;
  height: 100%;
  background: rgba(0, 0, 0, 0.8);
  transition: 1s;
}
.rebloom .intro .intro2 .intro-tit-sub {
  font-size: 28px;
  line-height: 33px;
  letter-spacing: 0.08em;
}
.rebloom .intro .intro2 .intro-sub {
  overflow: hidden;
  transform: translateY(-100%);
}
.rebloom .intro .intro3 .intro-sub {
  transform: translateY(200%);
}
.rebloom .intro .intro-video {
  top: auto;
  transform: scale(2);
  transform-origin: center center;
  transition: 1s;
}
.rebloom .cont1 {
  position: relative;
  width: 100%;
  height: 200vh;
  background: #FFFFFF;
  font-weight: 400;
}
.rebloom .cont1 .cont1-top {
  width: 100%;
  height: 50%;
  overflow-x: hidden;
  text-align: center;
}
.rebloom .cont1 .cont1-top .cont1-film {
  position: relative;
  display: flex;
  width: 200%;
  height: 100%;
  top: 0;
  left: 0;
  transition: 1s;
  overflow: hidden;
}
.rebloom .cont1 .film-box {
  position: relative;
  width: 50%;
  height: 100%;
}
.rebloom .cont1 .film-box:after {
  position: absolute;
  display: block;
  content: "";
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  width: 41%;
  height: 155px;
  background: url(../../assets/img/Sulwhasoo_logo.png) no-repeat center center/contain;
}
.rebloom .cont1 .film-box .cont1-back-img {
  position: absolute;
  height: 100%;
  top: auto;
  bottom: -50%;
  transform: scale(0.8);
  transform-origin: bottom center;
  transition: 0.5s;
  z-index: 1;
}
.rebloom .cont1 .film-box-next {
  padding: 0 9%;
  background: #171717;
  text-align: left;
}
.rebloom .cont1 .film-box-next:after {
  display: none;
}
.rebloom .cont1 .film-box-next .film-txt {
  margin-top: 10.8%;
  padding-right: 20%;
}
.rebloom .cont1 .film-box-next .cont-txt-tit {
  color: #FFFFFF;
}
.rebloom .cont1 .film-txt {
  margin-top: 7.2%;
  position: relative;
  color: #171717;
  transform: scale(1.5);
  transform-origin: center top;
  z-index: 10;
}
.rebloom .cont1 .film-txt button {
  margin-top: 32px;
  padding: 10px;
  font-size: 16px;
  line-height: 16px;
  letter-spacing: 0.11em;
  border: 1px solid #171717;
  background: #FFFFFF;
}
.rebloom .cont1 .film-txt .film-prev-btn {
  position: absolute;
  bottom: 0;
  right: 0;
  margin-top: 0;
  padding: 10px 10px 10px 30px;
  color: #FFFFFF;
  border: 1px solid #FFFFFF;
  background: url(../../assets/img/arrow_prev.png) no-repeat 9px center/10px auto;
}
.rebloom .cont1 .cont1-video .video-dim {
  background: rgba(0, 0, 0, 0.5);
}
.rebloom .cont1 .cont1-full {
  height: 50%;
}
.rebloom .cont1 .cont1-full .full-bg-txt {
  color: #000000;
}
.rebloom .cont1 .cont1-full .full-bg-sub {
  transform: translateY(100%);
  transition: 0.5s;
}
.rebloom .cont2 {
  position: relative;
  width: 100%;
  height: 400vh;
  background: #000000;
}
.rebloom .cont2 .cont2-box {
  width: 200%;
  height: 100vh;
  display: flex;
  position: absolute;
  top: 0;
}
.rebloom .cont2 .cont2-flow {
  width: 50%;
  height: 100vh;
  box-sizing: border-box;
  overflow: hidden;
}
.rebloom .cont2 .flow-wrap {
  height: 100vh;
}
.rebloom .cont2 .flow-list-box {
  display: flex;
  justify-content: flex-start;
  align-items: flex-start;
  height: 100%;
}
.rebloom .cont2 .flow-list img {
  width: 100%;
}
.rebloom .cont2 .flow-list.flow1 {
  width: 50%;
  padding-right: 12%;
  transform: translate(12%, 42%);
}
.rebloom .cont2 .flow-list.flow2 {
  width: 30%;
  padding-right: 12%;
  transform: translate(16%, 20%);
}
.rebloom .cont2 .flow-list.flow3 {
  width: 50%;
  transform: translate(16%, 40%);
}
.rebloom .cont2 .cont2-story {
  width: 50%;
  height: 100vh;
  color: #FFFFFF;
}
.rebloom .cont2 .cont2-story .story-box-img {
  width: 22%;
  overflow: hidden;
}
.rebloom .cont2 .cont2-story .story-box-img img {
  transform: scale(1.5);
  transition: 0.5s;
}
.rebloom .cont2 .cont2-story .story-box-txt .tit02,
.rebloom .cont2 .cont2-story .story-box-txt .cont-txt-tit,
.rebloom .cont2 .cont2-story .story-box-txt .cont-txt-sub {
  transform: translateX(50%);
}
.rebloom .cont3 {
  position: relative;
  width: 100%;
  height: 200vh;
  box-sizing: border-box;
  background: #000000;
  color: #FFFFFF;
}
.rebloom .cont4 {
  position: relative;
  height: 100vh;
}
.rebloom .cont4 .cont4-box {
  width: 100%;
  height: 100%;
}
.rebloom .cont5 {
  position: relative;
  height: 100vh;
  background: #000000;
  color: #FFFFFF;
  overflow: hidden;
}
.rebloom .cont5 .story-box-img {
  width: 40%;
  transform: translateY(100%) scale(2);
  transition: 0.5s;
  opacity: 0.2;
}
.rebloom .cont5 .cont-txt-sub {
  transform: translateY(100%);
  transition: 0.5s;
  opacity: 0;
}
.rebloom .cont6 {
  position: relative;
  width: 100%;
  height: 100vh;
  background: #000;
  overflow: hidden;
}
.rebloom .cont6 .cont6-back-img {
  position: absolute;
  width: 100%;
  height: 100%;
  transform: scale(0.4);
  transform-origin: bottom center;
  transition: 0.5s;
  bottom: -10%;
  left: 0;
}
.rebloom .cont7 {
  width: 100%;
  height: 100vh;
  /*
  position:relative;
  width:100%;
  height:300vh;
  background:green;
  .cont7-full {
    position:relative;
    left:0;
    top:0;
    height:100vh;
    &.cont7-sticky {
      position:sticky;
      top:0;
      left:0;
    }
  }
  .cont7-video {
    &.fix {
      top:0;
      z-index:0;
    }
  }
  .full-bg-sub {
    &.txt-next {
      opacity:0;
      transform: translateY(-111%);
    }
  }
  .cont7-full-txt {
    width:100%;
    height:100vh;
    position:absolute;
    bottom:0;
    left:0;
    background:$black-color;
  }*/
}
.rebloom .cont7 .cont7-history {
  position: sticky;
  width: 100%;
  height: 100%;
  top: 0;
  background: yellowgreen;
  overflow: hidden;
}
.rebloom .cont7 .history-box {
  position: relative;
  display: flex;
  align-items: center;
  width: 100%;
  height: 100%;
}
.rebloom .cont7 .history-box .history-list {
  position: relative;
  color: #FFFFFF;
}
.rebloom .cont7 .history-box .history-list .history-txt {
  position: absolute;
  width: 150%;
  left: 65%;
  bottom: 34px;
  z-index: 10;
}
.rebloom .cont7 .history-box .history-list .history-txt-year {
  font-size: 130px;
  letter-spacing: -0.058em;
}
.rebloom .cont7 .history-box .history-list .history-txt-exp {
  font-size: 28px;
  line-height: 40px;
  letter-spacing: 0.02em;
}
.rebloom .cont7 .history-box .history-list .history-txt-exp span {
  display: block;
}
.rebloom .cont7 .history-box .history-list .history-img {
  width: 100%;
  height: 100%;
  overflow: hidden;
}
.rebloom .cont7 .history-box .history-list .history-img img {
  width: auto;
  max-width: 150%;
  height: 100%;
}
.rebloom .cont7 .history-box .history1 {
  width: 24%;
  height: 58%;
}
.rebloom .cont7 .history-box .history2 {
  margin-left: 15%;
  width: 20%;
  height: 40%;
  transform: translateY(-50%);
}
.rebloom .cont7 .history-box .history2 .history-txt {
  bottom: -25%;
  left: 30%;
}
.rebloom .cont7 .history-box .history3 {
  margin-left: 5%;
  width: 23%;
  height: 66%;
  transform: translateY(30%);
}
.rebloom .cont7 .history-box .history3 .history-txt {
  top: 15%;
  right: -100%;
}
.rebloom .cont7 .history-box .history4 {
  margin-left: 25%;
  width: 24%;
  height: 58%;
  transform: translateY(0%);
}
.rebloom .cont7 .history-box .history4 .history-txt {
  top: 20%;
  left: -22%;
}
.rebloom .cont8 {
  width: 100%;
  height: 200vh;
}
.rebloom .cont8 .cont8-full {
  position: relative;
  width: 100%;
  height: 100vh;
}
.rebloom .cont8 .full-bg-sub .txt-next {
  opacity: 0;
}
.rebloom .cont9 {
  position: relative;
  width: 100%;
  height: 200vh;
  background: #000000;
}
.rebloom .cont9 .cont9-top {
  position: relative;
  width: 100%;
  height: 50%;
}
.rebloom .cont9 .cont9-top-txt {
  position: relative;
  width: 100%;
  height: 100%;
  display: flex;
  align-items: center;
  justify-content: center;
  flex-direction: column;
  color: #FFFFFF;
  z-index: 10;
}
.rebloom .cont9 .cont9-txt-talk {
  font-size: 20px;
  line-height: 30px;
}
.rebloom .cont9 .cont9-txt-ps {
  margin-top: 10px;
  font-size: 16px;
  line-height: 30px;
  letter-spacing: 0.11em;
}
.rebloom .cont9 .cont9-img {
  position: absolute;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  background: url(../../assets/img/talk_img.png) no-repeat center center/cover;
  opacity: 0;
}
.rebloom .cont9 .cont9-bottom {
  width: 100%;
  height: 50%;
  color: #FFFFFF;
}
.rebloom .cont9 .film-txt {
  position: relative;
  padding-top: 7.2%;
  transform: scale(1.5);
  transform-origin: center top;
  z-index: 10;
  text-align: center;
}
.rebloom .cont9 .film-txt button {
  margin-top: 32px;
  padding: 10px;
  font-size: 16px;
  line-height: 16px;
  letter-spacing: 0.11em;
  border: 1px solid #FFFFFF;
}
.rebloom .cont9 .cont9-right {
  position: absolute;
  padding: 0 9%;
  width: 100%;
  height: 100vh;
  top: 0;
  left: 0;
  color: #FFFFFF;
}
.rebloom .cont9 .cont9-right .film-next-txt {
  width: 100%;
  padding: 10.8% 20% 0 0;
  transform: scale(1);
  text-align: left;
}
.rebloom .cont9 .cont9-right .film-prev-btn {
  position: absolute;
  bottom: 0;
  right: 0;
  margin-top: 0;
  padding: 10px 10px 10px 30px;
  color: #FFFFFF;
  border: 1px solid #FFFFFF;
  background: url(../../assets/img/arrow_prev.png) no-repeat 9px center/10px auto;
}
.rebloom .cont10 {
  width: 100%;
  height: 100vh;
}
.rebloom .cont10 .edition-box {
  width: 100%;
  height: 100%;
  display: flex;
  align-items: center;
  justify-content: flex-start;
  color: #FFFFFF;
  background: url(../../assets/img/talk_img_pd.png) no-repeat left center/cover;
}
.rebloom .cont10 .edition-txt {
  padding-left: 45%;
}
.rebloom .cont10 .edition-txt-tit,
.rebloom .cont10 .edition-txt-sub,
.rebloom .cont10 .edition-more-btn {
  transform: translateY(100%);
  transition: 0.5s;
  opacity: 0;
}
.rebloom .cont10 .edition-txt-tit {
  font-size: 20px;
  line-height: 24px;
  letter-spacing: 0.1em;
}
.rebloom .cont10 .edition-txt-sub {
  margin-top: 30px;
  font-size: 20px;
  line-height: 30px;
}
.rebloom .cont10 .edition-more-btn {
  margin-top: 40px;
  padding: 8px 31px 8px 9px;
  font-size: 16px;
  line-height: 16px;
  letter-spacing: 0.11em;
  border: 1px solid #FFFFFF;
  background: url(../../assets/img/arrow-next.png) no-repeat calc(100% - 10px) center/10px auto;
}
.rebloom .cont11 {
  width: 100%;
  height: 200vh;
  text-align: center;
}
.rebloom .cont11 .campaign-box {
  position: relative;
  width: 100%;
  height: 50%;
}
.rebloom .cont11 .campaign-txt {
  padding-top: 7.2%;
}
.rebloom .cont11 .cont8-full-back {
  position: absolute;
  left: 0;
  bottom: -10%;
  width: 100%;
  height: 100%;
  transform: scale(0.5);
}
.rebloom .cont11 .cont8-full-back .video-dim {
  background: rgb(0, 0, 0);
}
.rebloom .cont11 .end {
  width: 100%;
  height: 50%;
  display: flex;
  align-items: center;
  justify-content: center;
  color: #FFFFFF;
}
.rebloom .cont11 .end .end-txt-tit {
  font-size: 48px;
  line-height: 57px;
}
.rebloom .cont11 .end .end-txt-sub {
  margin-top: 20px;
  font-size: 24px;
  line-height: 28px;
}
.cont1.ani .rebloom.active {
  animation: fadeInUp 0.5s ease-in-out;
}
@keyframes fadeInUp {
  0% {
    opacity: 0;
    transform: translate3d(0, 100%, 0);
  }
  to {
    opacity: 1;
    transform: translateZ(0);
  }
}
.rebloom .roll-txt .roll {
  transition: 0.5s;
  display: block;
  transform: translateY(100%);
}
.rebloom .full-video {
  position: absolute;
  width: 100%;
  height: 100vh;
  min-height: 100vh;
  top: 0;
  bottom: 0;
  left: 0;
  right: 0;
}
.rebloom .full-video video {
  width: 100%;
  height: 100%;
  object-fit: cover;
  object-position: center center;
}
.rebloom .full-video .video-dim {
  position: absolute;
  width: 100%;
  height: 100%;
  top: 0;
  left: 0;
  background: rgba(0, 0, 0, 0.5);
  transition: 0.5s;
}
.rebloom .m-video {
  display: none;
}
.rebloom .full-bg-box {
  display: flex;
  justify-content: center;
  align-items: flex-start;
  flex-direction: column;
  padding-left: 15%;
  height: 100%;
  background: transparent;
  color: #FFFFFF;
}
.rebloom .full-bg-box span {
  display: block;
}
.rebloom .full-bg-box .full-bg-txt {
  position: relative;
  z-index: 2;
}
.rebloom .full-bg-box .tit02 {
  color: #FFFFFF;
}
.rebloom .full-bg-box .full-bg-tit {
  font-size: 52px;
  font-weight: 500;
  line-height: 60px;
  letter-spacing: 0.01em;
}
.rebloom .full-bg-box .full-bg-sub {
  margin-top: 40px;
  font-size: 20px;
  line-height: 30px;
  letter-spacing: 0.01em;
  opacity: 0;
  transform: translateY(100%);
  transition: 0.5s;
}
.rebloom .scale-bg-img {
  position: absolute;
  top: -100px;
  left: 0;
  width: 100%;
  height: 100vh;
  transform: scale(0.3);
  transform-origin: center top;
  opacity: 1;
  z-index: 1;
  transition: 1s;
}
.rebloom .story-box {
  display: flex;
  align-items: center;
  justify-content: center;
  gap: 54px;
  height: 100vh;
}
.rebloom .story-box .story-box-txt {
  flex: 0 1 auto;
}
.rebloom .story-box .cont-txt-tit {
  margin-top: 5px;
}
.rebloom .story-box .cont-txt-sub {
  margin-top: 30px;
}
@media (max-width: 767px) {
  .rebloom .tit01 {
    font-size: 15px;
    font-weight: 300;
    line-height: 20px;
    letter-spacing: 0.12em;
  }
  .rebloom .tit02 {
    font-size: 12px;
    line-height: 16px;
    letter-spacing: 0.12em;
  }
  .rebloom .cont-txt-tit {
    margin-top: 5px;
    font-size: 16px;
    font-weight: 500;
    line-height: 24px;
    letter-spacing: 0.03em;
  }
  .rebloom .cont-txt-sub {
    margin-top: 25px;
    font-size: 14px;
    line-height: 22px;
    letter-spacing: 0.01em;
  }
  .rebloom .scroll-box {
    bottom: 30px;
    background-size: 10px auto;
  }
  .rebloom .scroll-box .scroll-down {
    padding-bottom: 10px;
    font-size: 12px;
    line-height: 30px;
    letter-spacing: 0.08em;
  }
  .rebloom .scroll-box.scroll-inpro {
    width: auto;
    height: auto;
    background: none;
  }
  .rebloom .scroll-box.scroll-inpro .scroll-down-mo {
    display: inline-block;
    padding: 2px 7px 4px;
    font-size: 12px;
    line-height: 23px;
    letter-spacing: 0.1em;
    border: 1px solid #FFFFFF;
  }
  .rebloom .intro .intro-list .intro-sub {
    font-size: 14px;
    line-height: 22px;
    letter-spacing: 0.1em;
  }
  .rebloom .intro .intro1 {
    background: url(../../assets/img/intro_bg_m.png) no-repeat center top/cover;
  }
  .rebloom .intro .intro1 .intro-tit-sub {
    margin-top: 10px;
    font-size: 26px;
    font-weight: 300;
    line-height: 32px;
    letter-spacing: 0.12em;
  }
  .rebloom .intro .intro1 .intro-dim {
    background: rgba(0, 0, 0, 0.34);
  }
  .rebloom .intro .intro2 .intro-tit-sub {
    margin-top: 4px;
    font-size: 16px;
    line-height: 29px;
    letter-spacing: -0.01em;
  }
  .rebloom .intro .intro2.intro2-focus .intro-tit {
    transform: translateY(-20px);
  }
  .rebloom .cont1 .cont1-top {
    position: static;
  }
  .rebloom .cont1 .film-txt {
    position: relative;
    margin-top: 20%;
    z-index: 10;
  }
  .rebloom .cont1 .film-txt button {
    margin-top: 26px;
    padding: 3px 7px;
    font-size: 12px;
    line-height: 17px;
  }
  .rebloom .cont1 .film-box .scale-bg-img {
    width: calc(100% - 60px);
    top: 50%;
    bottom: auto;
    left: 50%;
    transform: translate(-50%, 5%);
    height: auto;
    transform-origin: center center;
    z-index: 10;
  }
  .rebloom .cont1 .film-box .scale-bg-img .video-dim {
    display: none;
  }
  .rebloom .cont1 .film-box .full-video {
    position: static;
    height: auto;
    min-height: auto;
  }
  .rebloom .cont1 .film-box .full-video video {
    height: auto;
  }
  .rebloom .cont1 .m-cont1-video {
    display: block;
    position: absolute;
    top: 0;
    left: 0;
    width: 100%;
    height: 50%;
    opacity: 0;
  }
  .rebloom .cont1 .m-cont1-video video {
    height: 100vh;
    object-fit: cover;
    object-position: center top;
  }
  .rebloom .cont3 .story-box .story-box-img {
    width: calc(100% - 40px);
  }
  .rebloom .cont3 .cont3-back-img {
    top: 100vh;
  }
  .rebloom .cont4 {
    padding: 0 0 100vh;
  }
  .rebloom .cont4 .cont4-box {
    display: block;
    width: 100%;
    height: 100%;
    position: absolute;
    bottom: 0;
    left: 0;
  }
  .rebloom .cont4 .cont4-box .cont4-full,
  .rebloom .cont4 .cont4-box .cont4-story {
    width: 100%;
    height: 100vh;
  }
  .rebloom .cont4 .cont4-box.full-fixed {
    position: fixed;
    top: 0;
    left: 0;
  }
  .rebloom .cont4 .cont4-full-back .full-video {
    width: 100%;
  }
  .rebloom .cont4 .story-box {
    padding: 0 30px;
    flex-direction: column-reverse;
  }
  .rebloom .cont4 .story-box .story-box-img {
    width: 100%;
  }
  .rebloom .full-video video {
    height: 100vh;
  }
  .rebloom .scale-bg-img {
    transform: scale(1);
    top: 0;
  }
  .rebloom .full-bg-box {
    justify-content: flex-end;
    padding: 0 30px 15%;
  }
  .rebloom .full-bg-box .full-bg-tit {
    margin-top: 4px;
    font-size: 16px;
    line-height: 24px;
    letter-spacing: 0.016em;
  }
  .rebloom .full-bg-box .full-bg-sub {
    margin-top: 20px;
    font-size: 14px;
    line-height: 22px;
    letter-spacing: 0.014em;
  }
  .rebloom .story-box {
    flex-direction: column;
    gap: 43px;
  }
  .rebloom .story-box .story-box-txt {
    flex: 0 0 auto;
    text-align: center;
  }
  .rebloom .story-box .cont-txt-sub {
    margin-top: 20px;
  }
  .rebloom .story-box.story-fixed {
    position: fixed;
    top: 0;
    left: 0;
    padding: 0 30px;
  }
}

/*# sourceMappingURL=main.cs.map */
