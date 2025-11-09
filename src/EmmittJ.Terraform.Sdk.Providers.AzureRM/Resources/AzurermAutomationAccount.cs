using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_automation_account resource.
/// </summary>
public class AzurermAutomationAccount : TerraformResource
{
    public AzurermAutomationAccount(string name) : base("azurerm_automation_account", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("dsc_primary_access_key");
        this.DeclareOutput("dsc_secondary_access_key");
        this.DeclareOutput("dsc_server_endpoint");
        this.DeclareOutput("hybrid_service_url");
        this.DeclareOutput("private_endpoint_connection");
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
    /// The local_authentication_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LocalAuthenticationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("local_authentication_enabled");
        set => this.WithProperty("local_authentication_enabled", value);
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
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_network_access_enabled");
        set => this.WithProperty("public_network_access_enabled", value);
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
    /// The sku_name attribute.
    /// </summary>
    public TerraformProperty<string>? SkuName
    {
        get => GetProperty<TerraformProperty<string>>("sku_name");
        set => this.WithProperty("sku_name", value);
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
    /// The dsc_primary_access_key attribute.
    /// </summary>
    public TerraformExpression DscPrimaryAccessKey => this["dsc_primary_access_key"];

    /// <summary>
    /// The dsc_secondary_access_key attribute.
    /// </summary>
    public TerraformExpression DscSecondaryAccessKey => this["dsc_secondary_access_key"];

    /// <summary>
    /// The dsc_server_endpoint attribute.
    /// </summary>
    public TerraformExpression DscServerEndpoint => this["dsc_server_endpoint"];

    /// <summary>
    /// The hybrid_service_url attribute.
    /// </summary>
    public TerraformExpression HybridServiceUrl => this["hybrid_service_url"];

    /// <summary>
    /// The private_endpoint_connection attribute.
    /// </summary>
    public TerraformExpression PrivateEndpointConnection => this["private_endpoint_connection"];

}
