using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CDM1._1.Models
{
    public class StyleDbInitializer : DropCreateDatabaseAlways<StyleContext>
    {
        protected override void Seed(StyleContext db)
        {
            db.StyleType.Add(new StyleType { countSelect = 0, name = "American" });
            db.StyleType.Add(new StyleType { countSelect = 0, name = "Asian" });
            db.StyleType.Add(new StyleType { countSelect = 0, name = "Classic" });
            db.StyleType.Add(new StyleType { countSelect = 0, name = "Country" });
            db.StyleType.Add(new StyleType { countSelect = 0, name = "Eclectic" });
            db.StyleType.Add(new StyleType { countSelect = 0, name = "Industrial" });
            db.StyleType.Add(new StyleType { countSelect = 0, name = "Maritime" });
            db.StyleType.Add(new StyleType { countSelect = 0, name = "Mediterranean" });
            db.StyleType.Add(new StyleType { countSelect = 0, name = "Modern" });
            db.StyleType.Add(new StyleType { countSelect = 0, name = "Retro" });
            db.StyleType.Add(new StyleType { countSelect = 0, name = "Rustic" });
            db.StyleType.Add(new StyleType { countSelect = 0, name = "Scandinavian" });
            db.StyleType.Add(new StyleType { countSelect = 0, name = "Tropical" });

            db.StyleItems.Add(new StyleItems { parentId = 1, view = 0, path = "/img/American/american1.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 1, view = 0, path = "/img/American/american2.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 1, view = 0, path = "/img/American/american3.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 1, view = 0, path = "/img/American/american4.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 1, view = 0, path = "/img/American/american5.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 1, view = 0, path = "/img/American/american6.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 1, view = 0, path = "/img/American/american7.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 1, view = 0, path = "/img/American/american8.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 1, view = 0, path = "/img/American/american9.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 1, view = 0, path = "/img/American/american10.jpg" });

            db.StyleItems.Add(new StyleItems { parentId = 2, view = 0, path = "/img/Asian/asian1.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 2, view = 0, path = "/img/Asian/asian2.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 2, view = 0, path = "/img/Asian/asian3.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 2, view = 0, path = "/img/Asian/asian4.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 2, view = 0, path = "/img/Asian/asian5.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 2, view = 0, path = "/img/Asian/asian6.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 2, view = 0, path = "/img/Asian/asian7.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 2, view = 0, path = "/img/Asian/asian8.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 2, view = 0, path = "/img/Asian/asian9.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 2, view = 0, path = "/img/Asian/asian10.jpg" });

            db.StyleItems.Add(new StyleItems { parentId = 3, view = 0, path = "/img/Classic/classic1.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 3, view = 0, path = "/img/Classic/classic2.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 3, view = 0, path = "/img/Classic/classic3.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 3, view = 0, path = "/img/Classic/classic4.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 3, view = 0, path = "/img/Classic/classic5.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 3, view = 0, path = "/img/Classic/classic6.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 3, view = 0, path = "/img/Classic/classic7.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 3, view = 0, path = "/img/Classic/classic8.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 3, view = 0, path = "/img/Classic/classic9.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 3, view = 0, path = "/img/Classic/classic10.jpg" });

            db.StyleItems.Add(new StyleItems { parentId = 4, view = 0, path = "/img/Country/country1.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 4, view = 0, path = "/img/Country/country2.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 4, view = 0, path = "/img/Country/country3.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 4, view = 0, path = "/img/Country/country4.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 4, view = 0, path = "/img/Country/country5.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 4, view = 0, path = "/img/Country/country6.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 4, view = 0, path = "/img/Country/country7.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 4, view = 0, path = "/img/Country/country8.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 4, view = 0, path = "/img/Country/country9.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 4, view = 0, path = "/img/Country/country10.jpg" });

            db.StyleItems.Add(new StyleItems { parentId = 5, view = 0, path = "/img/Eclectic/eclectic1.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 5, view = 0, path = "/img/Eclectic/eclectic2.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 5, view = 0, path = "/img/Eclectic/eclectic3.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 5, view = 0, path = "/img/Eclectic/eclectic4.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 5, view = 0, path = "/img/Eclectic/eclectic5.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 5, view = 0, path = "/img/Eclectic/eclectic6.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 5, view = 0, path = "/img/Eclectic/eclectic7.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 5, view = 0, path = "/img/Eclectic/eclectic8.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 5, view = 0, path = "/img/Eclectic/eclectic9.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 5, view = 0, path = "/img/Eclectic/eclectic10.jpg" });

            db.StyleItems.Add(new StyleItems { parentId = 6, view = 0, path = "/img/Industrial/industrial1.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 6, view = 0, path = "/img/Industrial/industrial2.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 6, view = 0, path = "/img/Industrial/industrial3.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 6, view = 0, path = "/img/Industrial/industrial4.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 6, view = 0, path = "/img/Industrial/industrial5.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 6, view = 0, path = "/img/Industrial/industrial6.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 6, view = 0, path = "/img/Industrial/industrial7.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 6, view = 0, path = "/img/Industrial/industrial8.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 6, view = 0, path = "/img/Industrial/industrial9.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 6, view = 0, path = "/img/Industrial/industrial10.jpg" });

            db.StyleItems.Add(new StyleItems { parentId = 7, view = 0, path = "/img/Maritime/maritime1.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 7, view = 0, path = "/img/Maritime/maritime2.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 7, view = 0, path = "/img/Maritime/maritime3.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 7, view = 0, path = "/img/Maritime/maritime4.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 7, view = 0, path = "/img/Maritime/maritime5.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 7, view = 0, path = "/img/Maritime/maritime6.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 7, view = 0, path = "/img/Maritime/maritime7.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 7, view = 0, path = "/img/Maritime/maritime8.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 7, view = 0, path = "/img/Maritime/maritime9.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 7, view = 0, path = "/img/Maritime/maritime10.jpg" });

            db.StyleItems.Add(new StyleItems { parentId = 8, view = 0, path = "/img/Mediterranean/mediterranean1.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 8, view = 0, path = "/img/Mediterranean/mediterranean2.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 8, view = 0, path = "/img/Mediterranean/mediterranean3.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 8, view = 0, path = "/img/Mediterranean/mediterranean4.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 8, view = 0, path = "/img/Mediterranean/mediterranean5.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 8, view = 0, path = "/img/Mediterranean/mediterranean6.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 8, view = 0, path = "/img/Mediterranean/mediterranean7.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 8, view = 0, path = "/img/Mediterranean/mediterranean8.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 8, view = 0, path = "/img/Mediterranean/mediterranean9.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 8, view = 0, path = "/img/Mediterranean/mediterranean10.jpg" });

            db.StyleItems.Add(new StyleItems { parentId = 9, view = 0, path = "/img/Modern/modern1.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 9, view = 0, path = "/img/Modern/modern2.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 9, view = 0, path = "/img/Modern/modern3.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 9, view = 0, path = "/img/Modern/modern4.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 9, view = 0, path = "/img/Modern/modern5.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 9, view = 0, path = "/img/Modern/modern6.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 9, view = 0, path = "/img/Modern/modern7.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 9, view = 0, path = "/img/Modern/modern8.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 9, view = 0, path = "/img/Modern/modern9.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 9, view = 0, path = "/img/Modern/modern10.jpg" });

            db.StyleItems.Add(new StyleItems { parentId = 10, view = 0, path = "/img/Retro/retro1.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 10, view = 0, path = "/img/Retro/retro2.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 10, view = 0, path = "/img/Retro/retro3.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 10, view = 0, path = "/img/Retro/retro4.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 10, view = 0, path = "/img/Retro/retro5.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 10, view = 0, path = "/img/Retro/retro6.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 10, view = 0, path = "/img/Retro/retro7.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 10, view = 0, path = "/img/Retro/retro8.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 10, view = 0, path = "/img/Retro/retro9.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 10, view = 0, path = "/img/Retro/retro10.jpg" });

            db.StyleItems.Add(new StyleItems { parentId = 11, view = 0, path = "/img/Rustic/rustic1.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 11, view = 0, path = "/img/Rustic/rustic2.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 11, view = 0, path = "/img/Rustic/rustic3.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 11, view = 0, path = "/img/Rustic/rustic4.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 11, view = 0, path = "/img/Rustic/rustic5.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 11, view = 0, path = "/img/Rustic/rustic6.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 11, view = 0, path = "/img/Rustic/rustic7.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 11, view = 0, path = "/img/Rustic/rustic8.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 11, view = 0, path = "/img/Rustic/rustic9.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 11, view = 0, path = "/img/Rustic/rustic10.jpg" });

            db.StyleItems.Add(new StyleItems { parentId = 12, view = 0, path = "/img/Scandinavian/scandinavian1.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 12, view = 0, path = "/img/Scandinavian/scandinavian2.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 12, view = 0, path = "/img/Scandinavian/scandinavian3.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 12, view = 0, path = "/img/Scandinavian/scandinavian4.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 12, view = 0, path = "/img/Scandinavian/scandinavian5.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 12, view = 0, path = "/img/Scandinavian/scandinavian6.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 12, view = 0, path = "/img/Scandinavian/scandinavian7.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 12, view = 0, path = "/img/Scandinavian/scandinavian8.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 12, view = 0, path = "/img/Scandinavian/scandinavian9.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 12, view = 0, path = "/img/Scandinavian/scandinavian10.jpg" });

            db.StyleItems.Add(new StyleItems { parentId = 13, view = 0, path = "/img/Tropical/tropical1.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 13, view = 0, path = "/img/Tropical/tropical2.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 13, view = 0, path = "/img/Tropical/tropical3.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 13, view = 0, path = "/img/Tropical/tropical4.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 13, view = 0, path = "/img/Tropical/tropical5.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 13, view = 0, path = "/img/Tropical/tropical6.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 13, view = 0, path = "/img/Tropical/tropical7.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 13, view = 0, path = "/img/Tropical/tropical8.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 13, view = 0, path = "/img/Tropical/tropical9.jpg" });
            db.StyleItems.Add(new StyleItems { parentId = 13, view = 0, path = "/img/Tropical/tropical10.jpg" });
        
        }
    }
}