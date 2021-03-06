@import url("https://fonts.googleapis.com/css2?family=Lato:wght@300&display=swap");
/* font-family: 'Lato', sans-serif; */
@import url("https://fonts.googleapis.com/css2?family=Satisfy&display=swap");
/* font-family: 'Satisfy', cursive; */
@import url("https://fonts.googleapis.com/css2?family=Playfair+Display&display=swap");
/* font-family: 'Playfair Display', serif; */
* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}

/* inicio main */
/* encabezados*/
.h2--cursive {
  font-family: "Satisfy", cursive;
}

.h2--lato {
  font-family: "Lato", sans-serif;
}

.h3--lato {
  font-family: "Lato", sans-serif;
}

.h2--testimonios {
  margin-top: 15px;
  margin-left: auto;
  margin-right: auto;
  margin-bottom: 0;
  padding: 10px 25px;
}

.centrado {
  text-align: center;
}

.h2--nosotras {
  margin-top: 50px;
}

.h2--trat {
  margin-top: 20px;
}

h3 {
  font-family: "Lato", sans-serif;
}

.mapa__h3 {
  font-family: "Lato", sans-serif;
}

/* fin encabezados*/
.img--bienvenidos {
  width: 500px;
  height: auto;
  border-radius: 3px;
  max-width: 100%;
}

/* iconos redes index */
.seccion__img--descuentos {
  display: flex;
  flex-direction: row;
  flex-wrap: wrap;
  justify-content: center;
}

.img--redes {
  width: 75px;
}

/* fin iconos redes index */
.row--descuentos {
  width: 95%;
}

.row--bienvenidos {
  display: flex;
  align-items: center;
  margin-top: 60px;
  margin-bottom: 20px;
  background-color: #34bfb154;
  padding: 10px;
  box-shadow: 5px 5px 15px rgba(0, 0, 0, 0.116);
}

.row--nosotras {
  background-image: linear-gradient(to bottom, #f5e5f0, #f6ecf5, #f8f3fa, #fbf9fd, #ffffff);
  margin-top: 35px;
  margin-bottom: 65px;
  display: flex;
  align-items: center;
  padding: 20px;
  box-shadow: 5px 5px 15px rgba(0, 0, 0, 0.116);
}

.p--bienvenidos {
  text-align: justify;
}

.textoBienvenidos {
  padding: 5px;
}

.tituloBienvenidos {
  margin-top: 10px;
}

.p--testimonios {
  text-align: center;
  font-family: "Lato", sans-serif;
  font-style: italic;
  font-size: 1.8em;
  height: 304px;
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  padding-left: 15%;
  padding-right: 15%;
}

.nombres--testimonios {
  font-size: 1.3rem;
  font-style: normal;
  text-align: center;
  margin-top: 15px;
}

.card--tratamientos {
  margin: 35px;
  background-image: linear-gradient(to bottom, #f5e5f0, #f6ecf5, #f8f3fa, #fbf9fd, #ffffff);
}

.row--tratamientos {
  margin-bottom: 50px;
}

.card--vela {
  flex-direction: column;
  justify-content: center;
  align-items: center;
}

.card--vela ol {
  padding: 0 10%;
}

.tratamientos__titulos--cardVela {
  display: flex;
  flex-direction: row;
  align-items: center;
  flex-wrap: wrap;
  justify-content: center;
  margin-top: 10px;
}

.tratamientos__titulos--cardVela p {
  margin-top: 10px;
  margin-left: 10px;
}

.card--vela ol {
  margin-top: 20px;
}

.card-text {
  text-align: justify;
}

.card-img-top {
  padding-top: 15px;
}

.img--nosotras {
  display: flex;
  justify-content: center;
  align-items: center;
  width: 80% !important;
  height: auto;
}

.p--nosotras {
  display: flex;
  flex-direction: column;
}

.p--nosotras span {
  font-weight: bold;
  font-size: 18px;
}

/* fin main */
/* ANIMACION DE IMAGENES */
.imgScale {
  transition: 1s;
}

.imgScale:hover {
  transform: scale(1.5);
  animation-timing-function: ease-in-out;
}

.imgScale--nosotras {
  transition: 0.3s;
}

.imgScale--nosotras:hover {
  transform: scale(1.06);
  animation-timing-function: ease-in-out;
}

/* FIN ANIMACION DE IMAGENES */
/* CAROUSEL */
.slideTestimonios {
  background-image: url(../images_v3/fondoTestimonios.svg);
  height: 304px;
}

.carousel-control-prev-icon {
  background-image: url("data:image/svg+xml,%3csvg xmlns='http://www.w3.org/2000/svg' fill='%23000' width='8' height='8' viewBox='0 0 8 8'%3e%3cpath d='M5.25 0l-4 4 4 4 1.5-1.5L4.25 4l2.5-2.5L5.25 0z'/%3e%3c/svg%3e");
}

.carousel-control-next-icon {
  background-image: url("data:image/svg+xml,%3csvg xmlns='http://www.w3.org/2000/svg' fill='%23000' width='8' height='8' viewBox='0 0 8 8'%3e%3cpath d='M2.75 0l-1.5 1.5L3.75 4l-2.5 2.5L2.75 8l4-4-4-4z'/%3e%3c/svg%3e");
}

/* FIN CAROUSEL */
/* descuentos */
.giftCard {
  height: 100px;
  background-size: cover;
}

.div--giftCard p {
  margin-top: 20px;
}

.div--descuentos {
  border-right: 1px dotted #999;
}

.div--descuentos h3 {
  margin-bottom: 20px;
}

.container--descuentos {
  background-color: #34bfb154;
  padding: 10px;
  margin-top: 15px;
}

.container--descuentos h2 {
  padding: 10px;
}

/* fin descuentos */
/* inicio footer */
#navSecundaria {
  background-color: rgba(255, 235, 205, 0);
}

.footer__ul li {
  margin-bottom: 8px;
}

.footer__ul {
  list-style: none;
}

.footer__a {
  color: black;
  text-decoration: none;
}

.footer__a:hover {
  color: blue;
  text-decoration: none;
}

.footer__a:active {
  color: #570257;
}

.footer__img {
  width: 20px;
  display: block;
  margin: 4px;
}

.footer__tablaContacto tr td img {
  padding-bottom: 15px;
}

.footer__tablaContacto tr td a {
  text-decoration: none;
  color: black;
}

.footer__tablaContacto tr td a :hover {
  color: blue;
}

.footer__div--redes {
  margin-bottom: 25px;
}

footer {
  background-color: #34bfb154;
  padding-top: 30px;
  padding-bottom: 30px;
}

.footer__p {
  font-family: "Playfair Display", serif;
}

.footer__div--redes {
  display: flex;
  flex-direction: row;
  justify-content: left;
}

.footer__div--redes a {
  text-decoration: none;
}

.footer__div--redes a :hover {
  text-decoration: none;
}

.footer__div--redes i {
  font-size: 40px;
}

.fa-facebook-square {
  color: #333;
}

.fa-instagram-square {
  color: #333;
}

.iconoFacebook {
  margin-right: 20px;
}

/* fin footer */
/* formulario */
form {
  background-image: url(../images_v3/fondoFormulario.svg);
  border: 1px solid black;
  margin: 15px;
  padding: 10px;
  box-shadow: 5px 5px 15px rgba(0, 0, 0, 0.116);
  margin-top: 35px;
  margin-bottom: 60px;
}

legend {
  font-family: "Lato", sans-serif;
  padding: 10px;
}

textarea {
  width: 90%;
  margin: 10px;
  padding: 10px;
  font-size: 14px;
}

.input {
  margin: 10px;
  padding: 10px;
  border: 1px solid black;
  border-radius: 5px;
  font-size: 14px;
}

.label {
  margin-left: 10px;
  font-family: "Lato", sans-serif;
}

.img--nosotras {
  border-radius: 3px;
  width: 200px;
  height: auto;
  margin-bottom: 10px;
  margin-left: auto;
}

.articulo--nosotras {
  display: flex;
  flex-direction: column;
  text-align: center;
  margin-left: auto;
}

.articulo__pComun--nosotras {
  width: 100%;
  /* margin-left: 5%; */
  margin-top: 15px;
  margin-bottom: 50px;
}

.legendFormulario {
  font-weight: bold;
  letter-spacing: 0.05em;
}

/* fin formulario */
/* inicio header */
.img--header {
  height: 200px;
  margin-left: 250px;
  padding-top: 15px;
  padding-bottom: 15px;
}

.h1--header {
  color: black;
  font-family: "Lato", sans-serif;
  font-weight: bold;
  text-align: left;
  filter: drop-shadow(3px 3px 10px #34bfb154);
}

.row--header {
  display: flex;
  flex-direction: row;
  align-items: center;
  flex-wrap: wrap;
}

header {
  background-color: #f8f8f8;
}

.div--newsletter p {
  margin-bottom: 5px;
}

/* fin header */
/* mapa */
.seccion--mapa {
  display: flex;
  gap: 20px;
  justify-content: space-between;
}

.container--mapa {
  padding: 15px 15px;
  margin-bottom: 60px;
}

/* fin mapa */
/* inicio menu de navegacion */
.navbar {
  background-color: #34bfb154 !important;
}

.navbar ul li {
  margin-left: 60px;
  margin-right: 60px;
}

.nav-item a:hover {
  color: blue !important;
}

/* fin menu de navegacion */
/* boton header */
.button {
  display: inline-block;
  padding: 12px 24px;
  border: 1px solid #4f4f4f;
  border-radius: 4px;
  transition: all 0.2s ease-in;
  position: relative;
  overflow: hidden;
  font-size: 19px;
  color: black;
  z-index: 1;
}

.button:before {
  content: "";
  position: absolute;
  left: 50%;
  transform: translateX(-50%) scaleY(1) scaleX(1.25);
  top: 100%;
  width: 140%;
  height: 180%;
  background-color: rgba(0, 0, 0, 0.05);
  border-radius: 50%;
  display: block;
  transition: all 0.5s 0.1s cubic-bezier(0.55, 0, 0.1, 1);
  z-index: -1;
}

.button:after {
  content: "";
  position: absolute;
  left: 55%;
  transform: translateX(-50%) scaleY(1) scaleX(1.45);
  top: 180%;
  width: 160%;
  height: 190%;
  background-color: #34bfb154;
  border-radius: 50%;
  display: block;
  transition: all 0.5s 0.1s cubic-bezier(0.55, 0, 0.1, 1);
  z-index: -1;
}

.button:hover {
  color: #ffffff;
  border: 1px solid #34bfb154;
}

.button:hover:before {
  top: -35%;
  background-color: #34bfb154;
  transform: translateX(-50%) scaleY(1.3) scaleX(0.8);
}

.button:hover:after {
  top: -45%;
  background-color: #34bfb154;
  transform: translateX(-50%) scaleY(1.3) scaleX(0.8);
}

/* fin boton header */
/* whatsapp */
.float {
  position: fixed;
  width: 60px;
  height: 60px;
  bottom: 40px;
  right: 40px;
  background-color: #25d366;
  color: #FFF;
  border-radius: 50px;
  text-align: center;
  font-size: 30px;
  box-shadow: 2px 2px 3px #999;
  z-index: 100;
}

.float:hover {
  text-decoration: none;
  color: #25d366;
  background-color: #fff;
}

.my-float {
  margin-top: 16px;
}

/* fin whatsapp */
/* productos */
.row--productos {
  margin-top: 30px;
  margin-bottom: 60px;
}

.row--productos .card {
  box-shadow: rgba(0, 0, 0, 0.4) 0px 2px 4px, rgba(0, 0, 0, 0.3) 0px 7px 13px -3px, rgba(0, 0, 0, 0.2) 0px -3px 0px inset;
}

.cardTitle--productos {
  font-size: 18px;
}

.h3--productos {
  margin-top: 20px;
}

.btn-primary {
  background-color: #f5e5f0;
  color: black;
  border: 1px solid #2b2a2a;
}

.btn-primary:hover, .btn-primary:focus, .btn-primary:active, .btn-primary.active, .open > .dropdown-toggle.btn-primary {
  color: #fff;
  background-color: #05aeb4;
  border-color: #285e8e;
}

.card-text1 {
  margin-bottom: 3px;
}

video {
  width: 420px;
  margin-top: 10px;
  margin-bottom: 30px;
  padding: 10px 10px;
  border: 1px solid black;
  border-radius: 3px;
  box-shadow: 5px 5px 15px rgba(0, 0, 0, 0.116);
}

.h2--productos {
  margin-right: 35px;
  padding-top: 20px;
  margin-top: 35px;
}

.marginKit {
  margin-bottom: 27px;
}

.tituloProductos {
  background-image: linear-gradient(to bottom, #f5e5f0, #f6ecf5, #f8f3fa, #fbf9fd, #ffffff);
  margin-top: 60px;
  margin-bottom: 35px;
  align-items: center;
  padding: 20px;
  box-shadow: 5px 5px 15px rgba(0, 0, 0, 0.116);
}

.div--tituloProductos {
  display: flex;
  flex-direction: row;
  justify-content: center;
  align-items: center;
  align-items: center;
  gap: 40px;
}

.div--tituloProductos h2 {
  padding-top: 15px;
}

.div--pagoEnvio {
  display: flex;
  justify-content: center;
}

.formasPagoEnvio {
  font-size: 18px;
  font-weight: bold;
  margin-top: 55px;
  margin-bottom: 30px;
  text-align: center;
  background-color: #f5e5f0;
  width: 50%;
  line-height: 35px;
  border-radius: 5px;
}

.formasPagoEnvio a {
  text-decoration: none;
  color: black;
}

.formasPagoEnvio a:hover {
  color: blue;
}

.row--pagoEnvio {
  margin-top: 10px;
}

.fa-credit-card, .fa-truck {
  margin-left: 15px;
}

/* fin productos */
/* vela slim */
.div--velaSlim {
  display: flex;
  flex-wrap: wrap;
  justify-content: center;
  width: auto;
  height: auto;
}

.fondo--vela {
  background-image: url(../images_v3/fondoStars.svg);
  background-position: center;
}

.img--vela {
  max-width: 75%;
  height: auto;
  margin-top: 30px;
  margin-bottom: 40px;
  padding: 8px;
  border: 1px solid #7ecfc9;
  border-radius: 3px;
}

.card--vela {
  width: 500px;
  height: 400px;
  border-radius: 10px;
  background: linear-gradient(to bottom, #f5e5f0, #f6ecf5, #f8f3fa, #fbf9fd, #ffffff);
  box-shadow: 5px 5px 15px rgba(0, 0, 0, 0.116);
  margin-bottom: 10px;
}

.row-velaSlim {
  margin-bottom: 50px;
}

.velaslimplus {
  font-family: "Satisfy", cursive;
}

/* vela slim */
/* hifu */
.fondo--hifu {
  background-image: url(../images_v3/circles.svg);
  background-position: center;
}

/* fin hifu */
/* radiofrecuencia */
.fondo--radioFrec {
  background-image: url(../images_v3/polygon.svg);
  background-position: center;
}

.textoRadio {
  padding-left: 5%;
  padding-right: 5%;
  margin-top: 5%;
  line-height: 2;
  text-align: justify;
}

/* fin radiofrecuencia */
/* dermapen */
.fondo--dermapen {
  background: url(../images_v3/blob.svg);
  background-position: center;
}

/* fin dermapen */
/* nosotras */
.jumbotron {
  height: 350px;
  background-image: url(../images_v3/charlaOnline.jpg);
  background-size: cover;
  background-position: center;
  margin-top: 40px;
}

.row--jumbotron {
  border-top: 1px solid #cecece;
}

.jumbotron h1 {
  text-shadow: 1px 1px 8px black;
  color: whitesmoke;
}

.jumbotron p {
  background-color: rgba(255, 255, 255, 0.479);
  padding: 1% 2%;
  font-size: large;
}

.h2--charlas {
  margin-top: 20px;
}

.tabla--charlas {
  margin-bottom: 50px;
}

/* fin nosotras */
/* media queries */
@media (max-width: 768px) {
  .navbar-expand-md ul li a {
    text-align: center;
  }

  .tituloBienvenidos {
    margin-top: 30px;
  }

  .div--giftCard {
    border-top: 1px dotted #999;
    padding-top: 30px;
  }

  .p--testimonios {
    font-size: 1.4em;
  }

  .nombres--testimonios {
    font-size: 1rem;
  }

  .div--descuentos {
    border-right: 0;
  }

  .img--bienvenidos {
    margin-top: 15px;
  }

  .div--descuentos {
    padding-bottom: 30px;
  }

  .row--descuentos {
    width: 95%;
  }

  header h1 {
    padding-bottom: 15px;
    font-size: 25px;
    width: 95%;
  }

  .img--header {
    margin-left: auto;
    height: 150px;
    padding-top: 30px;
  }

  .caja--logoFormulaBustos {
    justify-content: center;
  }

  .row--envios div {
    margin-bottom: 10px;
  }

  .iconoFacebook {
    margin-right: 10px;
  }

  .button,
.button:before,
.button:after,
.button:hover,
.button:hover:before,
.button:hover:after {
    margin-bottom: 10px;
    font-size: 16px;
  }

  .div--newsletter p {
    margin-bottom: 3px;
  }

  .card--mobile {
    margin-bottom: 25px;
  }

  video {
    width: 320px;
  }

  .h3--productos {
    margin-left: 10px;
  }

  .formasPagoEnvio {
    font-size: 14px;
    font-weight: bold;
    margin-top: 30px;
    margin-bottom: 30px;
    padding-left: 5px;
    padding-right: 5px;
    text-align: center;
    background-color: #f5e5f0;
    width: 90%;
    line-height: 25px;
    border-radius: 5px;
  }

  .img--labo {
    margin-top: 10px;
  }

  .div--tituloProductos {
    display: flex;
    flex-direction: column;
    justify-content: center;
    text-align: center;
    flex-wrap: wrap;
    gap: 5px;
  }

  .row--productos {
    margin-bottom: 15px;
  }

  .div--velaSlim, .div--hifu {
    display: flex;
    flex-wrap: wrap;
    background-size: cover;
  }

  .img--vela {
    max-width: 90%;
    height: auto;
  }

  .card--vela {
    height: auto;
  }

  .tratamientos__titulos--cardVela {
    padding-top: 5%;
  }

  .tratamientos__titulos--cardVela ol {
    padding-bottom: 15%;
  }

  .row--tratamientos {
    margin-bottom: 10px;
  }

  .footer__div--marginBottom {
    margin-bottom: 25px;
  }

  .row--header {
    display: flex;
    flex-direction: row;
    align-items: center;
    flex-wrap: nowrap;
  }

  .h1--header {
    font-size: 1.5rem;
    padding-top: 20px;
    text-align: left;
  }

  .img--header {
    height: 120px;
    margin-left: 20px;
    padding-top: 15px;
    padding-bottom: 15px;
  }

  .div--newsletter {
    display: none;
  }

  .div--logoHeader {
    width: 50%;
  }

  .jumbotron {
    height: auto;
  }

  .h2--charlas {
    margin-left: 10px;
  }

  .tabla--charlas {
    width: 95%;
    margin-left: auto;
    margin-right: auto;
  }
}
/* fin media queries */

/*# sourceMappingURL=estilos_v3.cs.map */
