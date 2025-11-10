using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerRegistryDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermContainerRegistryDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermContainerRegistryDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
