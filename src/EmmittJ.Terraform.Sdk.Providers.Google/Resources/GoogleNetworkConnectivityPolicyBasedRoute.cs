using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_network_connectivity_policy_based_route resource.
/// </summary>
public class GoogleNetworkConnectivityPolicyBasedRoute : TerraformResource
{
    public GoogleNetworkConnectivityPolicyBasedRoute(string name) : base("google_network_connectivity_policy_based_route", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("kind");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("update_time");
        this.DeclareOutput("warnings");
    }

    /// <summary>
    /// An optional description of this resource.
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
    /// User-defined labels.
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
    /// The name of the policy based route.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Fully-qualified URL of the network that this route applies to, for example: projects/my-project/global/networks/my-network.
    /// </summary>
    public string? Network
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network")?.Value;
        set => this.WithProperty("network", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The IP address of a global-access-enabled L4 ILB that is the next hop for matching packets.
    /// </summary>
    public string? NextHopIlbIp
    {
        get => GetProperty<TerraformLiteralProperty<string>>("next_hop_ilb_ip")?.Value;
        set => this.WithProperty("next_hop_ilb_ip", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Other routes that will be referenced to determine the next hop of the packet. Possible values: [&amp;quot;DEFAULT_ROUTING&amp;quot;]
    /// </summary>
    public string? NextHopOtherRoutes
    {
        get => GetProperty<TerraformLiteralProperty<string>>("next_hop_other_routes")?.Value;
        set => this.WithProperty("next_hop_other_routes", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The priority of this policy-based route. Priority is used to break ties in cases where there are more than one matching policy-based routes found. In cases where multiple policy-based routes are matched, the one with the lowest-numbered priority value wins. The default value is 1000. The priority value must be from 1 to 65535, inclusive.
    /// </summary>
    public double? Priority
    {
        get => GetProperty<TerraformLiteralProperty<double>>("priority")?.Value;
        set => this.WithProperty("priority", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// Time when the policy-based route was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Type of this resource.
    /// </summary>
    public TerraformExpression Kind => this["kind"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Time when the policy-based route was created.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

    /// <summary>
    /// If potential misconfigurations are detected for this route, this field will be populated with warning messages.
    /// </summary>
    public TerraformExpression Warnings => this["warnings"];

}
