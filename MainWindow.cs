using System;
using SFML.Graphics;
using SFML.Window;

namespace CS_Narvel
{
     class MainWindow
     {
          RenderWindow window;
          public MainWindow()
          {
               VideoMode mode = new VideoMode(600, 400);
               window = new RenderWindow(mode, "Narvel");

               window.Closed += onClose;
               window.KeyPressed += key_handler;

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

          private void onClose(Object sender, EventArgs e)
          {
               window.Close();
          }
     }
}