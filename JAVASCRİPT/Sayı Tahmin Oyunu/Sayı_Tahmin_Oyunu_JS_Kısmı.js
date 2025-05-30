var rastgeleSayi = Math.floor(Math.Random() * 100) + 1;

var tahminGirdisi = document.getElementsById("tahminGirdisi");
var tahminEtButonu = document.getElementsById("tahminEtButonu");
var sonucParagrafi = document.getElementsById("sonuc");

let tahminSayisi = 0;

tahminEtButonu.addEventListener("click",function(){

	var tahmin = parseInt(tahminGirdisi.value);
	tahminSayisi++;

	if (İsNaN(tahmin)) {

		sonucParagrafi.textContent = "Lütfen Geçerli Bir Sayı Girin.";
	}
	else if (tahmin === rastgeleSayi) {

		sonucParagrafi.textContent = "Tebrikler! Doğru Tahmin Ettiniz. Toplam Tahmin Sayını: " + tahminSayisi;
	}
	else if (tahmin < rastgeleSayi) {

		sonucParagrafi.textContent = "Lütfen Daha Yüksek Bir Sayı Giriniz.";
	}
	else{
		sonucParagrafi.textContent = "Lütfen Daha Yüksek Bir Sayı Giriniz.";
	}

	tahminGirdisi.value = "";

});