using Orchard.UI.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Foundation
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(ResourceManifestBuilder builder)
        {
            var manifest = builder.Add();

            manifest.DefineStyle("openSans").SetCdn("http://fonts.googleapis.com/css?family=Open+Sans:400,300");

            manifest.DefineScript("foundation").SetUrl("foundation/foundation.js").SetDependencies("jQuery");
            manifest.DefineScript("foundation_alerts").SetUrl("foundation/foundation.alerts.js").SetDependencies("foundation");
            manifest.DefineScript("foundation_clearing").SetUrl("foundation/foundation.clearing.js").SetDependencies("foundation");
            manifest.DefineScript("foundation_cookie").SetUrl("foundation/foundation.cookie.js").SetDependencies("foundation");
            manifest.DefineScript("foundation_dropdown").SetUrl("foundation/foundation.dropdown.js").SetDependencies("foundation");
            manifest.DefineScript("foundation_forms").SetUrl("foundation/foundation.forms.js").SetDependencies("foundation");
            manifest.DefineScript("foundation_joyride").SetUrl("foundation/foundation.joyride.js").SetDependencies("foundation");
            manifest.DefineScript("foundation_magellan").SetUrl("foundation/foundation.magellan.js").SetDependencies("foundation");
            manifest.DefineScript("foundation_orbit").SetUrl("foundation/foundation.orbit.js").SetDependencies("foundation");
            manifest.DefineScript("foundation_placeholder").SetUrl("foundation/foundation.placeholder.js").SetDependencies("foundation");
            manifest.DefineScript("foundation_reveal").SetUrl("foundation/foundation.reveal.js").SetDependencies("foundation");
            manifest.DefineScript("foundation_section").SetUrl("foundation/foundation.section.js").SetDependencies("foundation");
            manifest.DefineScript("foundation_tooltips").SetUrl("foundation/foundation.tooltips.js").SetDependencies("foundation");
            manifest.DefineScript("foundation_topbar").SetUrl("foundation/foundation.topbar.js").SetDependencies("foundation");

            manifest.DefineScript("modernizr").SetUrl("modernizr-2.6.2.js").SetVersion("2.6.2");
        }
    }
}