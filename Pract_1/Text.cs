﻿using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Pract_1
{

    public partial class Nova : Form
    {

        #region Music
        public void MusicFromResource()
        {
            using (MemoryStream fileOut = new MemoryStream(Properties.Resources.Mass))
            using (GZipStream gz = new GZipStream(fileOut, CompressionMode.Decompress))
            {
                soundPlayer.Stream = gz;
                soundPlayer.Load();
                soundPlayer.Play();
            }
        }

        public void StopMusic()
        {
            soundPlayer.Stop();
        }

        #endregion

        #region Анимированый текст

        private int currentCharIndex = 0;
        private string animationText = "";

        private void StartTextAnimation(string text)
        {
            currentCharIndex = 0;
            animationText = text;
            text1.Text = "";       // Очистка текстового поля перед началом анимации
            AnimateText();   // Запуск
        }

        private async void AnimateText()
        {
            if (currentCharIndex < animationText.Length)
            {
                text1.Text += animationText[currentCharIndex]; // Добавка символа к текстовому полю
                currentCharIndex++;                            // Увеличивание индекса символа для следующей итерации
                await Task.Delay(40);                          // Интервал
                AnimateText();                                  // Вызов для следующего символа
            }
        }

        private void TextAnimation(object sender, EventArgs e)
        {                     
            StartTextAnimation(GetTextForAnimation());  // Вызов метода StartTextAnimation с текстом для анимации
        }

        // Метод, который возвращает текст
        private string GetTextForAnimation()
            {

            if (story == 1)
            {
                return "Нажмите клавижу мыши для продолжения...";

            }
            else if (story == 2)
            {
                return "Так выглядит наш мир после катастрофы...\n" +
                    "Понимаю у тебя много вопросов, но ты узнаешь обо всём позже.";

            }
            else if (story == 3)
            {
                return "Я расскажу тебе одну историю, весёлая она или грустная ты сам решишь."; 
            }
            else if (story == 4)
            {
                return "АКТ 1\n Туман";
            }
            else if (story == 5)
            {
                return "Я в полуразрушеном доме, - это первое о чём подумал тогда. " +
                    "Быстро пробежавшись взглядом по дому и не увидев ничего интересного я попытался вспомнить что случилось. " +
                    "И тут почувствовав сильную боль в голове я невольно прищурился.";
            }
            else if (story == 6)
            {
                return "Неожиданно в дом зашла невысокая фигура, " +
                    "сквозь свет за ней было плохо видно кто это. " +
                    "Однако мне удалось разглядеть человека в костюме учёного.";
            }
            else if (story == 7)
            {
                return "Ты как? Очнулся уже?";
            }
            else if (story == 8)
            {
                return " \n" +
                    "1. *Сделать вид, что еще сплю...*\n" +

                    "2. Кто ты? Где я? Что произошло?\n" +

                    "3. *Напасть на человека*\n";
            }
            else if (story == 101)
            {
                return "Тогда оставлю тебя ещё ненадолго";
            }
            else if (story == 102)
            {
                return "*Некоторое время спустя незнакомец возвращается*";
            }            
            else if (story == 9)
            {
                    return "Для начала меня Иваном звать, можешь просто Ваня. " +
                    "Мы с группой нашли тебя после тумана. То что ты жив никак чудо, но... " +
                    "Об этом потом поговорим, есть будешь?";
            }
            if (story == 201)
            {
                    return "*Незнакомец быстро достает пистолет и делает 2 выстрела в упор*";
            }
            if (story == 10)
            {
                return "*Медленно вставая с дивана*\n Да. Только отойду немного, проветрюсь."; ;
            }
            if (story == 11)
            {
                return "Ваня вышел из дома и пошёл к костру на улице.\n" +
                    "А я опять оглянувшись вокруг и не увидев ничего интересного вышел на улицу*\n";            
            }
            if (story == 12)
            {
                return "...";
            }
            if (story == 13)
            {
                return "Пасмурный день, окутанный мраком и печалью. Разрушеные дома, небо серое и угрюмое. \n" +
                    "Недалеко слышны звуки коста и спокойный разговор 3 незнакомых мне людей. ";
            }
            if (story == 14)
            {
                return "Я направился неспеша к костру всё  пытаясь вспонить кто я и как тут оказался. " +
                    "Завидев меня разговор незнакомцев затих.";
            }
            if (story == 15)
            {
                return "Ну, здарова, я тут главный Шрамом кличут, а этого Тихоном зовут. " +
                    "Ты давай ешь, а потом расскажешь что с тобой приключилось.\n " +
                    "Незнакомец протягивает банку с едой";
            }
            if (story == 16)
            {
                return "1. Отказаться. \n" +
                    "2. Взять еду.";
            }
            if (story == 17)
            {
                return "Видимо не зря тихоном назвали, - подумал я. И принялся за трапезу. " +
                    "Что ж, по вкусу она была такая же как и на вид... " +
                    "Отвратная, правда выбирать не приходиться";
            }
            if (story == 18)
            {
                return "Уставившись на костёр я быстро доел всё что было в жестянке";
            }
            if (story == 19)
            {
                return "Рассказывай кто ты? Откуда ты? Звать как?";
            }
            if (story == 20)
            {
                return "Я бы и сам рад, да вот непомню ничерта. " +
                    "Ни кто я, ни откуда, помню что по пустошам да заброшкам скитаюсь да наёмником подрабатываю. " +
                    "А как тут оказался и что до этого было никак вспомнить немогу.";
            }
            if (story == 21)
            {
                return "Хм... *Шрам пожал плечами* Понимаю... Врать думаю смысла тебе нет. " +
                    "Но вот что скажи, как ты выжил после тумана? Ведь ни одна живая душа ещё не возвращалась после него.";
            }
            if (story == 22)
            {
                return "После тумана?";
            }
            if (story == 23)
            {
                return "Ну да. Мы нашли тебя лежащим без сознания рано утром посреди путоши. " +
                    "Вначале думали что ты мёртв но подойдя увидели твою дрожь, " +
                    "ещё ты бубнел что то под нос но нито так ничего и не разобрал. " +
                    "В итоге решили тебя до безопасного места отнести да разузнать откуда ты такой взялся. ";
            }
            if (story == 24)
            {
                return "Я пожал плечами. Если бы помнил может быть и рассказал бы им, а так, даже вспомнить не могу";
            }


            if (story == 1000)
            {
                return "ПОМЕР";
            }
            return string.Empty; 
            }

        #endregion

    }
}


