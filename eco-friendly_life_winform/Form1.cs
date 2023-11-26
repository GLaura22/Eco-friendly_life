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
            hamburger.RecipeDescription = "rakd �ssze a hozz�val�kat";
            hamburger.Ingredients.Add("zs�mle");
            hamburger.Ingredients.Add("marhah�s");
            hamburger.Ingredients.Add("sal�ta");
            hamburger.Ingredients.Add("ketchup");
            hamburger.Ingredients.Add("hagyma");
            hamburger.ContainsMeat = true;
            hamburger.CarbonFootprint = 6.4;
            hamburger.DishTypeName = "f��tel";

            // Guly�s Recipe
            Recipe gulyas = new Recipe();
            gulyas.RecipeID = 1;
            gulyas.DishName = "Guly�s";
            gulyas.RecipeDescription = "Forr�s�tsunk fel egy nagy fazekat k�zepes l�ngon olajjal.\r\nAdjuk hozz� az apr�ra v�gott hagym�t �s fokhagym�t, majd p�roljuk �vegesre.\r\nPir�tsuk meg benne a kock�ra v�gott marhah�st.\r\nKeverj�k hozz� a pirospaprik�t, majd �nts�k fel v�zzel vagy h�sleves alapl�vel.\r\nAdunk hozz� z�ldpaprik�t, kock�ra v�gott burgony�t, paradicsomot, bab�rlevelet, s�t, borsot.\r\nF�zz�k lass� t�z�n fed� alatt kb. 1,5-2 �r�n �t, am�g minden �ssze�r �s a h�s megpuhul.\r\n�zl�s szerint korrig�ljuk a f�szerez�st.\r\nT�laljuk forr�n friss keny�rrel vagy savany�s�ggal.";
            gulyas.Ingredients.Add("marhah�s");
            gulyas.Ingredients.Add("hagyma");
            gulyas.Ingredients.Add("paprika");
            gulyas.Ingredients.Add("burgonya");
            gulyas.Ingredients.Add("paradicsom");
            gulyas.ContainsMeat = true;
            gulyas.CarbonFootprint = 6.2;
            gulyas.DishTypeName = "leves";

            // T�r�s Csusza Recipe
            Recipe turosCsusza = new Recipe();
            turosCsusza.RecipeID = 2;
            turosCsusza.DishName = "T�r�s Csusza";
            turosCsusza.RecipeDescription = "Forraljunk fel egy l�bas vizet �s adjunk hozz� s�t.\r\nAdjuk bele a csusza t�szt�t, �s f�zz�k ki a csomagol�son felt�ntetett id�tartamig.\r\nK�zben keverj�k �ssze a t�r�t kev�s s�val �s �zl�s szerinti mennyis�g� tejf�llel egy t�lban.\r\nAmikor a t�szta megf�tt, sz�rj�k le, majd keverj�k �ssze a t�r�val �s tejf�llel.";
            turosCsusza.Ingredients.Add("csusza t�szta");
            turosCsusza.Ingredients.Add("t�r�");
            turosCsusza.Ingredients.Add("tejf�l");
            turosCsusza.ContainsMeat = false;
            turosCsusza.CarbonFootprint = 3.6;
            turosCsusza.DishTypeName = "f��tel";

            // Hortob�gyi Palacsinta Recipe
            Recipe hortobagyiPalacsinta = new Recipe();
            hortobagyiPalacsinta.RecipeID = 3;
            hortobagyiPalacsinta.DishName = "Hortob�gyi Palacsinta";
            hortobagyiPalacsinta.RecipeDescription = "Elk�sz�tj�k a palacsintat�szt�t a szok�sos m�don. (Toj�s, liszt, tej �sszekever�se �s palacsintas�t�ben kis�tj�k.)\r\nK�zben elk�sz�tj�k a t�ltel�ket. Egy t�lban �sszekeverj�k a f�tt sonk�t �s f�tt csirkemellet, majd apr�ra v�gjuk �s �sszekeverj�k egy kev�s tejf�llel.\r\nT�lts�k meg a palacsint�kat a sonk�s-csirk�s t�ltel�kkel, majd tekerj�k fel vagy hajtogassuk �ssze.\r\nRakjuk egy s�t�t�lba az elk�sz�tett t�lt�tt palacsint�kat.\r\n�nts�nk r�juk tejf�lt, majd tegy�k el�meleg�tett s�t�be, �s s�ss�k kb. 10-15 percig, am�g a tejf�l teteje aranybarn�ra pirul.";
            hortobagyiPalacsinta.Ingredients.Add("palacsinta");
            hortobagyiPalacsinta.Ingredients.Add("f�tt sonka");
            hortobagyiPalacsinta.Ingredients.Add("f�tt csirkemell");
            hortobagyiPalacsinta.Ingredients.Add("tejf�l");
            hortobagyiPalacsinta.ContainsMeat = true;
            hortobagyiPalacsinta.CarbonFootprint = 6.9;
            hortobagyiPalacsinta.DishTypeName = "f��tel";

            // Hal�szl� Recipe
            Recipe halaszle = new Recipe();
            halaszle.RecipeID = 4;
            halaszle.DishName = "Hal�szl�";
            halaszle.RecipeDescription = "Forr�s�tsunk fel egy nagy fazekat k�zepes l�ngon, majd adjunk hozz� olajat vagy zs�rt.\r\nAdjuk hozz� az apr�ra v�gott hagym�t, �s p�roljuk �vegesre.\r\nKeverj�k hozz� a pirospaprik�t, majd azonnal �nts�k fel kb. 1-1,5 liter v�zzel.\r\nAdjuk hozz� a halat (pl. halfil�t) �s a z�lds�geket (pl. hagyma, paprika), majd f�zz�k lass� t�z�n kb. 20-30 percig.\r\nF�szerezz�k �zl�s szerint s�val, borsmal �s esetleg csemegepaprik�val.";
            halaszle.Ingredients.Add("halfil�");
            halaszle.Ingredients.Add("hagyma");
            halaszle.Ingredients.Add("paprika");
            halaszle.Ingredients.Add("paradicsom");
            halaszle.ContainsMeat = false;
            halaszle.CarbonFootprint = 5.7;
            halaszle.DishTypeName = "leves";

            // Lecs� Recipe
            Recipe lecso = new Recipe();
            lecso.RecipeID = 5;
            lecso.DishName = "Lecs�";
            lecso.RecipeDescription = "Forr�s�tsunk fel egy serpeny�t k�zepes l�ngon, majd adjunk hozz� olajat vagy zs�rt.\r\nDob�ljuk r� a v�konyra szeletelt kolb�szt, �s pir�tsuk meg n�h�ny percig, am�g aranybarn�ra s�l.\r\nAdjunk hozz� apr�ra v�gott hagym�t, �s p�roljuk �vegesre.\r\nKeverj�k hozz� a kock�ra v�gott paprik�t �s paradicsomot.\r\nF�szerezz�k �zl�s szerint s�val, frissen �r�lt borssal �s esetleg egy kev�s pirospaprik�val.\r\nF�zz�k tov�bbi 10-15 percig, am�g a z�lds�gek megpuhulnak �s az �zek �ssze�rnek.\r\nT�laljuk melegen friss keny�rrel vagy ak�r rizzsel.";
            lecso.Ingredients.Add("paprika");
            lecso.Ingredients.Add("paradicsom");
            lecso.Ingredients.Add("kolb�sz");
            lecso.Ingredients.Add("hagyma");
            lecso.ContainsMeat = true;
            lecso.CarbonFootprint = 4.3;
            lecso.DishTypeName = "f��tel";

            // T�lt�tt K�poszta Recipe
            Recipe tolottKaposzta = new Recipe();
            tolottKaposzta.RecipeID = 6;
            tolottKaposzta.DishName = "T�lt�tt K�poszta";
            tolottKaposzta.RecipeDescription = "Vegy�nk el� egy nagy fazekat, �s tegy�nk bele vizet, majd forraljuk fel.\r\nVegy�nk ki egy nagyobb savany� k�posztalevelet a savany� k�poszta fej�b�l, majd blans�rozzuk vagy �ztassuk forr� v�zbe, hogy l�gyabb� v�ljon �s k�nnyebben form�zhat� legyen.\r\nElk�sz�tj�k a t�ltel�ket: egy t�lban keverj�nk �ssze dar�lt h�st (pl. sert�s �s marha kever�k�t), rizst, apr�ra v�gott hagym�t, s�t, borsot �s egy�b �zl�s szerinti f�szereket.\r\nT�lts�k meg a k�posztaleveleket a t�ltel�kkel, majd tekergess�k fel, hogy a t�ltel�k ne essen ki.\r\nTegy�k az elk�sz�tett t�lt�tt k�poszt�kat a faz�kba egym�s mell�.\r\n�nts�nk r�juk vizet vagy h�sleves alaplevet �gy, hogy ellepje a k�poszt�kat.\r\nF�zz�k lass� t�z�n kb. 1,5-2 �r�n �t, am�g a t�lt�tt k�poszta megpuhul �s az �zek �ssze�rnek.";
            tolottKaposzta.Ingredients.Add("savany� k�poszta");
            tolottKaposzta.Ingredients.Add("dar�lt h�s");
            tolottKaposzta.Ingredients.Add("rizs");
            tolottKaposzta.Ingredients.Add("hagyma");
            tolottKaposzta.ContainsMeat = true;
            tolottKaposzta.CarbonFootprint = 7.1;
            tolottKaposzta.DishTypeName = "f��tel";

            // Rakott Krumpli Recipe
            Recipe rakottKrumpli = new Recipe();
            rakottKrumpli.RecipeID = 7;
            rakottKrumpli.DishName = "Rakott Krumpli";
            rakottKrumpli.RecipeDescription = "El�meleg�tj�k a s�t�t 180 fokra.\r\nMegpucoljuk �s v�kony szeletekre v�gjuk a krumplit.\r\nEgy s�t�ed�ny alj�t kivajazzuk vagy kiken�nk olajjal.\r\nElhelyez�nk egy r�teg krumplit az ed�ny alj�n.\r\nSz�rjunk a krumplira s�t, borsot �s esetleg apr�ra v�gott hagym�t.\r\nIsm�telj�k meg az el�z� l�p�st �jabb r�teg krumplival, s�val, borssal �s hagym�val, am�g elfogy a krumpli.\r\n�nts�nk r� tejf�lt, hogy az ed�ny tartalma j�l ellepje.\r\nTegy�k a s�t�be �s s�ss�k kb. 45-60 percig, am�g a teteje sz�p aranybarn�ra pirul.";
            rakottKrumpli.Ingredients.Add("krumpli");
            rakottKrumpli.Ingredients.Add("sonka");
            rakottKrumpli.Ingredients.Add("sajt");
            rakottKrumpli.Ingredients.Add("tejf�l");
            rakottKrumpli.ContainsMeat = true;
            rakottKrumpli.CarbonFootprint = 5.4;
            rakottKrumpli.DishTypeName = "f��tel";

            // Dobos Torte Recipe
            Recipe dobosTorte = new Recipe();
            dobosTorte.RecipeID = 8;
            dobosTorte.DishName = "Dobos Torta";
            dobosTorte.RecipeDescription = "Meleg�ts�k el� a s�t�t 180 Celsius fokra. K�sz�ts�nk el� egy tortaform�t, �s b�lelj�k ki s�t�pap�rral.\r\nElk�sz�tj�k a pisk�tat�szt�t: A toj�sokat �s a cukrot habosra keverj�k. Adjuk hozz� a lisztet �s a s�t�port, majd �vatosan keverj�k el a massz�t.\r\n�nts�k a massz�t a tortaform�ba, �s s�ss�k k�r�lbel�l 20-25 percig, vagy am�g a pisk�ta megs�l �s aranybarn�ra pirul.\r\nK�zben elk�sz�tj�k a kr�met: A toj�sok s�rg�j�t keverj�k habosra a cukorral, majd adjuk hozz� a lisztet �s a tejet, �s f�zz�k s�r�re a t�zhelyen, folyamatos keverget�s mellett. Hagyjuk kih�lni.\r\nAmikor a pisk�ta megs�lt �s kih�lt, v�gjuk kett� v�zszintesen k�t lapra.\r\nAz als� lapra kenj�k r� a kr�met, majd helyezz�k r� a m�sik lapot.\r\nElk�sz�tj�k a csokol�d�kr�met: A csokol�d�t �s a vajat v�zg�z felett olvasszuk �ssze. Kenj�k a torta tetej�re, majd egy spatul�val sim�tsuk el egyenletesen.\r\nHa a csokol�d� megdermedt, v�gjuk a tort�t kis kock�kra �s t�laljuk.";
            dobosTorte.Ingredients.Add("toj�s");
            dobosTorte.Ingredients.Add("liszt");
            dobosTorte.Ingredients.Add("cukor");
            dobosTorte.Ingredients.Add("vaj");
            dobosTorte.ContainsMeat = false;
            dobosTorte.CarbonFootprint = 3.9;
            dobosTorte.DishTypeName = "desszert";

            // Gombap�rk�lt Recipe
            Recipe gombaporkolt = new Recipe();
            gombaporkolt.RecipeID = 9;
            gombaporkolt.DishName = "Gombap�rk�lt";
            gombaporkolt.RecipeDescription = "Meleg�ts�nk fel egy serpeny�t k�zepes l�ngon, majd adjunk hozz� olajat vagy vajat.\r\nAdjuk hozz� az apr�ra v�gott hagym�t, �s pir�tsuk �vegesre.\r\nKeverj�k hozz� az apr�ra v�gott gomb�t, �s pir�tsuk meg n�h�ny percig.\r\nSz�rjuk meg a gomb�t pirospaprik�val �s egy�b �zl�s szerinti f�szerekkel (pl. s�, bors), majd keverj�k �ssze.\r\nHa sz�ks�ges, adjunk hozz� egy kev�s vizet vagy h�s alaplevet a serpeny�be, hogy a gomba ne legyen sz�raz.\r\nF�zz�k a gomb�t k�zepes l�ngon kb. 10-15 percig, am�g megpuhul �s az �zek �ssze�rnek.";
            gombaporkolt.Ingredients.Add("gomba");
            gombaporkolt.Ingredients.Add("hagyma");
            gombaporkolt.Ingredients.Add("paprika");
            gombaporkolt.Ingredients.Add("paradicsom");
            gombaporkolt.ContainsMeat = false;
            gombaporkolt.CarbonFootprint = 4.6;
            gombaporkolt.DishTypeName = "f��tel";

            // Rakott Kel Recipe
            Recipe rakottKel = new Recipe();
            rakottKel.RecipeID = 10;
            rakottKel.DishName = "Rakott Kel";
            rakottKel.RecipeDescription = "El�meleg�tj�k a s�t�t 180 Celsius fokra.\r\nA k�poszta leveleit el�z�leg megp�roljuk vagy blans�rozzuk forr� v�zben, hogy l�gyabbak legyenek.\r\nEgy s�t�ed�ny alj�t kivajazzuk vagy kiken�nk olajjal.\r\nElhelyez�nk egy r�teg k�posztalevelet az ed�ny alj�n.\r\nA k�poszt�ra sz�rjuk r� a s�t, borsot �s esetleg apr�ra v�gott hagym�t.\r\nIsm�telj�k meg az el�z� l�p�st �jabb r�teg k�poszt�val, s�val, borssal �s hagym�val, am�g elfogy a k�poszta.\r\n�nts�nk r� tejf�lt, hogy az ed�ny tartalma j�l ellepje.\r\nTegy�k a s�t�be �s s�ss�k kb. 45-60 percig, am�g a teteje sz�p aranybarn�ra pirul.";
            rakottKel.Ingredients.Add("kel");
            rakottKel.Ingredients.Add("rizs");
            rakottKel.Ingredients.Add("sajt");
            rakottKel.Ingredients.Add("tejf�l");
            rakottKel.ContainsMeat = false;
            rakottKel.CarbonFootprint = 3.8;
            rakottKrumpli.DishTypeName = "f��tel";

            // T�r�gomb�c Recipe
            Recipe turogomboc = new Recipe();
            turogomboc.RecipeID = 11;
            turogomboc.DishName = "T�r�gomb�c";
            turogomboc.RecipeDescription = "Elk�sz�tj�k a t�r�gomb�c t�szt�j�t: Egy t�lban �sszekeverj�k a t�r�t, toj�st, cukrot �s lisztet. Gy�rjuk �ssze, hogy homog�n t�szta �llagot kapjunk.\r\nForm�ljunk a t�szt�b�l kis gomb�cokat vagy g�mb�ket, �s helyezz�k �ket egy t�ny�rra vagy deszk�ra.\r\nEgy nagyobb l�basban vagy faz�kban forraljunk fel vizet, majd tegy�k bele a gomb�cokat.\r\nF�zz�k a gomb�cokat forr�sban l�v� v�zben, am�g fel nem j�nnek a v�z felsz�n�re, �s megf�ttek (�ltal�ban 8-10 perc).\r\nAmikor a gomb�cok felj�ttek a v�z felsz�n�re, sz�rj�k le �ket, majd tegy�k egy t�lba vagy t�lal� ed�nybe.\r\nOpcion�lisan: K�sz�ts�nk egy kev�s morzs�t: Olvasszunk fel vajat egy serpeny�ben, majd adjunk hozz� zsemlemorzs�t �s keverj�k addig, am�g aranybarn�ra pirul.\r\nT�lalhatjuk a t�r�gomb�cokat tejf�llel �s porcukorral megsz�rva, valamint a pir�tott morzs�val a tetej�n.";
            turogomboc.Ingredients.Add("t�r�");
            turogomboc.Ingredients.Add("toj�s");
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
            elso.TippName = "Ne �ntsd a fest�ket a lefoly�ba!";

            Tipp masodik = new Tipp();
            masodik.TippID = 1;
            masodik.TippName = "Mosogat�g�pet haszn�lni sokkal id�takar�kosabb �s k�rnyezetbar�tabb is, mivel kevesebb v�zet fogyaszt!";

            Tipp harmadik = new Tipp();
            harmadik.TippID = 2;
            harmadik.TippName = "A fenntarthat�s�g �rdek�ben v�lassz �jrahasznos�tott vagy �jrahasznos�that� csomagol�st a v�s�rl�saidhoz!";

            Tipp negyedik = new Tipp();
            negyedik.TippID = 3;
            negyedik.TippName = "Ker�ld az egyszer haszn�latos m�anyagokat �s helyett�k v�lassz �jrahasznos�that� vagy komposzt�lhat� alternat�v�kat!";

            Tipp otodik = new Tipp();
            otodik.TippID = 4;
            otodik.TippName = "Az energiatakar�koss�g�rt pr�b�ld ki az energiahat�kony izz�kat vagy LED l�mp�kat otthonodban!";

            Tipp hatodik = new Tipp();
            hatodik.TippID = 5;
            hatodik.TippName = "A k�zleked�s sor�n v�laszd az alternat�v m�dszereket, mint p�ld�ul a gyalogl�s, bicikliz�s vagy t�megk�zleked�s, hogy cs�kkentsd az egy�ni k�ros k�rnyezeti hat�sokat!";

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

            //ingredientComboBox1.Items.Add("t�r�");
            //ingredientComboBox1.Items.Add("sajt");
            //ingredientComboBox1.Items.Add("tejf�l");

            //ingredientComboBox2.Items.Add("gomba");
            //ingredientComboBox2.Items.Add("paprika");
            //ingredientComboBox2.Items.Add("paradicsom");
            //ingredientComboBox2.Items.Add("hagyma");

            //ingredientComboBox3.Items.Add("toj�s");
            //ingredientComboBox3.Items.Add("marhah�s");
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
                tipus = "f��tel";
            }
            else if (appetizerCheckBox.Checked)
            {
                tipus = "el��tel";
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