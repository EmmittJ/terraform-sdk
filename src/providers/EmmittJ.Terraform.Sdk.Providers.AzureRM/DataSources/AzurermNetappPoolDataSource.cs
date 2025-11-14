using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetappPoolDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_netapp_pool.
/// </summary>
public class AzurermNetappPoolDataSource : TerraformDataSource
{
    public AzurermNetappPoolDataSource(string name) : base("azurerm_netapp_pool", name)
    {
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformArgument("account_name")]
    public required TerraformValue<string> AccountName
    {
        get => new TerraformReference<string>(this, "account_name");
        set => SetArgument("account_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermNetappPoolDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The cool_access_enabled attribute.
    /// </summary>
    [TerraformArgument("cool_access_enabled")]
    public TerraformValue<bool> CoolAccessEnabled
    {
        get => new TerraformReference<bool>(this, "cool_access_enabled");
    }

    /// <summary>
    /// The custom_throughput_mibps attribute.
    /// </summary>
    [TerraformArgument("custom_throughput_mibps")]
    public TerraformValue<double> CustomThroughputMibps
    {
        get => new TerraformReference<double>(this, "custom_throughput_mibps");
    }

    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    [TerraformArgument("encryption_type")]
    public TerraformValue<string> EncryptionType
    {
        get => new TerraformReference<string>(this, "encryption_type");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The service_level attribute.
    /// </summary>
    [TerraformArgument("service_level")]
    public TerraformValue<string> ServiceLevel
    {
        get => new TerraformReference<string>(this, "service_level");
    }

    /// <summary>
    /// The size_in_tb attribute.
    /// </summary>
    [TerraformArgument("size_in_tb")]
    public TerraformValue<double> SizeInTb
    {
        get => new TerraformReference<double>(this, "size_in_tb");
    }

}
