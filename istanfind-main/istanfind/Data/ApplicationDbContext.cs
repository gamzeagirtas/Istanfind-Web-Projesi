using istanfind.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace istanfind.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
         : base(options)
        {

        }
        public DbSet<FunPlace> FunPlace { get; set; }

        public DbSet<HistoricalPlace> HistoricalPlace { get; set; }
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<Park> Park { get; set; }
        public DbSet<Shop> Shop { get; set; }
        public DbSet<Restaurant> Restaurant { get; set; }
        public DbSet<Comment> Comment { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Hotel>().HasData(
                new Hotel()
                {
                    Id = 1,
                    Name = "Shangri-La",
                    PhoneNumber = "(0212) 275 88 88",
                    WebSiteUrl = " https://www.shangri-la.com/istanbul/shangrila/?WT.mc_id=SLIM_201703_GLOBAL_SEM_GOOGLE_SLIB-Brand_Brand-Exact_shangri%20la%20bosphorus_EN&ds_rl=1247823&gclid=Cj0KCQiA0MD_BRCTARIsADXoopYSfDeeXvYtgytSwRzWJA8MElXb6kEIDWM6vxuEAHFbwn_2gHXfP2AaAm1TEALw_wcB&gclsrc=aw.ds ",
                    Adress = "Sinanpaşa, Hayrettin İskelesi Sk. D:No.1, 34353 Beşiktaş/İstanbul ",
                    AdressUrl = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d12037.242823684175!2d29.005279!3d41.040334!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0x95a3c04d410592a1!2sShangri-La%20Bosphorus%20%C4%B0stanbul!5e0!3m2!1str!2str!4v1609093839148!5m2!1str!2str",
                    Score = 100,
                    DataText = "İstanbul seyahati yapan gezginler için Shangri-La Bosphorus, Istanbul harika bir seçim. Bütçeye uygunluğu, konforu ve elverişli konumuyla bu otel, aileler için uygun bir ortam ve tam da sizin gibi gezginler için düşünülmüş tesis olanakları sunuyor.Shangri-La Bosphorus, Istanbul konuklara düz ekran televizyon gibi birçok oda olanağı sunuyor. İnternete bağlanmak da ücretsiz wifi sayesinde mümkün.Konaklamanızı daha keyifli kılmak üzere otel, concierge ve oda servisi hizmeti veriyor. İşletmede ayrıca havuz ve oturma salonu mevcut. Aracıyla gelen konuklar otopark hizmetinden yararlanabilir.İstanbul'a seyahat eden gezginler, Shangri-La Bosphorus, Istanbul'da konaklayarak Istiklal Caddesi (2, 7 km) ve Galata Kulesi (3, 1 km) gibi yakınlardaki ünlü yerleri kolayca gezebilir.İstanbul'da birçok Akdeniz restoranı bulunuyor. Seyahatiniz sırasında Hatay Medeniyetler Sofrasi Taksim, Olive Anatolian Restaurant ve Roof Mezze 360 gibi gözde mekanlara uğrayıp lezzetli yemeklerden tatmayı ihmal etmeyin.Yapılacak şeyler arıyorsanız, turistlerin en beğendiği gezilecek yerlerden olan Dolmabahçe Palace'ye (0, 4 km), Taksim Meydanı'na (1, 7 km) veya Ortaköy'e (1, 8 km) uğrayabilirsiniz. Üstelik hepsi de yürüme mesafesinde.Shangri-La Bosphorus, Istanbul'da konaklarken, İstanbul'un sunduğu zengin deneyimlerin tadını doyasıya çıkaracağınızı umuyoruz. ",
                    TitleText = "İstanbul seyahati yapan gezginler için Shangri-La Bosphorus, Istanbul harika bir seçim.",
                    ImageUrl = "\\images\\hotel\\ShangriLa.jpg",
                },
                 new Hotel()
                 {
                     Id = 2,
                     Name = "Hilton İstanbul Bomonti Hotel & Conference Center",
                     PhoneNumber = "(0212) 375 30 00",
                     WebSiteUrl = " https://www.hilton.com.tr/oteller/turkiye/istanbul/hilton-istanbul-bomonti-hotel-and-conference-center ",
                     Adress = "Adres: Merkez, Silahşör Cd. No:42, 34381 Şişli/İstanbul",
                     AdressUrl = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d12033.928330606763!2d28.9793553!3d41.0584538!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0x99466dd22ca806de!2sHilton%20%C4%B0stanbul%20Bomonti%20Hotel%20%26%20Conference%20Center!5e0!3m2!1str!2str!4v1609602756099!5m2!1str!2str",
                     Score = 100,
                     DataText = "İstanbul’un iş, tarih ve eğlence merkezlerine oldukça yakın mesafede bulunan Hilton Istanbul Bomonti, etkileyici mimarisi ve harika manzarası ile misafirlerine iş veya tatil amaçlı konaklamalarında kusursuz bir deneyim sunuyor.Bu ön cephesi cam, çok katlı lüks otel, şehrin simgelerinden Galata Kulesi'ne 5 km, ünlü Sultanahmet Camii'ne 11 km uzaklıktadır.Samimi atmosfere sahip odalarda deniz veya şehir manzarası sunan boydan boya pencereler, düz ekran televizyon, mini bar ve ücretsiz kablosuz internet bulunur. Süitlerde ek olarak salon, espresso makinesi ve ücretsiz kahvaltı, atıştırmalık ile içecek sunan kulüp salonuna erişim imkanı vardır. Bazı süitler mutfak ve/veya saunaya sahiptir. Oda servisi mevcuttur.İmkanlar arasında zarif bir restoran, 34. katta bulunan kokteyl/suşi barı ve şık dinlenme salonu yer alır. Ayrıca içinde barı bulunan bir açık havuz ile kapalı havuz, hamam ve spor salonu bulunan, 3 katlı lüks bir spa vardır.",
                     TitleText = "İstanbul’un iş, tarih ve eğlence merkezlerine oldukça yakın mesafede bulunan Hilton Istanbul Bomonti, etkileyici mimarisi ve harika manzarası ile misafirlerine iş veya tatil amaçlı konaklamalarında kusursuz bir deneyim sunuyor.",
                     ImageUrl = "\\images\\hotel\\hilton.jpg",
                 },
                 new Hotel()
                 {
                     Id = 3,
                     Name = "Swissotel The Bosphorus",
                     PhoneNumber = "Telefon: (0212) 326 11 00",
                     WebSiteUrl = " https://www.swissotel.com.tr/hotels/istanbul/",
                     Adress = "Vişnezade Mah. Acısu Sok. No:19, İstanbul 34357 Türkiye",
                     AdressUrl = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d12037.139930401927!2d28.9976543!3d41.0408966!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0x92ada1dd6c7d611e!2sHotel%20Swiss%C3%B4tel%20The%20Bosphorus%20-%20Istanbul!5e0!3m2!1str!2str!4v1609603376370!5m2!1str!2str",
                     Score = 100,
                     DataText = "016 – 2020 Safe Hotels Executive Sertifikasına sahip Swissotel The Bosphorus, İstanbul şehrin merkezinde, Boğaz'ın Avrupa kıyılarında yer alan, beş yıldızlı lüks bir oteldir. Alışveriş ve canlı gece hayatına 5 dakika yürüme mesafesinde, Dolmabahçe Saray’ının tarihi bahçesinde 65 dönümlük bir Alana konumlandırılmıştır. Otel, son teknoloji ürünü ve özel olanaklara sahip 566 oda ve süit sunmaktadır.Etkinlik odaları ve balo salonu da dahil olmak üzere 5 ila 1200 kişi kapasiteli çeşitli toplantı alanlarının yanı sıra, etkinlik planlamacılarından oluşan bir ekip, Swissotel The Bosphorus, İstanbul'da mükemmel bir düğün düzenlemenize yardımcı olmak için hazır.Swissotel The Bosphorus, İstanbul, Swissotel Living sayesinde size özel, yeni bir yaşam tarzı sunuyor: stüdyodan bir ila üç yatak odalı, nihai tarzı ve lüksü sunmak için çeşitli boyutlarda tasarlanmış 63 zarif süit tam kapsamlı otel hizmetleri ve yalnız kendi konuklarının kullanabildiği terasındaki özel havuzuyla benzersiz bir deneyim fırsatı.",
                     TitleText = "Swissotel The Bosphorus, İstanbul şehrin merkezinde, Boğaz'ın Avrupa kıyılarında yer alan, beş yıldızlı lüks bir oteldir.",
                     ImageUrl = "\\images\\hotel\\swissotel.jpg",
                 },
                 new Hotel()
                 {
                     Id = 4,
                     Name = "Radisson Blu Hotel Istanbul Ottomare",
                     PhoneNumber = "(0212) 939 45 00",
                     WebSiteUrl = "https://www.radissonhotels.com/tr-tr/oteller/radisson-blu-istanbul-ottomare",
                     Adress = "Kazlıçeşme Mh., Abay Caddesi No:223 Zeytinburnu, İstanbul 34020 Türkiye",
                     AdressUrl = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d12048.036065853474!2d28.8973411!3d40.9812834!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0x7e63dfd8e88c54ce!2sRadisson%20Blu%20Hotel%20Istanbul%20Ottomare!5e0!3m2!1str!2str!4v1609603856951!5m2!1str!2str",
                     Score = 100,
                     DataText = "Radisson Blu Hotel İstanbul Ottomare’de ücretsiz kablosuz internet, oda içi kahve ve çay servisine sahip iş veya tatil amaçlı seyahat edenler için 133 oda bulunmaktadır.Konferans salonumuzu ayırtın veya Özel Yemek Salonu’nda parti düzenleyin. Sahildeki bu mükemmel konum, hem iş hem de sosyal toplantılar için benzersiz bir ortam sunuyor. Dört toplantı odamız yaklaşık 250 metre kare üzerine kurulmuş olup en son teknoloji ses-görüntü ekipmanları ve özel yemek servisi sunuyor. İş toplantılarından düğünlere kadar etkinliğinizin sorunsuz bir biçimde geçmesine yardımcı olmaları için kendisini işine adamış ekibimize güvenin.",
                     TitleText = "Radisson Blu Hotel İstanbul Ottomare, Marmara Denizi kıyılarındaki muhteşem konumuyla, bu çok özel bölgede geçirdiğiniz zaman sırasında güzel manzaralı bir konaklama olanağı sunar. İstanbul’un Tarihi Yerlerine yakın bir konumda yer alan Ottomare oteli sizi canlı Zeytinburnu bölgesine davet ediyor.",
                     ImageUrl = "\\images\\hotel\\radisson.jpg",
                 },
                 new Hotel()
                 {
                     Id = 5,
                     Name = "White House Hotel Istanbul",
                     PhoneNumber = "(0212) 526 00 19",
                     WebSiteUrl = " https://www.istanbulwhitehouse.com/ ",
                     Adress = "Alemdar Mahallesi Çatalçeşme Sok. No:21, İstanbul 34122 Türkiye",
                     AdressUrl = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d12042.921185641386!2d28.9756024!3d41.009276!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0xf9dae4ce49263f6!2sWhite%20House%20Hotel%20Istanbul!5e0!3m2!1str!2str!4v1609604028319!5m2!1str!2str",
                     Score = 100,
                     DataText = "White House Hotel İstanbul tarihi yarımadanın kalbinde yer almakta olup Ayasofya, Sultanahmet Camii, Topkapı Sarayı, Arkeoloji Müzesi, Yerebatan Sarnıcı, Kapalıçarşı, Mısır Çarşısı, Milenyum Taşı ve Bizans Hipodromu'na yürüme mesafesindedir. şehrin en önemli simgeleridir.White House Hotel İstanbul, bu Osmanlı başkentinin sonsuz tarihi mekanlarını, müzelerini, restoranlarını, kulüplerini ve mağazalarını keşfetmek için ideal bir başlangıç ​​noktasıdır.Otelin mimarisi, doğu ve batı medeniyetleri ile otantik kültürel özellikleri birleştiriyor.Otelin cephesi ağırlıklı olarak Roma mimari konseptine uygun olarak tasarlanmıştır.İç tasarım, Osmanlı mimarisini andıran, ihtişamlı olmayan klasik bir konsepttir. Otelin mimarisi Doğu ve Batı sentezini harmanlamaktadır.White House Hotels'in profesyonel ve özenli personeli de İstanbul'da kaldığınız süre boyunca size destek olacaktır.Bu büyüleyici ve zarif otel, eski İstanbul'u modern ve lüks bir atmosferde yaşamak isteyenler için ideal bir destinasyondur. White House Hotel, İstanbul'da kaldığınız süre boyunca sizlere sıcak bir misafirperverlikle konaklama imkanı sunmakta ve sizi İstanbul'un en lüks otellerinden birinde ağırlamaktadır.",
                     TitleText = "White House Hotel İstanbul tarihi yarımadanın kalbinde yer almakta olup Ayasofya, Sultanahmet Camii, Topkapı Sarayı, Arkeoloji Müzesi, Yerebatan Sarnıcı, Kapalıçarşı, Mısır Çarşısı, Milenyum Taşı ve Bizans Hipodromu'na yürüme mesafesindedir. şehrin en önemli simgeleridir.",
                     ImageUrl = "\\images\\hotel\\whitehouse.jpg",
                 }
                

               );
            builder.Entity<Restaurant>().HasData(

                 new Restaurant()
                 {
                     Id = 1,
                     Name = "Nusr-Et Steakhouse",
                     PhoneNumber = "(0212) 358 30 22",
                     WebSiteUrl = " https://www.nusr-et.com.tr/tr/ana-sayfa.aspx ",
                     Adress = "Etiler, Nispetiye Cd No:87, 34337 Beşiktaş/İstanbul",
                     AdressUrl = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d12029.89154060719!2d29.0334347!3d41.0805134!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0xc36794433940ac13!2sNusr-Et%20Steakhouse!5e0!3m2!1str!2str!4v1609605590048!5m2!1str!2str",
                     Score = 100,
                     DataText = "2010 yIlInda kapIlarInI açan Nusr-Et Steakhouse; lezzetlİ etlerİ,benzersİz servİsİ ve butİk konseptİyle sektörün lİderlİğİnİ sürdürüyor.Et severler İçİn pek çok özgün seçenek yaratan,kIsa süre İçİnde steakhouse kültürüne keyİflİ ve lezzetlİyenİ bİr yorum getİren Nusr-Et, et müdavİmlerİnİn vazgeçİlmezmekanI olarak hİzmet verİyor.AçIldIğI İlk günden bu yana et meraklIlarInIn İlk ve tek adresİhalİne gelen Nusr-Et Steakhouse;sunduğu zengİn lezzetler, sIcak ortamI ve servİsİyle fark yaratIyor.",
                     TitleText = "Nusr-Et’İn alIşIlagelmİş et ve hİzmet kalİtesİnİ burger konseptİnetaşIyan Nusr-Et Burger İse, lezzetten ödün vermeyenlerİ,Bebek, NİşantaşI, Kanyon ve İstİnyePark şubelerİnde ağIrlIyor.",
                     ImageUrl = "\\images\\restaurant\\nusret.jpg",
                 },
                 new Restaurant()
                 {
                     Id = 2,
                     Name = "F&B Culture",
                     PhoneNumber = "+90 532 275 69 94",
                     WebSiteUrl = " https://www.quandoo.com.tr/en/place/fb-culture-56081 ",
                     Adress = "Bereketzade Mah. Camekan Sokak No: 6 Beyoğlu, İstanbul 34343 Türkiye",
                     AdressUrl = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d12040.016682374395!2d28.9743161!3d41.0251647!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0x989161ac88d7473e!2sF%26B%20Culture!5e0!3m2!1str!2str!4v1609606021578!5m2!1str!2str",
                     Score = 100,
                     DataText = "İçeriye girdiğiniz andan itibaren kulaklarınıza seçkin müzik listesinin tınıları doluyor. İsterseniz ön tarafta sokağı izleyebilir, isterseniz arka tarafta kış bahçesi formunda bulunan masalarda oturabilirsiniz.Özellikle akşam konseptinin gerçekten çok hoş olduğunu söyleyebilirim. Benim bu tarz şık mekanlarda dikkat ettiğim ilk özellik kasıntı olmaması oluyor. Çünkü rahat olamamak ve mercek altında hissetmek gerçekten çok rahatsız edici bir durum. Birçok kez ayak bastığım bu mekanda en sevdiğim özellik de bu oldu. Konseptine ve şıklığına kıyasla aynı zamanda çok da rahat ve huzurlu bir mekan.Menü oldukça geniş, herkes damak tadına uygun bir tat bulabilir; farklı olarak da restoranın kendine öz tatlarını deneyebilirisiniz. Geniş kahvaltısı, kendilerine has tarifleriyle yaptıkları ekmekleri ve 4 peynirli pizzası gerçekten çok lezzetli.",
                     TitleText = "Hem Galata Kulesi’ne yakın olmak hem de Karaköy’ün deniz manzaralı sokaklarında olmak isteyenler için biçilmiş kaftan F&B Culture. Galata Kulesi’nin kapısının karşısına bakan sokakta beş dakikadan az bir süre içerisinde ulaşabileceğiniz bu restoran, kendisini şık mimarisinin arkasına gizlemiş durumda.",
                     ImageUrl = "\\images\\restaurant\\fbculture.jpg",
                 },
                 new Restaurant()
                 {
                     Id = 3,
                     Name = "Hatay Medeniyetler Sofrası",
                     PhoneNumber = "(0212) 358 30 22",
                     WebSiteUrl = " https://www.hataymedeniyetlersofrasi.com.tr/tr/hakkimizda ",
                     Adress = "Horhor Caddesi No: 49 Aksaray / İSTANBUL, İstanbul 34096 Türkiye",
                     AdressUrl = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3010.624103222342!2d28.947811315083385!3d41.01159997930033!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14caba2880147eab%3A0x20cdbf0cfe0c4548!2sHatay%20Medeniyetler%20Sofras%C4%B1!5e0!3m2!1str!2str!4v1609606551685!5m2!1str!2str",
                     Score = 100,
                     DataText = "Bir yandan Amanos dağlarından gelen kekik kokulu serin rüzgarlar ve efsanelerin ırmağı Asi'nin sularıyla bereket fışkıran Amik Ovasının kucakladığı Hatay toprakları... Diğer yandan dinlerin ve mezheplerin hoşgörüsünün en sağlam bağlarla yaşandığı Hatay toprakları...Bu müstesna ve zengin birikimiyle göz kamaştıran Hatay mutfağından siz değerli misafirlerimize sunabilmek üzere yıllar öncesinden var olan deneyimlerimizden güç alarak o yöreden özenle seçilen elemanlarıyla yola çıkmayı amaç edindik... 2004 yılında sayın başbakanımızın Hatay'da yapmış olduğu konuşmasından da esinlenerek soframızın adını,Hatay Medeniyetler Sofrası olarak tescil ettirdik.%90'ını o yöreden temin etmekte olduğumuz ürünlerden oluşturulan zengin içerikli soframızı sizlere en ayrıcalıklı biçimde sunabildiğimiz için onurluyuz... Mutluyuz...",
                     TitleText = "Bir yandan Amanos dağlarından gelen kekik kokulu serin rüzgarlar ve efsanelerin ırmağı Asi'nin sularıyla bereket fışkıran Amik Ovasının kucakladığı Hatay toprakları... Diğer yandan dinlerin ve mezheplerin hoşgörüsünün en sağlam bağlarla yaşandığı Hatay toprakları...",
                     ImageUrl = "\\images\\restaurant\\hataymedeniyetlersofrasi.jpg",
                 },
                 new Restaurant()
                 {
                     Id = 4,
                     Name = "Midpoint",
                     PhoneNumber = "(0212) 245 70 40",
                     WebSiteUrl = "https://www.midpoint.com.tr/tr/index.html",
                     Adress = "İstiklal Cad. No:187 Beyoğlu Merkez, İstanbul Türkiye",
                     AdressUrl = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3009.7080006695346!2d28.97398731541473!3d41.03164387929838!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14cab9e008f5aeed%3A0x847914abee075d94!2sMidpoint%20Beyo%C4%9Flu!5e0!3m2!1str!2str!4v1609606873279!5m2!1str!2str",
                     Score = 100,
                     DataText = "Alışveriş arası yorgunlukların atıldığı, iş toplantılarının keyifli sohbetlere dönüştüğü, Pazar kahvaltılarının ev sıcaklığında yapıldığı Midpoint restoranları bugün; İstanbul, Ankara, İzmir, İzmit, Bursa, Antalya ve Mersin olmak üzere 7 farklı şehirde toplam 34 buluşma noktasında misafirlerine keyifli bir yemek ve sohbet imkanı sunuyor.Alışveriş arası yorgunlukların atıldığı, iş toplantılarının keyifli sohbetlere dönüştüğü, Pazar kahvaltılarının ev sıcaklığında yapıldığı Midpoint restoranları bugün; İstanbul, Ankara, İzmir, İzmit, Bursa, Antalya ve Mersin olmak üzere 7 farklı şehirde toplam 34 buluşma noktasında misafirlerine keyifli bir yemek ve sohbet imkanı sunuyor.Usta ellerden çıkan özel tatları kendi yorumuyla sunarak, sadece damaklara değil, gözlere de hitap eden Midpoint, aynı zamanda zengin şarap seçenekleri, farklı kokteylleri, en iyi yerli ve yabancı marka içkilerden derlediği menüsü ile de dikkat çekiyor. Huzurlu ve keyifli bir atmosferde vakit geçirmek isteyenlerin müdavimi haline geldiği Midpoint, farklı bir soluk getirdiği hizmet anlayışını, sohbetlerinizi düşünerek seçtiği kaliteli ve neşeli müziklerle süsleyerek zamanınızı dolu dolu yaşatmaya ve herkesin buluşma noktası olmaya devam ediyor.Sağlıklı yaşamı desteklemek için hazırladığımız hafif yemeklerimizi, çeşitli kahvaltı alternatiflerimizi, lezzetli yemeklerimizi ve küçük misafirlerimizi mutlu edecek bol çeşitli çocuk menümüzü beğeneceğinizi umuyor, en güzel buluşmaları yaşamanızı ve en unutulmaz anıları biriktirmeniz için sizleri restoranlarımıza bekliyoruz.",
                     TitleText = "Herkesin Buluşma Noktası,sloganıyla yola çıkan ve ilk şubesini 2002 yılında, Anadolu Yakası’nın kalbi olan Bağdat Caddesi'nde hizmetinize sunan Midpoint, dünya mutfaklarından seçilmiş lezzetleri, farklı tatlara uyarladığı menüsü, profesyonel hizmet ve uygun fiyat anlayışı, hızlı servis kalitesi, sıcak atmosferi ve modern mimarisi ile müşteri memnuniyetini esas alarak yola devam ediyor.",
                     ImageUrl = "\\images\\restaurant\\midpoint.jpeg",
                 },
                 new Restaurant()
                 {
                     Id = 5,
                     Name = "360 İstanbul",
                     PhoneNumber = "+90 212 251 10 42",
                     WebSiteUrl = "http://www.360istanbul.com/tr/index.html",
                     Adress = "İstiklal Caddesi No: 163/8 Beyoğlu, Misir Apt., İstanbul 34330 Türkiye",
                     AdressUrl = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d12038.646800476274!2d28.976666!3d41.0326567!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0xafdbcda2f5aafc90!2s360%20%C4%B0stanbul!5e0!3m2!1str!2str!4v1609607182791!5m2!1str!2str",
                     Score = 100,
                     DataText = "Bir çok uluslararası ödüle sahip 360istanbul, tarihi ve kadim Mısır Apartmanı'nın en üst katında yer alıyor. 360 derece nefes kesen İstanbul manzarası eşliğinde, seçkin şarap ve zengin bar mönüsü ile Dünya ve modern Türk mutfağından öğle ve akşam yemeği servis ediyor. Yurtdışından ünlü sanatçılar ve DJ’ler konuk eden 360 İstanbul, canlı show’ları ile haftasonları Club’a dönüşüyor.Bu konsept 4 temel elemetten oluşur; Yemek - Atmosfer - Eğlence ve Ambiyans. 360istanbul'daki hiçbir element diğerinden daha değerli yada daha değersiz değildir. Hepsi birbiriyle uyum içindedir.Hakkımızda360 Entertainment Group’un bilgili ve tecrübeli profesyonel ekibi tarafından geliştirilen 360 İstanbul konseptinin temelini YEMEK, EĞLENCE, AMBİYANS ve ATMOSFER faktörleri oluşturmaktadır. Her faktörün aynı derecede önem taşıması ve birbirini tamamlaması konsepti bir bütün haline getirerek müşteri memnuniyetini en üst düzeye çıkarabilmemizi sağlar.",
                     TitleText = "Bir çok uluslararası ödüle sahip 360istanbul, tarihi ve kadim Mısır Apartmanı'nın en üst katında yer alıyor. 360 derece nefes kesen İstanbul manzarası eşliğinde, seçkin şarap ve zengin bar mönüsü ile Dünya ve modern Türk mutfağından öğle ve akşam yemeği servis ediyor.",
                     ImageUrl = "\\images\\restaurant\\360istanbul.jpg",
                 }

               );

            builder.Entity<Park>().HasData(
            new Park()
            {
                Id = 1,
                Name = "Gülhane Parkı",
                PhoneNumber = "(0212) 455 13 00",
                WebSiteUrl = "http://www.360istanbul.com/tr/index.html",
                Adress = "Adres: Cankurtaran, Kennedy Cd., 34122 Fatih/İstanbul",
                AdressUrl = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3010.552154338979!2d28.979206415414257!3d41.013174479300304!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14cab9c735bcda2b%3A0x65e6a6edfa646cb!2zR8O8bGhhbmUgUGFya8Sx!5e0!3m2!1str!2str!4v1609607502739!5m2!1str!2str",
                Score = 100,
                DataText = "Gülhane Parkı, Osmanlı İmparatorluğu döneminde Topkapı Sarayı'nın dış bahçesiydi ve içinde bir koru ve gül bahçelerini barındırırdı. Türk tarihinde demokratikleşmenin ilk somut adımı olan Tanzimat Fermanı, 3 Kasım 1839'da Abdülmecit döneminde Hariciye Nazırı Mustafa Reşit Paşa tarafından Gülhane Parkı'nda okunmuştur ve bu nedenle Gülhane Hatt-ı Hümayunu da denir.İstanbul şehremini operatör Cemil Paşa (Topuzlu) zamanında düzenlenerek 1912 yılında park haline getirildi ve halka açıldı. Toplam alanı 163 dönüm kadardır. Parkın girişinde sağ tarafta İstanbul şehremini ve belediye başkanlarının büstleri vardır. Parkın ortasından iki yanı ağaçlı yol geçer. Bu yolun sağında ve solunda dinlenme yerleri, çocuk bahçesi bulunmaktadır. Boğaza doğru kıvrılarak inen yokuşun hemen sağında bir Aşık Veysel heykeli, yokuşun sonuna doğru biraz üst kısımda ise Romalılardan kalma Gotlar Sütunu vardır.",
                TitleText = "Gülhane Parkı, İstanbul'un Fatih ilçesinin Eminönü semtinde yer alan tarihî bir parktır. Alay Köşkü, Topkapı Sarayı ve Sarayburnu arasında yer alır.",
                ImageUrl = "\\images\\park\\gulhane.jfif",
            },
            new Park()
            {
                Id = 2,
                Name = "Yıldız Parkı",
                PhoneNumber = "0212 258 90 20",
                WebSiteUrl = "https://www.tripadvisor.com.tr/Attraction_Review-g293974-d524126-Reviews-Yildiz_Park-Istanbul.html",
                Adress = "Yıldız, 34349 Beşiktaş/İstanbul",
                AdressUrl = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3008.90790197154!2d29.013074415415346!3d41.049143079296634!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14cab7ba74cafa3d%3A0x8d3f0c3423ee17e6!2zWcSxbGTEsXogUGFya8Sx!5e0!3m2!1str!2str!4v1609607693079!5m2!1str!2str",
                Score = 100,
                DataText = "Beşiktaş semtinin sırtlarında Yıldız Sarayı’nın alt tarafında Boğaz’a hakim bir konumda yer alan Yıldız Parkı ve Korusu, İstanbul’un en etkileyici, huzurlu ve sık ziyaret edilen parkları arasında başta geliyor. Malta ve Çadır Köşkleri ile kahvaltı ve yeme içme imkanı sunuyor. İstanbul’un en güzel parklarından biri olan parkta, birbirinden güzel havuzlar, şelaleler ve göletlerin yanı sıra büyüleyici bahçeler ve ağaçlardan oluşuyor.Yıldız Parkı’nda Osmanlı döneminden kalma ve dünyanın her yerinden toplanmış çok çeşitli çiçek, bitki ve ağaçlar ile birlikte güzel bahçeler, asma köprüler, şelaleler, göletler ve tarihi köşkler bulunuyor. Parkın bitki örtüsü olarak manolya, defne yaprağı, erguvanlar, gümüş misket limonu, at kestanesi, meşe, selvi, çam, porsuk, sedir ve dişbudak ağaçları yoğunlukta.Parkın içerisinde ayrıca iki adet suni göl var. Park alanları da boğaz manzaralı.Yıldız Parkı, özellikle hafta sonları için popüler bir kahvaltı, yeme içme ve dinlenme yeri. Park içerisinde aynı zamanda kahvaltı ve yeme içme hizmeti de sunan Çadır Köşkü ve Malta Köşkü adıyla iki adet tarihi köşk bulunuyor. 1871 tarihinde Sultan Abdülaziz tarafından inşa ettirilmiş.",
                TitleText = "Beşiktaş semtinin sırtlarında Yıldız Sarayı’nın alt tarafında Boğaz’a hakim bir konumda yer alan Yıldız Parkı ve Korusu, İstanbul’un en etkileyici, huzurlu ve sık ziyaret edilen parkları arasında başta geliyor. Malta ve Çadır Köşkleri ile kahvaltı ve yeme içme imkanı sunuyor. İstanbul’un en güzel parklarından biri olan parkta, birbirinden güzel havuzlar, şelaleler ve göletlerin yanı sıra büyüleyici bahçeler ve ağaçlardan oluşuyor.",
                ImageUrl = "\\images\\park\\yildizparki.jpg",
            },
            new Park()
            {
                Id = 3,
                Name = "Fethi Paşa Korusu",
                PhoneNumber = "0216 444 10 34",
                WebSiteUrl = "https://tesislerimiz.ibb.istanbul/fethipasa-sosyal-tesisi/",
                Adress = "Kuzguncuk Mah. Paşa Limanı Cad. Nacak Sokak No:6, Üsküdar, İstanbul",
                AdressUrl = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3009.6835618369296!2d29.024734815414863!3d41.03217847929842!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14cab7ec0b2cab8f%3A0x30ecd38f5422f88c!2zRmV0aGkgUGHFn2EgS29ydXN1LCDDnHNrw7xkYXIvxLBzdGFuYnVs!5e0!3m2!1str!2str!4v1609608179828!5m2!1str!2str",
                Score = 100,
                DataText = "Üsküdar ile Beylerbeyi arasında bir konumda, İstanbul Boğazı’na hakim bir tepede oldukça etkileyici ve güzel bir alanda yer alan Fethi Paşa Korusu, aynı zamanda İstanbul’un en güzel koru ve parklarından birisi.Sultantepe sırtlarından başlayarak Kuzguncuk‘a kadar bir alanı kapsayan ve karşısında Sarayburnu‘ndan başlayıp Ortaköy‘e kadar uzanan eşsiz Boğaz manzarasına sahip Fethi Paşa Korusu, özellikle hafta sonu manzaralı bir yerde güzel bir kahvaltı, yeme içme ve dinlence keyfi sürmek isteyenler için çok ideal.İstanbul’un en güzel ve en iyi Boğaz manzaralarından birisine sahip bir konumda olan Fethi Paşa Korusu, yaklaşık 16 hektar yeşil alan üzerine kurulu.Fethi Paşa Korusu’nda İstanbul Belediyesi tarafından işletilen Fethi Paşa Sosyal Tesisleri isimli restoran ve kafeterya ile birlikte yüzlerce bitki ve ağaç türlerini barındıran koru, yeşil alanlar, yürüyüş ve gezi parkurları bulunuyor.",
                TitleText = "Üsküdar ile Beylerbeyi arasında bir konumda, İstanbul Boğazı’na hakim bir tepede oldukça etkileyici ve güzel bir alanda yer alan Fethi Paşa Korusu, aynı zamanda İstanbul’un en güzel koru ve parklarından birisi.",
                ImageUrl = "\\images\\park\\fethipasa.jpg",
            },
            new Park()
            {
                Id = 4,
                Name = "Emirgan Korusu",
                PhoneNumber = "(0212) 455 13 00",
                WebSiteUrl = "https://www.tripadvisor.com.tr/Attraction_Review-g293974-d1553374-Reviews-Emirgan_Park-Istanbul.html ",
                Adress = "Reşitpaşa, Emirgan Sk., 34467 Sarıyer/İstanbul",
                AdressUrl = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d12024.689407861177!2d29.044511137355887!3d41.10892681864937!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14caca7152beb381%3A0x163da0c8ff4d15bb!2sEmirg%C3%A2n%20Korusu!5e0!3m2!1str!2str!4v1609608597631!5m2!1str!2str",
                Score = 100,
                DataText = "İstanbul Avrupa yakasında Boğazı kıyısındaki şirin Emirgan semtinde denize nazır bir konumda yer alan Emirgan Parkı ve Korusu, İstanbul’un en güzel ve sık ziyaret edilen parkları arasında başta geliyor. Boğaza nazır huzurlu bir ortamda yeşillikler içerisindeki koru, özellikle hafta sonu kahvaltı, yeme içme ve dinlence için ideal yerler arasında.Yaklaşık 325,000 metrekarelik bir alanda kurulu Emirgan Parkı ve Korusunda;Çeşitli çam, şemsiye çamı, selvi, köknar, söğüt ve ıhlamur ağaçları,Güzel bir göl Boğaz’ın güzel manzarasına sahip teraslar, Koşu ve yürüyüş parkurları, Çocuk oyun alanları,  Mükemmel fotoğraf çekme noktaları, 19’uncu yüzyıldan kalma tarihi köşklerde üç restoran ve kafe bulunuyor.Emirgan Korusu’nun kafelerinde hafta içi harika bir kahvaltı veya hafta sonları açık büfe kahvaltı yapabilirsiniz.",
                TitleText = "İstanbul Avrupa yakasında Boğazı kıyısındaki şirin Emirgan semtinde denize nazır bir konumda yer alan Emirgan Parkı ve Korusu, İstanbul’un en güzel ve sık ziyaret edilen parkları arasında başta geliyor. Boğaza nazır huzurlu bir ortamda yeşillikler içerisindeki koru, özellikle hafta sonu kahvaltı, yeme içme ve dinlence için ideal yerler arasında.",
                ImageUrl = "\\images\\park\\emirgankorusu.png",
            },
           new Park()
           {
               Id = 5,
               Name = "Mihrabat Korusu",
               PhoneNumber = "0216 425 8616",
               WebSiteUrl = " https://istanbeautiful.com/tr/mihrabat-korusu/",
               Adress = "Kanlıca, Mihrabat cad, Mihrabat Korusu No:50, 34810 Beykoz",
               AdressUrl = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d12027.50489038964!2d29.068236000000002!3d41.093551!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0x5589bc01ffd47abf!2sOta%C4%9Ftepe%20Fatih%20Korusu!5e0!3m2!1sen!2sus!4v1609608794250!5m2!1sen!2sus",
               Score = 100,
               DataText = "Anadolu yakası boğaz kıyısında Beykoz ilçesinin Kanlıca semti sırtlarında bulunan Mihrabat Korusu, aynı zamanda İstanbul’un en güzel koru ve parklarından birisi konumunda misafirlerini ağırlıyor. Koru aynı zamanda Türkiye’nin önemli yazarlarından Yahya Kemal Beyatlı’nın “Sana dün bir tepeden baktım aziz İstanbul” mısrasının geçtiği mekan.Koru, Osmanlı’nın son dönemlerinde Mısır’lı Abbas Halim Paşa’nın kızı Rukiye Hanıma yüz görümlüğü olarak hediye edilmiş bir yer. Döneminde padişahların ve sultanların ağırlandığı bir mekan olmuş.Mihrabat Korusu, 25 hektarlık bir alanda kurulu. İçerisinde güzel bahçeler ve yürüyüş parkurları bulunuyor. Ayrıca Boğaz manzarası da muhteşem. Yeşillikler içinde içeceğinizi yudumlamak ayrı bir zevk olacak.Hemen solunuzda Boğazın en şirin koylarından birisi, sağınızda Fatih Sultan Mehmet Köprüsü ve tam karşınızda da Ortaköy sahili, Rumeli Hisarı ve İstinye Koyu’nu izlemek büyük keyif.Mihrabat Korusu’nun içerisinde ayrıca Aadan Lounge isimli şirin bir kafe ve Mihrabat Restaurant isimli güzel restoran bulunuyor.Başta düğün ve nişan yemekleri olmak üzere her türlü sosyal organizasyon ve yeme içme aktiviteleri için ideal bir mekan.",
               TitleText = "Anadolu yakası boğaz kıyısında Beykoz ilçesinin Kanlıca semti sırtlarında bulunan Mihrabat Korusu, aynı zamanda İstanbul’un en güzel koru ve parklarından birisi konumunda misafirlerini ağırlıyor. Koru aynı zamanda Türkiye’nin önemli yazarlarından Yahya Kemal Beyatlı’nın “Sana dün bir tepeden baktım aziz İstanbul” mısrasının geçtiği mekan.",
               ImageUrl = "\\images\\park\\mihrabat.jpg",
           }

         );
            builder.Entity<Shop>().HasData(
            new Shop()
            {
                Id = 1,
                Name = "Kapalı Çarşı",
                PhoneNumber = "0212 519 12 48",
                WebSiteUrl = "https://istanbeautiful.com/tr/kapalicarsi-istanbul/",
                Adress = "Kalpakçılar Cad., Kapalıçarşı, Beyazıt, Fatih",
                AdressUrl = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d48170.654760315534!2d28.933049179101562!3d41.010684800000014!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14cab99162d70527%3A0x64c8680b5ac198ab!2zS2FwYWzEsSDDh2FyxZ_EsQ!5e0!3m2!1str!2str!4v1609613499868!5m2!1str!2str",
                Score = 100,
                DataText = "Kapalıçarşı, 550 yılı aşkın mazisi ile beraber İstanbul tarihi yarımadanın en gözde yerlerinden birisi konumunda. Dünya’nın en eski ve en büyük kapalı çarşılarından birisi. Labirent şeklinde sokakları ve geçitleriyle birlikte dört binden fazla mağaza ve dükkanı barından Kapalıçarşı, özellikle turistlerin en çok rağbet ettiği ve ziyaret ettiği yerler arasında ilk sıralarda geliyor.Toplam 47.000 m2’lik bir alanı kaplayan İstanbul Kapalıçarşı, 64 sokak, 4.000 adet mağaza, 22 giriş kapısı ve 25.000 çalışanıyla birlikte bir dizi kapalı labirent cadde, geçit ve koridorlardan oluşuyor.Kapalıçarşı’da geleneksel desenlerde en iyi ipeksi şal ve eşarplar, antikalar, deri ürünleri, seramik, halı, kilim, baharat, lokum ve kahve çeşitlerinden el sanatları, altın ve mücevherata kadar hemen hemen her şeyi bulabilirsiniz.Kapalıçarşı aynı zamanda Türkiye’deki altın ve döviz borsasının da bir nevi kalbi konumunda. Kuyumcu dükkanları en çok ilgiyi çeken yerler arasında başta geliyor. Kapalıçarşı sadece alışveriş yapmak için değil, hareketli sokaklarında yürürken, aynı zamanda rengarenk dükkanların ve baharatların büyüleyici kokuları arasında güzel bir gün geçirebileceğiniz harika bir tarihi yer.Türk lokumu ve Türk kahvesinin cazip kokusu sizleri cezbedecek. Kapalıçarşı’da ayrıca kömür ateşinde pişirilmiş en iyi Türk kahvesini bulabileceğiniz tarihi bir kahve evi de bulunuyor. Ayrıca geleneksel Türk yemekleri sunan bir de restoran var.",
                TitleText = "Kapalıçarşı, 550 yılı aşkın mazisi ile beraber İstanbul tarihi yarımadanın en gözde yerlerinden birisi konumunda. Dünya’nın en eski ve en büyük kapalı çarşılarından birisi. Labirent şeklinde sokakları ve geçitleriyle birlikte dört binden fazla mağaza ve dükkanı barından Kapalıçarşı, özellikle turistlerin en çok rağbet ettiği ve ziyaret ettiği yerler arasında ilk sıralarda geliyor.",
                ImageUrl = "\\images\\shop\\kapalicarsi.jpg",
            },
            new Shop()
            {
                Id = 2,
                Name = "Kanyon",
                PhoneNumber = "+90 532 290 56 96",
                WebSiteUrl = "https://www.kanyon.com.tr/",
                Adress = "Levent, Büyükdere Cd. No:185, 34394 Şişli/İstanbul",
                AdressUrl = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3007.5637978394634!2d29.008783915416288!3d41.07852657929383!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14cab668046b358d%3A0xaa7c419109c4bcb6!2zRXNlbnRlcGUsIEthbnlvbiBBVk0sIDM0Mzk0IMWeacWfbGkvxLBzdGFuYnVs!5e0!3m2!1str!2str!4v1609613660898!5m2!1str!2str",
                Score = 100,
                DataText = "Kanyon Alışveriş Merkezi İstanbul’un Beşiktaş ilçesinin Levent semtinde bulunan bir alışveriş merkezidir. Aynı yapı kompleksinde bir rezidans kulesi de yer almaktadır.2001 yılında düzenlenen uluslararası mimari proje yarışmasını kazanan Tabanlıoğlu Mimarlık, Arup ve Jerde Partnership grubuna verilen projenin tasarlanmasına 2002 yılının Kasım ayında başlandı.[1] İşverenin Eczacıbaşı Topluluğu ile İş GYO ve de müteahhitinin Tepe İnşaat olduğu projenin inşaatına 2003 yılında başlandı ve 2006 yılında tamamlandı.Kanyon Alışveriş Merkezi her gün saat 10:00 ile 22:00 saatleri arasında açıktır. 4 kat ve 160 mağazadan oluşan komplekste birçok restoran, kafe, bar, sinema salonu ve spor salonları da mevcuttur. Sadece bunlarla kalmayıp içerisinde rezidans ve ofisler de barındırmaktadır. 179 konutun yanında kompleksin yüksek yapısı ofisler için ayrılmış 26 kattan oluşur. Şekli bir kanyonu andırdığından bu ismi alan kompleks açık, yarı açık ve kapalı mekanlardan oluşan bir alışveriş merkezidir.Binanın üstünde, 2009'da açılan bir heliport yer almaktadır.",
                TitleText = "-AVM-Kanyon Alışveriş Merkezi İstanbul’un Beşiktaş ilçesinin Levent semtinde bulunan bir alışveriş merkezidir. Aynı yapı kompleksinde bir rezidans kulesi de yer almaktadır.",
                ImageUrl = "\\images\\shop\\kanyon.jpg",
            },
            new Shop()
            {
                Id = 3,
                Name = "Cevahir",
                PhoneNumber = "0 212 368 69 00",
                WebSiteUrl = "http://www.istanbulcevahir.com/tr-TR/anasayfa/1.aspx",
                Adress = "19 Mayıs, Büyükdere Cd. No:22, 34360 Şişli/İstanbul",
                AdressUrl = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3008.2886332715384!2d28.990843715415703!3d41.062683079295276!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14cab7023f69f4c7%3A0x31b74f9588343eef!2zxLBzdGFuYnVsIENldmFoaXIgQWzEscWfdmVyacWfIHZlIEXEn2xlbmNlIE1lcmtlemk!5e0!3m2!1str!2str!4v1609614070640!5m2!1str!2str",
                Score = 100,
                DataText = "İstanbul Cevahir Alışveriş ve Eğlence Merkezi, Avrupa'nın ve dünyanın en büyük ve önde gelen alışveriş ve eğlence merkezlerinden biri olarak 15 Ekim 2005 tarihinde ziyaretçilerine kapılarını açtı.Türkiye’nin en eğlenceli alışveriş merkezi İstanbul Cevahir, 6 kata yayılan toplam 300’e yakın mağazasıyla ve 2500 araç kapasiteli kapalı otoparkıyla ziyaretçilerine kusursuz bir alışveriş deneyimi sunuyor.İstanbul Cevahir Alışveriş Merkezi’nde vizyon filmleri, leziz tatlar, kapalı temalı oyun parkı alanı FunLab’te sınırsız eğlence; yeni bir yaşam tarzında bir araya geliyor. İstanbul Cevahir, ziyaretçilerin tüm aile üyeleriyle birlikte yaşayacağı keyifli bir alışveriş ortamı hazırlıyor. İstanbul Cevahir Alışveriş Merkezi, dünyanın önde gelen markalarına ev sahipliği yapmanın getirdiği keyifli alışveriş anlayışı, farklı ve ilkleri yaşatan etkinlikleriyle ziyaretçileri için sosyal hayatın içinde vazgeçilmez bir parça haline gelmiştir.İstanbul Cevahir Alışveriş Merkezi, Türkiye’nin metropolü İstanbul’un stratejik bir noktasında bulunmaktadır. İçlerinde Koçtaş, YKM, Debenhams, Teknosa, Marks&Spencer ve Migros’un da yer aldığı güçlü markalardan oluşan mağaza karmasının yanı sıra organize perakendeciliğinin güçlü ulusal ve uluslar arası markalarının en önemli faaliyet alanlarından biri olarak, yerli ve yabancı ziyaretçilerine yılın 365 günü, 230 mağaza ile hizmet vermeye devam ediyor.",
                TitleText = "İstanbul Cevahir Alışveriş ve Eğlence Merkezi, Avrupa'nın ve dünyanın en büyük ve önde gelen alışveriş ve eğlence merkezlerinden biri olarak 15 Ekim 2005 tarihinde ziyaretçilerine kapılarını açtı.",
                ImageUrl = "\\images\\shop\\cevahir.jpg",
            },
            new Shop()
            {
                Id = 4,
                Name = "Viaport Asia",
                PhoneNumber = "0216 696 10 02",
                WebSiteUrl = "http://www.viaport.com.tr/tr/",
                Adress = "Yenişehir, Dedepaşa Blv. No:19, 34912 Pendik/İstanbul",
                AdressUrl = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3013.964470031017!2d29.321443615411944!3d40.93844587930801!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14cad0a009e00a49%3A0x67676050d69b82fc!2sViaport%20Asya%20Outlet%20Al%C4%B1%C5%9Fveri%C5%9F%20Merkezi!5e0!3m2!1str!2str!4v1609614257083!5m2!1str!2str",
                Score = 100,
                DataText = "Via Properties’in İstanbul’daki ilk yatırımı olarak 2008 yılında hayata geçirdiği Viaport Asia Outlet Shopping, bugün Türkiye’nin en çok ziyaretçi çeken yaşam merkezlerinden biri olmuştur.Toplam 365 bin m2’lik alan üzerine kurulu olan Viaport Asia, 250 mağazası, 4000 bin araçlık otoparkı, eğlence merkezleri, sineması ve diğer tüm ihtiyaçlara cevap veren tesisleriyle sosyal yaşamın merkezi haline gelmiştir.Açıkhava mimarisi ile, cadde konseptinde tasarlanan Viaport Asia, “outlet” konseptinde mağazalarıyla, kaliteyi uygun fiyatlarla ziyaretçilerinin hizmetine sunuyor. Göl kenarında konumlanan yeme içme alanlarında, şehrin gürültüsünden uzak, doğa ile içiçe bir atmosfer sunan Viaport Asia, tavus kuşları, tavşanlar, köpekler ve kedilerle iç içe natürel bir yaşamın kapılarını aralıyor.Çocuklu ailelerin de en çok tercih ettiği yaşam merkezlerinden biri olan Viaport Asia, Ponny Club, Eğlence Merkezi, bowling ve sinemasıyla da eğlenceyi doruklara çıkarıyor.Akdeniz kasabası havasında tasarlanan sokaklarda, yol boyu konumlanan mevsim çiçekleri, vitrinlerin ışıltısıyla birleşerek doyumsuz bir manzara oluşturuyor. Viaport Asia içerisinde bulunan, Kapalıçarşı’nın minyatür mimarisiyle donatılmış Bedesten’de ziyaretçilerimizi adeta tarihe yolculuğa çıkarıyor. Devlet sanatçıları tarafından 3 ayda işlenen kubbesi ile göz dolduran Bedesten, akustik yapısı ve heybetiyle ziyaretçilerin uğrak noktalarından biri.",
                TitleText = "Via Properties’in İstanbul’daki ilk yatırımı olarak 2008 yılında hayata geçirdiği Viaport Asia Outlet Shopping, bugün Türkiye’nin en çok ziyaretçi çeken yaşam merkezlerinden biri olmuştur.",
                ImageUrl = "\\images\\shop\\viaport.jpg",
            },
            new Shop()
            {
                Id = 5,
                Name = "Emaar Square Mall",
                PhoneNumber = "0850 290 8090",
                WebSiteUrl = "https://www.emaarsquaremall.com/",
                Adress = "Ünalan, Libadiye Cd. No:88, 34700 Üsküdar/İstanbul",
                AdressUrl = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3010.9971545077697!2d29.069191215413923!3d41.003435479301345!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14cac7de4d07f7ef%3A0xbc3f51296f041508!2sEmaar%20Square%20Mall!5e0!3m2!1str!2str!4v1609614577437!5m2!1str!2str",
                Score = 100,
                DataText = "2017 yılında kapılarını açmış olan Emaar Square Mall, Anadolu Yakası’nın en büyük, İstanbul’un ise en büyük 3’üncü alışveriş merkezi. Üsküdar’da yer alan AVM, merkezi lokasyonu ve kapsadığı geniş alanla oldukça avantajlı durumda. 138 bin 423 metrekare alana sahip olan bina bu özelliğini çok daha kapsamlı olarak kullanmış.491 ayrı markayla çalışan AVM, Türkiye’de ve Anadolu yakasında birçok markanın bulunduğu tek yer. Dünya moda devlerine, lüks ve ulaşılabilir lüks markalar kadar ekonomik markalara da ev sahipliği yapıyor. Bu merkez İstanbul’da yaşayanlar için ilk alışveriş merkezi seçeneği olabilir.Emaar Square Mall birçok etkinlik ve geniş yelpazedeki marka ve mağazalarıyla kesinlikle birçok ziyaretçi için İstanbul’daki en iyi AVM olarak yerini alıyor.Seçkin gastronomi markaları, dünya mutfağı, geleneksel Türk mutfağı, alanında öncü cafe ve restoranlar da Emaar Square’in bir parçası.Aynı zamanda Emaar Square Anadolu Yakası’nın tek su altı hayvanat bahçesi ve akvaryumuna, tek 4DX sinemasına sahip.İstanbul’daki en büyük 10 alışveriş merkezinden biri olan ve tüm bu özellikleriyle birçok ziyaretçi için kesinlikle ilk sırada olan Emaar Square Mall, 2017 yılından günümüze geçen kısa sürede adından söz ettirmeyi başardı.",
                TitleText = "2017 yılında kapılarını açmış olan Emaar Square Mall, Anadolu Yakası’nın en büyük, İstanbul’un ise en büyük 3’üncü alışveriş merkezi. Üsküdar’da yer alan AVM, merkezi lokasyonu ve kapsadığı geniş alanla oldukça avantajlı durumda. 138 bin 423 metrekare alana sahip olan bina bu özelliğini çok daha kapsamlı olarak kullanmış.",
                ImageUrl = "\\images\\shop\\emar.jpg",
            }

           );

            builder.Entity<FunPlace>().HasData(
           new FunPlace()
           {
               Id = 1,
               Name = "Sortie Club",
               PhoneNumber = "0212 327 85 85",
               WebSiteUrl = "http://www.sortie.com.tr/",
               Adress = "Muallim Naci Cd. No:54, Kuruçeşme, Beşiktaş",
               AdressUrl = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d192560.16734914226!2d29.0334751!3d41.0525387!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0x66351122d1ecac3d!2sSortie!5e0!3m2!1str!2str!4v1609614932042!5m2!1str!2str",
               Score = 100,
               DataText = "Asya ve Avrupa kıtasının tutkulu kavuşmasına seyirci kalmadık. İstanbulluların da bu buluşmaya şahit olmasını ve yaşamasını isteyerek Sortie’yi yarattık. Boğaz’ın bütün güzelliklerini arz-ı endam ettiği Kuruçeşme’de kurulduğumuz ilk günden beri sizleri iyi yemek, iyi müzik ve iyi eğlence ile buluşturmak için 4 mevsim çalışmalarımıza devam ediyoruz.Fransızca ‘Çıkış’ anlamına gelen Sortie, günlük yaşamın yoğun temposundan keyifle çıkabileceğiniz bir ortam. 3500m2’lik bir alana kurulmuş olan mekânımızda, ‘beraberlik’ en önemli ilkemiz. 2012 yılından itibaren yaz ve kış, 12 ay hizmet vermeye başlayan Sortie’de, yaz aylarında, bütün damak tatlarına hitap eden ve dünya mutfaklarının en güzel seçkilerini sunan 7 restorantı, kış aylarında ise yalnız Sortie Restaurant ile misafirlerimizi ağırlıyoruz. Eğlence trendlerini dünya ile aynı anda size sunan Sortie Club, 12 ay boyunca hız kesmeden Dj Tarık SARUL'un müzik koordinatörlüğünde eğlendirmeye devam ediyor.Dünyanın en muhteşem manzarasına sahip Sortie; günün her saatinin keyfini ayrı yaşayabileceğiniz, dostlarınızla buluşup, keyifli dakikalar geçirebileceğiniz, yabancı misafirlerinizi gururla ağırlayabileceğiniz, özel günlerinizi en coşkulu şekilde yaşayabileceğiniz, yeniliklerin ve eğlencenin tadını çıkartabileceğiniz en büyük alanı sizlere sunmaktan her daim keyif alıyor.",
               TitleText = "Asya ve Avrupa kıtasının tutkulu kavuşmasına seyirci kalmadık. İstanbulluların da bu buluşmaya şahit olmasını ve yaşamasını isteyerek Sortie’yi yarattık. Boğaz’ın bütün güzelliklerini arz-ı endam ettiği Kuruçeşme’de kurulduğumuz ilk günden beri sizleri iyi yemek, iyi müzik ve iyi eğlence ile buluşturmak için 4 mevsim çalışmalarımıza devam ediyoruz.",
               ImageUrl = "\\images\\funplace\\sorti.jpg",
           },

            new FunPlace()
            {
                Id = 2,
                Name = "Ruby",
                PhoneNumber = "0212 291 84 40",
                WebSiteUrl = "https://www.rubyistanbul.com/",
                Adress = "Yıldız Mh., Ortaköy Salhanesi Sk. No:5, Ortaköy, Beşiktaş",
                AdressUrl = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3008.9779684568757!2d29.022766615415165!3d41.04761087929678!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14cab7c85d58878d%3A0xfa4687227dedcd0!2sRUBY!5e0!3m2!1str!2str!4v1609615294728!5m2!1str!2str",
                Score = 100,
                DataText = "Ortaköy’de denize nazır ateşli ve ışıltılı bir konumda bulunan Ruby, muhteşem Boğaz manzarası ve lezzetli menüleri ile İstanbul’da yepyeni bir eğlence deneyimi sunuyor. Akşam yemeğinde sonra Ruby’de ister alt ister üst kattaki kulüp bölümlerinde sabahın ilk ışıklarına kadar dans ve müzik eşliğinde unutulmaz geceler yaşayabilirsiniz.Dünyanın en muhteşem manzarasına sahip Ruby; günün her saatinin keyfini ayrı yaşayabileceğiniz, dostlarınızla buluşup, keyifli dakikalar geçirebileceğiniz, yabancı misafirlerinizi gururla ağırlayabileceğiniz, özel günlerinizi en coşkulu şekilde yaşayabileceğiniz, yeniliklerin ve eğlencenin tadını çıkartabileceğiniz en büyük alanı sizlere sunmaktan her daim keyif alıyor",
                TitleText = "Ortaköy’de denize nazır ateşli ve ışıltılı bir konumda bulunan Ruby, muhteşem Boğaz manzarası ve lezzetli menüleri ile İstanbul’da yepyeni bir eğlence deneyimi sunuyor. Akşam yemeğinde sonra Ruby’de ister alt ister üst kattaki kulüp bölümlerinde sabahın ilk ışıklarına kadar dans ve müzik eşliğinde unutulmaz geceler yaşayabilirsiniz.",
                ImageUrl = "\\images\\funplace\\ruby.jpeg",
            },
             new FunPlace()
             {
                 Id = 3,
                 Name = "İsfanbul Tema Park",
                 PhoneNumber = "0212 600 01 00",
                 WebSiteUrl = "https://isfanbul.com/",
                 Adress = "Yeşilpınar Mahallesi Girne Caddesi, Eyüp, İstanbul",
                 AdressUrl = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d12031.468303724801!2d28.91470193733751!3d41.07189811870822!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14cab0eeedf314ef%3A0xea9558ebfe1c48d1!2sIsfanbul%20Tema%20Park!5e0!3m2!1str!2str!4v1609615415198!5m2!1str!2str",
                 Score = 100,
                 DataText = "İstanbul Avrupa yakasında Eyüp’te yaklaşık 100 futbol sahası büyüklüğünde 600 dönümlük bir arazide kurulu eğlence ve yaşam merkezi olan Isfanbul Tema Park, temalı parkı, alışveriş caddelerinden oluşan AVM’si, konsept mağazaları ve büyük etkinlik alanları ile Türkiye’nin dünya standartlarındaki ilk temalı parkı olarak hizmet veriyor. Özellikle çocuklu aileler için çok ideal bir mekan.Aileniz ve arkadaşlarınızla gün boyunca hiç sıkılmadan İsfanbul’un muhteşem ve büyülü dünyasının tadını çıkarabilirsiniz. Dünyanın en büyük 4’üncü roller coaster’ı burada. Ayrıca, parkın alışveriş merkezi de boş zamanınız da biraz gezmek biraz da alışveriş yapmak için ideal.İsfanbul’u farklı kılan şeylerin başında, burasının sadece bir tema ve eğlence parkı değil, aynı zamanda alışveriş, eğlence ve sergi merkezlerini tek bir yerde birleştiren büyük bir kompleks olması.Bu da özellikle çocuklu ailelerin burada tüm gün boyunca hiç sıkılmadan harika zaman geçirmelerine imkan tanıyor. İsfanbul için İstanbul’da çocuklar için en iyi yer olduğunu söyleyebiliriz.Çocuklar tema parkının çok çeşitli ve heyecanlı aktivitelerine katılırken, büyükler de alışveriş merkezi, temalı sokaklar, butikler, festival ve etkinlik alanları ile restoranlar ve cafelerde vakit geçirebiliyor.",
                 TitleText = "İstanbul Avrupa yakasında Eyüp’te yaklaşık 100 futbol sahası büyüklüğünde 600 dönümlük bir arazide kurulu eğlence ve yaşam merkezi olan Isfanbul Tema Park, temalı parkı, alışveriş caddelerinden oluşan AVM’si, konsept mağazaları ve büyük etkinlik alanları ile Türkiye’nin dünya standartlarındaki ilk temalı parkı olarak hizmet veriyor. Özellikle çocuklu aileler için çok ideal bir mekan.",
                 ImageUrl = "\\images\\funplace\\isfanbul.jpg",
             },
              new FunPlace()
              {
                  Id = 4,
                  Name = "İstanbul Dolphinarium",
                  PhoneNumber = "0212 581 78 78",
                  WebSiteUrl = "http://www.istanbuldolphinarium.com/",
                  Adress = "Silahtarağa Mah. Silahtarağa Cad. No:20 Eyüpsultan, İstanbul",
                  AdressUrl = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3008.3316399133596!2d28.940519215415677!3d41.061742879295394!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14cab0d7e6f893e9%3A0x785a5773bb5be5c!2s%C4%B0stanbul%20Dolphinarium!5e0!3m2!1str!2str!4v1609615752507!5m2!1str!2str",
                  Score = 100,
                  DataText = "İstanbul Dolphinarium Yunus Gösteri Merkezi’nde yunus gösterilerini izleyebilir, yunuslarla yüzme, dalış ve rehabilitasyon programlarına katılabilirsiniz.Ayrıca eğlenceli foklar, büyük morslar ve beyaz balina gibi diğer sevimli deniz memelilerinin dünyasını keşfedebilir, eğlenceli bir gün geçirebilirsiniz.İstanbul Dolphinarium’da yunuslarla yüzme ve yunuslara dokunup sarılma gibi sizlere ve özellikle çocuklarınıza güzel enerji verecek aktivitelere katılabilirsiniz.Yunuslarla yüzmek isteyenlerin yüzme bilmesi, ayrıca kış aylarında 10 yaşından, yaz aylarında ise 6 yaşından büyük olması şartı var. Ayrıca üzerinizde yüzük, saat, küpe, kolye vb. takılı herhangi bir aksesuar bulunmaması gerekiyor.İstanbul Dolphinarium’da yunuslarla dalış programına da katılabiliyorsunuz. Havuza girdiğinizde yunuslar size bir hoş geldin karşılaması yapıyor. Yanınızdan süzülüp geçiyorlar. Ve dilediğiniz zaman yunuslarla dalış yapabiliyorsunuz.",
                  TitleText = "İstanbul Dolphinarium Yunus Gösteri Merkezi’nde yunus gösterilerini izleyebilir, yunuslarla yüzme, dalış ve rehabilitasyon programlarına katılabilirsiniz.",
                  ImageUrl = "\\images\\funplace\\dolphinarium.jpg",
              },
               new FunPlace()
               {
                   Id = 5,
                   Name = "İstanbul LEGOLAND Discovery Center",
                   PhoneNumber = "444 3 253",
                   WebSiteUrl = "https://www.legolanddiscoverycentre.com/istanbul/",
                   Adress = "Forum Alışveriş Merkezi, Kocatepe Mah. Paşa Cad. No:5/5, Bayrampaşa, İstanbul",
                   AdressUrl = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3009.07017837906!2d28.89396891541524!3d41.04559437929706!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14caba86aaaaaaab%3A0x92bce2601ccae96d!2sLEGOLAND%20Discovery%20Centre%20Istanbul!5e0!3m2!1str!2str!4v1609615932891!5m2!1str!2str",
                   Score = 100,
                   DataText = "Dünyanın en ünlü markalarından birisi olan LEGOLAND Discovery Center’ın İstanbul şubesi olan İstanbul LEGOLAND Discovery Center (Eğlenceli Öğrenme Merkezi), İstanbul Bayrampaşa’da bulunan Forum Alışveriş Merkezi bünyesinde hizmet veren, İstanbul’da ailelerin 3-10 yaş arasındaki çocukları ile yaratıcılık dünyasını keşfedip eğlenebileceği rengarenk LEGO® parçaları ile dolu İstanbul’un en iyi kapalı eğlence merkezlerinden birisidir. LEGOLAND Discovery Center’da milyonlarca lego parçası ve saatlerce eğlence sizleri ve çocuklarınızı bekliyor.İstanbul LEGOLAND Discovery Center’da; Minyatür Kent MINILAND‘de Galata Kulesi, Ayasofya, Sultanahmet Camii, Boğaz Köprüsü ile İstanbul’un ve Dünya’nın simge haline gelmiş ünlü diğer pek çok yapısını keşfedebilirsiniz. LEGO® 4D Sinema the LEGO® Movie™’nin 4 boyutlu 15 dakikalık yeni macerası ile ziyaretiniz süresince farklı seanslar halinde 4 farklı filmiizleyebilirsiniz. Krallık Macerası Lazer Oyunu’nda at arabasıza atlayarak kötü iskeletlere ve dev trollere karşı puan kazanmak suretiyle eğlenceli bir gün geçirebilirsiniz.",
                   TitleText = "Dünyanın en ünlü markalarından birisi olan LEGOLAND Discovery Center’ın İstanbul şubesi olan İstanbul LEGOLAND Discovery Center (Eğlenceli Öğrenme Merkezi), İstanbul Bayrampaşa’da bulunan Forum Alışveriş Merkezi bünyesinde hizmet veren, İstanbul’da ailelerin 3-10 yaş arasındaki çocukları ile yaratıcılık dünyasını keşfedip eğlenebileceği rengarenk LEGO® parçaları ile dolu İstanbul’un en iyi kapalı eğlence merkezlerinden birisidir. LEGOLAND Discovery Center’da milyonlarca lego parçası ve saatlerce eğlence sizleri ve çocuklarınızı bekliyor.",
                   ImageUrl = "\\images\\funplace\\legoland.jpg",
               }

          );

            builder.Entity<HistoricalPlace>().HasData(
           new HistoricalPlace()
           {
               Id = 1,
               Name = "Yerebatan Sarnıcı",
               PhoneNumber = "0212 512 15 70",
               WebSiteUrl = "https://www.yerebatan.com/",
               Adress = "Alemdar Mh., Yerebatan Str. 1/3, Fatih, Istanbul",
               AdressUrl = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3010.7710555791823!2d28.97568931541396!3d41.00838397930067!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14cab9bde0c66ac9%3A0x60c02fe1ee6d8471!2zWWVyZWJhdGFuIFNhcm7EsWPEsQ!5e0!3m2!1str!2str!4v1609616107217!5m2!1str!2str",
               Score = 100,
               DataText = "İstanbul'un görkemli tarihsel yapılarından birisi de Ayasofya’nın güneybatısında bulunan Bazilika Sarnıcı’dır. Bizans İmparatoru I. Justinianus (527-565) tarafından yaptırılan bu büyük yeraltı sarnıcı, suyun içinden yükselen ve sayısız gibi görülen mermer sütunlar sebebiyle halk arasında “Yerebatan Sarayı” olarak isimlendirilmiştir.Sarnıcın bulunduğu yerde daha önce bir Bazilika bulunduğundan, Bazilika Sarnıcı olarak da anılır.Sarnıç, uzunluğu 140 metre, genişliği 70 metre olan dikdörtgen biçiminde bir alanı kaplayan, dev bir yapıdır. Toplam 9.800 m2 alanı kaplayan bu sarnıç, yaklaşık 100.000 ton su depolama kapasitesine sahiptir. 52 basamaklı taş bir merdivenle inilen bu sarnıcın içerisinde her biri 9 metre yüksekliğinde 336 sütun bulunmaktadır. Birbirine 4.80 metre aralıklarla dikilen bu sütunlar, her biri 28 sütun içeren 12 sıra meydana getirirler.  Çoğunluğu daha eski yapılardan toplandığı anlaşılan ve çeşitli mermer cinslerinden yontulmuş sütunların büyük bir kısmı tek parçadan, bir kısmı da iki parçadan oluşmaktadır. Bu sütunların başlıkları, yer yer farklı özellikler taşır. Bunlardan 98 adedi Corint üslûbu yansıtırken bir bölümü de Dor üslûbunu yansıtmaktadır.  Sarnıçtaki sütunların köşeli veya yivli biçimde olan birkaç tanesi hariç büyük bir çoğunluğu silindir biçimindedir. Sarnıcın ortasına doğru kuzeydoğu duvarı önünde yer alan 8 sütun, 1955-1960 yıllarında yapılan bir inşaat sırasında kırılma tehlikesine maruz kaldıklarından, bunların her biri, kalın bir beton tabaka içine alınarak dondurulmuş ve bu yüzden eski özelliklerini kaybetmişlerdir. Sarnıcın tavan aralığı kemerler vasıtasıyla sütunlara aktarılmıştır. Sarnıcın tuğladan örülmüş 4.80 metre kalınlığındaki duvarları ve tuğla döşeli zemini, Horasan harcından kalın bir tabakayla sıvanarak su geçmez hale getirilmiştir.",
               TitleText = "İstanbul'un görkemli tarihsel yapılarından birisi de Ayasofya’nın güneybatısında bulunan Bazilika Sarnıcı’dır. Bizans İmparatoru I. Justinianus (527-565) tarafından yaptırılan bu büyük yeraltı sarnıcı, suyun içinden yükselen ve sayısız gibi görülen mermer sütunlar sebebiyle halk arasında “Yerebatan Sarayı” olarak isimlendirilmiştir.Sarnıcın bulunduğu yerde daha önce bir Bazilika bulunduğundan, Bazilika Sarnıcı olarak da anılır.",
               ImageUrl = "\\images\\historicalplace\\yerebatan.jpg",
           },
            new HistoricalPlace()
            {
                Id = 2,
                Name = "Topkapı Sarayı Müzesi",
                PhoneNumber = "",
                WebSiteUrl = "https://www.millisaraylar.gov.tr/saraylar/topkapi-sarayi",
                Adress = "Topkapı Sarayı, Sultanahmet, Fatih, Istanbul",
                AdressUrl = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3010.6277817164214!2d28.981190215414212!3d41.011519479300446!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14cab9b8afa5f833%3A0x15aa1943c3015300!2zVG9wa2FwxLEgU2FyYXnEsSBNw7x6ZXNp!5e0!3m2!1str!2str!4v1609616419825!5m2!1str!2str",
                Score = 100,
                DataText = "Dünyanın en zengin müzelerinden birisi olarak kabul edilen Topkapı Sarayı, yanı başındaki komşusu Ayasofya Camii ile birlikte, hem yerli hem de yabancı turistler tarafından İstanbul’da en çok ziyaret edilen mekanlar arasında ilk sırada geliyor. İstanbul Boğazı ve Haliç‘e nazır üçgen bir burun üzerinde konumlanmış muhteşem bir saray olan Topkapı Sarayı, aynı zamanda dünyanın en büyük mimari eserlerinden birisi.15’inci yüzyıldan 19’uncu yüzyıla kadar Osmanlı Padişahlarının yaşadığı yer olan Topkapı Sarayı halen Milli Saraylar’a bağlı müze olarak hizmet veriyor ve muhteşem mimarisi ve barındırdığı değerleri ile İstanbul’a geldiğinizde mutlaka görmeniz gereken yerlerden birisi konumunda. Dünyanın en iyi Çin porseleni koleksiyonundan Osmanlı Padişahların kıyafetlerine kadar çok sayıda nadide eser sergileniyor.Topkapı Sarayı, Osmanlı sultanlarının ikametgahı olmasının yanı sıra İmparatorluğun da idare, eğitim ve merkeziydi. Saray 1460-1478 yılları arasında Sarayburnu’ndaki Bizans akropolünün bulunduğu alana İstanbul’un fethinden sonra Fatih Sultan Mehmed’in emriyle 1453-1478 yılları arasında inşa edilmiş.Topkapı Sarayı’nda dünyanın en iyi mühür, kitap ciltleme, mücevher ve kutu işçiliği örnekleri ve yazıtlar bulunuyor. Eski imparatorluk mutfağı, dünyadaki en iyi Çin porseleni koleksiyonuna ev sahipliği yapıyor. Osmanlı Sultanların kostümleri de yine burada sergileniyor.Hazine bölümünde dünyanın en iyi zümrüt, yakut ve elmas gibi mücevher kolleksiyonları ile birlikte kılıçlar, incilerle süslenmiş altın tahtlar bulunuyor.Etkileyici mavi çinilerle dekore edilmiş Bağdat Köşkü ise Topkapı Sarayı’nın en çok ziyaret edilen Kutsal Emanetler bölümü.",
                TitleText = "Dünyanın en zengin müzelerinden birisi olarak kabul edilen Topkapı Sarayı, yanı başındaki komşusu Ayasofya Camii ile birlikte, hem yerli hem de yabancı turistler tarafından İstanbul’da en çok ziyaret edilen mekanlar arasında ilk sırada geliyor. İstanbul Boğazı ve Haliç‘e nazır üçgen bir burun üzerinde konumlanmış muhteşem bir saray olan Topkapı Sarayı, aynı zamanda dünyanın en büyük mimari eserlerinden birisi.",
                ImageUrl = "\\images\\historicalplace\\topkap.jpg",
            },
             new HistoricalPlace()
             {
                 Id = 3,
                 Name = "St Antuan Kilisesi",
                 PhoneNumber = "",
                 WebSiteUrl = "https://www.sentantuan.com/",
                 Adress = "Tomtom, İstiklal Cd. No:171, 34433 Beyoğlu/İstanbul",
                 AdressUrl = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3009.6776600892963!2d28.974944715414814!3d41.03230757929834!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14cab7600647761f%3A0x87ccd464f889e39!2sSent%20Antuan%20Kilisesi!5e0!3m2!1str!2str!4v1609616532736!5m2!1str!2str",
                 Score = 100,
                 DataText = "St. Antuan Katolik Kilisesi (Fransızca: St. Antoine) İstanbul'un en büyük ve cemaati en geniş Katolik Kilisesi'dir. Beyoğlu'ndaki İstiklal Caddesi üzerinde Galatasaray'dan (Galatasaray Lisesi tarafında) Tünel'e doğru giderken sol tarafta bulunur.İstanbul’un en fazla cemaati olan Katolik Kilisesi, sadece bu mezhebe mensup kişiler tarafından değil, farklı dinleri benimsemiş kimseler tarafından da sık sık ziyaret ediliyor. Galatasay’dan Tünel’e giderken hemen solda yer alan St. Antoine Kilisesi, Fransisken tarikatına bağlı keşişler tarafından yapıldı.Ahşap kilise, 1699’da çıkan yangın sonucunda harap olmuş, 1762 yılında şu anki Fransız Elçiliği’nin arazisi üzerine inşa edilen Katolik Fransisken Kilisesi, tramvay geçişini engellediği için yıkılmış. İnşa şekli gotik tarzda olan binanın dış cephesi kırmızı tuğlaile inşa edilmiştir. İç tasarımı Latin haçı gibidir. İçerisinde romanesk bir kript vardır. İsa ve Aziz Antoine heykeli yan yana konmuştur. Kilisenin çan kulesi güney yönündedir ve kiliseye paralel olan manastır binası vardır. Ayin saatleri,Pazar günleri 10:00 ile 19:00 saatleri arası,Pazartesi ve Cumartesi günleri 08:00 ile 19:00 saatleri arası,Her Salı günü 11:30 olarak belirlenmiştir. Kiliseye girişi için herhangi bir ücret ödemiyorsunuz. Kiliseye yardım maksadı ile mum yakabilir ve bağış kutularına para atabilirsiniz. Biz paskalya zamanında ziyaret ettiğimiz için ayine şahit olabildik. Paskalya olduğu için normal zamanlara göre daha kalabalık idi. Yılbaşı öncesi yaptığım ziyaretlerdede çok kalabalık olduğunu söyleyebilirim.",
                 TitleText = "St. Antuan Katolik Kilisesi (Fransızca: St. Antoine) İstanbul'un en büyük ve cemaati en geniş Katolik Kilisesi'dir. Beyoğlu'ndaki İstiklal Caddesi üzerinde Galatasaray'dan (Galatasaray Lisesi tarafında) Tünel'e doğru giderken sol tarafta bulunur.",
                 ImageUrl = "\\images\\historicalplace\\kilise.jpg",
             },
              new HistoricalPlace()
              {
                  Id = 4,
                  Name = "Dolmabahçe Sarayı",
                  PhoneNumber = "0212 236 90 00",
                  WebSiteUrl = "https://www.millisaraylar.gov.tr/saraylar/dolmabahce-sarayi",
                  Adress = "Milli Saraylar İdaresi Başkanlığı Dolmabahçe Sarayı, Beşiktaş",
                  AdressUrl = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3009.364187218722!2d28.99827071541506!3d41.039164279297665!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14cab7761a3b7de3%3A0xdcd33e38cf3b830b!2zRG9sbWFiYWjDp2UgU2FyYXnEsQ!5e0!3m2!1str!2str!4v1609616861691!5m2!1str!2str",
                  Score = 100,
                  DataText = "Kabataş-Beşiktaş arasında İstanbul Boğazı’nın en güzel yerine kurulmuş olan, Avrupa barok tarzı görkemli mimarisi, oryantal dokusu ve sergi salonları ile misafirlerini büyüleyen Dolmabahçe Sarayı, Ayasofya ve Topkapı Sarayı ile birlikte İstanbul’a geldiğinizde mutlaka gezip görmeniz gereken yerler arasında. Osmanlı İmpartorluğu’nun son altı padişahı ile Türkiye Cumhuriyeti’nin kurucusu Atatürk’ün ikametgahı olmuş bir saray.Yaklaşık 110.000 metrekarelik bir alanda kurulu olan ve Sultan Abdülmecid (1839-1861) tarafından yaptırılan Dolmabahçe Sarayı’nın inşasına 13 Haziran 1843 tarihinde başlanmış ve 7 Haziran 1856 tarihinde kullanıma açılmış.Dolmabahçe Sarayı, 1856 yılından 1924 yılına kadar toplam altı padişaha ve son Osmanlı Halifesi Abdülmecid Efendi’ye ev sahipliği yapmış.Türkiye Cumhuriyeti’nin kuruluşundan sonra 1927- 1949 yılları arasında Cumhurbaşkanlığı makamı olarak kullanılmış. Mustafa Kemal Atatürk, 1927-1938 yılları arasında İstanbul’daki çalışmalarında Dolmabahçe Sarayı’nı kullanmış ve 10 Kasım 1938 yılında burada vefat etmiş",
                  TitleText = "Kabataş-Beşiktaş arasında İstanbul Boğazı’nın en güzel yerine kurulmuş olan, Avrupa barok tarzı görkemli mimarisi, oryantal dokusu ve sergi salonları ile misafirlerini büyüleyen Dolmabahçe Sarayı, Ayasofya ve Topkapı Sarayı ile birlikte İstanbul’a geldiğinizde mutlaka gezip görmeniz gereken yerler arasında. Osmanlı İmpartorluğu’nun son altı padişahı ile Türkiye Cumhuriyeti’nin kurucusu Atatürk’ün ikametgahı olmuş bir saray.",
                  ImageUrl = "\\images\\historicalplace\\dolmabahce.jpg",
              },
               new HistoricalPlace()
               {
                   Id = 5,
                   Name = "Miniatürk Müzesi",
                   PhoneNumber = " 0212 222 28 82",
                   WebSiteUrl = "https://www.miniaturk.com.tr/tr",
                   Adress = "Örnektepe Mahallesi, İmrahor Caddesi, No.7 Sütlüce, Beyoğlu",
                   AdressUrl = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d6016.870119690601!2d28.94469472677551!3d41.059481867182214!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14cab0ca49006bf5%3A0x3189508ccec2d71c!2sMiniat%C3%BCrk!5e0!3m2!1str!2str!4v1609617052421!5m2!1str!2str",
                   Score = 100,
                   DataText = "Miniatürk, diğer bir ifadeyle Minyatür Türkiye Parkı ve Müzesi, dünyanın bazı ülkelerinde de olduğu gibi şehirlerin ve ülkenin önemli eser ve yapıtlarının minyatür maketlerinin sergilendiği bir açık hava müzesi. İstanbul içinde kısa bir sürede Türkiye’nin önemli tarihi ve kültürel mekanlarında tur atmak isteyenler ve özellikle çocuklu aileler için çok ideal bir mekan.Haliç kıyılarında, Sütlüce semtinde bulunuyor. Aynı zamanda 60.000 metrekarelik alanı ile dünyanın en geniş alanına kurulmuş bir minyatür park özelliğine sahip.Miniatürk’te Çanakkale Zafer Anıtından Amasya ve Safranbolu evlerine, Selimiye Camii, Mevlana Türbesinden Malabadi ve Mostar köprüsüne, Sultanahmet, Ayasofya, Boğaziçi Köprüsünden Atatürk Havalimanına kadar Türkiye’nin en önemli ve tarihi yapıtların gerçek boyutlarının 1/25 oranında minyatürlerini görmek mümkün.Bünyesinde ayrıca Kristal İstanbul ve Panorama Zafer Müzesi adında iki minik müze bulunuyor.Açık havadaki sergi alanının dışında ayrıca restoran, kafeterya, hediyelik eşya dükkanı, çocuk oyun parkı, feribot, kumandalı tekne, gezi treni, satranç ve labirent alanı ile Türkiye-İstanbul Simülasyon Helikopter turunu barındıran çok büyük bir kompleks. Ayrıca 300 araçlık otopark alanı da mevcut.",
                   TitleText = "Miniatürk, diğer bir ifadeyle Minyatür Türkiye Parkı ve Müzesi, dünyanın bazı ülkelerinde de olduğu gibi şehirlerin ve ülkenin önemli eser ve yapıtlarının minyatür maketlerinin sergilendiği bir açık hava müzesi. İstanbul içinde kısa bir sürede Türkiye’nin önemli tarihi ve kültürel mekanlarında tur atmak isteyenler ve özellikle çocuklu aileler için çok ideal bir mekan.",
                   ImageUrl = "\\images\\historicalplace\\miniaturk.jpeg",
               }
          );

        }
    }
}
