using System.Collections.Generic;
using System.Linq;
using System;
using Мarketplace.Data.Interfaces;
using Мarketplace.Data.Models;

namespace Мarketplace.Data.Mocks
{
    public class MockSmartphones : IAllSmartphones
    {
        private readonly ISmartphoneCategory smartphoneCategory = new MockCategory();
        public IEnumerable<Smartphone> Smartphones
        {
            get
            {
                return new List<Smartphone>
                {
                    new Smartphone
                    {
                        Designation ="iPhone 11",
                        ShortDescription="Yellow 64GB",
                        LongDescription="Дисплей Liquid Retina HD ЖК‑дисплей Multi-Touch с технологией IPS," +
                        " на всю переднюю панель, диагональ 6,1 дюйма 1792×828 пикселей, 326 пикселей на дюйм" +
                        " Контрастность 1400:1 (стандартная)Технология True Tone Широкий цветовой охват (P3) " +
                        "Тактильный отклик при нажатии Яркость до 625 кд/м² (стандартная) Олеофобное покрытие," +
                        " устойчивое к появлению следов от пальцев",
                        Img="https://img.mvideo.ru/Big/30052945bb.jpg",
                        Price=54000,
                        IsFavourite=true,
                        Available=true,
                        Category= smartphoneCategory.AllCategories.First()


                    },
                    new Smartphone
                    {
                        Designation ="iPhone 12",
                        ShortDescription="White 128GB",
                        LongDescription="iPhone 12 поражает возможностями. A14 Bionic, самый быстрый процессор" +
                        " iPhone. Новая система двух камер. И великолепный дисплей Super Retina XDR, на котором" +
                        " видно каждую деталь.",
                        Img="https://img.mvideo.ru/Big/30052886bb1.jpg",
                        Price=74000,
                        IsFavourite=true,
                        Available=true,
                        Category= smartphoneCategory.AllCategories.First()


                    },
                    new Smartphone
                    {
                        Designation ="iPhone 13 Pro Max",
                        ShortDescription="Gold 128GB",
                        LongDescription="iPhone 13 Pro Max. Грандиозный апгрейд камер Pro. Режим " +
                        "«Киноэффект» делает из видео настоящее кино. Дисплей Super Retina XDR с " +
                        "технологией ProMotion для более быстрого и плавного взаимодействия. А15 Bionic" +
                        " — самый быстрый чип для iPhone. Прочный корпус и самое долгое время работы без" +
                        " подзарядки среди iPhone",
                        Img="https://img.mvideo.ru/Big/30059073bb.jpg",
                        Price=164000,
                        IsFavourite=true,
                        Available=true,
                        Category= smartphoneCategory.AllCategories.First()


                    },
                    new Smartphone
                    {
                        Designation ="iPhone 13",
                        ShortDescription="Red 128GB",
                        LongDescription="iPhone 13. Самая совершенная система двух камер на iPhone." +
                        " Режим «Киноэффект» делает из видео настоящее кино. Супербыстрый чип A15 Bionic." +
                        " Неутомимый аккумулятор. Прочный корпус. И ещё более яркий дисплей Super Retina XDR.",
                        Img="https://img.mvideo.ru/Big/30059049bb.jpg",
                        Price=89000,
                        IsFavourite=true,
                        Available=true,
                        Category= smartphoneCategory.AllCategories.First()


                    },
                    new Smartphone
                    {
                        Designation ="iPhone 13 mini",
                        ShortDescription="Midnight 512GB",
                        LongDescription="iPhone 13 mini. Самая совершенная система двух камер на iPhone." +
                        " Режим «Киноэффект» делает из видео настоящее кино. Супербыстрый чип A15 Bionic." +
                        " Неутомимый аккумулятор. Прочный корпус. И ещё более яркий дисплей Super Retina XDR.",
                        Img="https://img.mvideo.ru/Big/30059016bb.jpg",
                        Price=109000,
                        IsFavourite=true,
                        Available=true,
                        Category= smartphoneCategory.AllCategories.First()


                    },
                    new Smartphone
                    {
                        Designation ="iPhone 13 Pro",
                        ShortDescription="Silver 512GB",
                        LongDescription="iPhone 13 Pro Max. Грандиозный апгрейд камер Pro. Режим " +
                        "«Киноэффект» делает из видео настоящее кино. Дисплей Super Retina XDR с " +
                        "технологией ProMotion для более быстрого и плавного взаимодействия. А15 Bionic" +
                        " — самый быстрый чип для iPhone. Прочный корпус и самое долгое время работы без" +
                        " подзарядки среди iPhone",
                        Img="https://img.mvideo.ru/Big/30059060bb.jpg",
                        Price=194000,
                        IsFavourite=true,
                        Available=true,
                        Category= smartphoneCategory.AllCategories.First()


                    },
                    new Smartphone
                    {
                        Designation ="HUAWEI P Smart 2021",
                        ShortDescription="Midnight Black 128 GB",
                        LongDescription="Huawei P Smart 2021 – стильный смартфон в прочном пластиковом корпусе со специальным покрытием." +
                        " Поверхность устойчива к механическим повреждениям, поэтому девайс сохранит свой первоначальный вид надолго, даже" +
                        " если вы будете пользоваться им без чехла.",
                        Img="https://img.mvideo.ru/Big/30053814bb2.jpg",
                        Price=16990,
                        IsFavourite=true,
                        Available=true,
                        Category= smartphoneCategory.AllCategories.ElementAt(2)


                    },
                    new Smartphone
                    {
                        Designation ="HUAWEI P50 Pro",
                        ShortDescription="Cocoa Gold 128GB",
                        LongDescription="Huawei P50 Pro — смартфон премиум-класса, в котором установлен восьмиядерный процессор Qualcomm Snapdragon" +
                        " 888. Он работает под управлением фирменной операционной системы Android EMUI 12. В этой модели не поддерживаются сервисы " +
                        "Google, но все необходимые программы и приложения можно найти в AppGallery.",
                        Img="https://img.mvideo.ru/Big/30061579bb1.jpg",
                        Price=114000,
                        IsFavourite=true,
                        Available=true,
                        Category= smartphoneCategory.AllCategories.ElementAt(2)


                    },
                    new Smartphone
                    {
                        Designation ="HUAWEI nova 9",
                        ShortDescription="Starry Blue",
                        LongDescription="Huawei nova 9 – стильный смартфон с ультратонким корпусом, толщина которого составляет всего 7,77 мм.6,57-дюймовый" +
                        " дисплей, созданный по технологии OLED, не просто занимает почти всю лицевую поверхность. Он ещё и закруглён на грани. Его разрешение" +
                        " составляет 2340 х 1080 пикселей, а частота обновления – 120 Гц. Это значит, что изображение будет ярким, реалистичным и детализированным," +
                        " а плавность в динамичных сценах порадует самого требовательного пользователя.",
                        Img="https://img.mvideo.ru/Big/30060084bb1.jpg",
                        Price=42000,
                        IsFavourite=true,
                        Available=true,
                        Category= smartphoneCategory.AllCategories.ElementAt(2)


                    },
                    new Smartphone
                    {
                        Designation ="HUAWEI nova 8i",
                        ShortDescription="Interstellar Blue 128GB",
                        LongDescription="Сердце модели – восьмиядерный процессор Qualcomm Snapdragon 662. Он работает при поддержке солидного объёма оперативной памяти" +
                        " и быстро запускает не только повседневные приложения, но и ресурсоёмкие игры. Аккумулятор 4300 мАч позволяет долго обходиться без подзарядки.",
                        Img="https://img.mvideo.ru/Big/30059394bb1.jpg",
                        Price=22000,
                        IsFavourite=true,
                        Available=true,
                        Category= smartphoneCategory.AllCategories.ElementAt(2)


                    },
                    new Smartphone
                    {
                        Designation ="HUAWEI P40",
                        ShortDescription="Silver Frost 128GB",
                        LongDescription="Смартфон Huawei P40 подойдёт тем, кто любит много фотографировать и выкладывать оригинальные снимки в социальные сети. Тройная камера" +
                        " Leica и двойной фронтальный модуль позволят получить кадры отличного качества в любой ситуации. Объёмные панорамы, детализированная макросъёмка," +
                        " портреты и селфи с точной и естественной цветопередачей – им всё по плечу.",
                        Img="https://img.mvideo.ru/Big/30048587bb1.jpg",
                        Price=44000,
                        IsFavourite=true,
                        Available=true,
                        Category= smartphoneCategory.AllCategories.ElementAt(2)


                    },
                    new Smartphone
                    {
                        Designation ="HUAWEI Y5p",
                        ShortDescription="Mint Green 32GB",
                        LongDescription="Huawei Y5p – стильный и производительный смартфон на основе восьмиядерного процессора Mediatek MT6762R и 2 Гб оперативной памяти." +
                        " Девайс легко справляется с любыми задачами – от рабочих до развлекательных.",
                        Img="https://img.mvideo.ru/Big/30049820bb2.jpg",
                        Price=8000,
                        IsFavourite=true,
                        Available=true,
                        Category= smartphoneCategory.AllCategories.ElementAt(2)
                    },
                    new Smartphone
                    {
                        Designation ="Samsung Galaxy S21FE",
                        ShortDescription="Light Green 128GB",
                        LongDescription="Samsung Galaxy S21 FE оборудован 6,4-дюймовым экраном с поддержкой" +
                        " технологии Dynamic Amoled 2X для яркой и сочной цветовой гаммы, а также разрешением" +
                        " 2340 x 1080 пикселей. Частота обновления достигает 120 Гц, что обеспечивает максимально" +
                        " плавную анимацию и воспроизведение контента. В верхней части расположен вырез для " +
                        "32-мегапиксельной селфи-камеры.",
                        Img="https://img.mvideo.ru/Big/30061115bb.jpg",
                        Price=59000,
                        IsFavourite=true,
                        Available=true,
                        Category= smartphoneCategory.AllCategories.Last()


                    },
                    new Smartphone
                    {
                        Designation ="Samsung Galaxy S20 FE",
                        ShortDescription="Violet 128GB",
                        LongDescription="Корпус этой модели выполнен из усиленного поликарбоната и надёжно защищает" +
                        " внутренние микросхемы. Его сложно случайно поцарапать или сломать, поэтому даже при пользовании" +
                        " девайсом без чехла его привлекательный внешний вид сохранится на протяжении всего срока службы.",
                        Img="https://img.mvideo.ru/Big/30056958bb.jpg",
                        Price=45000,
                        IsFavourite=true,
                        Available=true,
                        Category= smartphoneCategory.AllCategories.Last()


                    },
                    new Smartphone
                    {
                        Designation ="Samsung Galaxy A52",
                        ShortDescription="Awesome Black 256GB",
                        LongDescription="64-мегапиксельная матрица, светосильный объектив и оптическая стабилизация творят" +
                        " чудеса – вы получаете чёткие детализированные кадры при ярком солнечном свете и в полной темноте." +
                        " Смартфон также умеет делать портреты с эффектом боке, широкоугольные панорамы и макрофотографии." +
                        " А ещё он может снимать видео на уровне экшн-камеры, передавая естественные движения в динамичных сценах.",
                        Img="https://img.mvideo.ru/Big/30056206bb.jpg",
                        Price=39000,
                        IsFavourite=true,
                        Available=true,
                        Category= smartphoneCategory.AllCategories.Last()


                    },
                    new Smartphone
                    {
                        Designation ="Samsung Galaxy A12",
                        ShortDescription="Blue 128GB",
                        LongDescription="Фирменный процессор Exynos 850 обеспечивает быстрый запуск и плавную работу игр и приложений." +
                        " Приложение Samsung Members помогает оптимизировать настройки и распределить ресурсы системы для эффективного" +
                        " решения любых, даже самых сложных задач.",
                        Img="https://img.mvideo.ru/Big/30058492bb.jpg",
                        Price=16000,
                        IsFavourite=true,
                        Available=true,
                        Category= smartphoneCategory.AllCategories.Last()


                    },
                    new Smartphone
                    {
                        Designation ="Samsung Galaxy M32",
                        ShortDescription="White 128GB",
                        LongDescription="Samsung Galaxy M32 – стильный и удобный смартфон с 6,4-дюймовым экраном, разрешение которого" +
                        " составляет 1080 х 2400 пикселей. Дисплей, созданный на основе матрицы Super AMOLED, воспроизводит яркое, " +
                        "детализированное изображение с безупречно реалистичными цветами.",
                        Img="https://img.mvideo.ru/Big/30058242bb.jpg",
                        Price=27000,
                        IsFavourite=true,
                        Available=true,
                        Category= smartphoneCategory.AllCategories.Last()


                    },
                    new Smartphone
                    {
                        Designation ="Samsung Galaxy M52",
                        ShortDescription="Black 128GB",
                        LongDescription="Samsung Galaxy M52 – функциональный и мощный смартфон со стильным минималистичным дизайном" +
                        " и очень тонким корпусом. За высокую производительность в самых сложных сценариях отвечает восьмиядерный " +
                        "процессор флагманского уровня и оперативка 6 Гб, которая в зависимости от стиля использования способна " +
                        "расширяться виртуально на целых 4 Гб.",
                        Img="https://img.mvideo.ru/Big/30059562bb.jpg",
                        Price=34000,
                        IsFavourite=true,
                        Available=true,
                        Category= smartphoneCategory.AllCategories.Last()


                    }

                };

            }
        }


        public IEnumerable<Smartphone> GetFavoritSmartphone
        {
            get;
            set;
        }

        public Smartphone GetObjectSmartphone(int smartphoneId)
        {
            throw new System.NotImplementedException();
        }

    }
}

