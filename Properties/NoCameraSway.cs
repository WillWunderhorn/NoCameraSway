using MelonLoader;

namespace NoCameraSway
{

    public class NoCameraSway : MelonMod
    {
        public override void OnInitializeMelon()
        {
            LoggerInstance.Msg("Original mod by: " + BuildInfo.OriginalAuthor + " Fixed by: " + BuildInfo.ModAuthor);
        }
    }
}
