using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_network_management_connectivity_test resource.
/// </summary>
public class GoogleNetworkManagementConnectivityTest : TerraformResource
{
    public GoogleNetworkManagementConnectivityTest(string name) : base("google_network_management_connectivity_test", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("terraform_labels");
    }

    /// <summary>
    /// Whether the analysis should skip firewall checking. Default value is false.
    /// </summary>
    public bool? BypassFirewallChecks
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("bypass_firewall_checks")?.Value;
        set => this.WithProperty("bypass_firewall_checks", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The user-supplied description of the Connectivity Test.
    /// Maximum of 512 characters.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Resource labels to represent user-provided metadata.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, string>? Labels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("labels")?.Value;
        set => this.WithProperty("labels", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// Unique name for the connectivity test.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// IP Protocol of the test. When not provided, &amp;quot;TCP&amp;quot; is assumed.
    /// </summary>
    public string? Protocol
    {
        get => GetProperty<TerraformLiteralProperty<string>>("protocol")?.Value;
        set => this.WithProperty("protocol", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Other projects that may be relevant for reachability analysis.
    /// This is applicable to scenarios where a test can cross project
    /// boundaries.
    /// </summary>
    public List<string>? RelatedProjects
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("related_projects")?.Value;
        set => this.WithProperty("related_projects", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// Whether run analysis for the return path from destination to source.
    /// Default value is false.
    /// </summary>
    public bool? RoundTrip
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("round_trip")?.Value;
        set => this.WithProperty("round_trip", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
