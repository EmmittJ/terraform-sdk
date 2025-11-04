using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_express_route_port resource.
/// </summary>
public class AzurermExpressRoutePort : TerraformResource
{
    public AzurermExpressRoutePort(string name) : base("azurerm_express_route_port", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("ethertype");
        this.DeclareOutput("guid");
        this.DeclareOutput("mtu");
    }

    /// <summary>
    /// The bandwidth_in_gbps attribute.
    /// </summary>
    public double? BandwidthInGbps
    {
        get => GetProperty<TerraformLiteralProperty<double>>("bandwidth_in_gbps")?.Value;
        set => this.WithProperty("bandwidth_in_gbps", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The billing_type attribute.
    /// </summary>
    public string? BillingType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("billing_type")?.Value;
        set => this.WithProperty("billing_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The encapsulation attribute.
    /// </summary>
    public string? Encapsulation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("encapsulation")?.Value;
        set => this.WithProperty("encapsulation", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The peering_location attribute.
    /// </summary>
    public string? PeeringLocation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("peering_location")?.Value;
        set => this.WithProperty("peering_location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The ethertype attribute.
    /// </summary>
    public TerraformExpression Ethertype => this["ethertype"];

    /// <summary>
    /// The guid attribute.
    /// </summary>
    public TerraformExpression Guid => this["guid"];

    /// <summary>
    /// The mtu attribute.
    /// </summary>
    public TerraformExpression Mtu => this["mtu"];

}
