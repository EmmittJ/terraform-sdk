using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetappPoolDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_netapp_pool.
/// </summary>
public class AzurermNetappPoolDataSource : TerraformDataSource
{
    public AzurermNetappPoolDataSource(string name) : base("azurerm_netapp_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("cool_access_enabled");
        this.WithOutput("custom_throughput_mibps");
        this.WithOutput("encryption_type");
        this.WithOutput("location");
        this.WithOutput("service_level");
        this.WithOutput("size_in_tb");
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformProperty<string> AccountName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("account_name");
        set => this.WithProperty("account_name", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNetappPoolDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermNetappPoolDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The cool_access_enabled attribute.
    /// </summary>
    public TerraformExpression CoolAccessEnabled => this["cool_access_enabled"];

    /// <summary>
    /// The custom_throughput_mibps attribute.
    /// </summary>
    public TerraformExpression CustomThroughputMibps => this["custom_throughput_mibps"];

    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    public TerraformExpression EncryptionType => this["encryption_type"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The service_level attribute.
    /// </summary>
    public TerraformExpression ServiceLevel => this["service_level"];

    /// <summary>
    /// The size_in_tb attribute.
    /// </summary>
    public TerraformExpression SizeInTb => this["size_in_tb"];

}
