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
    public TerraformProperty<double>? BandwidthInGbps
    {
        get => GetProperty<TerraformProperty<double>>("bandwidth_in_gbps");
        set => this.WithProperty("bandwidth_in_gbps", value);
    }

    /// <summary>
    /// The billing_type attribute.
    /// </summary>
    public TerraformProperty<string>? BillingType
    {
        get => GetProperty<TerraformProperty<string>>("billing_type");
        set => this.WithProperty("billing_type", value);
    }

    /// <summary>
    /// The encapsulation attribute.
    /// </summary>
    public TerraformProperty<string>? Encapsulation
    {
        get => GetProperty<TerraformProperty<string>>("encapsulation");
        set => this.WithProperty("encapsulation", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The peering_location attribute.
    /// </summary>
    public TerraformProperty<string>? PeeringLocation
    {
        get => GetProperty<TerraformProperty<string>>("peering_location");
        set => this.WithProperty("peering_location", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
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
