using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_scc_management_organization_security_health_analytics_custom_module resource.
/// </summary>
public class GoogleSccManagementOrganizationSecurityHealthAnalyticsCustomModule : TerraformResource
{
    public GoogleSccManagementOrganizationSecurityHealthAnalyticsCustomModule(string name) : base("google_scc_management_organization_security_health_analytics_custom_module", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("ancestor_module");
        this.DeclareOutput("last_editor");
        this.DeclareOutput("name");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The display name of the Security Health Analytics custom module. This
    /// display name becomes the finding category for all findings that are
    /// returned by this custom module. The display name must be between 1 and
    /// 128 characters, start with a lowercase letter, and contain alphanumeric
    /// characters or underscores only.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The enablement state of the custom module. Possible values: [&amp;quot;ENABLED&amp;quot;, &amp;quot;DISABLED&amp;quot;]
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
    /// Location ID of the parent organization. If not provided, &#39;global&#39; will be used as the default location.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// If empty, indicates that the custom module was created in the organization, folder,
    /// or project in which you are viewing the custom module. Otherwise, ancestor_module
    /// specifies the organization or folder from which the custom module is inherited.
    /// </summary>
    public TerraformExpression AncestorModule => this["ancestor_module"];

    /// <summary>
    /// The editor that last updated the custom module.
    /// </summary>
    public TerraformExpression LastEditor => this["last_editor"];

    /// <summary>
    /// The resource name of the custom module. Its format is &amp;quot;organizations/{organization}/locations/{location}/securityHealthAnalyticsCustomModules/{securityHealthAnalyticsCustomModule}&amp;quot;.
    /// The id {securityHealthAnalyticsCustomModule} is server-generated and is not user settable. It will be a numeric id containing 1-20 digits.
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
