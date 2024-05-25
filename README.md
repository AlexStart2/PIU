# Gestionarea Cursurilor

## Descriere generală

"Gestionarea Cursurilor" este o aplicație desktop dezvoltată în C# utilizând platforma Windows Forms, destinată pentru administrarea eficientă a cursurilor educaționale. Aceasta permite utilizatorilor să adauge, să vizualizeze, să caute și să gestioneze cursurile și întrebările asociate acestora într-un mod simplu și intuitiv.

## Funcționalități principale

1. **Adăugare cursuri**: Permite utilizatorilor să adauge cursuri noi în baza de date prin completarea unui formular dedicat.
2. **Vizualizare cursuri**: Afișează lista de cursuri existente într-un tabel, incluzând detalii precum numele cursului și numărul de întrebări asociate.
3. **Căutare cursuri**: Oferă funcționalități de căutare pentru a găsi cursuri după nume, facilitând astfel accesul rapid la informațiile dorite.
4. **Ștergere cursuri**: Permite utilizatorilor să șteargă cursuri selectate din listă.
5. **Vizualizare detalii curs**: Oferă posibilitatea de a vizualiza detalii suplimentare despre un curs specific, incluzând lista de întrebări asociate acestuia.
- Aici se poate de adaugat/editat intrebari noi și de raspuns la aceste întrebări în cadrul unui test (la fiecare intrebare se poate de adăugat o imagine).
6. **Salvare date**: Permite salvarea datelor într-un fișier pentru a asigura persistenta acestora între sesiuni.

## Tehnologii utilizate

1. **Limbaj de programare**: C#
2. **Platformă**: Windows Forms
3. **Biblioteci suplimentare**: 
   - `System.Windows.Forms` pentru crearea interfeței grafice.
   - `System.Drawing` pentru manipularea și afișarea imaginilor.

## Cerințe de sistem

- **Sistem de operare**: Windows 7 sau mai recent
- **Procesor**: Minim 1 GHz
- **Memorie RAM**: Minim 1 GB
- **Spațiu pe disc**: Minim 50 MB spațiu disponibil
- **.NET Framework**: Versiunea 4.5 sau mai recentă

## Instalare și rulare

1. **Instalare**:
   - Descărcați și instalați [Visual Studio](https://visualstudio.microsoft.com/).
   - Clonați proiectul de pe GitHub în directorul local.

2. **Rulare**:
   - Deschideți proiectul în Visual Studio.
   - Compilați proiectul utilizând opțiunea `Build`.
   - Rulați aplicația prin selectarea opțiunii `Start`.

## Utilizare

1. **Adăugare curs**:
   - Apăsați pe butonul "Adaugă Curs".
   - Completați numele cursului în formularul afișat și apăsați pe "Adaugă".

2. **Vizualizare cursuri**:
   - Lista de cursuri este afișată automat la deschiderea aplicației.
   - Pentru a actualiza lista, apăsați pe butonul "Afișează Cursuri".

3. **Căutare cursuri**:
   - Introduceți numele cursului în bara de căutare și apăsați pe butonul de căutare sau apăsați `Enter`.

4. **Ștergere cursuri**:
   - Selectați linia cu cursul dorit din tabel și apăsați pe butonul "Șterge".

5. **Vizualizare detalii curs**:
   - Selectați cursul dorit din tabel și apăsați pe butonul "Detalii Curs".

6. **Salvare date**:
   - Apăsați pe butonul "Salvează" pentru a salva datele în fișier.
