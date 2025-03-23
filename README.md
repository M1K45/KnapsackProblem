# Knapsack
## Konsolowa oraz okienkowa aplikacja służąca do rozwiązywania problemu plecakowego
> Autor: Michał Kaszowski (indeks 272570)
### Wstęp
Napisano aplikację na platwormie .NET (wersja 8.0) rozwiązującą problem plecakowy będący jednym z problemów optymalizacyjnych.
Stworzono również testy jednostkowe do funkcji rozwiązującej ten problem oraz graficzny interfejs użytkownika (GUI)

### Opis problemu
Problem plecakowy polega na wyborze przedmiotów, które mają łącznie największą wartość tak, aby ich łączna waga nie przekraczała pojemności plecaka. 

### Pliki programu oraz ich przeznaczenie
1. Aplikacja konsolowa
  - *Item.cs* - klasa reprezentująca przedmiot: posiada on swoje ID (potrzebne do listy przedmiotów do włożenia do plecacka w rozwiązaniu), wagę, wartość, oraz stosunek wartości do wagi
  - *Result.cs* - klasa reprezentująca rozwiązanie problemu: zawiera ona listę ID przedmiotów, ich łączną masę oraz wartość
  - *Problem.cs* - klasa będąca instancją problemu plecakowego: zawiera ona listę przedmiotow, oraz metodę, służącą do rozwiązywania tego problemu (zwraca ona obiekt klasy *Result*)
  - *Program.cs* - plik, służący do tworzenia obiektu klasy *Problem* oraz do wywołania funkcji rozwiązującej zadanie.
2. Testy jednostkowe
    - *Test1.cs* - plik, w którym przechowywane są testy jednostkowe
3. GUI
    - *Form1.cs* - plik w którym zaprogramowano zachowanie przycisku, oraz pól, do których są wpisywane informacje niezbędne do wygenerowania instancji problemu.
      
### Opis testów 
W pliku *Test1.cs* napisano następujące testy: 
1. *Problem_Solve_EmptySolution* - weryfikacja, czy w przypadku, kiedy nie będzie można włożyć do plecaka żadnego przedmiotu, zostanie zwrócona pusta lista
2. *Problem_Solve_ReturnAtLeastOneElement* - weryfikacja, czy w przypadku w którym plecak jest wystarczająco pojemny, żeby wrzucić do niego przedmioty, zostanie zwrócona lista z co najmniej jednym elementem
3. *Problem_Solve_IsCorrect* - weryfikacja poprawności rozwiązania problemu dla wybranej instancji
4. *Problem_Solve_MaxFill* - weryfikacja możliwości wypełnienia plecaka "na styk"
5. *Problem_Solve_lessThanOneCapacity* - sprawdzenie, czy zostanie zwrócony odpowiedni błąd w przypadku wywołania funkcji z ujemną pojemnością

### Działanie programu 
1. Aplikacja konsolowa
   - W pliku *Program.cs* przy tworzeniu obiektu określa się w konstruktorze: ilość przedmiotów, oraz ziarno służące do generowania losowych przedmiotów
   - Następnie używając metody *Solve()*, podając w argumencie pojemność plecaka, można rozwiązać problem.
2. Aplikacja okienkowa
   
  - Przykład działania aplikacji okienkowej 

https://github.com/user-attachments/assets/c46fbf5d-c186-4406-9451-f9ceec839a79

- Walidacja wpisywanych wartości 


https://github.com/user-attachments/assets/336bbc64-fa88-43c5-ab62-a7efb9a2277a

### Wykorzystane technologie 
- .NET (wersja 8.0)
- C#
- MSTests (dla testów jednostkowych)
- Windows Forms (dla GUI)
   
