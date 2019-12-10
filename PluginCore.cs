namespace EnqueueActionExamplePlugin
{
    [Decal.Adapter.FriendlyName("EnqeueActionExamplePlugin")]
    public partial class PluginCore : Decal.Adapter.PluginBase
    {
        protected override void Startup()
        {
            try
            {
                Core.CharacterFilter.LoginComplete += CharacterFilter_LoginComplete;
            }
            catch (System.Exception ex)
            {
                // Nothing
            }
        }

        protected override void Shutdown()
        {
            try
            {
                Core.CharacterFilter.LoginComplete -= CharacterFilter_LoginComplete;
            }
            catch (System.Exception ex)
            {
                // Nothing
            }
        }

        private void CharacterFilter_LoginComplete(object sender, System.EventArgs e)
        {
            try
            {
                Core.Actions.AddChatText("EnqueueActionExamplePlugin.LoginComplete()", 1);
            }
            catch (System.Exception ex)
            {
                // Nothing
            }
        }
    }
}
