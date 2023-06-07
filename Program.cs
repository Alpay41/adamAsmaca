namespace Hangman
{
    using System;
    //char selectedLetter;

    internal class Program
    {
    class AdamAsmacaOyunu
        {
            //            static string[] kelimeListesi = { "elma", "muz", "portakal", "çilek", "ananas" };
            //            static Random rastgele = new Random();

            //            static void Main(string[] args)
            //            {
            //                Console.WriteLine("Adam Asmaca oyununa hoş geldiniz!");

            //                string tahminEdilecekKelime = RastgeleKelimeSec();
            //                char[] tahminEdilenHarfler = new char[tahminEdilecekKelime.Length];

            //                int kalanDenemeHakki = 6;
            //                bool kelimeTahminEdildi = false;

            //                while (kalanDenemeHakki > 0 && !kelimeTahminEdildi)
            //                {
            //                    Console.WriteLine();
            //                    Console.WriteLine("Kalan deneme hakkı: " + kalanDenemeHakki);
            //                    Console.WriteLine("Kelime: " + TahminEdilenKelimeyiAl(tahminEdilenHarfler));

            //                    char tahminEdilenHarf = HarfTahminiAl();

            //                    if (tahminEdilecekKelime.Contains(tahminEdilenHarf))
            //                    {
            //                        TahminEdilenHarfleriGuncelle(tahminEdilenHarf, tahminEdilecekKelime, tahminEdilenHarfler);
            //                        if (TahminEdilenKelimeyiAl(tahminEdilenHarfler) == tahminEdilecekKelime)
            //                        {
            //                            kelimeTahminEdildi = true;
            //                        }
            //                    }
            //                    else
            //                    {
            //                        kalanDenemeHakki--;
            //                        Console.WriteLine("Yanlış tahmin!");
            //                        AsikCiz(kalanDenemeHakki);
            //                    }
            //                }

            //                Console.WriteLine();

            //                if (kelimeTahminEdildi)
            //                {
            //                    Console.WriteLine("Tebrikler! Kelimeyi doğru tahmin ettiniz: " + tahminEdilecekKelime);
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Üzgünüz, kaybettiniz. Kelime: " + tahminEdilecekKelime);
            //                }

            //                Console.WriteLine("Çıkmak için herhangi bir tuşa basın.");
            //                Console.ReadKey();
            //            }

            //            static string RastgeleKelimeSec()
            //            {
            //                int index = rastgele.Next(0, kelimeListesi.Length);
            //                return kelimeListesi[index];
            //            }

            //            static char HarfTahminiAl()
            //            {
            //                Console.Write("Bir harf tahmini girin: ");
            //                string input = Console.ReadLine().ToLower();

            //                char harf;
            //                while (!char.TryParse(input, out harf) || !Char.IsLetter(harf))
            //                {
            //                    Console.Write("Geçersiz giriş. Bir harf tahmini girin: ");
            //                    input = Console.ReadLine().ToLower();
            //                }
            //                return harf;
            //            }

            //            static string TahminEdilenKelimeyiAl(char[] tahminEdilenHarfler)
            //            {
            //                return new string(tahminEdilenHarfler);
            //            }

            //            static void TahminEdilenHarfleriGuncelle(char harf, string tahminEdilecekKelime, char[] tahminEdilenHarfler)
            //            {
            //                for (int i = 0; i < tahminEdilecekKelime.Length; i++)
            //                {
            //                    if (tahminEdilecekKelime[i] == harf)
            //                    {
            //                        tahminEdilenHarfler[i] = harf;
            //                    }
            //                }
            //            }

            //            static void AsikCiz(int kalanDenemeHakki)
            //            {
            //                switch (kalanDenemeHakki)
            //                {
            //                    case 6:
            //                        Console.WriteLine("________");
            //                        Console.WriteLine("|      |");
            //                        Console.WriteLine("|");
            //                        Console.WriteLine("|");
            //                        Console.WriteLine("|");
            //                        Console.WriteLine("|");
            //                        break;
            //                    case 5:
            //                        Console.WriteLine("________");
            //                        Console.WriteLine("|      |");
            //                        Console.WriteLine("|      O");
            //                        Console.WriteLine("|");
            //                        Console.WriteLine("|");
            //                        Console.WriteLine("|");
            //                        break;
            //                    case 4:
            //                        Console.WriteLine("________");
            //                        Console.WriteLine("|      |");
            //                        Console.WriteLine("|      O");
            //                        Console.WriteLine("|      |");
            //                        Console.WriteLine("|");
            //                        Console.WriteLine("|");
            //                        break;
            //                    case 3:
            //                        Console.WriteLine("________");
            //                        Console.WriteLine("|      |");
            //                        Console.WriteLine("|      O");
            //                        Console.WriteLine("|     /|");
            //                        Console.WriteLine("|");
            //                        Console.WriteLine("|");
            //                        break;
            //                    case 2:
            //                        Console.WriteLine("________");
            //                        Console.WriteLine("|      |");
            //                        Console.WriteLine("|      O");
            //                        Console.WriteLine("|     /|\\");
            //                        Console.WriteLine("|");
            //                        Console.WriteLine("|");
            //                        break;
            //                    case 1:
            //                        Console.WriteLine("________");
            //                        Console.WriteLine("|      |");
            //                        Console.WriteLine("|      O");
            //                        Console.WriteLine("|     /|\\");
            //                        Console.WriteLine("|     /");
            //                        Console.WriteLine("|");
            //                        break;
            //                    case 0:
            //                        Console.WriteLine("________");
            //                        Console.WriteLine("|      |");
            //                        Console.WriteLine("|      O");
            //                        Console.WriteLine("|     /|\\");
            //                        Console.WriteLine("|     / \\");
            //                        Console.WriteLine("|");
            //                        break;
            //                }
            //            }
            //        }
            //    }
        }

    class HangmanGame
        {
            //        static string[] wordList = { "apple", "banana", "orange", "strawberry", "pineapple" };
            //        static Random random = new Random();

            //        static void Main(string[] args)
            //        {
            //            Console.WriteLine("Welcome to Hangman!");

            //            string wordToGuess = GetRandomWord();
            //            char[] guessedLetters = new char[wordToGuess.Length];

            //            int attemptsLeft = 6;
            //            bool wordGuessed = false;

            //            while (attemptsLeft > 0 && !wordGuessed)
            //            {
            //                Console.WriteLine();
            //                Console.WriteLine("Attempts left: " + attemptsLeft);
            //                Console.WriteLine("Word: " + GetGuessedWord(guessedLetters));

            //                char guessedLetter = GetLetterGuess();

            //                if (wordToGuess.Contains(guessedLetter))
            //                {
            //                    UpdateGuessedLetters(guessedLetter, wordToGuess, guessedLetters);
            //                    if (GetGuessedWord(guessedLetters) == wordToGuess)
            //                    {
            //                        wordGuessed = true;
            //                    }
            //                }
            //                else
            //                {
            //                    attemptsLeft--;
            //                    Console.WriteLine("Wrong guess!");
            //                    DrawHangman(attemptsLeft);
            //                }
            //            }

            //            Console.WriteLine();

            //            if (wordGuessed)
            //            {
            //                Console.WriteLine("Congratulations! You guessed the word: " + wordToGuess);
            //            }
            //            else
            //            {
            //                Console.WriteLine("Sorry, you lost. The word was: " + wordToGuess);
            //            }

            //            Console.WriteLine("Press any key to exit.");
            //            Console.ReadKey();
            //        }

            //        static string GetRandomWord()
            //        {
            //            int index = random.Next(0, wordList.Length);
            //            return wordList[index];
            //        }

            //        static char GetLetterGuess()
            //        {
            //            Console.Write("Enter a letter guess: ");
            //            string input = Console.ReadLine().ToLower();

            //            char letter;
            //            while (!char.TryParse(input, out letter) || !Char.IsLetter(letter))
            //            {
            //                Console.Write("Invalid input. Enter a letter guess: ");
            //                input = Console.ReadLine().ToLower();
            //            }

            //            return letter;
            //        }

            //        static string GetGuessedWord(char[] guessedLetters)
            //        {
            //            return new string(guessedLetters);
            //        }

            //        static void UpdateGuessedLetters(char letter, string wordToGuess, char[] guessedLetters)
            //        {
            //            for (int i = 0; i < wordToGuess.Length; i++)
            //            {
            //                if (wordToGuess[i] == letter)
            //                {
            //                    guessedLetters[i] = letter;
            //                }
            //            }
            //        }

            //        static void DrawHangman(int attemptsLeft)
            //        {
            //            switch (attemptsLeft)
            //            {
            //                case 6:
            //                    Console.WriteLine("________");
            //                    Console.WriteLine("|      |");
            //                    Console.WriteLine("|");
            //                    Console.WriteLine("|");
            //                    Console.WriteLine("|");
            //                    Console.WriteLine("|");
            //                    break;
            //                case 5:
            //                    Console.WriteLine("________");
            //                    Console.WriteLine("|      |");
            //                    Console.WriteLine("|      O");
            //                    Console.WriteLine("|");
            //                    Console.WriteLine("|");
            //                    Console.WriteLine("|");
            //                    break;
            //                case 4:
            //                    Console.WriteLine("________");
            //                    Console.WriteLine("|      |");
            //                    Console.WriteLine("|      O");
            //                    Console.WriteLine("|      |");
            //                    Console.WriteLine("|");
            //                    Console.WriteLine("|");
            //                    break;
            //                case 3:
            //                    Console.WriteLine("________");
            //                    Console.WriteLine("|      |");
            //                    Console.WriteLine("|      O");
            //                    Console.WriteLine("|     /|");
            //                    Console.WriteLine("|");
            //                    Console.WriteLine("|");
            //                    break;
            //                case 2:
            //                    Console.WriteLine("________");
            //                    Console.WriteLine("|      |");
            //                    Console.WriteLine("|      O");
            //                    Console.WriteLine("|     /|\\");
            //                    Console.WriteLine("|");
            //                    Console.WriteLine("|");
            //                    break;
            //                case 1:
            //                    Console.WriteLine("________");
            //                    Console.WriteLine("|      |");
            //                    Console.WriteLine("|      O");
            //                    Console.WriteLine("|     /|\\");
            //                    Console.WriteLine("|     /");
            //                    Console.WriteLine("|");
            //                    break;
            //                case 0:
            //                    Console.WriteLine("________");
            //                    Console.WriteLine("|      |");
            //                    Console.WriteLine("|      O");
            //                    Console.WriteLine("|     /|\\");
            //                    Console.WriteLine("|     / \\");
            //                    Console.WriteLine("|");
            //                    break;
            //            }
            //        }
        }

        static char[] harfler = { 'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G', 'Ğ', 'H', 'I', 'İ', 'J', 'K', 
                                'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'Y', 'Z' };
        static void Main(string[] args)
        {
        int score = 0;

        string[] hayvanlar = { "Kedi", "Köpek", "At", "Tavşan", "Leylek", "Deve", "Yarasa", "Sincap", "Sinek", "Karınca" };
        string[] ulkeler = { "Türkiye", "İtalya", "Kanada", "Almanya", "Japonya", "İngiltere", "Rusya", "Fransa", "Meksika", "Brezilya" };
        string[] meslekler = { "Öğretmen", "Doktor", "Mühendis", "Hemşire", "Polis", "Avukat", "İnşaat işçisi", "Dişçi", "Gazeteci", "Bankacı" };
        string[] yemekler = { "Makarna", "Kebap", "Pilav", "Pizza", "Köfte", "Tavuk", "Balık", "Mantı", "Börek", "Salata" };
        string[] sporlar = { "Futbol", "Basketbol", "Voleybol", "Tenis", "Yüzme", "Atletizm", "Boks", "Jimnastik", "Hentbol", "Ragbi" };
        string[] kategoriler = { "Hayvanlar", "Ülkeler", "Meslekler", "Yemekler", "Sporlar" };

            ShowGameName();
            ShowCategories(kategoriler);
            ChooseCategory(kategoriler);
            ShowAlphabet();
            Console.WriteLine();
            while (true)
            {

            ChooseLetter();

            Console.WriteLine("Puan: {0}", score);
            }
            Console.ReadLine();
            Console.Clear();
        }
        static void ShowAlphabet()
        {
        char[] harfler = { 'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G', 'Ğ', 'H', 'I', 'İ', 'J', 'K', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'Y', 'Z' };
        for (int harf = 0; harf < harfler.Length; harf++)
        {
        Console.Write("{0} ", harfler[harf]);
        if (harf == harfler.Length / 2) Console.WriteLine();
        }
        }
        static void ShowCategories(string[] categories)
        {
            int columnCount = 2;
            for (int i = 0; i < categories.Length; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    if (i == 4 && j == 1) break;
                    Console.Write("{0}- {1}\t", i + j + 1, categories[i]);
                }
                Console.WriteLine();
                i++;
            }
        }
        static int choosedCategory;
        static void ChooseCategory(string[] categories)
        {
            while (choosedCategory < 1 || choosedCategory > categories.Length)
            {
                Console.Write("Kategori Seçiniz: ");
                choosedCategory = int.Parse(Console.ReadLine());
            }
        }
        static void ShowGameName()
        {
            Console.WriteLine("Adam Asmaca");
        }
        static string chosenLetter = default;
        static void ChooseLetter()
        {
            bool whileStop = false;

            do
            {
                Console.Write("Bir harf seçiniz: ");
                chosenLetter = Console.ReadLine().ToUpper();

                for (int i = 0; i < harfler.Length; i++)
                {
                    if (chosenLetter.Length > 1 || chosenLetter.Length == 0)
                    {
                        Console.WriteLine("Yalnız Bir Harf Giriniz! \n");
                        break;
                    }
                    else if (char.Parse(chosenLetter) == harfler[i])
                    {
                        Console.WriteLine("( {0} ) Harfini Seçtiniz", chosenLetter);
                        whileStop = true;
                        RemoveLetter();
                        Console.WriteLine("\n");
                        ShowDynamicAlphabet();
                        Console.WriteLine("\n");
                        ShowAlphabet();

                        break;
                    }
                    else if (i == harfler.Length - 1)
                    {
                        Console.WriteLine("Lütfen Yalnız Harf Giriniz!  \n");
                    }
                }

            } while (whileStop == false);

        }
        static void RemoveLetter()
        {
            DynamicAlphabet();
            for (int i = 0; i < harfler.Length; i++)
            {
                if (char.Parse(chosenLetter) == harfler[i])
                {
                    dynamicHarfler[i] = ' ';
                }
                else if (char.Parse(chosenLetter) == ' ')
                {
                    Console.WriteLine("Bu harfi daha önce seçtiniz, Başka harf seçiniz \n");
                }

            }
        }

        static char[] dynamicHarfler = new char[harfler.Length];
        static void DynamicAlphabet()
        {
            for (int i = 0; i < harfler.Length; i++)
            {
                dynamicHarfler[i] = harfler[i];
            }

        }
        static void ShowDynamicAlphabet()
        {
            for (int harf = 0; harf < harfler.Length; harf++)
            {
                Console.Write("{0} ", dynamicHarfler[harf]);
                if (harf == harfler.Length / 2) Console.WriteLine("{0} ", dynamicHarfler[harf]);
            }
        }
    }
 }

