using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMapsAccountDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_maps_account.
/// </summary>
public class AzurermMapsAccountDataSource : TerraformDataSource
{
    public AzurermMapsAccountDataSource(string name) : base("azurerm_maps_account", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("primary_access_key");
        this.DeclareOutput("secondary_access_key");
        this.DeclareOutput("sku_name");
        this.DeclareOutput("x_ms_client_id");
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMapsAccountDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermMapsAccountDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    public TerraformExpression PrimaryAccessKey => this["primary_access_key"];

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    public TerraformExpression SecondaryAccessKey => this["secondary_access_key"];

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformExpression SkuName => this["sku_name"];

    /// <summary>
    /// The x_ms_client_id attribute.
    /// </summary>
    public TerraformExpression XMsClientId => this["x_ms_client_id"];

}
