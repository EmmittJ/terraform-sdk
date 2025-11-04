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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The local_authentication_enabled attribute.
    /// </summary>
    public bool? LocalAuthenticationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("local_authentication_enabled")?.Value;
        set => this.WithProperty("local_authentication_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The public_network_access_enabled attribute.
    /// </summary>
    public bool? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("public_network_access_enabled")?.Value;
        set => this.WithProperty("public_network_access_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The sku_name attribute.
    /// </summary>
    public string? SkuName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku_name")?.Value;
        set => this.WithProperty("sku_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
