using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_scc_management_organization_event_threat_detection_custom_module resource.
/// </summary>
public class GoogleSccManagementOrganizationEventThreatDetectionCustomModule : TerraformResource
{
    public GoogleSccManagementOrganizationEventThreatDetectionCustomModule(string name) : base("google_scc_management_organization_event_threat_detection_custom_module", name)
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
    public string? Config
    {
        get => GetProperty<TerraformLiteralProperty<string>>("config")?.Value;
        set => this.WithProperty("config", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The human readable name to be displayed for the module.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The state of enablement for the module at the given level of the hierarchy. Possible values: [&amp;quot;ENABLED&amp;quot;, &amp;quot;DISABLED&amp;quot;]
    /// </summary>
    public string? EnablementState
    {
        get => GetProperty<TerraformLiteralProperty<string>>("enablement_state")?.Value;
        set => this.WithProperty("enablement_state", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Location ID of the parent organization. Only global is supported at the moment.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Numerical ID of the parent organization.
    /// </summary>
    public string? Organization
    {
        get => GetProperty<TerraformLiteralProperty<string>>("organization")?.Value;
        set => this.WithProperty("organization", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Immutable. Type for the module. e.g. CONFIGURABLE_BAD_IP.
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type")?.Value;
        set => this.WithProperty("type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The editor that last updated the custom module
    /// </summary>
    public TerraformExpression LastEditor => this["last_editor"];

    /// <summary>
    /// The resource name of the Event Threat Detection custom module.
    /// Its format is &amp;quot;organizations/{organization}/locations/{location}/eventThreatDetectionCustomModules/{eventThreatDetectionCustomModule}&amp;quot;.
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
