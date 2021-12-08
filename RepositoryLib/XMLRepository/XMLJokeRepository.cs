﻿using Help;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLib.XMLRepository
{
    public class XMLJokeRepository : IRepository
    {
        public XMLJokeRepository()
        {
            if (!Directory.Exists("XMLRepository"))
                Directory.CreateDirectory("XMLRepository");
            if (!File.Exists("XMLRepository/Joke"))
            {
                string[] parametrs = new string[] {
                "Едет мужик в поезде. Достает банан, посыпает его солью и выкидывает в окно. Посыпает солью и выкидывает в окно. Продолжалось так минут 10. И его сосед не выдерживает и спрашивает:\r\n" +
                "  - Мужик, ты зачем это делаешь?\r\n" +
                "  - Да я просто бананы соленые не люблю",
                "Заходит как-то афроамериканц с попугаем в бар,подходит к бармену,бармен спрашивает:\r\n" +
                "  -Где купил?\r\n" +
                "Попугай отвечает:\r\n" +
                "  -В Африке",
                "Как отличить зайца от зайчихи? Очень просто. Взять за уши и кинуть на землю, если побежал - это заяц, а если побежала - зайчиха",
                "Наркоманы такие трудяги, с утра до вечера вкалывают",
                "Когда черепашка вырастает, она становится черепавлом",
                "Что делает глухой гинеколог? Читает по губам",
                "Почему африканские купюры легко подделать? На них не водяных знаков",
                "Кого больше всего боится конная полиция? Цыган",
                "Что банан сказал вибратору? Чего трясёшься, съест то она меня",
                "Идёт мужик по лесу,видит подкова лежит, перевернул,а там конь",
                "Ученые выяснили что от классической музыки цветы растут быстрее а когда они включили около цветов панк рок то земля высохла цветы завяли а горшок умер",
                "Что ищет шепелявый пират? Фундук",
                "Гена с Чебурашкой купили косячок. Приходят домой.\r\n" +
                "Гена говорит:\r\n" +
                "  -Чебурашка, я пойду приму ванну, помоюсь немного и потом раскурим с тобой косяк. Только ты падла не кури без меня.\r\n" +
                "Чебурашка:\r\n" +
                "  -Нет Гена, ты что. Я без тебя не буду.\r\n" +
                "Ну уходит Гена в ванну. Чебурашка сел телик смотреть. Сидит делать нечего, по я щику одну хрень показывают.\r\n" +
                "Ну думает:\r\n" +
                "  -Дай я хапану немного, мол незаметит. Ну и начал курить. М.. М.. м.. И все скурил. Сидит и думает… Е-мое, меня же Гена убъет. Надо беломора затолкать.\r\n" +
                "И тут голос из ванной:\t\n" +
                "  -Чебурашка, приниси полотенце!\r\n" +
                "Бля… Полотенце. Щас спалюсь. Че делать? ТАк… так-так-так, что надо делать. Ага. Надо пойти в комнату, открыть шкаф, взять полотенце, закрыть шкаф.\r\n" +
                "А тут опять голос из ванной:\r\n" +
                "  -Чебурашка!!! Мать твою, где полотенце?\r\n" +
                "Тот весь на изводе. Че делать. Собирается с мыслями. Ну приходит в комнату…. Стоит, думает. Нахуя я сюда пришел? Опять голос из ванной.\r\n" +
                "  -Где полотенце?!А-а-а-… полотенце!!!\r\n" +
                "Подходит к шкафу, открывает дверь берет полотенце и уходит. Там Гена уже заебался ждать. Чебурашка думает, как сказать ему? Ведь щас запалит. И пиздец мне будет.\r\n" +
                "  -Так… Гена… Помнишь ты просил меня принести полотенце? Вот твое… Нет. Спалит бля. Че же делать… Геннадий, вот твое… Тьфу ты бля. почему Геннадий?\r\n" +
                "Гена:\r\n" +
                "  -Чебурашка! Ну че ты там?!\r\n" +
                "  -Все… думает Чебурашка, надо идти. Как сказать. А.. Гена на, Гена на, Гена на, Гена на ААААААА, Крокодил в ванной!!!!!!!!!!",
                "Корова лезет на дерево. Пастух её спрашивает:\r\n" +
                "  -Нахуй ты лезешь на дерево?\r\n" +
                "  -Яблоки кушать\r\n" +
                "  -Ты ебанулась? Это же берёза!\r\n" +
                "  -А у меня с собой!",
                "О чем думает зоофил с некрофильскими наклонностями? Где собака зарыта",
                "Многие считают, что тиранозавры могут хлопать из-за своих коротких лапок, но на самом деле они не могут хлопать, потому что они вымерли",
                "Инопланетяне, похищенные другими инопланетянами, чувствуют себя не в своей тарелке",
            };
                XmlFiles.Create(parametrs, "XMLRepository/Joke");
            }
            
        }

        public void Add(AskModel model)
        {
            XmlFiles.Add(model, "XMLRepository/Joke");
        }

        public string Get(int id)
        {
            return XmlFiles.Get(id, "XMLRepository/Joke");
        }
        ~XMLJokeRepository()
        {
            File.Delete("XMLRepository/Joke");
        }
    }
}
