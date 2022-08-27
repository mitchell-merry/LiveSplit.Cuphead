using System;
using LiveSplit.Model;
using System.Reflection;

namespace LiveSplit.UI.Components
{
    public class CupheadFactory : IComponentFactory
    {
        public string ComponentName => "Cuphead Autosplitter v" + Version.ToString();
        public string Description => "Controls the timer for Cuphead speedruns.";
        public ComponentCategory Category => ComponentCategory.Control;
        public IComponent Create(LiveSplitState state) => new CupheadComponent(state);
        public string UpdateName => ComponentName;
        public string UpdateURL => "https://raw.githubusercontent.com/mitchell-merry/LiveSplit.Cuphead/main/";
        public string XMLURL => UpdateURL + "Components/Updates.xml";
        public Version Version => Assembly.GetExecutingAssembly().GetName().Version;
    }
}
