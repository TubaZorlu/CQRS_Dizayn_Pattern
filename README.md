# CQRS_Dizayn Pattern
Bu projede CQRS dizayn paterni pekiştirmek için uygulama yapılmıtşr.
CQRS, özünde Command Query Responsibility Segregation‘ın kısaltılmış halidir.
Açılımından da ‘Command’ ve ‘Query’ sorumluluklarının ayrılması prensibini esas alan bir yaklaşımı savunmaktadır
Yani Silme-Güncelleme-Ekleme işlemleri ile listelemek yada okumak için lan işlemlerin ayrıılmasıdır.
Kulanım temelinde yüksek oranda okuma listeleme yaplan sitemlerde hatanlaşmayı engellemmektir
Ayrıca projede tüm request, response ve handle nesnelerini, davranışlarına göre yönetebilmemizi sağlayan merkezi bir yapılanma oluşturmak için Mediator pattern’dan faydalandık,bu surreç için MeditatR kütüphanesini sistemimize dahil ettik
