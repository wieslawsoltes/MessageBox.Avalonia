using System;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using MessageBox.Avalonia.BaseWindows.Base;
using MessageBox.Avalonia.Enums;

namespace MessageBox.Avalonia.Views
{
    public class MsBoxStandardWindow : BaseWindow, IWindowGetResult<ButtonResult>
    {
        public MsBoxStandardWindow() : base()
        {
            InitializeComponent();
        }

        public ButtonResult ButtonResult { get; set; } = ButtonResult.None;

        public ButtonResult GetResult() => ButtonResult;


        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        protected override void OnOpened(EventArgs e)
        {
            base.OnOpened(e);

            // Hack to fix scroll bar and limits
            if (SizeToContent != SizeToContent.Manual)
            {
                SizeToContent = SizeToContent.Manual;
                Width--;
                Height--;
            }
        }
    }
}