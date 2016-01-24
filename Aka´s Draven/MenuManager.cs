
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EloBuddy.SDK.Menu;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Menu.Values;

namespace AkaDraven
{
    internal class MenuManager
    {
        public static Menu YMenu,
            ComboMenu,
            AxeMenu,
            HarassMenu,
            LaneClearMenu,
            MiscMenu,
            FleeMenu,
            KillStealMenu,
            DrawingMenu,
            ItemMenu;

        public static void Load()
        {
            Mainmenu();
            Axemenu();
            Combomenu();
            Harassmenu();
            Fleemenu();
            LaneClearmenu();
            Miscmenu();
            KillStealmenu();
            Drawingmenu();
            Itemmenu();
        }

        public static void Mainmenu()
        {
            YMenu = MainMenu.AddMenu("Aka´s Draven", "akasdraven");
            YMenu.AddGroupLabel("Bienvenidos al addon de Draaaaven - Lolscripts.net! :)");
        }

        public static void Combomenu()
        {
            ComboMenu = YMenu.AddSubMenu("Combo", "Combo");
            ComboMenu.AddGroupLabel("Combo");
            ComboMenu.Add("Q", new CheckBox("Usar Q"));
            ComboMenu.Add("W", new CheckBox("Usar W"));
            ComboMenu.Add("E", new CheckBox("Usar E"));
            ComboMenu.Add("R", new CheckBox("Usar R"));
        }

        public static void Axemenu()
        {
            AxeMenu = YMenu.AddSubMenu("Axe Ajustes", "Axe Ajustes");
            AxeMenu.AddGroupLabel("Axe Ajustes");
            AxeMenu.AddLabel("1: Combo 2: Any 3: Siempre");
            AxeMenu.Add("Qmode", new Slider("Axe Modo de captura:", 3, 1, 3));
            AxeMenu.Add("Qrange", new Slider("Catch Axe Rango:", 800, 120, 1500));
            AxeMenu.Add("Qmax", new Slider("maximo Axes:", 2, 1, 3));
            AxeMenu.Add("WforQ", new CheckBox("Usar W si axe esta demasiado lejos"));
            AxeMenu.Add("Qunderturret", new CheckBox("No debe quedar atrapado debajo de la torreta"));
        }

        public static void Harassmenu()
        {
            HarassMenu = YMenu.AddSubMenu("Tirar", "Tirar");
            HarassMenu.Add("E", new CheckBox("Usar E"));
            HarassMenu.Add("AutoE", new KeyBind("Auto Tirar", true, KeyBind.BindTypes.PressToggle, 'G'));
        }

        public static void Fleemenu()
        {
            FleeMenu = YMenu.AddSubMenu("Huir", "Huir");
            FleeMenu.Add("E", new CheckBox("Usar E"));
            FleeMenu.Add("W", new CheckBox("Usar W"));
        }

        public static void LaneClearmenu()
        {
            LaneClearMenu = YMenu.AddSubMenu("Limpiar Linea", "Limpiar Linea");
            LaneClearMenu.Add("Q", new CheckBox("Usar Q"));
            LaneClearMenu.Add("W", new CheckBox("Usar W"));
            LaneClearMenu.Add("Mana", new Slider("Configuracion de Mana", 50));
        }

        public static void KillStealmenu()
        {
            KillStealMenu = YMenu.AddSubMenu("KillSteal", "KillSteal");
            KillStealMenu.Add("KsE", new CheckBox("Usar E"));
            KillStealMenu.Add("KsIgnite", new CheckBox("Usar Ignite"));
        }

        public static void Miscmenu()
        {
            MiscMenu = YMenu.AddSubMenu("Otros", "Otros");
            MiscMenu.Add("UseEInterrupt", new CheckBox("Usar E para interrumpir"));
            MiscMenu.Add("UseWInstant", new CheckBox("Usar W instantaneamente", false));
            MiscMenu.Add("UseWSlow", new CheckBox("Usar W si relentiza"));
            MiscMenu.Add("WMana", new Slider("W Configurancion del mana", 50));
            MiscMenu.Add("autolvl", new CheckBox("Activar auto Nivel"));
        }

        public static void Drawingmenu()
        {
            DrawingMenu = YMenu.AddSubMenu("Circulos", "Circulos");
            DrawingMenu.Add("DrawE", new CheckBox("Draw E"));
            DrawingMenu.Add("DrawAxe", new CheckBox("Draw Axe"));
            DrawingMenu.Add("Dibuja Rango capturas Axe", new CheckBox("Dibuja Rango capturas Axe"));
        }

        public static void Itemmenu()
        {
            ItemMenu = YMenu.AddSubMenu("Items", "QSS");
            ItemMenu.Add("Items", new CheckBox("Usar Items"));
            ItemMenu.Add("myhp", new Slider("Uar Rey Arruinado si mi vida esta en <=", 70, 0, 101));
            ItemMenu.AddSeparator();
            ItemMenu.Add("use", new KeyBind("Usar QSS/Mercurial", true, KeyBind.BindTypes.PressToggle, 'K'));
            ItemMenu.Add("delay", new Slider("Activacion de delay", 1000, 0, 2000));
            ItemMenu.Add("Blind",
                new CheckBox("Ciego", false));
            ItemMenu.Add("Charm",
                new CheckBox("Hechizo"));
            ItemMenu.Add("Fear",
                new CheckBox("Temor"));
            ItemMenu.Add("Polymorph",
                new CheckBox("Organismo polimorfo"));
            ItemMenu.Add("Stun",
                new CheckBox("Stun"));
            ItemMenu.Add("Snare",
                new CheckBox("Snare"));
            ItemMenu.Add("Silence",
                new CheckBox("Silenciar", false));
            ItemMenu.Add("Taunt",
                new CheckBox("Taunt"));
            ItemMenu.Add("Suppression",
                new CheckBox("Supresión"));
        }
    }
}
