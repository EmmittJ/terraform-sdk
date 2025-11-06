using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_network.
/// </summary>
public class GoogleComputeNetworkDataSource : TerraformDataSource
{
    public GoogleComputeNetworkDataSource(string name) : base("google_compute_network", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("description");
        this.DeclareOutput("gateway_ipv4");
        this.DeclareOutput("internal_ipv6_range");
        this.DeclareOutput("network_id");
        this.DeclareOutput("numeric_id");
        this.DeclareOutput("self_link");
        this.DeclareOutput("subnetworks_self_links");
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The network_profile attribute.
    /// </summary>
    public string? NetworkProfile
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_profile")?.Value;
        set => this.WithProperty("network_profile", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The gateway_ipv4 attribute.
    /// </summary>
    public TerraformExpression GatewayIpv4 => this["gateway_ipv4"];

    /// <summary>
    /// The internal_ipv6_range attribute.
    /// </summary>
    public TerraformExpression InternalIpv6Range => this["internal_ipv6_range"];

    /// <summary>
    /// The network_id attribute.
    /// </summary>
    public TerraformExpression NetworkId => this["network_id"];

    /// <summary>
    /// The numeric_id attribute.
    /// </summary>
    public TerraformExpression NumericId => this["numeric_id"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// The subnetworks_self_links attribute.
    /// </summary>
    public TerraformExpression SubnetworksSelfLinks => this["subnetworks_self_links"];

}
