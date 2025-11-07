using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_fluid_relay_server resource.
/// </summary>
public class AzurermFluidRelayServer : TerraformResource
{
    public AzurermFluidRelayServer(string name) : base("azurerm_fluid_relay_server", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("frs_tenant_id");
        this.DeclareOutput("orderer_endpoints");
        this.DeclareOutput("primary_key");
        this.DeclareOutput("secondary_key");
        this.DeclareOutput("service_endpoints");
        this.DeclareOutput("storage_endpoints");
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
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The storage_sku attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StorageSku
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_sku");
        set => this.WithProperty("storage_sku", value);
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
    /// The frs_tenant_id attribute.
    /// </summary>
    public TerraformExpression FrsTenantId => this["frs_tenant_id"];

    /// <summary>
    /// The orderer_endpoints attribute.
    /// </summary>
    public TerraformExpression OrdererEndpoints => this["orderer_endpoints"];

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    public TerraformExpression PrimaryKey => this["primary_key"];

    /// <summary>
    /// The secondary_key attribute.
    /// </summary>
    public TerraformExpression SecondaryKey => this["secondary_key"];

    /// <summary>
    /// The service_endpoints attribute.
    /// </summary>
    public TerraformExpression ServiceEndpoints => this["service_endpoints"];

    /// <summary>
    /// The storage_endpoints attribute.
    /// </summary>
    public TerraformExpression StorageEndpoints => this["storage_endpoints"];

}
