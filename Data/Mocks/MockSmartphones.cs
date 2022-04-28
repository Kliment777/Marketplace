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
                        Img="",
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
                        Img="",
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
                        Img="",
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
                        Img="",
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
                        Img="",
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
                        Img="",
                        Price=194000,
                        IsFavourite=true,
                        Available=true,
                        Category= smartphoneCategory.AllCategories.First()


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
                        Img="",
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
                        Img="",
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
                        Img="",
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
                        Img="",
                        Price=16000,
                        IsFavourite=true,
                        Available=true,
                        Category= smartphoneCategory.AllCategories.Last()


                    },
                    new Smartphone
                    {
                        Designation ="Galaxy M32",
                        ShortDescription="White 128GB",
                        LongDescription="Samsung Galaxy M32 – стильный и удобный смартфон с 6,4-дюймовым экраном, разрешение которого" +
                        " составляет 1080 х 2400 пикселей. Дисплей, созданный на основе матрицы Super AMOLED, воспроизводит яркое, " +
                        "детализированное изображение с безупречно реалистичными цветами.",
                        Img="",
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
                        Img="",
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

