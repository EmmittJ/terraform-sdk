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
    public TerraformLiteralProperty<double>? BandwidthInGbps
    {
        get => GetProperty<TerraformLiteralProperty<double>>("bandwidth_in_gbps");
        set => this.WithProperty("bandwidth_in_gbps", value);
    }

    /// <summary>
    /// The billing_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? BillingType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("billing_type");
        set => this.WithProperty("billing_type", value);
    }

    /// <summary>
    /// The encapsulation attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Encapsulation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("encapsulation");
        set => this.WithProperty("encapsulation", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The peering_location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PeeringLocation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("peering_location");
        set => this.WithProperty("peering_location", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
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
