using eco_friendly_life_winform.Backend;

namespace eco_friendly_life_winform
{
    public partial class Form1 : Form
    {
        List<Recipe> recipes = new List<Recipe>();
        Recipe wanted = new Recipe();

        List<Tipp> tipps = new List<Tipp>();

        public Form1()
        {
            InitializeComponent();
            mainWindowPanel.Visible = true;
            RecipePanel.Visible = false;
            TippPanel.Visible = false;


            Recipe hamburger= new Recipe();
            hamburger.RecipeID = 0;
            hamburger.DishName = "hamburger";
            hamburger.RecipeDescription = "rakd össze a hozzávalókat";
            hamburger.Ingredients.Add("zsömle");
            hamburger.Ingredients.Add("marhahús");
            hamburger.Ingredients.Add("saláta");
            hamburger.Ingredients.Add("ketchup");
            hamburger.Ingredients.Add("hagyma");
            hamburger.ContainsMeat = true;
            hamburger.CarbonFootprint = 6.4;
            hamburger.DishTypeName = "fõétel";

            // Gulyás Recipe
            Recipe gulyas = new Recipe();
            gulyas.RecipeID = 1;
            gulyas.DishName = "Gulyás";
            gulyas.RecipeDescription = "Forrósítsunk fel egy nagy fazekat közepes lángon olajjal.\r\nAdjuk hozzá az apróra vágott hagymát és fokhagymát, majd pároljuk üvegesre.\r\nPirítsuk meg benne a kockára vágott marhahúst.\r\nKeverjük hozzá a pirospaprikát, majd öntsük fel vízzel vagy húsleves alaplével.\r\nAdunk hozzá zöldpaprikát, kockára vágott burgonyát, paradicsomot, babérlevelet, sót, borsot.\r\nFõzzük lassú tûzön fedõ alatt kb. 1,5-2 órán át, amíg minden összeér és a hús megpuhul.\r\nÍzlés szerint korrigáljuk a fûszerezést.\r\nTálaljuk forrón friss kenyérrel vagy savanyúsággal.";
            gulyas.Ingredients.Add("marhahús");
            gulyas.Ingredients.Add("hagyma");
            gulyas.Ingredients.Add("paprika");
            gulyas.Ingredients.Add("burgonya");
            gulyas.Ingredients.Add("paradicsom");
            gulyas.ContainsMeat = true;
            gulyas.CarbonFootprint = 6.2;
            gulyas.DishTypeName = "leves";

            // Túrós Csusza Recipe
            Recipe turosCsusza = new Recipe();
            turosCsusza.RecipeID = 2;
            turosCsusza.DishName = "Túrós Csusza";
            turosCsusza.RecipeDescription = "Forraljunk fel egy lábas vizet és adjunk hozzá sót.\r\nAdjuk bele a csusza tésztát, és fõzzük ki a csomagoláson feltüntetett idõtartamig.\r\nKözben keverjük össze a túrót kevés sóval és ízlés szerinti mennyiségû tejföllel egy tálban.\r\nAmikor a tészta megfõtt, szûrjük le, majd keverjük össze a túróval és tejföllel.";
            turosCsusza.Ingredients.Add("csusza tészta");
            turosCsusza.Ingredients.Add("túró");
            turosCsusza.Ingredients.Add("tejföl");
            turosCsusza.ContainsMeat = false;
            turosCsusza.CarbonFootprint = 3.6;
            turosCsusza.DishTypeName = "fõétel";

            // Hortobágyi Palacsinta Recipe
            Recipe hortobagyiPalacsinta = new Recipe();
            hortobagyiPalacsinta.RecipeID = 3;
            hortobagyiPalacsinta.DishName = "Hortobágyi Palacsinta";
            hortobagyiPalacsinta.RecipeDescription = "Elkészítjük a palacsintatésztát a szokásos módon. (Tojás, liszt, tej összekeverése és palacsintasütõben kisütjük.)\r\nKözben elkészítjük a tölteléket. Egy tálban összekeverjük a fõtt sonkát és fõtt csirkemellet, majd apróra vágjuk és összekeverjük egy kevés tejföllel.\r\nTöltsük meg a palacsintákat a sonkás-csirkés töltelékkel, majd tekerjük fel vagy hajtogassuk össze.\r\nRakjuk egy sütõtálba az elkészített töltött palacsintákat.\r\nÖntsünk rájuk tejfölt, majd tegyük elõmelegített sütõbe, és süssük kb. 10-15 percig, amíg a tejföl teteje aranybarnára pirul.";
            hortobagyiPalacsinta.Ingredients.Add("palacsinta");
            hortobagyiPalacsinta.Ingredients.Add("fõtt sonka");
            hortobagyiPalacsinta.Ingredients.Add("fõtt csirkemell");
            hortobagyiPalacsinta.Ingredients.Add("tejföl");
            hortobagyiPalacsinta.ContainsMeat = true;
            hortobagyiPalacsinta.CarbonFootprint = 6.9;
            hortobagyiPalacsinta.DishTypeName = "fõétel";

            // Halászlé Recipe
            Recipe halaszle = new Recipe();
            halaszle.RecipeID = 4;
            halaszle.DishName = "Halászlé";
            halaszle.RecipeDescription = "Forrósítsunk fel egy nagy fazekat közepes lángon, majd adjunk hozzá olajat vagy zsírt.\r\nAdjuk hozzá az apróra vágott hagymát, és pároljuk üvegesre.\r\nKeverjük hozzá a pirospaprikát, majd azonnal öntsük fel kb. 1-1,5 liter vízzel.\r\nAdjuk hozzá a halat (pl. halfilét) és a zöldségeket (pl. hagyma, paprika), majd fõzzük lassú tûzön kb. 20-30 percig.\r\nFûszerezzük ízlés szerint sóval, borsmal és esetleg csemegepaprikával.";
            halaszle.Ingredients.Add("halfilé");
            halaszle.Ingredients.Add("hagyma");
            halaszle.Ingredients.Add("paprika");
            halaszle.Ingredients.Add("paradicsom");
            halaszle.ContainsMeat = false;
            halaszle.CarbonFootprint = 5.7;
            halaszle.DishTypeName = "leves";

            // Lecsó Recipe
            Recipe lecso = new Recipe();
            lecso.RecipeID = 5;
            lecso.DishName = "Lecsó";
            lecso.RecipeDescription = "Forrósítsunk fel egy serpenyõt közepes lángon, majd adjunk hozzá olajat vagy zsírt.\r\nDobáljuk rá a vékonyra szeletelt kolbászt, és pirítsuk meg néhány percig, amíg aranybarnára sül.\r\nAdjunk hozzá apróra vágott hagymát, és pároljuk üvegesre.\r\nKeverjük hozzá a kockára vágott paprikát és paradicsomot.\r\nFûszerezzük ízlés szerint sóval, frissen õrölt borssal és esetleg egy kevés pirospaprikával.\r\nFõzzük további 10-15 percig, amíg a zöldségek megpuhulnak és az ízek összeérnek.\r\nTálaljuk melegen friss kenyérrel vagy akár rizzsel.";
            lecso.Ingredients.Add("paprika");
            lecso.Ingredients.Add("paradicsom");
            lecso.Ingredients.Add("kolbász");
            lecso.Ingredients.Add("hagyma");
            lecso.ContainsMeat = true;
            lecso.CarbonFootprint = 4.3;
            lecso.DishTypeName = "fõétel";

            // Töltött Káposzta Recipe
            Recipe tolottKaposzta = new Recipe();
            tolottKaposzta.RecipeID = 6;
            tolottKaposzta.DishName = "Töltött Káposzta";
            tolottKaposzta.RecipeDescription = "Vegyünk elõ egy nagy fazekat, és tegyünk bele vizet, majd forraljuk fel.\r\nVegyünk ki egy nagyobb savanyú káposztalevelet a savanyú káposzta fejébõl, majd blansírozzuk vagy áztassuk forró vízbe, hogy lágyabbá váljon és könnyebben formázható legyen.\r\nElkészítjük a tölteléket: egy tálban keverjünk össze darált húst (pl. sertés és marha keverékét), rizst, apróra vágott hagymát, sót, borsot és egyéb ízlés szerinti fûszereket.\r\nTöltsük meg a káposztaleveleket a töltelékkel, majd tekergessük fel, hogy a töltelék ne essen ki.\r\nTegyük az elkészített töltött káposztákat a fazékba egymás mellé.\r\nÖntsünk rájuk vizet vagy húsleves alaplevet úgy, hogy ellepje a káposztákat.\r\nFõzzük lassú tûzön kb. 1,5-2 órán át, amíg a töltött káposzta megpuhul és az ízek összeérnek.";
            tolottKaposzta.Ingredients.Add("savanyú káposzta");
            tolottKaposzta.Ingredients.Add("darált hús");
            tolottKaposzta.Ingredients.Add("rizs");
            tolottKaposzta.Ingredients.Add("hagyma");
            tolottKaposzta.ContainsMeat = true;
            tolottKaposzta.CarbonFootprint = 7.1;
            tolottKaposzta.DishTypeName = "fõétel";

            // Rakott Krumpli Recipe
            Recipe rakottKrumpli = new Recipe();
            rakottKrumpli.RecipeID = 7;
            rakottKrumpli.DishName = "Rakott Krumpli";
            rakottKrumpli.RecipeDescription = "Elõmelegítjük a sütõt 180 fokra.\r\nMegpucoljuk és vékony szeletekre vágjuk a krumplit.\r\nEgy sütõedény alját kivajazzuk vagy kikenünk olajjal.\r\nElhelyezünk egy réteg krumplit az edény alján.\r\nSzórjunk a krumplira sót, borsot és esetleg apróra vágott hagymát.\r\nIsmételjük meg az elõzõ lépést újabb réteg krumplival, sóval, borssal és hagymával, amíg elfogy a krumpli.\r\nÖntsünk rá tejfölt, hogy az edény tartalma jól ellepje.\r\nTegyük a sütõbe és süssük kb. 45-60 percig, amíg a teteje szép aranybarnára pirul.";
            rakottKrumpli.Ingredients.Add("krumpli");
            rakottKrumpli.Ingredients.Add("sonka");
            rakottKrumpli.Ingredients.Add("sajt");
            rakottKrumpli.Ingredients.Add("tejföl");
            rakottKrumpli.ContainsMeat = true;
            rakottKrumpli.CarbonFootprint = 5.4;
            rakottKrumpli.DishTypeName = "fõétel";

            // Dobos Torte Recipe
            Recipe dobosTorte = new Recipe();
            dobosTorte.RecipeID = 8;
            dobosTorte.DishName = "Dobos Torta";
            dobosTorte.RecipeDescription = "Melegítsük elõ a sütõt 180 Celsius fokra. Készítsünk elõ egy tortaformát, és béleljük ki sütõpapírral.\r\nElkészítjük a piskótatésztát: A tojásokat és a cukrot habosra keverjük. Adjuk hozzá a lisztet és a sütõport, majd óvatosan keverjük el a masszát.\r\nÖntsük a masszát a tortaformába, és süssük körülbelül 20-25 percig, vagy amíg a piskóta megsül és aranybarnára pirul.\r\nKözben elkészítjük a krémet: A tojások sárgáját keverjük habosra a cukorral, majd adjuk hozzá a lisztet és a tejet, és fõzzük sûrûre a tûzhelyen, folyamatos kevergetés mellett. Hagyjuk kihûlni.\r\nAmikor a piskóta megsült és kihûlt, vágjuk ketté vízszintesen két lapra.\r\nAz alsó lapra kenjük rá a krémet, majd helyezzük rá a másik lapot.\r\nElkészítjük a csokoládékrémet: A csokoládét és a vajat vízgõz felett olvasszuk össze. Kenjük a torta tetejére, majd egy spatulával simítsuk el egyenletesen.\r\nHa a csokoládé megdermedt, vágjuk a tortát kis kockákra és tálaljuk.";
            dobosTorte.Ingredients.Add("tojás");
            dobosTorte.Ingredients.Add("liszt");
            dobosTorte.Ingredients.Add("cukor");
            dobosTorte.Ingredients.Add("vaj");
            dobosTorte.ContainsMeat = false;
            dobosTorte.CarbonFootprint = 3.9;
            dobosTorte.DishTypeName = "desszert";

            // Gombapörkölt Recipe
            Recipe gombaporkolt = new Recipe();
            gombaporkolt.RecipeID = 9;
            gombaporkolt.DishName = "Gombapörkölt";
            gombaporkolt.RecipeDescription = "Melegítsünk fel egy serpenyõt közepes lángon, majd adjunk hozzá olajat vagy vajat.\r\nAdjuk hozzá az apróra vágott hagymát, és pirítsuk üvegesre.\r\nKeverjük hozzá az apróra vágott gombát, és pirítsuk meg néhány percig.\r\nSzórjuk meg a gombát pirospaprikával és egyéb ízlés szerinti fûszerekkel (pl. só, bors), majd keverjük össze.\r\nHa szükséges, adjunk hozzá egy kevés vizet vagy hús alaplevet a serpenyõbe, hogy a gomba ne legyen száraz.\r\nFõzzük a gombát közepes lángon kb. 10-15 percig, amíg megpuhul és az ízek összeérnek.";
            gombaporkolt.Ingredients.Add("gomba");
            gombaporkolt.Ingredients.Add("hagyma");
            gombaporkolt.Ingredients.Add("paprika");
            gombaporkolt.Ingredients.Add("paradicsom");
            gombaporkolt.ContainsMeat = false;
            gombaporkolt.CarbonFootprint = 4.6;
            gombaporkolt.DishTypeName = "fõétel";

            // Rakott Kel Recipe
            Recipe rakottKel = new Recipe();
            rakottKel.RecipeID = 10;
            rakottKel.DishName = "Rakott Kel";
            rakottKel.RecipeDescription = "Elõmelegítjük a sütõt 180 Celsius fokra.\r\nA káposzta leveleit elõzõleg megpároljuk vagy blansírozzuk forró vízben, hogy lágyabbak legyenek.\r\nEgy sütõedény alját kivajazzuk vagy kikenünk olajjal.\r\nElhelyezünk egy réteg káposztalevelet az edény alján.\r\nA káposztára szórjuk rá a sót, borsot és esetleg apróra vágott hagymát.\r\nIsmételjük meg az elõzõ lépést újabb réteg káposztával, sóval, borssal és hagymával, amíg elfogy a káposzta.\r\nÖntsünk rá tejfölt, hogy az edény tartalma jól ellepje.\r\nTegyük a sütõbe és süssük kb. 45-60 percig, amíg a teteje szép aranybarnára pirul.";
            rakottKel.Ingredients.Add("kel");
            rakottKel.Ingredients.Add("rizs");
            rakottKel.Ingredients.Add("sajt");
            rakottKel.Ingredients.Add("tejföl");
            rakottKel.ContainsMeat = false;
            rakottKel.CarbonFootprint = 3.8;
            rakottKrumpli.DishTypeName = "fõétel";

            // Túrógombóc Recipe
            Recipe turogomboc = new Recipe();
            turogomboc.RecipeID = 11;
            turogomboc.DishName = "Túrógombóc";
            turogomboc.RecipeDescription = "Elkészítjük a túrógombóc tésztáját: Egy tálban összekeverjük a túrót, tojást, cukrot és lisztet. Gyúrjuk össze, hogy homogén tészta állagot kapjunk.\r\nFormáljunk a tésztából kis gombócokat vagy gömböket, és helyezzük õket egy tányérra vagy deszkára.\r\nEgy nagyobb lábasban vagy fazékban forraljunk fel vizet, majd tegyük bele a gombócokat.\r\nFõzzük a gombócokat forrásban lévõ vízben, amíg fel nem jönnek a víz felszínére, és megfõttek (általában 8-10 perc).\r\nAmikor a gombócok feljöttek a víz felszínére, szûrjük le õket, majd tegyük egy tálba vagy tálaló edénybe.\r\nOpcionálisan: Készítsünk egy kevés morzsát: Olvasszunk fel vajat egy serpenyõben, majd adjunk hozzá zsemlemorzsát és keverjük addig, amíg aranybarnára pirul.\r\nTálalhatjuk a túrógombócokat tejföllel és porcukorral megszórva, valamint a pirított morzsával a tetején.";
            turogomboc.Ingredients.Add("túró");
            turogomboc.Ingredients.Add("tojás");
            turogomboc.Ingredients.Add("cukor");
            turogomboc.Ingredients.Add("liszt");
            turogomboc.ContainsMeat = false;
            turogomboc.CarbonFootprint = 2.9;
            turogomboc.DishTypeName = "desszert";

            recipes.Add(turogomboc);
            recipes.Add(rakottKel);
            recipes.Add(gombaporkolt);
            recipes.Add(dobosTorte);
            recipes.Add(rakottKrumpli);
            recipes.Add(tolottKaposzta);
            recipes.Add(lecso);
            recipes.Add(halaszle);
            recipes.Add(hortobagyiPalacsinta);
            recipes.Add(turosCsusza);
            recipes.Add(gulyas);
            recipes.Add(hamburger);

            Tipp elso = new Tipp();
            elso.TippID = 0;
            elso.TippName = "Ne öntsd a festéket a lefolyóba!";

            Tipp masodik = new Tipp();
            masodik.TippID = 1;
            masodik.TippName = "Mosogatógépet használni sokkal idõtakarékosabb és környezetbarátabb is, mivel kevesebb vízet fogyaszt!";

            Tipp harmadik = new Tipp();
            harmadik.TippID = 2;
            harmadik.TippName = "A fenntarthatóság érdekében válassz újrahasznosított vagy újrahasznosítható csomagolást a vásárlásaidhoz!";

            Tipp negyedik = new Tipp();
            negyedik.TippID = 3;
            negyedik.TippName = "Kerüld az egyszer használatos mûanyagokat és helyettük válassz újrahasznosítható vagy komposztálható alternatívákat!";

            Tipp otodik = new Tipp();
            otodik.TippID = 4;
            otodik.TippName = "Az energiatakarékosságért próbáld ki az energiahatékony izzókat vagy LED lámpákat otthonodban!";

            Tipp hatodik = new Tipp();
            hatodik.TippID = 5;
            hatodik.TippName = "A közlekedés során válaszd az alternatív módszereket, mint például a gyaloglás, biciklizés vagy tömegközlekedés, hogy csökkentsd az egyéni káros környezeti hatásokat!";

            tipps.Add(elso);
            tipps.Add(masodik);
            tipps.Add(harmadik);
            tipps.Add(negyedik);
            tipps.Add(otodik);
            tipps.Add(hatodik);
        }


        private void recipeSuggestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainWindowPanel.Visible = false;
            TippPanel.Visible = false;
            RecipePanel.Visible = true;

            //ingredientComboBox1.Items.Add("túró");
            //ingredientComboBox1.Items.Add("sajt");
            //ingredientComboBox1.Items.Add("tejföl");

            //ingredientComboBox2.Items.Add("gomba");
            //ingredientComboBox2.Items.Add("paprika");
            //ingredientComboBox2.Items.Add("paradicsom");
            //ingredientComboBox2.Items.Add("hagyma");

            //ingredientComboBox3.Items.Add("tojás");
            //ingredientComboBox3.Items.Add("marhahús");
            //ingredientComboBox3.Items.Add("sonka");
            //ingredientComboBox3.Items.Add("hal");
        }

        private void nearestRecycleBinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainWindowPanel.Visible = false;
            RecipePanel.Visible = false;
            TippPanel.Visible = false;
        }

        private void tippsAndTricksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainWindowPanel.Visible = false;
            RecipePanel.Visible = false;
            TippPanel.Visible = true;

            Random rnd = new Random();
            int num = rnd.Next(0, tipps.Count());

            //todaysTippTextBox.AutoSize = true;
            todaysTippTextBox.Text = tipps[num].TippName;
        }

        private void generalasButton_Click(object sender, EventArgs e)
        {
            string wantedIngredient1 = string.Empty;
            string wantedIngredient2 = string.Empty;
            string wantedIngredient3 = string.Empty;

            wantedIngredient1 = ingredientComboBox1.Text;
            wantedIngredient2 = ingredientComboBox2.Text;
            wantedIngredient3 = ingredientComboBox3.Text;

            string tipus = string.Empty;

            List<Recipe> result_list = new List<Recipe>();

            if (soupCheckBox.Checked)
            {
                tipus = "leves";
            }
            else if (mainDishCheckBox.Checked)
            {
                tipus = "fõétel";
            }
            else if (appetizerCheckBox.Checked)
            {
                tipus = "elõétel";
            }
            else if (dessertCheckBox.Checked)
            {
                tipus = "desszert";
            }

            foreach (Recipe dish in recipes)
            {
                if (dish.DishTypeName == tipus)
                {
                    result_list.Add(dish);
                }
            }

            List<Recipe> filtered = new List<Recipe>();

            if ("" != wantedIngredient1 || "" != wantedIngredient2 || "" != wantedIngredient3)
            {
                foreach (Recipe dish in result_list)
                {
                    foreach (string hozzavalo in dish.Ingredients)
                    {
                        if (hozzavalo == wantedIngredient1 || hozzavalo == wantedIngredient2 || hozzavalo == wantedIngredient3)
                        {
                            filtered.Add(dish);
                        }
                    }
                }
            }
            else
            {
                filtered = result_list;
            }

            if (filtered.Count != 0)
            {
                Random rnd = new Random();
                int num = rnd.Next(0, filtered.Count());
                wanted = filtered[num];

                MessageBox.Show(wanted.DishName);

                string ingredients_list = "";
                foreach (string i in wanted.Ingredients)
                {
                   ingredients_list += i + "\n";
                }
                MessageBox.Show(ingredients_list);
                MessageBox.Show(wanted.RecipeDescription);
            }

        }
    }
}