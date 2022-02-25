# Insertion_sort

## Patika Insertion Sort Projesi

### Insertion Sort: Algoritmada döngümüz her bir tur döndüğünde sıradaki elemanı sondan başa doğru karşılaştırarak yerine yerleştirme esaslı çalışmaktadır.

---

## 1.Soru

[22,27,16,2,18,6] -> Insertion Sort yöntemi ile aşamaları

1. 22,27,16,2,18,6 Dizinin 0'ıncı elemanı olan 22 dizinin bir sonraki elemanlarını sırasıyla ziyaret eder. 16, 22'den küçük olduğu için 27 ve 22 nin önüne geçer.

2. 16,22,27,2,18,6 Dizinin 3. elemanı olan 2 27,22 ve 16 elemanlarını ziyaret eder ve küçük olduğu için dizinin ilk elemanı olarak yerleşir.
3. 2,16,22,27,18,6 Dizinin 4.elemanı olan 18 sırasıyla 27, 22,16 elemanlarına gider. 16, 18'den küçük olduğu için dizinin 2. elemanı olarak sıraya girer
4. 2,16,18,22,27,6 Dizinin 5. ve son elemanı olan 6 sırasıyla 27,22,18,16 ve 2 ye gider 2'den büyük olduğu için dizide 1.sıraya yerleşir.

   Sonuç= 2,6,16,18,22,27

---

## 2.Soru

O(n^2)

---

## 3.Soru

18 Sayısı Average case kapsamına girer

---

## 4.Soru

[7,3,5,8,2,9,4,15,6]

1. 7,3,5,8,2,9,4,15,6 Dizinin 1. elemanı olan 3 7'den küçük olduğu için ilk sıraya geçer.
2. 3,7,5,8,2,9,4,15,6 Dizinin 2.elemanı olan 5 7'den küçük olduğu için 1.sıraya geçer ama 0. eleman olan 3'ten büyük olduğu için 1.sırada kalır
3. 3,5,7,8,2,9,4,15,6 Dizinin 3.elemanı olan 8'in yeri değişmez ve 4.eleman olan 2'ye bakılır. 2 8,7,5,3'ten küçük olduğu için ilk sıraya geçer.
4. 2,3,5,7,8,9,4,15,6 Dizinin 5.elemanı 9 sabit kalır ve 6. eleman olan 4'e bakılır. 4 sayısı 9,8,7,5'ten küçük 3'ten büyük olduğu için 2. eleman olarak yerleşir.

Sonuç= 2,3,4,5,7,8,9,15,6
