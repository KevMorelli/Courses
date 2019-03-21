using Xamarin.Forms;

namespace StarWarsSample.Forms.UI.Components
{
    public partial class InformationFormsView : Grid
    {
        public InformationFormsView()
        {
            InitializeComponent();
        }

        public string LabelText
        {
            get { return (string)GetValue(LabelTextProperty); }
            set { SetValue(LabelTextProperty, value); }
        }

        public static readonly BindableProperty LabelTextProperty = BindableProperty.Create
        (
            nameof(LabelText),
            typeof(string),
            typeof(InformationFormsView),
            default(string),
            BindingMode.OneWay,
            propertyChanged: (bindable, oldVal, newVal) =>
            {
                var view = (InformationFormsView)bindable;

                view.Label.Text = (string)newVal;
            }
        );

        public string ValueText
        {
            get { return (string)GetValue(ValueTextProperty); }
            set { SetValue(ValueTextProperty, value); }
        }

        public static readonly BindableProperty ValueTextProperty = BindableProperty.Create
        (
            nameof(ValueText),
            typeof(string),
            typeof(InformationFormsView),
            default(string),
            BindingMode.OneWay,
            propertyChanged: (bindable, oldVal, newVal) =>
            {
                var view = (InformationFormsView)bindable;

                view.Value.Text = (string)newVal;
            }
        );

        public Color ValueColor
        {
            get { return (Color)GetValue(ValueColorProperty); }
            set { SetValue(ValueColorProperty, value); }
        }

        public static readonly BindableProperty ValueColorProperty = BindableProperty.Create
        (
            nameof(ValueColor),
            typeof(Color),
            typeof(InformationFormsView),
            default(Color),
            BindingMode.OneWay,
            propertyChanged: (bindable, oldVal, newVal) =>
            {
                var view = (InformationFormsView)bindable;

                view.Value.TextColor = (Color)newVal;
            }
        );
    }
}
