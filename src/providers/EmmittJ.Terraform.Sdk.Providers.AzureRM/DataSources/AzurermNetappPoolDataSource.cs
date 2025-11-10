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
        set => SetProperty("read", value);
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
        SetOutput("cool_access_enabled");
        SetOutput("custom_throughput_mibps");
        SetOutput("encryption_type");
        SetOutput("location");
        SetOutput("service_level");
        SetOutput("size_in_tb");
        SetOutput("account_name");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformProperty<string> AccountName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("account_name");
        set => SetProperty("account_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNetappPoolDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
