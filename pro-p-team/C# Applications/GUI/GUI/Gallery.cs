using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.Resources.Decorations.DrinkDecorations;
using GUI.Resources.Food;
using GUI.Resources.FoodDecorator;

namespace GUI
{
    public class Gallery
    {
        //fields
        private static int productId = 0;
        private List<IProduct> listOfProductDrinks;
        private List<IProduct> listOfProductFood;
        private List<IProduct[]> listOfDecoratorDrinks;
        private List<IProduct[]> listOfDecoratorFoods;
        private PictureBox[] arrayMainOfPB;
        private PictureBox[][] arrayDecoratorOfPB;
        private PictureBox[] arrayMainFoodPB;
        private PictureBox[][] arrayDecoratorFood;
        // property
        public List<IProduct> ListOfProductDrinks
        {
            get
            {
                return listOfProductDrinks;
            }

            private set
            {
                listOfProductDrinks = value;
            }
        }

        public List<IProduct[]> ListOfDecoratorDrinks
        {
            get
            {
                return listOfDecoratorDrinks;
            }

            private set
            {
                listOfDecoratorDrinks = value;
            }
        }


        public PictureBox[][] ArrayDecoratorOfPB
        {
            get
            {
                return arrayDecoratorOfPB;
            }

            set
            {
                arrayDecoratorOfPB = value;
            }
        }

        public List<IProduct[]> ListOfDecoratorFoods
        {
            get
            {
                return listOfDecoratorFoods;
            }

            set
            {
                listOfDecoratorFoods = value;
            }
        }

        public PictureBox[] ArrayMainFoodPB
        {
            get
            {
                return arrayMainFoodPB;
            }

            set
            {
                arrayMainFoodPB = value;
            }
        }

        public PictureBox[][] ArrayDecoratorFood
        {
            get
            {
                return arrayDecoratorFood;
            }

            set
            {
                arrayDecoratorFood = value;
            }
        }

        public List<IProduct> ListOfProductFood
        {
            get
            {
                return listOfProductFood;
            }

            set
            {
                listOfProductFood = value;
            }
        }

        public PictureBox[] ArrayMainOfPB
        {
            get
            {
                return arrayMainOfPB;
            }

            set
            {
                arrayMainOfPB = value;
            }
        }



        //ctor
        public Gallery()
        {
            ListOfProductDrinks = new List<IProduct>();
            ListOfDecoratorDrinks = new List<IProduct[]>();
            ListOfDecoratorFoods = new List<IProduct[]>();
            ListOfProductFood = new List<IProduct>();
            DrinkIProductPopulation();
            FoodIProductPopulation();
            DrinkDecoratorPopulation();
            FoodDecoratorPopulation();
        }
        //Methods
        /// <summary>
        /// Populates listOfProducts with IProduct Objects and Sets the Objects productId!
        /// </summary>
        private void DrinkIProductPopulation()
        {
            ListOfProductDrinks.AddRange(new IProduct[] { new Coffie(), new Whisky(), new Bear(), new Cola(), new Juice(), new Peps(), new Rakia(), new Smoothy(), new Soda(), new Tea(), new Vodka(), new Water() });
            ArrayMainOfPB = new PictureBox[ListOfProductDrinks.Count];
            for (short i = 0; i < ListOfProductDrinks.Count; i++)
            {
                ArrayMainOfPB[i] = new PictureBox();
                ListOfProductDrinks[i].ProductId(productId++);
            }
        }
        private void FoodIProductPopulation()
        {
            ListOfProductFood.AddRange(new IProduct[] { new Burger(), new Pizza(), new Sandwitch(), new Snacks() });
            ArrayMainFoodPB = new PictureBox[ListOfProductFood.Count];
            for (short i = 0; i < ArrayMainFoodPB.Length; i++)
            {
                ArrayMainFoodPB[i] = new PictureBox();
                ListOfProductFood[i].ProductId(productId++);
            }
        }
        /// <summary>
        /// Populates the listOfDecorators with IProduct objects 
        /// </summary>
        /// <returns></returns>
        private void DrinkDecoratorPopulation()
        {
            ArrayDecoratorOfPB = new PictureBox[12][];
            for (short i = 0; i < 12; i++)
            {
                switch (i)
                {
                    case 0:
                        ListOfDecoratorDrinks.Add(new Decorator[] { new CoffeeAmericano(ListOfProductDrinks[i]), new CoffeeBlack(ListOfProductDrinks[i]), new CoffeeCappuccino(ListOfProductDrinks[i]), new CoffeeDryCappuccino(ListOfProductDrinks[i]), new CoffeeEspresso(ListOfProductDrinks[i]), new CoffeeBlack(ListOfProductDrinks[i]), new CoffeeFrappe(ListOfProductDrinks[i]), new CoffeeLatte(ListOfProductDrinks[i]), new CoffeeMacchiato(ListOfProductDrinks[i]), new CoffeeMocha(ListOfProductDrinks[i]), new CoffeeWhite(ListOfProductDrinks[i]) });
                        break;
                    case 1:
                        ListOfDecoratorDrinks.Add(new Decorator[] { new Apple(ListOfProductDrinks[i]), new Apricot(ListOfProductDrinks[i]), new Banana(ListOfProductDrinks[i]), new Carbonation(ListOfProductDrinks[i]), new Cherry(ListOfProductDrinks[i]), new Grape(ListOfProductDrinks[i]), new Kiwi(ListOfProductDrinks[i]), new Mango(ListOfProductDrinks[i]), new Olive(ListOfProductDrinks[i]), new Orange(ListOfProductDrinks[i]), new Pineapple(ListOfProductDrinks[i]) });
                        break;
                    case 2:
                        ListOfDecoratorDrinks.Add(new Decorator[] { new BearDark(ListOfProductDrinks[i]), new BeerAmber(ListOfProductDrinks[i]), new BeerBrown(ListOfProductDrinks[i]), new BeerCream(ListOfProductDrinks[i]), new BeerLagers(ListOfProductDrinks[i]), new BeerMalts(ListOfProductDrinks[i]) });
                        break;
                    case 3:
                        ListOfDecoratorDrinks.Add(new Decorator[] { new CocaColaLife(ListOfProductDrinks[i]), new CocacolaLight(ListOfProductDrinks[i]), new CocaColaZero(ListOfProductDrinks[i]) });
                        break;
                    case 4:
                        ListOfDecoratorDrinks.Add(new Decorator[] { new Apple(ListOfProductDrinks[i]), new Apricot(ListOfProductDrinks[i]), new Banana(ListOfProductDrinks[i]), new Carbonation(ListOfProductDrinks[i]), new Cherry(ListOfProductDrinks[i]), new Grape(ListOfProductDrinks[i]), new Kiwi(ListOfProductDrinks[i]), new Mango(ListOfProductDrinks[i]), new Olive(ListOfProductDrinks[i]), new Orange(ListOfProductDrinks[i]), new Pineapple(ListOfProductDrinks[i]) });
                        break;
                    case 5:
                        ListOfDecoratorDrinks.Add(new Decorator[] { new PepsiSummerChill(ListOfProductDrinks[i]), new PepsiTwist(ListOfProductDrinks[i]), new PepsiWhite(ListOfProductDrinks[i]) });
                        break;
                    case 6:
                        ListOfDecoratorDrinks.Add(new Decorator[] { new Apple(ListOfProductDrinks[i]), new Apricot(ListOfProductDrinks[i]), new Banana(ListOfProductDrinks[i]), new Carbonation(ListOfProductDrinks[i]), new Cherry(ListOfProductDrinks[i]), new Grape(ListOfProductDrinks[i]), new Kiwi(ListOfProductDrinks[i]), new Mango(ListOfProductDrinks[i]), new Olive(ListOfProductDrinks[i]), new Orange(ListOfProductDrinks[i]), new Pineapple(ListOfProductDrinks[i]) });
                        break;
                    case 7:
                        ListOfDecoratorDrinks.Add(new Decorator[] { new Apple(ListOfProductDrinks[i]), new Apricot(ListOfProductDrinks[i]), new Banana(ListOfProductDrinks[i]), new Carbonation(ListOfProductDrinks[i]), new Cherry(ListOfProductDrinks[i]), new Grape(ListOfProductDrinks[i]), new Kiwi(ListOfProductDrinks[i]), new Mango(ListOfProductDrinks[i]), new Olive(ListOfProductDrinks[i]), new Orange(ListOfProductDrinks[i]), new Pineapple(ListOfProductDrinks[i]) });
                        break;
                    case 8:
                        ListOfDecoratorDrinks.Add(new Decorator[] { new Apple(ListOfProductDrinks[i]), new Apricot(ListOfProductDrinks[i]), new Banana(ListOfProductDrinks[i]), new Carbonation(ListOfProductDrinks[i]), new Cherry(ListOfProductDrinks[i]), new Grape(ListOfProductDrinks[i]), new Kiwi(ListOfProductDrinks[i]), new Mango(ListOfProductDrinks[i]), new Olive(ListOfProductDrinks[i]), new Orange(ListOfProductDrinks[i]), new Pineapple(ListOfProductDrinks[i]) });
                        break;
                    case 9:
                        ListOfDecoratorDrinks.Add(new Decorator[] { new Apple(ListOfProductDrinks[i]), new Apricot(ListOfProductDrinks[i]), new Banana(ListOfProductDrinks[i]), new Carbonation(ListOfProductDrinks[i]), new Cherry(ListOfProductDrinks[i]), new Grape(ListOfProductDrinks[i]), new Kiwi(ListOfProductDrinks[i]), new Mango(ListOfProductDrinks[i]), new Olive(ListOfProductDrinks[i]), new Orange(ListOfProductDrinks[i]), new Pineapple(ListOfProductDrinks[i]) });
                        break;
                    case 10:
                        ListOfDecoratorDrinks.Add(new Decorator[] { new Apple(ListOfProductDrinks[i]), new Apricot(ListOfProductDrinks[i]), new Banana(ListOfProductDrinks[i]), new Carbonation(ListOfProductDrinks[i]), new Cherry(ListOfProductDrinks[i]), new Grape(ListOfProductDrinks[i]), new Kiwi(ListOfProductDrinks[i]), new Mango(ListOfProductDrinks[i]), new Olive(ListOfProductDrinks[i]), new Orange(ListOfProductDrinks[i]), new Pineapple(ListOfProductDrinks[i]) });
                        break;
                    case 11:
                        ListOfDecoratorDrinks.Add(new Decorator[] { new Apple(ListOfProductDrinks[i]), new Apricot(ListOfProductDrinks[i]), new Banana(ListOfProductDrinks[i]), new Carbonation(ListOfProductDrinks[i]), new Cherry(ListOfProductDrinks[i]), new Grape(ListOfProductDrinks[i]), new Kiwi(ListOfProductDrinks[i]), new Mango(ListOfProductDrinks[i]), new Olive(ListOfProductDrinks[i]), new Orange(ListOfProductDrinks[i]), new Pineapple(ListOfProductDrinks[i]) });
                        break;
                    default:
                        ListOfDecoratorDrinks.Add(new Decorator[] { new Apple(ListOfProductDrinks[i]), new Apricot(ListOfProductDrinks[i]), new Banana(ListOfProductDrinks[i]), new Carbonation(ListOfProductDrinks[i]), new Cherry(ListOfProductDrinks[i]), new Grape(ListOfProductDrinks[i]), new Kiwi(ListOfProductDrinks[i]), new Mango(ListOfProductDrinks[i]), new Olive(ListOfProductDrinks[i]), new Orange(ListOfProductDrinks[i]), new Pineapple(ListOfProductDrinks[i]) });
                        break;
                }
                ArrayDecoratorOfPB[i] = new PictureBox[ListOfDecoratorDrinks[i].Length];
                for (short j = 0; j < ArrayDecoratorOfPB[i].Length; j++)
                {
                    ArrayDecoratorOfPB[i][j] = new PictureBox();
                    ListOfDecoratorDrinks[i][j].ProductId(productId++);
                }
            }
        }
        private void FoodDecoratorPopulation()
        {
            ArrayDecoratorFood = new PictureBox[ListOfProductFood.Count][];
            for (short i = 0; i < ListOfProductFood.Count; i++)
            {
                ListOfDecoratorFoods.Add(new Decorator[] { new Bacon(ListOfProductFood[i]), new Cheese(ListOfProductFood[i]), new Chicken(ListOfProductFood[i]), new Eggs(ListOfProductFood[i]), new Fries(ListOfProductFood[i]), new Garlick(ListOfProductFood[i]), new Unien(ListOfProductFood[i]), new Choriso(ListOfProductFood[i]) });
                ArrayDecoratorFood[i] = new PictureBox[ListOfDecoratorFoods[i].Length];
                for (short j = 0; j < ArrayDecoratorFood[i].Length; j++)
                {
                    ArrayDecoratorFood[i][j] = new PictureBox();
                    ListOfDecoratorFoods[i][j].ProductId(productId++);
                }
            }
        }


    }
}
