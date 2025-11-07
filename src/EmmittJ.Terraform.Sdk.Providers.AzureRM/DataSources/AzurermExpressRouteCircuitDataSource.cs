using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_express_route_circuit.
/// </summary>
public class AzurermExpressRouteCircuitDataSource : TerraformDataSource
{
    public AzurermExpressRouteCircuitDataSource(string name) : base("azurerm_express_route_circuit", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("location");
        this.DeclareOutput("peerings");
        this.DeclareOutput("service_key");
        this.DeclareOutput("service_provider_properties");
        this.DeclareOutput("service_provider_provisioning_state");
        this.DeclareOutput("sku");
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The peerings attribute.
    /// </summary>
    public TerraformExpression Peerings => this["peerings"];

    /// <summary>
    /// The service_key attribute.
    /// </summary>
    public TerraformExpression ServiceKey => this["service_key"];

    /// <summary>
    /// The service_provider_properties attribute.
    /// </summary>
    public TerraformExpression ServiceProviderProperties => this["service_provider_properties"];

    /// <summary>
    /// The service_provider_provisioning_state attribute.
    /// </summary>
    public TerraformExpression ServiceProviderProvisioningState => this["service_provider_provisioning_state"];

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformExpression Sku => this["sku"];

}
