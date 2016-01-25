using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EloBuddy.SDK.Menu;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Menu.Values;

namespace Aka_s_Vayne_reworked
{
    class MenuManager
    {
        public static Menu VMenu,
            ComboMenu,
            CondemnMenu,
            HarassMenu,
            FleeMenu,
            LaneClearMenu,
            JungleClearMenu,
            MiscMenu,
            ItemMenu,
            MechanicMenu,
            DrawingMenu;

        public static void Load()
        {
            Mainmenu();
            Combomenu();
            Condemnmenu();
            Harassmenu();
            Fleemenu();
            LaneClearmenu();
            JungleClearmenu();
            Miscmenu();
            Itemmenu();
            Mechanicmenu();
            Drawingmenu();
        }

        public static void Mainmenu()
        {
            VMenu = MainMenu.AddMenu("Vayne - Lolscripts.net", "Lolscripts.net");
            VMenu.AddGroupLabel("Bienvenido al script de VAYNE !! :)");
            VMenu.AddGroupLabel("Lolscripts.net");
        }

        public static void Combomenu()
        {
            ComboMenu = VMenu.AddSubMenu("Combo", "Combo");
            ComboMenu.AddGroupLabel("Combo");
            ComboMenu.AddGroupLabel("Q Modo");
            ComboMenu.AddLabel("1: Mouse 2: Smart 3: Kite Melees");
            ComboMenu.Add("Qmode", new Slider("Q Modo", 2, 1, 3));
            ComboMenu.AddLabel("Smart: 1: Agresiva  2: Defensiva");
            ComboMenu.Add("Qmode2", new Slider("Smart Modo", 1, 1, 2));
            ComboMenu.Add("UseQb", new CheckBox("Usar Q antes AA?", false));
            ComboMenu.Add("UseQa", new CheckBox("Usar Q despues AA?"));
            ComboMenu.AddGroupLabel("Q Config");
            ComboMenu.Add("UseSafeQ", new CheckBox("Dinamica Q Seguridad?", false));
            ComboMenu.Add("UseQE", new CheckBox("No Q contra enemigos?", false));
            ComboMenu.Add("QE", new CheckBox("Intentar QE?", false));
            ComboMenu.Add("UseQspam", new CheckBox("No haga caso de los cheques", false));
            ComboMenu.AddLabel("En Burst Tumble pared Modo Vayne Paredes para un rápido restablecimiento.");
            ComboMenu.Add("Mirin", new CheckBox("Burstmode"));
          //ComboMenu.AddGroupLabel("AA Resets");
          //ComboMenu.AddLabel("Once you untick´d the AA Reset you have to reload[F5]");
          //ComboMenu.Add("AAReset", new CheckBox("Use my AA Reset"));
          //ComboMenu.AddLabel("If your AA´s Cancel use this, or deactivate my AA Reset.");
          //ComboMenu.Add("AACancel", new Slider("AA Cancel", 0, 0, 20));
            ComboMenu.AddGroupLabel("W Config");
            ComboMenu.Add("focusw", new CheckBox("Focus W", false));
            ComboMenu.AddGroupLabel("E Config");
            ComboMenu.Add("Ekill", new CheckBox("Usar E si es matable?"));
            ComboMenu.Add("comboUseE", new CheckBox("Usar E", false));
            ComboMenu.AddGroupLabel("R Config");
            ComboMenu.Add("comboUseR", new CheckBox("Use R", false));
            ComboMenu.Add("RnoAA", new CheckBox("No AA mientras que el sigilo", false));
            ComboMenu.Add("RnoAAs", new Slider("No AA sigilo cuando >= enemigo en rango", 2, 0, 5));
            ComboMenu.Add("comboRSlider", new Slider("Use R if", 2, 1, 5));
        }

        public static void Condemnmenu()
        {
            CondemnMenu = VMenu.AddSubMenu("Condemn", "Condemn");
            CondemnMenu.AddGroupLabel("Condemn");
            // CondemnMenu.AddLabel("1: Perfect 2: Smart 3: Sharpshooter 4: Gosu 5: VHR");
            // CondemnMenu.AddLabel("6: Fastest 7: Legacy 8: Marksman 9: Old 10: Hiki 11: VHR2 12: Fluxys");
            CondemnMenu.AddLabel("1:Mejor 2:Nuevo 3:Adc 4:Brillar");
            //CondemnMenu.Add("Condemnmode", new Slider("Condemn Mode", 3, 1, 3));
            //  CondemnMenu.Add("Condemnmode", new Slider("Condemn Mode", 4, 1, 12));
            CondemnMenu.Add("Condemnmode", new Slider("Condemn Modo", 1, 1, 4));
            //CondemnMenu.Add("condemnmethod1", new CheckBox("Condemn 1(Hiki)", false));
            //CondemnMenu.Add("condemnmethod2", new CheckBox("Condemn 2(VHR)", false));
            //CondemnMenu.Add("condemnmethod3", new CheckBox("Condemn 3(Fluxy)"));
            CondemnMenu.Add("UseEauto", new CheckBox("Usar auto E?"));
            CondemnMenu.Add("UseEc", new CheckBox("Sólo stunear objetivo actual (target)?", false));
            CondemnMenu.Add("condemnPercent", new Slider("Condemn Hitchance %", 33, 1));
            CondemnMenu.Add("noeaa", new Slider("No E si el objetivo puede ser muerto x AA´s", 0, 0, 4));
            CondemnMenu.Add("trinket", new CheckBox("Usar trinket bush?"));
            CondemnMenu.Add("pushDistance", new Slider("Condemn Empuje Distancia", 420, 350, 470));
        }

        public static void Harassmenu()
        {
            HarassMenu = VMenu.AddSubMenu("Tirar", "Tirar");
            HarassMenu.AddGroupLabel("Tirar");
            HarassMenu.AddLabel("Yo preferiría que marque sólo 1 de los opciones, prefiero el de Q.");
            HarassMenu.Add("UseQHarass", new CheckBox("Usar Q(si 2 W stacks)"));
            HarassMenu.Add("UseEHarass", new CheckBox("Usar E(si 2 W stacks)", false));
            HarassMenu.Add("UseCHarass", new CheckBox("Usar Combo: AA -> Q+AA -> E(Propbli Trabajo)", false));
            HarassMenu.Add("ManaHarass", new Slider("Uso máximo de maná en porcentaje ({0}%)", 40));
        }

        public static void Fleemenu()
        {
            FleeMenu = VMenu.AddSubMenu("Huir", "Huir");
            FleeMenu.AddGroupLabel("Huir");
            FleeMenu.Add("FleeUseQ", new CheckBox("Usar Q"));
            FleeMenu.Add("FleeUseE", new CheckBox("Usar E"));
        }

        public static void LaneClearmenu()
        {
            LaneClearMenu = VMenu.AddSubMenu("LaneClear", "LaneClear");
            LaneClearMenu.AddGroupLabel("LaneClear");
            LaneClearMenu.Add("LCQ", new CheckBox("Usar Q"));
            LaneClearMenu.Add("LCQMana", new Slider("Uso máximo de maná en porcentaje ({0}%)", 40));
        }

        public static void JungleClearmenu()
        {
            JungleClearMenu = VMenu.AddSubMenu("JungleClear", "JungleClear");
            JungleClearMenu.AddGroupLabel("JungleClear");
            JungleClearMenu.Add("JCQ", new CheckBox("Usar Q"));
            JungleClearMenu.Add("JCE", new CheckBox("Usar E"));
        }

        public static void Miscmenu()
        {
            MiscMenu = VMenu.AddSubMenu("Otros", "Otros");
            MiscMenu.AddGroupLabel("Otros");
            MiscMenu.AddLabel("www.lolscripts.net");
            MiscMenu.Add("GapcloseE", new CheckBox("Gapclose E"));
            MiscMenu.Add("AntiRengar", new CheckBox("Anti Rengar"));
            MiscMenu.Add("AntiKalista", new CheckBox("Anti Kalista"));
            MiscMenu.Add("AntiPanth", new CheckBox("Anti Pantheon"));
            MiscMenu.Add("fpsdrop", new CheckBox("Anti Fps Drop", false));
            MiscMenu.Add("InterruptE", new CheckBox("Interrumpir hechizos con E?"));
            MiscMenu.Add("LowLifeE", new CheckBox("Mala vida E", false));
            var dangerSlider = MiscMenu.Add("dangerLevel", new Slider("Establezca su Peligro de nivel: ", 3, 1, 3));
            var dangerSliderDisplay = MiscMenu.Add("dangerLevelDisplay",
                new Label("Peligro de nivel: " + Variables.DangerSliderValues[dangerSlider.Cast<Slider>().CurrentValue - 1]));
            dangerSlider.Cast<Slider>().OnValueChange += delegate
            {
                dangerSliderDisplay.Cast<Label>().DisplayName =
                    "Peligro de nivel: " + Variables.DangerSliderValues[dangerSlider.Cast<Slider>().CurrentValue - 1];
            };
        }

        public static void Itemmenu()
        {
            ItemMenu = VMenu.AddSubMenu("Activador", "Activador");
            ItemMenu.AddGroupLabel("Items");
            ItemMenu.AddLabel("Pregúntame si usted necesita más items.");
            ItemMenu.Add("botrk", new CheckBox("Usar Rey Arruinado & Bilge"));
            ItemMenu.Add("you", new CheckBox("Usar Yoummmus"));
            ItemMenu.Add("yous", new Slider("Si esta a distancia >", 1000, 0, 1500));
            ItemMenu.Add("autopotion", new CheckBox("Auto Healpotion"));
            ItemMenu.Add("autopotionhp", new Slider("HpPot if hp =>", 60));
            ItemMenu.AddGroupLabel("Invocadores");
            ItemMenu.AddLabel("Pregúntame si usted necesita más invocadores.");
            ItemMenu.Add("heal", new CheckBox("Heal"));
            ItemMenu.Add("hp", new Slider("Heal si mi HP <=", 20, 0, 100));
            ItemMenu.Add("healally", new CheckBox("Heal aliado"));
            ItemMenu.Add("hpally", new Slider("Tirar heal si mi aliado tiene vida <=", 20, 0, 100));
            ItemMenu.AddGroupLabel("Qss");
            ItemMenu.Add("qss", new CheckBox("Usar Qss"));
            ItemMenu.Add("delay", new Slider("Delay", 1000, 0, 2000));
            ItemMenu.Add("Blind",
                new CheckBox("Blind", false));
            ItemMenu.Add("Charm",
                new CheckBox("Charm"));
            ItemMenu.Add("Fear",
                new CheckBox("Fear"));
            ItemMenu.Add("Polymorph",
                new CheckBox("Polymorph"));
            ItemMenu.Add("Stun",
                new CheckBox("Stun"));
            ItemMenu.Add("Snare",
                new CheckBox("Snare"));
            ItemMenu.Add("Silence",
                new CheckBox("Silence", false));
            ItemMenu.Add("Taunt",
                new CheckBox("Taunt"));
            ItemMenu.Add("Suppression",
                new CheckBox("Suppression"));
        }

        public static void Mechanicmenu()
        {
            MechanicMenu = VMenu.AddSubMenu("Extras", "Extras");
            MechanicMenu.AddGroupLabel("Mecanicas");
            MechanicMenu.Add("flashe", new KeyBind("Flash Condemn!", false, KeyBind.BindTypes.HoldActive, 'Y'));
            MechanicMenu.Add("insece", new KeyBind("Flash Insec!", false, KeyBind.BindTypes.HoldActive, 'Z'));
            MechanicMenu.AddLabel("1: Para Aliados 2: A torre 3: A Mouse");
            MechanicMenu.Add("insecmodes", new Slider("Insec Modo", 1, 1, 3));
            MechanicMenu.AddGroupLabel("Utilidad");
            MechanicMenu.Add("skinhack", new CheckBox("Activar Skin hack"));
            MechanicMenu.Add("skinId", new Slider("Skin Hack", 0, 0, 9));
            MechanicMenu.Add("autobuy", new CheckBox("Autocomprar Starters/Trinkets"));
            MechanicMenu.AddLabel("1: Max W 2: Max Q(my estilo :3)");
            MechanicMenu.Add("autolvl", new CheckBox("Activatar Auto level"));
            MechanicMenu.Add("autolvls", new Slider("Level Modo", 1, 1, 2));
            switch (MechanicMenu["autolvls"].Cast<Slider>().CurrentValue)
            {
                case 1:
                    Variables.AbilitySequence = new[] { 1, 3, 2, 2, 2, 4, 2, 1, 2, 1, 4, 1, 1, 3, 3, 4, 3, 3 };
                    break;
                case 2:
                    Variables.AbilitySequence = new[] { 1, 3, 2, 1, 1, 4, 1, 2, 1, 2, 4, 2, 2, 3, 3, 4, 3, 3 };
                    break;
            }
        }

        public static void Drawingmenu()
        {
            DrawingMenu = VMenu.AddSubMenu("Circulos", "Circulos");
            DrawingMenu.AddGroupLabel("Circulos");
            DrawingMenu.Add("DrawQ", new CheckBox("Draw Q", false));
            DrawingMenu.Add("DrawE", new CheckBox("Draw E", false));
            DrawingMenu.Add("DrawOnlyReady", new CheckBox("Draw Sólo si Hechizos están listos"));
        }

    }
}
