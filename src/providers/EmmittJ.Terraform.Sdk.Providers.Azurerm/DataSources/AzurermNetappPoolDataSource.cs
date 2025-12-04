using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermNetappPoolDataSource.
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
        get => GetArgument<TerraformValue<string>>("read");
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
        get => GetArgument<TerraformValue<string>>("account_name");
        set => SetArgument("account_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The cool_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool> CoolAccessEnabled
        => AsReference("cool_access_enabled");

    /// <summary>
    /// The custom_throughput_mibps attribute.
    /// </summary>
    public TerraformValue<double> CustomThroughputMibps
        => AsReference("custom_throughput_mibps");

    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    public TerraformValue<string> EncryptionType
        => AsReference("encryption_type");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The service_level attribute.
    /// </summary>
    public TerraformValue<string> ServiceLevel
        => AsReference("service_level");

    /// <summary>
    /// The size_in_tb attribute.
    /// </summary>
    public TerraformValue<double> SizeInTb
        => AsReference("size_in_tb");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNetappPoolDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNetappPoolDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
