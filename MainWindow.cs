using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace CS_Narvel
{
     class MainWindow
     {
          RenderWindow window;
          static Vector2f rect_size = new Vector2f(50,50);

          RectangleShape r = new RectangleShape(rect_size);

          public MainWindow()
          {
               VideoMode mode = new VideoMode(600, 400);
               window = new RenderWindow(mode, "Narvel");

               window.Closed += WindowClose;
               window.KeyPressed += key_handler;
               window.LostFocus += WindowClose;

               while (window.IsOpen)
               {
                   window.DispatchEvents();
                   window.Display();
               }
          }

          private void key_handler(Object sender, KeyEventArgs e)
          {
               switch (e.Code)
               {
                    case Keyboard.Key.Escape:
                         window.Close();
                         break;
               }
          }

          private void WindowClose(Object sender, EventArgs e)
          {
               window.Close();
          }
     }
}