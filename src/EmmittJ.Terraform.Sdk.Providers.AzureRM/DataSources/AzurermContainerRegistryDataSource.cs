using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_container_registry.
/// </summary>
public class AzurermContainerRegistryDataSource : TerraformDataSource
{
    public AzurermContainerRegistryDataSource(string name) : base("azurerm_container_registry", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("admin_enabled");
        this.DeclareOutput("admin_password");
        this.DeclareOutput("admin_username");
        this.DeclareOutput("data_endpoint_enabled");
        this.DeclareOutput("data_endpoint_host_names");
        this.DeclareOutput("location");
        this.DeclareOutput("login_server");
        this.DeclareOutput("sku");
        this.DeclareOutput("tags");
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
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The admin_enabled attribute.
    /// </summary>
    public TerraformExpression AdminEnabled => this["admin_enabled"];

    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    public TerraformExpression AdminPassword => this["admin_password"];

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    public TerraformExpression AdminUsername => this["admin_username"];

    /// <summary>
    /// The data_endpoint_enabled attribute.
    /// </summary>
    public TerraformExpression DataEndpointEnabled => this["data_endpoint_enabled"];

    /// <summary>
    /// The data_endpoint_host_names attribute.
    /// </summary>
    public TerraformExpression DataEndpointHostNames => this["data_endpoint_host_names"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The login_server attribute.
    /// </summary>
    public TerraformExpression LoginServer => this["login_server"];

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformExpression Sku => this["sku"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
