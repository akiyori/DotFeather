namespace DotFeather.Demo
{
    [DemoScene("/drawable/sprite")]
    [Description("en", "Generate, display and move sprites")]
    [Description("ja", "スプライトを生成して表示し、動かします")]
    public class SpriteExampleScene : Scene
    {
        public override void OnStart(Router router, GameBase game, System.Collections.Generic.Dictionary<string, object> args)
        {
            game.Print("Press ESC to return");
        }

        public override void OnUpdate(Router router, GameBase game, DFEventArgs e)
        {
            if (DFKeyboard.Escape.IsKeyUp)
                router.ChangeScene<LauncherScene>();
        }
    }

}
