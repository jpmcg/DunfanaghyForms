using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dunfanaghy.Pages;

namespace Dunfanaghy.Helpers
{
    static class PlacesHelper
    {
        public static List<Place> GetPlaces()
        {
            var places = new List<Place>();

            GetAccommodation(places);
            GetBars(places);
            GetEatingOut(places);
            GetShops(places);
            GetBeaches(places);
            GetArea(places);
            GetLeisure(places);
            GetWalks(places);

            return places;
        }

        private static void GetWalks(List<Place> places)
        {
            places.Add(new Place
            {
                Name = "The Famine Graveyard Walk",
                ImageUrl = "graveyardwalk1.jpg",
                Category = "Walks",
                Description = new List<string>
                {
                   "Starting from the Market Square in the middle of Dunfanaghy, walk along the main N56 road towards Creelough. After about 800 metres, turn right to walk up the hill, where you walk past a small caravan site. ",
                   "Then you encounter several different graveyards, due to the history of the now ruined Clondahorkey church. Interred in the first graveyard you come to are the remains of “Wee Hannah” whose story is told in The Workhouse. ",
                   "Next to this graveyard is the Famine Graveyard. "
                }
            });

            places.Add(new Place
            {
                Name = "Horn Head Walk",
                ImageUrl = "hornheadwalk1.jpg",
                Category = "Walks",
                Description = new List<string>
                {
                   "A simple but stunning walk is from the lookout post car park at Horn Head, At the east end of the small car park, a few trodden paths can be found. Just off to your right in about 60m, you can have wonderful views -weather permitting -south east and beyond to the cliffs below the viewpoint on the main road. Turn about and follow the small trail in the direction of the Signal Tower. The Tower was built during the Napoleonic Wars to warn of possible French invasion-if you are French and reading this,you are most welcome now ! "
                }
            });

        }

        private static void GetLeisure(List<Place> places)
        {
            places.Add(new Place
            {
                Name = "Dunfanaghy Golf Club",
                ImageUrl = "golf1.jpg",
                Category = "Leisure",
                Description = new List<string>
                {
                    "Dunfanaghy Golf Links was laid out by Harry Vardon in 1905. The original 1st hole, now the 18th, still bears his name, “Vardon’s First”. The course layout has hardly changed since Vardon laid out the fairways and greens, over a century ago. Dunfanaghy is a beautiful links 18 hole course, a living slice of history."
                }
            });

            places.Add(new Place
            {
                Name = "Dunfanaghy Stables",
                ImageUrl = "horseriding1.jpg",
                Category = "Leisure",
                Description = new List<string>
                {
                   "Dunfanaghy is the perfect place to visit if you enjoy horse-riding, or indeed if you would like to try it for the first time. Trekking out across the bay at low tide, or along the beach, or out across the sand dunes to Tramore is a wonderful experience from the saddle of your horse. ",
                   "The long established Dunfanaghy Riding Stables offers a first class experience whether you are a beginner or an experienced rider. The stables are located at the rear of Arnolds hotel right in the middle of the village, and are open from Easter to Halloween. "
                }
            });
        }

        private static void GetArea(List<Place> places)
        {
            places.Add(new Place
            {
                Name = "Doe Castle",
                ImageUrl = "doecastle1.jpg",
                Category = "Area",
                Description = new List<string>
                {
                "Situated about 14 km from the village of Dunfanaghy, Doe Castle was the traditional home of the Sweeney Clan. Built during the 16th Century, it changed hands many times, and was inhabited until 1843. ",
                "Today the castle sits majestic, but empty, and roughly a decade ago major renovation work was started to restore the it, and then the restoration work stopped! And so we are left with a fully rendered Keep surrounded by rough stone walls. It does look a little strange, but, in fact, this is one of the best examples of a 16th century castle in Donegal. ",
                "Inside the Keep, great work has been done to restore the old Oak floors and staircases, and it is superbly done, but unfortunately the keepers of the Keep do not permit visitors, due to the vandalism that was done to the castle several years ago. But the good news is that in the summer of 2015, the Keep was officially reopened, and there are now tours of the castle with a guide organised every Friday, Saturday and Sunday from 11am during the summer months. "
                }
            });

            places.Add(new Place
            {
                Name = "Ards Friary",
                ImageUrl = "ardsfriary1.jpg",
                Category = "Area",
                Description = new List<string>
                {
                ""
                }
            });
            //ardsfriary1.jpg
        }

        private static void GetBeaches(List<Place> places)
        {
            places.Add(new Place
            {
                Name = "Kilahoey Beach",
                ImageUrl = "kilahoey1.jpg",
                Category = "Beaches",
                Description = new List<string>
                {
                "The closest beach to Dunfanaghy is the majestic Blue Flag Kilahoey Strand, which stretches about 1 km along the shore from Dunfanaghy. ",
                "The beach has beautiful golden sand, and is very safe for swimming, and for all water sports. During the summer months there are life guards on duty throughout the day. It is very rarely crowded. ",
                "You can access the beach by driving down the road through the golf course, which is just on the edge of the town. Or if you prefer to walk there is a little road just opposite Arnold’s hotel which leads straight onto the start of the beach. The road seems to terminate in someone’s front garden, but it is fine to just keep walking, and then go down the little path which leads onto the beach. "
                }
            });

            places.Add(new Place
            {
                Name = "Tramore",
                ImageUrl = "tramore1.jpg",
                Category = "Beaches",
                Description = new List<string>
                {
                "All over Ireland you will find beaches called “Tramore”! It is Irish and it means literally “Big Beach”, and this is no exception, as it stretches for 2 miles. ",
                "To reach Tramore head towards Horn Head, and once you cross the long low bridge look out for the signs for Car Park. From the car park walk through the gates and along the tree-lined pathway. Then follow the path for about 30 minutes walking. Enjoy a leisurely walk along this beautiful beach where the only company that you will have is that of fulmars, sanderlings and the occasional oystercatcher. ",
                "A piece of “local knowledge” - on a late spring or summer’s evening, if it is looking as though there is going to be a good sunset, a perfect way to experience it is do this walk over to Tramore! ",
                "Please note that because of very dangerous currents and rip tides, swimming from Tramore beach is NOT recommended."
                }
            });
        }

        private static void GetEatingOut(List<Place> places)
        {
            places.Add(new Place
            {
                Name = "Arnolds",
                ImageUrl = "arnolds2.jpg",
                Category = "EatingOut",
                Description = new List<string>
                {
                 "Within Arnold’s Hotel, on the main street of Dunfanaghy, are two separate restaurants, The Bistro offering a relaxed, informal setting adjacent to the bar, and The Seascape Restaurant offering a more formal setting, with superb views across Sheephaven Bay to the majestic Horn Head. ",
                 "Both restaurants offer superb food, served by friendly staff, and prepared using high quality, locally-produced ingredients. Before your meal relax before an open fire in the comfortable lounge area, or enjoy an aperitif in The Whiskey Fly Bar, then sit down to a delicious meal chosen from a menu of interesting options. All dishes are carefully prepared using the best of local produce and are presented beautifully, making your dining experience a special occasion. "
                }
            });

            places.Add(new Place
            {
                Name = "The Mill Restaurant",
                ImageUrl = "themill1.jpg",
                Category = "EatingOut",
                Description = new List<string>
                {
                 "Originally a flax mill, and then the studio and home of the acclaimed artist Frank Eggington, The Mill now houses a multi-award winning restaurant, run by the grand-daughter of the artist. ",
                 "The Mill serves high quality cuisine made from local fresh ingredients and specialising in shellfish and seafood. From the canapés served in the conservatory, through the two superb courses that constitute dinner, and back to the petits fours and coffee in the conservatory, the quality of the food and the standard of presentation is superb!! "
                }
            });
        }

        private static void GetShops(List<Place> places)
        {
            places.Add(new Place
            {
                Name = "McAulifffe's Craft Shop",
                ImageUrl = "mcauliffes1.jpg",
                Category = "Shops",
                Description = new List<string>
                {
                    "McAuliffe’s Craft Shop on the main street of Dunfanaghy is more than just a shop, it is an institution, as this family business has been in existence through three generations of the McAuliffe family, attracting people from far and wide to admire their displays, and purchase their quality Irish products. ",
                    "Many of Ireland’s distinguished designers such as Tipperary Crystal, Newbridge Silverware, Belleek, Genesis Bronzes, Kiltrea Bridge, Louis Mulcahy, Stephen Pearce and Amanda Murphy pottery are all represented in the beautiful shop displays. ",
                    "McAuliffe’s stock a vast array of fashion, pottery, handcrafts, jewellery, books, music, cards and all sorts of goodies. The shop windows are always a delight to behold, and the interior shop displays always live up to the famous McAuliffe reputation."
                }
            });

            places.Add(new Place
            {
                Name = "The Green Man",
                ImageUrl = "thegreenman1.jpg",
                Category = "Shops",
                Description = new List<string>
                {
                    "Halfway up the main street in Dunfanaghy, hidden behind a curious orange facade, and calling itself The Green Man, is what can only be described as an Aladdin’s Cave of gourmet delights. ",
                    "Here you will find every exotic ingredient you can think of, including freshly baked croissants, ciabatta and baguettes, Irish cheeses, organic herbs, spices, oils & vinegars, New and Old World wines, and not only that, for at hand is expert advice in the form of Neil, the owner, who is an ex-chef!"
                }
            });
        }

        private static void GetBars(List<Place> places)
        {
            places.Add(new Place
            {
                Name = "Patsy Dans",
                ImageUrl = "patsys1.jpg",
                Category = "Bars",
                Description = new List<string>
                {
                    "Patsy Dan’s is a small traditional pub on the main street in Dunfanaghy, with low ceilings, dark corners and a roaring turf fire. ",
                    "Patsy’s offers music on numerous nights of the week, all year round. The Traditional Sessions every Friday and Monday evenings, throughout the year, are not to be missed. Everyone welcome, and all musicians are encouraged to bring along their fiddles, their whistles, and their vocal chords. ",
                    "And, if you are feeling peckish, dont’ forget that the Rusty Oven Pizza is in the same building, so that you can enjoy a fresh wood fired oven pizza, along with your velvety pint of Guinness. "
                }
            });

            places.Add(new Place
            {
                Name = "Mollys",
                ImageUrl = "mollys1.jpg",
                Category = "Bars",
                Description = new List<string>
                {
                    "Molly’s is back in town, bigger brighter and better than ever!!",
                    "A big Welcome to Molly’s Bar in Dunfanaghy, where you are sure of a good pint, a warm fire, a big friendly welcome, and, a chance to do a small flutter as there is a facility to invest a few pounds in the horse of your choice, or your team of the moment. During the summer months, you will be able to hear some of the finest live music every night of the week - a perfect evening out!"
                }
            });

            places.Add(new Place
            {
                Name = "The Whiskey Fly",
                ImageUrl = "whiskeyfly1.jpg",
                Category = "Bars",
                Description = new List<string>
                {
                    "The Whiskey Fly Bar is an integral part of Arnold’s Hotel in the village of Dunfanaghy, and overlooking Sheephaven Bay. ",
                    "Here Derek, Gerarda and Aisling and their friendly and efficient staff will give you a superb welcome, and you can enjoy a pint of Guinness and glass of wine in comfortable surroundings, including a quiet and relaxing beer garden when the weather permits. ",
                    "Music is high up in the agenda in The Whiskey Fly, due in part to Gerarda’s interest, and indeed talent, in all things musical. Music of all genres are regularly to be found, including jazz, rock, folk, and of course regular traditional sessions."
                }
            });
        }

        private static void GetAccommodation(List<Place> places)
        {
            places.Add(new Place
            {
                Name = "Anseo B&B",
                ImageUrl = "anseo1.jpg",
                Category = "Accommodation",
                Description = new List<string>
                {
                    "Lisa in Anseo B & B has worked tirelessly to attain this recommendation. As well as offering a high standard of accomodation, what you can be sure of also is the warmest of Donegal welcomes.",
                    "This B & B is situated right on the edge of the village, a short walk from local restaurants, shops and pubs, and a 10 minute walk to the beach.",
                    "All the bedrooms are tastefully furnished, and the large bright living room offers guests the perfect space to relax and chill out after a day out enjoying all that this beautiful part of Ireland offers."
                }
            });

            places.Add(new Place
            {
                Name = "Arnolds Hotel",
                ImageUrl = "arnolds1.jpg",
                Category = "Accommodation",
                Description = new List<string>
                {
                    "In the Main Street of Dunfanaghy, overlooking the village green, and the beautiful Sheephaven Bay you will find Arnold’s Hotel.",
                    "Recently Arnold’s celebrated its 90th year of tending to the needs of visitors and locals alike. Whether it is for a room for the night, an á la carte meal, a quick snack in the bar, or a well-pulled pint of stout in the attractive Whiskey Fly Bar, you will be guaranteed a warm welcome from Derek Arnold, his family and their staff.",
                    "The hotel is an important hub for both visitors and locals in Dunfanaghy: for accommodation, food, entertainment, horse-riding, fishing, walking information, or general information about the area - the staff at Arnolds will sort you out. "
                }
            });


            places.Add(new Place
            {
                Name = "Shandon Hotel",
                ImageUrl = "shandon1.jpg",
                Category = "Accommodation",
                Description = new List<string>
                {
                    "The Shandon Hotel and Spa re-opened for business at Easter 2016. The hotel’s new proprietors have invested heavily in its refurbishment in order to bring the Shandon Hotel & Spa to a new level of luxury. ",
                    "The hotel & spa overlook the breathtakingly beautiful Sheephaven Bay and are located on the Wild Atlantic Way, being just a short drive from Dunfanaghy and Horn Head. ",
                    "This new Donegal hotel is one of the few hotels that can boast a spectacular view of the sea from every bedroom. The lobby, bar, swimming pool, thermal spa, relaxation room & outdoor Canadian hot-tub all overlook the beautiful bay, hills & countryside, so you can relax and enjoy the wonderful views no matter what you are doing. "
                }
            });
        }
    }
}
