using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_scc_event_threat_detection_custom_module resource.
/// </summary>
public class GoogleSccEventThreatDetectionCustomModule : TerraformResource
{
    public GoogleSccEventThreatDetectionCustomModule(string name) : base("google_scc_event_threat_detection_custom_module", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("last_editor");
        this.DeclareOutput("name");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// Config for the module. For the resident module, its config value is defined at this level.
    /// For the inherited module, its config value is inherited from the ancestor module.
    /// </summary>
    public TerraformProperty<string>? Config
    {
        get => GetProperty<TerraformProperty<string>>("config");
        set => this.WithProperty("config", value);
    }

    /// <summary>
    /// The human readable name to be displayed for the module.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The state of enablement for the module at the given level of the hierarchy. Possible values: [&amp;quot;ENABLED&amp;quot;, &amp;quot;DISABLED&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? EnablementState
    {
        get => GetProperty<TerraformProperty<string>>("enablement_state");
        set => this.WithProperty("enablement_state", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Numerical ID of the parent organization.
    /// </summary>
    public TerraformProperty<string>? Organization
    {
        get => GetProperty<TerraformProperty<string>>("organization");
        set => this.WithProperty("organization", value);
    }

    /// <summary>
    /// Immutable. Type for the module. e.g. CONFIGURABLE_BAD_IP.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The editor that last updated the custom module
    /// </summary>
    public TerraformExpression LastEditor => this["last_editor"];

    /// <summary>
    /// The resource name of the Event Threat Detection custom module.
    /// Its format is &amp;quot;organizations/{organization}/eventThreatDetectionSettings/customModules/{module}&amp;quot;.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The time at which the custom module was last updated.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and
    /// up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
