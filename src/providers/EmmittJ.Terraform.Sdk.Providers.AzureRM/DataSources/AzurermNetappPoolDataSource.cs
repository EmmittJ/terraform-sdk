using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Represents a azurerm_netapp_pool Terraform data source.
/// Retrieves information about a azurerm_netapp_pool.
/// </summary>
public partial class AzurermNetappPoolDataSource(string name) : TerraformDataSource("azurerm_netapp_pool", name)
{
    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformValue<string> AccountName
    {
        get => new TerraformReference<string>(this, "account_name");
        set => SetArgument("account_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The cool_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool> CoolAccessEnabled
    {
        get => new TerraformReference<bool>(this, "cool_access_enabled");
    }

    /// <summary>
    /// The custom_throughput_mibps attribute.
    /// </summary>
    public TerraformValue<double> CustomThroughputMibps
    {
        get => new TerraformReference<double>(this, "custom_throughput_mibps");
    }

    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    public TerraformValue<string> EncryptionType
    {
        get => new TerraformReference<string>(this, "encryption_type");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The service_level attribute.
    /// </summary>
    public TerraformValue<string> ServiceLevel
    {
        get => new TerraformReference<string>(this, "service_level");
    }

    /// <summary>
    /// The size_in_tb attribute.
    /// </summary>
    public TerraformValue<double> SizeInTb
    {
        get => new TerraformReference<double>(this, "size_in_tb");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNetappPoolDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNetappPoolDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
