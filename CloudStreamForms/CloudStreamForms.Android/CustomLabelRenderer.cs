﻿using Android.Content;
using Android.Graphics;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

//[assembly: ExportFont("Lobster-Regular.ttf", Alias = "Lobster")]
[assembly: ExportRenderer(typeof(Label), typeof(CustomLabelRenderer))]
public class CustomLabelRenderer : LabelRenderer
{
    private Context context;
    public CustomLabelRenderer(Context context) : base(context)
    {
        this.context = context;
    }

    protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
    {
        base.OnElementChanged(e);
        if (Control == null)
            return;
        var tv = Control as global::Android.Widget.TextView;
        tv.VerticalScrollBarEnabled = false;
        if(e.NewElement.ClassId == "OUTLINE") {
            
            //tv.SetOutlineSpotShadowColor(Android.Graphics.Color.Black);
             tv.SetShadowLayer(5f, 5, 5, Android.Graphics.Color.Black);
        }
    }
}
