/* http://meyerweb.com/eric/tools/css/reset/ 
   v2.0 | 20110126
   License: none (public domain)
*/
@import "../fonts/stylesheet.css";
html, body, div, span, applet, object, iframe,
h1, h2, h3, h4, h5, h6, p, blockquote, pre,
a, abbr, acronym, address, big, cite, code,
del, dfn, em, img, ins, kbd, q, s, samp,
small, strike, strong, sub, sup, tt, var,
b, u, i, center,
dl, dt, dd, ol, ul, li,
fieldset, form, label, legend,
table, caption, tbody, tfoot, thead, tr, th, td,
article, aside, canvas, details, embed,
figure, figcaption, footer, header, hgroup,
menu, nav, output, ruby, section, summary,
time, mark, audio, video {
  margin: 0;
  padding: 0;
  border: 0;
  font-size: 100%;
  font: inherit;
  vertical-align: baseline;
}

/* HTML5 display-role reset for older browsers */
article, aside, details, figcaption, figure,
footer, header, hgroup, menu, nav, section {
  display: block;
}

body {
  line-height: 1;
}

ol, ul {
  list-style: none;
}

blockquote, q {
  quotes: none;
}

blockquote:before, blockquote:after,
q:before, q:after {
  content: "";
  content: none;
}

table {
  border-collapse: collapse;
  border-spacing: 0;
}

*,
*:after,
*::before {
  box-sizing: border-box;
}

html {
  font-size: 62.5%;
}

body {
  font-family: "Roboto";
  font-weight: 400;
  font-size: 1.4rem;
  margin: 0;
}

a {
  color: unset;
  text-decoration: none;
}

img {
  display: block;
  width: 100%;
  object-fit: cover;
}

li {
  list-style: none;
}

.container {
  width: 100%;
  max-width: 120rem;
  margin: 0 auto;
}

.fullheight {
  height: 100vh;
}

.align-item-center {
  display: flex;
  align-items: center;
  justify-content: center;
  text-align: center;
}

.bg-img {
  background-position: center;
  background-size: cover;
  background-repeat: no-repeat;
}

.bg-img-fixed {
  background-attachment: fixed;
}

.fullheight {
  height: 100vh;
}

.btn {
  border: none;
  outline: none;
  border-radius: 0.6rem;
  font-size: 1.2rem;
  font-weight: bold;
  line-height: 1.6rem;
  color: white;
  text-transform: uppercase;
  background-color: #E7194A;
  padding: 1rem 2.4rem;
  cursor: pointer;
  transition: 0.3s ease-in-out;
  border: 1px solid #E7194A;
}
.btn:hover {
  background-color: white;
  color: #E7194A;
}

.heading-title {
  font-size: 3rem;
  font-weight: bold;
  line-height: 3.9rem;
  color: #371F62;
}
.heading-desc {
  font-size: 1.4rem;
  line-height: 1.9rem;
}

.back-to-top {
  border-radius: 10px;
  position: fixed;
  right: 2rem;
  bottom: 2rem;
  z-index: 99;
  font-size: 4rem;
  background-color: #E7194A;
  color: white;
  padding: 1rem;
  transition: 0.5s ease-in-out;
  animation: up linear 1s infinite alternate;
  opacity: 0;
  visibility: hidden;
  cursor: pointer;
}

.sidebar {
  width: 41.6%;
  padding-left: 3rem;
  padding-right: 5rem;
  padding-top: 6rem;
  padding-bottom: 4.4rem;
  background-color: #F4F4F7;
}
.sidebar-heading {
  font-size: 2rem;
  font-weight: bold;
  line-height: 2.6rem;
  color: #371F62;
  margin-bottom: 2rem;
}
.sidebar-item {
  display: flex;
  align-items: flex-start;
  margin-bottom: 2rem;
}
.sidebar-img {
  max-width: 14rem;
}
.sidebar-item-content {
  padding-left: 1.6rem;
}
.sidebar-item-title {
  font-size: 1.6rem;
  font-weight: bold;
  line-height: 2.1rem;
  margin-bottom: 0.4rem;
  transition: 0.3s ease-in-out;
}
.sidebar-item-title:hover {
  color: #E7194A;
}
.sidebar-item-date {
  line-height: 1.9rem;
}
@media screen and (max-width: 1023px) {
  .sidebar {
    padding-left: 1rem;
    padding-right: 1rem;
    padding-top: 3rem;
    padding-bottom: 3rem;
    overflow-y: auto;
    height: 90rem;
  }
  .sidebar-img {
    max-width: 100%;
    margin-bottom: 1rem;
  }
}
@media screen and (max-width: 767px) {
  .sidebar {
    overflow-y: unset;
    height: unset;
  }
}
@media screen and (max-width: 450px) {
  .sidebar-item {
    display: block;
  }
  .sidebar-item-content {
    padding-left: unset;
  }
}

body.is-active {
  overflow: hidden;
}

@media screen and (max-width: 767px) {
  .back-to-top {
    font-size: 2.5rem;
  }
}
@keyframes up {
  to {
    transform: translateY(-50%);
  }
}
@keyframes fixedMenu {
  0% {
    opacity: 0.7;
    transform: translateY(-100%);
  }
  100% {
    opacity: 1;
    transform: translateY(0);
  }
}
@keyframes bubble1 {
  0% {
    transform: translateY(0);
  }
  25% {
    transform: translate(10%, 50%);
  }
  50% {
    transform: translate(20%, 100%);
  }
  75% {
    transform: translateX(100%);
  }
  100% {
    transform: translate(0);
  }
}
@keyframes bubble2 {
  0% {
    transform: translateY(-20%);
  }
  25% {
    transform: translate(30%, 0);
  }
  50% {
    transform: translate(20%, 20%);
  }
  100% {
    transform: translateY(0);
  }
}
@keyframes decorImg {
  0% {
    transform: translateX(100%);
    opacity: 0.8;
  }
  100% {
    transform: translateX(0);
    opacity: 1;
  }
}
@keyframes zoom {
  0% {
    transform: scale(1, 1);
  }
  50% {
    transform: scale(1.2, 1.2);
  }
  100% {
    transform: scale(1, 1);
  }
}
.new-hightlight {
  background-color: #E7194A;
  color: white;
  padding: 0.3rem 0.6rem;
  line-height: 1rem;
  font-size: 0.8rem;
  font-weight: 500;
  border-radius: 0.2rem;
  display: inline-block;
}

.swiper-button-prev {
  border-right: 1px solid gray;
  padding-right: 2.5rem;
}

.swiper-button-next, .swiper-button-prev {
  height: 2rem;
  width: 2rem;
}

.swiper-button-next:after, .swiper-button-prev:after {
  font-size: 2rem;
  color: #E7194A;
}

.custom-navigation {
  display: flex;
  padding: 1rem 0;
}

.custom-nav-btn {
  font-weight: lighter;
  font-size: 2rem;
  padding: 0 0rem;
  color: #E7194A;
  cursor: pointer;
}
.custom-nav-btn.swiper-button-disabled {
  color: gray;
}
.custom-nav-btn:first-child {
  padding-right: 1rem;
}
.custom-nav-btn:last-child {
  padding-left: 1rem;
  border-left: 1px solid #69578A;
}

.header {
  position: fixed;
  top: 0;
  left: 0;
  right: 0;
  width: 100%;
  z-index: 100;
}
.header-top {
  background-color: white;
  padding: 1rem 0;
  animation: fixedMenu 0.3s linear;
}
.header-logo {
  width: 8.3rem;
  height: 6rem;
  margin: 0 auto;
}
.header-bottom {
  background-color: #371f62;
  color: white;
}
.header-nav-wrap {
  display: flex;
  justify-content: space-between;
  align-items: center;
  padding: 0 1.5rem;
  position: relative;
}
.header-menu-list {
  display: flex;
  align-items: center;
  justify-content: space-between;
  margin-left: -1.3rem;
}
.header-menu-item {
  padding: 1.5rem 0;
  transition: 0.3s ease-in-out;
  position: relative;
}
.header-menu-item:hover {
  background-color: #E7194A;
}
.header-menu-item:hover .header-menu-item-new {
  box-shadow: rgba(99, 99, 99, 0.2) 0px 2px 5px 5px;
}
.header-menu-link {
  padding: 1.5rem 1.3rem;
  line-height: 1.9rem;
}
.header-menu-item-new {
  position: absolute;
  right: -15%;
}
.header-login {
  padding: 1rem 1.6rem;
  border-radius: 0.4rem;
  line-height: 1.6rem;
  font-size: 1.2rem;
  font-weight: bold;
  background-color: #E7194A;
  cursor: pointer;
  transition: 0.3s linear;
}
.header-login:hover {
  background-color: white;
  color: #E7194A;
}
.header .collapse-menu {
  display: none;
}
.header .hamburger-inner, .header .hamburger-inner::before, .header .hamburger-inner::after, .header .hamburger.is-active .hamburger-inner, .header .hamburger.is-active .hamburger-inner::before, .header .hamburger.is-active .hamburger-inner::after {
  background-color: #E7194A;
}
@media screen and (max-width: 767px) {
  .header-top {
    padding: 0.5rem 0;
  }
  .header-logo {
    width: 6rem;
    height: 4rem;
  }
  .header-login {
    padding: 0.8rem;
  }
  .header .collapse-menu {
    display: block;
  }
  .header .hamburger {
    padding: 0.8rem 0;
  }
  .header-menu {
    position: absolute;
    top: 4.3rem;
    margin: 0 -1.7rem;
    transform: translateX(-100%);
    transition: 0.3s ease-in-out;
  }
  .header-menu.is-active {
    transform: translateX(0);
  }
  .header-menu-list {
    display: block;
    margin-left: 0;
    background-color: #371F62;
    height: 100vh;
    width: 30rem;
  }
  .header-menu-item-new {
    position: relative;
    right: 0;
  }
  .header-menu-item {
    padding-left: 1rem;
  }
}

.banner {
  padding-top: 12.7rem;
}

.slide {
  height: 50rem;
  padding-top: 7rem;
  position: relative;
  color: white;
  background-image: url(../img/slide-img-2.png);
  background-position: center;
  overflow: hidden;
}
.slide-content {
  padding-left: 1.5rem;
  padding-right: 1.5rem;
  position: relative;
  z-index: 99;
  text-align: left;
}
.slide-heading {
  font-size: 2.4rem;
  font-weight: bold;
  line-height: 3.2rem;
  margin-bottom: 1rem;
}
.slide-title {
  font-size: 4.8rem;
  font-weight: bold;
  line-height: 6.3rem;
}
.slide-title span {
  color: #E7194A;
}
.slide-titles {
  margin-bottom: 1.5rem;
}
.slide-desc {
  max-width: 47rem;
  font-size: 1.8rem;
  color: #1FBCED;
  margin-bottom: 3rem;
}
.slide-desc strong {
  text-transform: uppercase;
  color: #E7194A;
  line-height: 1.5;
}
.slide-ads {
  display: flex;
  align-items: center;
  margin-bottom: 3rem;
}
.slide-ads-img {
  display: flex;
  align-items: center;
  margin-left: 0.8rem;
}
.slide .ads-img {
  margin-left: -0.8rem;
}
.slide-ads-desc {
  color: white;
  margin-left: 0.5rem;
}
.slide-decor-img {
  width: 63rem;
  position: absolute;
  right: 40rem;
  bottom: -1rem;
  z-index: 10;
  animation: decorImg 0.5s linear;
}
.slide-decor-title {
  color: white;
  font-style: 2rem;
  text-transform: uppercase;
  line-height: 1.4;
  text-align: center;
  width: 12rem;
  position: absolute;
  z-index: 99;
  top: 3rem;
  right: 3rem;
  animation: zoom 1.5s infinite;
}
.slide-decor-title span {
  font-weight: bold;
}
.slide-decor-circle1 {
  width: 22.7rem;
  position: absolute;
  top: 0rem;
  left: 13rem;
  transition: 0.5s linear;
  animation: bubble1 7s linear infinite;
}
.slide-decor-circle2 {
  width: 10rem;
  height: 10rem;
  border-radius: 50%;
  background-color: rgba(255, 255, 255, 0.144);
  position: absolute;
  bottom: 5rem;
  left: 30%;
  transition: 0.5s linear;
  animation: bubble2 4s linear infinite;
}
@media screen and (max-width: 1910px) {
  .slide-decor-img {
    right: 15%;
  }
}
@media screen and (max-width: 1500px) {
  .slide-decor-img {
    right: 11%;
  }
}
@media screen and (max-width: 1337px) {
  .slide-decor-img {
    right: 6%;
  }
}
@media screen and (max-width: 1023px) {
  .slide {
    height: 45rem;
  }
  .slide-content {
    text-align: center;
  }
  .slide-desc {
    margin: 0 auto;
    margin-bottom: 1.5rem;
    text-align: center;
    font-size: 1.4rem;
  }
  .slide-ads {
    margin: 0 auto;
    justify-content: center;
    margin-bottom: 1rem;
  }
  .slide-decor-img {
    display: none;
  }
}
@media screen and (max-width: 767px) {
  .slide {
    height: 34rem;
    padding-top: 5rem;
  }
  .slide-heading {
    font-size: 1.6rem;
    margin-bottom: 0.5rem;
  }
  .slide-title {
    font-size: 3rem;
    line-height: 1.5;
  }
}
@media screen and (max-width: 374px) {
  .slide {
    padding-top: 2rem;
  }
  .slide-title {
    font-size: 2.5rem;
    line-height: 1.5;
  }
  .slide-desc, .slide-ads {
    font-size: 1.2rem;
  }
}

@media screen and (max-width: 767px) {
  .banner {
    padding-top: 9rem;
  }
}
.list {
  padding: 6rem 1.5rem;
  background-color: #F4F4F7;
}
.list-heading {
  margin-bottom: 3rem;
}
.list-title {
  font-size: 3rem;
  font-weight: bold;
  line-height: 3.9rem;
  color: #371F62;
  position: relative;
  margin-bottom: 0.2rem;
}
.list-new {
  position: absolute;
  top: 0;
}
.list-heading-desc {
  font-size: 1.4rem;
  color: black;
  line-height: 1.9rem;
}
.list-lists {
  display: flex;
  align-items: center;
  flex-wrap: wrap;
  margin-left: -1rem;
  margin-bottom: 2rem;
}
.list-item {
  display: flex;
  align-items: flex-start;
  width: calc(50% - 1rem);
  margin-left: 1rem;
  margin-bottom: 1rem;
  background-color: white;
  transition: 0.3s ease-in-out;
}
.list-item:nth-child(2) .list-item-highlight {
  background-color: #38AAF2;
}
.list-item:nth-child(3) .list-item-highlight {
  background-color: #FFA10B;
}
.list-item:nth-child(4) .list-item-highlight {
  background-color: #262E67;
}
.list-item:hover {
  box-shadow: rgba(99, 99, 99, 0.2) 0px 2px 5px 5px;
}
.list-item-img-wrap {
  width: 50%;
  position: relative;
  height: 100%;
}
.list-item-highlight {
  color: white;
  font-weight: bold;
  font-size: 1.4rem;
  line-height: 1.9rem;
  background-color: #B72EB7;
  padding: 0.9rem 2rem;
  position: absolute;
  top: 0;
  left: 0;
}
.list-item-content {
  width: calc(50% - 1rem);
  padding-top: 2rem;
  padding-left: 3rem;
}
.list-item-author {
  display: flex;
  margin-bottom: 0.6rem;
}
.list-item-avatar {
  width: 1.4rem;
  height: 1.4rem;
}
.list-item-name {
  font-size: 1rem;
  line-height: 1.3rem;
  margin-left: 0.3rem;
}
.list-item-title {
  font-size: 1.6rem;
  font-weight: bold;
  line-height: 2.1rem;
  color: #371F62;
  margin-bottom: 1.5rem;
}
.list-item-details {
  display: flex;
  align-items: center;
  flex-wrap: wrap;
  justify-content: space-between;
  margin-bottom: 1.8rem;
}
.list-item-info {
  display: flex;
  align-items: center;
  width: 50%;
  margin-bottom: 1rem;
}
.list-item-icon {
  width: 1.4rem;
  height: 1.4rem;
}
.list-item-detail {
  font-size: 1.4rem;
  line-height: 1.9rem;
  padding-left: 0.5rem;
}
.list-item-link {
  font-size: 1.2rem;
  font-weight: bold;
  color: #E7194A;
  text-transform: uppercase;
  transition: 0.3s ease-in-out;
}
.list-item-link:hover {
  color: #371F62;
}
.list-btn {
  display: block;
  margin-left: auto;
}
@media screen and (max-width: 1110px) {
  .list-item-content {
    padding-left: 1.5rem;
  }
  .list-item-details {
    margin-bottom: 0.8rem;
  }
  .list-item-detail {
    font-size: 1.2rem;
  }
}
@media screen and (max-width: 1023px) {
  .list {
    padding: 3rem 1.5rem;
  }
  .list-item-content {
    padding-left: 1.5rem;
    padding-bottom: 2rem;
  }
  .list-item-details {
    margin-bottom: 1rem;
    justify-content: space-between;
  }
  .list-item-detail {
    font-size: 1.3rem;
  }
  .list-item {
    display: block;
  }
  .list-item-img-wrap {
    width: 100%;
  }
  .list-item-content {
    width: 100%;
  }
}
@media screen and (max-width: 767px) {
  .list-lists {
    display: block;
    margin-left: 0;
  }
  .list-item {
    width: 100%;
    margin-left: 0;
  }
}

.refer {
  padding: 6rem 1.5rem;
  position: relative;
  overflow-x: hidden;
}
.refer-heading {
  margin-bottom: 3rem;
  position: relative;
  padding-left: 1.5rem;
  display: flex;
  align-items: center;
  justify-content: space-between;
}
.refer .swiper-container {
  width: 100%;
  height: 100%;
}
.refer .swiper-slide {
  width: 27rem;
  text-align: center;
  cursor: pointer;
}
.refer-img {
  margin-bottom: 1.5rem;
}
.refer-title {
  font-size: 1.6rem;
  font-weight: bold;
  line-height: 2.1rem;
  color: #371F62;
  margin-bottom: 0.5rem;
}
.refer-date {
  font-size: 1.4rem;
  line-height: 1.9rem;
}
.refer .swiper-container {
  overflow: unset;
}
.refer .swiper-button-prev {
  border-right: 1px solid gray;
  padding-right: 2.5rem;
}
.refer .swiper-button-next, .refer .swiper-button-prev {
  height: 2rem;
  width: 2rem;
}
.refer .swiper-button-next:after, .refer .swiper-button-prev:after {
  font-size: 2rem;
  color: #E7194A;
}
.refer .swiper-button-prev, .refer .swiper-container-rtl .swiper-button-next {
  left: -8rem;
}
.refer .swiper-button-next, .refer .swiper-container-rtl .swiper-button-prev {
  right: 19px;
}
@media screen and (max-width: 1335px) {
  .refer .swiper-container {
    overflow: hidden;
  }
}

.tips {
  padding: 6rem 0;
  background-color: #371F62;
}
.tips-heading-title {
  color: white;
  margin-bottom: 2rem;
}
.tips-wrap {
  display: flex;
  position: relative;
}
.tips-img-wrap {
  width: 50%;
}
.tips-content {
  width: 50%;
  padding-left: 3rem;
  padding-right: 1rem;
  color: white;
  position: relative;
}
.tips-slide {
  position: relative;
  cursor: pointer;
}
.tips-slide-title {
  font-size: 2rem;
  font-weight: bold;
  line-height: 2.6rem;
  margin-bottom: 0.4rem;
}
.tips-slide-date {
  font-size: 1.4rem;
  line-height: 1.9rem;
  color: #69578A;
  margin-bottom: 2rem;
}
.tips-slide-desc {
  font-size: 1.4rem;
  line-height: 2.4rem;
  margin-bottom: 1.5rem;
}
.tips-slide-link {
  display: inline-block;
  color: #E7194A;
  text-transform: uppercase;
  font-size: 1.2rem;
  line-height: 1.6rem;
  margin-bottom: 2.7rem;
}
.tips-slide-link:hover {
  color: white;
}
.tips-navigation {
  display: flex;
  padding: 1rem 0;
}
.tips-nav-btn {
  font-weight: lighter;
  font-size: 2rem;
  padding: 0 0rem;
  color: #E7194A;
  cursor: pointer;
}
.tips-nav-btn.swiper-button-disabled {
  color: gray;
}
.tips-nav-btn:first-child {
  padding-right: 1rem;
}
.tips-nav-btn:last-child {
  padding-left: 1rem;
  border-left: 1px solid #69578A;
}
.tips-decor-circle1 {
  width: 22.7rem;
  height: 22.7rem;
  border-radius: 50%;
  background-color: #FFA10B;
  position: absolute;
  z-index: 1;
  top: -10rem;
  left: -40rem;
  box-shadow: 1rem 1rem 3rem rgba(0, 0, 0, 0.16);
}
.tips-decor-circle2 {
  width: 10rem;
  height: 10rem;
  border-radius: 50%;
  background-color: #E7194A;
  position: absolute;
  z-index: 1;
  bottom: -11rem;
  left: -10rem;
  box-shadow: 1rem 1rem 3rem rgba(0, 0, 0, 0.16);
}
.tips-decor-circle3 {
  width: 17.4rem;
  height: 17.4rem;
  border-radius: 50%;
  background-color: #1FBCED;
  position: absolute;
  z-index: 1;
  bottom: -14rem;
  right: -30rem;
  box-shadow: 1rem 1rem 3rem rgba(0, 0, 0, 0.16);
}
@media screen and (max-width: 1500px) {
  .tips-decor-circle1, .tips-decor-circle2, .tips-decor-circle3 {
    display: none;
  }
}
@media screen and (max-width: 1335px) {
  .tips {
    padding: 4rem 1.5rem;
  }
  .tips-content {
    padding-left: 1.5rem;
  }
  .tips-slide-desc {
    display: -webkit-box;
    -webkit-line-clamp: 4;
    -webkit-box-orient: vertical;
    overflow: hidden;
    margin-bottom: 1rem;
  }
  .tips-slide-link {
    margin-bottom: 1.5rem;
  }
  .tips-heading-title {
    margin-bottom: 1rem;
  }
  .tips-slide-date {
    margin-bottom: 1rem;
  }
}
@media screen and (max-width: 1023px) {
  .tips-wrap {
    display: block;
  }
  .tips-img-wrap {
    width: 100%;
    margin-bottom: 1rem;
  }
  .tips-content {
    width: 100%;
  }
}
@media screen and (max-width: 767px) {
  .tips {
    padding: 2rem 1.5rem;
  }
}

.footer {
  padding: 6rem 1.5rem;
  background-color: #F8F8F8;
}
.footer-top {
  display: flex;
  align-items: flex-start;
  justify-content: space-between;
  padding-bottom: 3.3rem;
  border-bottom: 1px solid #CED0DB;
  margin-bottom: 2rem;
  padding-left: 1.5rem;
  padding-right: 1.5rem;
}
.footer-logo {
  width: 16.66%;
  padding-right: 6rem;
}
.footer-center {
  width: 66.66%;
  padding-right: 1.6rem;
}
.footer-desc {
  font-size: 1.4rem;
  color: black;
  line-height: 2.4rem;
  margin-bottom: 2rem;
}
.footer-center-list {
  display: flex;
  align-items: center;
  justify-content: space-between;
}
.footer-center-item {
  padding-right: 7rem;
  text-transform: uppercase;
  font-weight: bold;
  color: #371F62;
  display: flex;
  align-items: center;
  transition: 0.3s ease-in-out;
}
.footer-center-item i {
  font-size: 1.6rem;
  color: #E7194A;
  margin-left: 0.8rem;
  transition: 0.3s ease-in-out;
}
.footer-center-item:hover {
  color: #E7194A;
}
.footer-center-item:hover i {
  transform: rotate(90deg);
}
.footer-right {
  width: 16.66%;
}
.footer-right-list {
  display: flex;
  flex-direction: column;
  justify-content: space-between;
  margin-bottom: 1.2rem;
}
.footer-right-item {
  font-style: 1.4rem;
  font-weight: bold;
  color: block;
  line-height: 1.9rem;
  padding-bottom: 1.5rem;
  transition: 0.3s ease-in-out;
}
.footer-right-item:hover {
  color: #E7194A;
}
.footer-social p {
  font-style: 1rem;
  line-height: 1.3rem;
  margin-bottom: 0.5rem;
}
.footer-social-list {
  display: flex;
  align-items: center;
}
.footer-social-item {
  margin-right: 0.5rem;
  height: 2rem;
  width: 2rem;
  border-radius: 50%;
  display: flex;
  align-items: center;
  justify-content: center;
  transition: 0.3s ease-in-out;
  cursor: pointer;
}
.footer-social-item:nth-child(1) {
  background-color: #3B5998;
}
.footer-social-item:nth-child(2) {
  background-color: #41A1F2;
}
.footer-social-item:nth-child(3) {
  background-color: #EA412C;
}
.footer-social-item i {
  font-size: 1rem;
  color: white;
}
.footer-social-item:hover {
  background-color: #E7194A;
}
.footer-copyright {
  font-style: 1.4rem;
  line-height: 1.9rem;
  display: flex;
  align-items: center;
  justify-content: space-between;
}
.footer-copyright-list {
  display: flex;
  align-items: center;
  justify-content: space-between;
  margin-right: -1rem;
}
.footer-copyright-item {
  padding: 1rem;
  transition: 0.3s ease-in-out;
}
.footer-copyright-item:hover {
  color: #E7194A;
}
@media screen and (max-width: 1335px) {
  .footer-center-item {
    padding-right: 3rem;
  }
}
@media screen and (max-width: 1023px) {
  .footer {
    padding: 3rem 0;
  }
  .footer-logo {
    width: 16.66%;
    padding-right: 1rem;
  }
  .footer-desc {
    padding-left: 0.5rem;
    font-size: 1.2rem;
  }
  .footer-center-item {
    font-size: 1.2rem;
    padding-right: 1rem;
  }
  .footer-center-item i {
    margin-left: 0.5rem;
  }
  .footer-copyright {
    justify-content: center;
  }
  .footer-copyright-list {
    display: none;
  }
}
@media screen and (max-width: 767px) {
  .footer-top {
    display: block;
    padding: 0 1rem;
    padding-bottom: 1rem;
  }
  .footer-logo {
    width: 40%;
    margin-bottom: 1rem;
  }
  .footer-center {
    width: 100%;
    padding: unset;
  }
  .footer-right {
    width: 100%;
  }
  .footer-center-list {
    margin-bottom: 1rem;
  }
  .footer-center-item {
    padding-right: 0;
    font-size: 1.1rem;
  }
  .footer-center-item i {
    margin-left: 0;
  }
  .footer-right-list {
    flex-direction: row;
    margin-bottom: 1rem;
  }
  .footer-right-item {
    padding: 0 0.2rem;
  }
  .footer-social {
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: center;
  }
  .footer-social-list {
    margin: 0 auto;
  }
}
@media screen and (max-width: 410px) {
  .footer-center-list {
    display: none;
  }
  .footer-right-item:not(:first-child) {
    border-left: 1px solid #CED0DB;
  }
}

.about-banner {
  padding-top: 12.7rem;
}
.about-banner-wrap {
  height: 40rem;
  background-image: url(../img/about-banner-img.png);
  text-align: center;
  font-size: 4rem;
  line-height: 5.3rem;
  font-weight: bold;
  color: white;
  padding-top: 28.3rem;
  position: relative;
  z-index: 1;
}
.about-banner-wrap:before {
  content: "";
  position: absolute;
  top: 0;
  right: 0;
  left: 0;
  bottom: 0;
  background-image: url(../img//about-banner-layer.png);
  z-index: -1;
}
.about-banner-wrap h1 {
  position: relative;
  z-index: 50;
}

.about {
  overflow: hidden;
  padding-left: 1.5rem;
}
.about-wrap {
  display: flex;
}
.about-content {
  padding-top: 6rem;
  padding-right: 3rem;
  padding-bottom: 6.7rem;
  width: 58.33%;
  position: relative;
}
.about-content::before {
  content: "";
  height: 87rem;
  width: 87rem;
  border-radius: 50%;
  background-color: #F8F8F8;
  position: absolute;
  bottom: -40rem;
  left: -45rem;
  z-index: -1;
}
.about-heading {
  margin-bottom: 2.3rem;
  color: #371F62;
}
.about-desc {
  font-size: 1.4rem;
  line-height: 2.4rem;
  margin-bottom: 3.8rem;
}
.about-desc span {
  text-transform: uppercase;
  font-weight: bold;
}
.about-count-list {
  display: flex;
  align-items: center;
  flex-wrap: wrap;
}
.about-count-item {
  width: 40%;
  margin-bottom: 3rem;
}
.about-count-heading {
  font-size: 5rem;
  line-height: 6.6rem;
  color: #E7194A;
}
.about-count-title {
  text-transform: uppercase;
  font-size: 1.4rem;
  font-weight: bold;
  line-height: 1.9rem;
}
@media screen and (max-width: 1023px) {
  .about-content {
    padding-top: 3rem;
  }
}
@media screen and (max-width: 767px) {
  .about {
    padding-left: 0;
  }
  .about-wrap {
    display: block;
  }
  .about-content {
    width: 100%;
    padding-left: 1.5rem;
    padding-right: 1.5rem;
    padding-bottom: 3rem;
  }
  .about .sidebar {
    width: 100%;
  }
  .about-count-list {
    justify-content: center;
  }
  .about-count-item {
    margin-bottom: 1rem;
  }
  .about-count-heading {
    font-size: 3rem;
    margin-bottom: 1rem;
    line-height: 4rem;
  }
  .about-count-title {
    font-size: 1.2rem;
    line-height: 1.5;
  }
}

.decor-img {
  height: 40rem;
  background-image: url(../img/decor-bg.png);
  background-repeat: no-repeat;
  background-position: top;
}

@media screen and (max-width: 1023px) {
  .decor-img {
    display: none;
  }
}
.reason {
  padding-top: 4rem;
  padding-bottom: 7rem;
  padding-left: 1.5rem;
  padding-right: 1.5rem;
}
.reason-heading {
  margin-bottom: 3rem;
}
.reason-list {
  display: flex;
  flex-wrap: wrap;
  align-items: center;
  justify-content: space-between;
}
.reason-wrap {
  padding-right: 5rem;
}
.reason-item {
  text-align: left;
  width: 33.3%;
  margin-bottom: 4rem;
}
.reason-icon {
  height: 4rem;
  width: 4rem;
  margin-bottom: 1rem;
}
.reason-title {
  font-size: 2rem;
  font-weight: bold;
  line-height: 2.6rem;
  margin-bottom: 1.2rem;
}
.reason-desc {
  line-height: 2.4rem;
}
@media screen and (max-width: 767px) {
  .reason-heading {
    text-align: center;
  }
  .reason-wrap {
    padding-right: 2rem;
  }
  .reason-item {
    width: 50%;
  }
}
@media screen and (max-width: 400px) {
  .reason {
    padding: 3rem 1.5rem;
  }
  .reason-wrap {
    padding-right: 0;
    text-align: center;
  }
  .reason-icon {
    margin: 0 auto;
    margin-bottom: 1rem;
  }
  .reason-list {
    display: block;
  }
  .reason-item {
    width: 100%;
  }
}

.teachers {
  padding: 7rem 1.5rem;
}
.teachers-heading {
  margin-bottom: 3rem;
}
.teachers-img-wrap {
  margin-bottom: 1.5rem;
}
.teachers-name {
  font-size: 2rem;
  font-weight: bold;
  line-height: 2.6rem;
}
.teachers-position {
  color: #E7194A;
  line-height: 2.4rem;
  margin-bottom: 1.5rem;
}
.teachers-info {
  line-height: 2.4rem;
}
.teachers .swiper-wrapper {
  cursor: pointer;
}

.what {
  height: 8rem;
  text-align: center;
}
.what-title {
  font-size: 3rem;
  font-weight: bold;
  color: #371F62;
  line-height: 3.9rem;
  padding: 2rem 0;
}
.what-title :hover {
  color: #E7194A;
}
.what-title :hover i {
  color: #E7194A;
}
.what .swiper-slide:nth-child(1) {
  background-color: #B72EB7;
}
.what .swiper-slide:nth-child(2) {
  background-color: #38AAF2;
}
.what .swiper-slide:nth-child(3) {
  background-color: #FFA10B;
}
.what .swiper-slide:nth-child(4) {
  background-color: #262E67;
}

/*# sourceMappingURL=style.cs.map */
