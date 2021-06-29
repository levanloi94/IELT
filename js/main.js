
// ONSROLL NAV
window.onscroll = function() {scrollFunction()};
const backToTopBtn = document.querySelector('.back-to-top');
function scrollFunction() {
        if (document.body.onscrollTop >200 || document.documentElement.scrollTop > 200) {
            document.querySelector('.header-top').style.display ='none';
            backToTopBtn.style.opacity = '1';
            backToTopBtn.style.visibility = 'visible';
        }else{  
            document.querySelector('.header-top').style.display ='';
            backToTopBtn.style.opacity = '';
            backToTopBtn.style.visibility = '';
        }      
}

//BACK TO TOP FUNC

backToTopBtn.addEventListener('click', ()=>{
    window.scrollTo({ top: 0, behavior: 'smooth' });
})

// MENU MOBILE
const body = document.querySelector('body');
const openMenuMb = document.querySelector('.collapse-menu');
const menuMb = document.querySelector('.header .header-menu');
const menuMbActived =document.querySelector('.header-menu.is-active');
const openMenuMbActived = document.querySelector('.collapse-menu.is-active');

openMenuMb.addEventListener('click', ()=>{
    openMenuMb.classList.toggle('is-active');
    menuMb.classList.toggle('is-active');
    body.classList.toggle('is-active');
})

document.addEventListener('click', (e) =>{
    if(!menuMb.contains(e.target) && 
       !openMenuMb.contains(e.target)){
        openMenuMb.classList.remove('is-active');
        menuMb.classList.remove('is-active');
        body.classList.remove('is-active');
       }
})


const swiper = new Swiper('.banner .swiper-container', {
    slidesPerView: 1,
    autoplay: {
        delay: 5000,
    },
  
});
const swiper2 = new Swiper('.refer .swiper-container',{
    slidesPerView: 2,
    // centeredSlides: true,
    // slidesOffsetBefore:10,
    spaceBetween: 15,
    navigation: {
        prevEl: '.slidePrev-btn',
        nextEl: '.slideNext-btn'
    },
    breakpoints: {
        // when window width is >= 767px
        767: {
          slidesPerView: 4,
          spaceBetween: 30
        }
    },
    autoplay: {
        delay: 3000,
    }
    
    
});
// swiper2.slideTo(5);

const swiper3 = new Swiper('.tips .swiper-container',{
    spaceBetween: 20,
    navigation: {
        prevEl: '.slidePrev-btn',
        nextEl: '.slideNext-btn'
    },
    autoplay: {
        delay: 4000,
    }
})

const swiperTeacher = new Swiper('.teachers .swiper-container',{
    slidesPerView: 2,
    spaceBetween: 10,
    autoplay: {
        delay: 3000,
    },
    breakpoints: {
        // when window width is >= 767px
        767: {
          slidesPerView: 4,
          spaceBetween: 30
        }
    },
})
const swiperWhat = new Swiper('.what .swiper-container',{
    slidesPerView: 1,
    autoplay: {
        delay: 2000,
    }
})
const swpiperCourseRelate  = new Swiper('.courserelate .swiper-container',{
    slidesPerView: 1,
    spaceBetween: 10,

    pagination: {
        el: '.swiper-pagination',
      },
      
    autoplay: {
        delay: 2000,
    },
    breakpoints: {
        650: {
            slidesPerView: 2,
            spaceBetween: 10
          },
        // when window width is >= 930px
        930: {
          slidesPerView: 3,
          spaceBetween: 15
        }
    },
})
    



//active pagination
const paginationItem = document.querySelectorAll('.pagination-item');
const pagination =  document.querySelector('.pagination');

if(pagination){
    for(let i =0; i< paginationItem.length; i++){
        paginationItem[i].addEventListener('click', ()=>{
            console.log('click')
            let currItem = document.querySelector('.pagination-item.is-active');
            currItem.classList.remove('is-active');
            paginationItem[i].classList.add('is-active');
        })
    }
}
//Toggle like
const likeBtn = document.querySelectorAll('.like');

if(likeBtn){
    for(let i = 0; i< likeBtn.length; i++){
        likeBtn[i].addEventListener('click',() => {
            likeBtn[i].classList.toggle('is-active');
        })
    }
}

//Aos animate
AOS.init();