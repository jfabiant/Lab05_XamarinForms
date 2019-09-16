using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Lab05.pageDesign;

namespace Lab05
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Item1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new pageDesign.ButtonDemo());

            };
            Item2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new pageDesign.ButtonCode());
            };
            Item3.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new pageDesign.DatepickerDemo());

            };
            Item4.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new EditorDemo());

            };
            Item5.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new EditorCode());

            };
            Item6.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new EntryDemo());

            };
            Item7.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new EntryCode());

            };
            Item8.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new pageDesign.LabelDemo());

            };
            Item9.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new LabelCode());

            };
            Item10.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new LocalImage());

            };
            Item11.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new EmbeddedImage());

            };
            //Item12.Clicked += async (sender, e) =>
            //{
            //    await Navigation.PushAsync(new ListViewDemo());

            //};
            //Item13.Clicked += async (sender, e) =>
            //{
            //    await Navigation.PushAsync(new ListViewCode());

            //};
            //Item14.Clicked += async (sender, e) =>
            //{
            //    await Navigation.PushAsync(new ListViewSource());

            //};

        }
    }
}
