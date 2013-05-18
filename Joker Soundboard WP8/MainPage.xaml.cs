using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Phone.Tasks;

namespace Joker_Soundboard
{
    public partial class MainPage : PhoneApplicationPage

    {
        bool fromHold;
        SaveRingtoneTask customRingtone;
        public static Stream LaughStream = TitleContainer.OpenStream("Sounds/Laugh.wav");
        public static SoundEffect LaughEffect = SoundEffect.FromStream(LaughStream);
        public static Stream EveningStream = TitleContainer.OpenStream("Sounds/Evening commissioner.wav");
        public static SoundEffect EveningEffect = SoundEffect.FromStream(EveningStream);
        public static Stream CardStream = TitleContainer.OpenStream("Sounds/Here's my card.wav");
        public static SoundEffect CardEffect = SoundEffect.FromStream(CardStream);
        public static Stream HereWeGoStream = TitleContainer.OpenStream("Sounds/Here we go.wav");
        public static SoundEffect HereWeGoEffect = SoundEffect.FromStream(HereWeGoStream);
        public static Stream WordStream = TitleContainer.OpenStream("Sounds/I'm a man of my word.wav");
        public static SoundEffect WordEffect = SoundEffect.FromStream(WordStream);
        public static Stream PlanStream = TitleContainer.OpenStream("Sounds/It's all part of the plan.wav");
        public static SoundEffect PlanEffect = SoundEffect.FromStream(PlanStream);
        public static Stream KillStream = TitleContainer.OpenStream("Sounds/Kill the Batman.wav");
        public static SoundEffect KillEffect = SoundEffect.FromStream(KillStream);
        public static Stream SmileStream = TitleContainer.OpenStream("Sounds/Let's put a smile on that face.wav");
        public static SoundEffect SmileEffect = SoundEffect.FromStream(SmileStream);
        public static Stream SeriousStream = TitleContainer.OpenStream("Sounds/Why so serious.wav");
        public static SoundEffect SeriousEffect = SoundEffect.FromStream(SeriousStream);
        public static Stream BeautifulStream = TitleContainer.OpenStream("Sounds/Hello beautiful.wav");
        public static SoundEffect BeautifulEffect = SoundEffect.FromStream(BeautifulStream);
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            customRingtone = new SaveRingtoneTask();
            customRingtone.Completed += new EventHandler<TaskEventArgs>(customRingtone_Completed);

        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (fromHold != true)
            {
                FrameworkDispatcher.Update();
                WordEffect.Play();
            }
            fromHold = false;
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            if (fromHold != true)
            {
                FrameworkDispatcher.Update();
                HereWeGoEffect.Play();
            }
            fromHold = false;
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (fromHold != true)
            {
                FrameworkDispatcher.Update();
                LaughEffect.Play();
            }
            fromHold = false;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (fromHold != true)
            {
                FrameworkDispatcher.Update();
                SeriousEffect.Play();
            }
            fromHold = false;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (fromHold != true)
            {
                FrameworkDispatcher.Update();
                KillEffect.Play();
            }
            fromHold = false;
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (fromHold != true)
            {
                FrameworkDispatcher.Update();
                CardEffect.Play();
            }
            fromHold = false;
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (fromHold != true)
            {
                FrameworkDispatcher.Update();
                SmileEffect.Play();
            }
            fromHold = false;
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (fromHold != true)
            {
                FrameworkDispatcher.Update();
                BeautifulEffect.Play();
            }
            fromHold = false;
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (fromHold != true)
            {
                FrameworkDispatcher.Update();
                PlanEffect.Play();
            }
            fromHold = false;
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            if (fromHold != true)
            {
                FrameworkDispatcher.Update();
                EveningEffect.Play();
            }
            fromHold = false;
        }
        private void ApplicationBarIconHelpButton_Click(object sender, EventArgs e)
        {
            EmailComposeTask emailcomposer = new EmailComposeTask();
            emailcomposer.To = "joker-soundboard@timrogers.co.uk";
            emailcomposer.Subject = "Joker Soundboard Suggestions";
            emailcomposer.Show();

        }

        private void button10_Hold(object sender, GestureEventArgs e)
        {
            fromHold = true;
            customRingtone.Source = new Uri("appdata:/Ringtones/Evening commissioner.mp3");
            customRingtone.DisplayName = "Evening commissioner";
            customRingtone.Show();
        }
        void customRingtone_Completed(object sender, TaskEventArgs e)
        {
            switch (e.TaskResult)
            {
                case TaskResult.OK:
                    MessageBox.Show("The ringtone was saved successfully.");
                    break;
                case TaskResult.Cancel:;
                    break;
                case TaskResult.None:
                    break;
            }
        }

        private void button9_Hold(object sender, GestureEventArgs e)
        {
            fromHold = true;
            customRingtone.Source = new Uri("appdata:/Ringtones/Here we go.mp3");
            customRingtone.DisplayName = "Here we go";
            customRingtone.Show();
        }

        private void button8_Hold(object sender, GestureEventArgs e)
        {
            fromHold = true;
            customRingtone.Source = new Uri("appdata:/Ringtones/It's all part of the plan.mp3");
            customRingtone.DisplayName = "It's all part of the plan";
            customRingtone.Show();
        }

        private void button7_Hold(object sender, GestureEventArgs e)
        {
            fromHold = true;
            customRingtone.Source = new Uri("appdata:/Ringtones/Hello beautiful.mp3");
            customRingtone.DisplayName = "Hello beautiful";
            customRingtone.Show();
        }

        private void button6_Hold(object sender, GestureEventArgs e)
        {
            fromHold = true;
            customRingtone.Source = new Uri("appdata:/Ringtones/I'm a man of my word.mp3");
            customRingtone.DisplayName = "I'm a man of my word";
            customRingtone.Show();
        }

        private void button5_Hold(object sender, GestureEventArgs e)
        {
            fromHold = true;
            customRingtone.Source = new Uri("appdata:/Ringtones/Let's put a smile on that face.mp3");
            customRingtone.DisplayName = "Let's put a smile on that face";
            customRingtone.Show();
        }

        private void button4_Hold(object sender, GestureEventArgs e)
        {
            fromHold = true;
            customRingtone.Source = new Uri("appdata:/Ringtones/Here's my card.mp3");
            customRingtone.DisplayName = "Here's my card";
            customRingtone.Show();
        }

        private void button3_Hold(object sender, GestureEventArgs e)
        {
            fromHold = true;
            customRingtone.Source = new Uri("appdata:/Ringtones/Kill the Batman.mp3");
            customRingtone.DisplayName = "Kill the Batman";
            customRingtone.Show();
        }

        private void button2_Hold(object sender, GestureEventArgs e)
        {
            fromHold = true;
            customRingtone.Source = new Uri("appdata:/Ringtones/Laugh.mp3");
            customRingtone.DisplayName = "Joker Laugh";
            customRingtone.Show();
        }

        private void button1_Hold(object sender, GestureEventArgs e)
        {
            fromHold = true;
            customRingtone.Source = new Uri("appdata:/Ringtones/Why so serious.mp3");
            customRingtone.DisplayName = "Why so serious?";
            customRingtone.Show();
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            MarketplaceReviewTask marketplaceReviewTask = new MarketplaceReviewTask();
            marketplaceReviewTask.Show();
        }
    }
}