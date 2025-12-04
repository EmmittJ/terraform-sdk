using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermServicebusNamespaceDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermServicebusNamespaceDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_servicebus_namespace Terraform data source.
/// Retrieves information about a azurerm_servicebus_namespace.
/// </summary>
public partial class AzurermServicebusNamespaceDataSource(string name) : TerraformDataSource("azurerm_servicebus_namespace", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    public TerraformValue<double> Capacity
        => AsReference("capacity");

    /// <summary>
    /// The default_primary_connection_string attribute.
    /// </summary>
    public TerraformValue<string> DefaultPrimaryConnectionString
        => AsReference("default_primary_connection_string");

    /// <summary>
    /// The default_primary_key attribute.
    /// </summary>
    public TerraformValue<string> DefaultPrimaryKey
        => AsReference("default_primary_key");

    /// <summary>
    /// The default_secondary_connection_string attribute.
    /// </summary>
    public TerraformValue<string> DefaultSecondaryConnectionString
        => AsReference("default_secondary_connection_string");

    /// <summary>
    /// The default_secondary_key attribute.
    /// </summary>
    public TerraformValue<string> DefaultSecondaryKey
        => AsReference("default_secondary_key");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
        => AsReference("endpoint");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The premium_messaging_partitions attribute.
    /// </summary>
    public TerraformValue<double> PremiumMessagingPartitions
        => AsReference("premium_messaging_partitions");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformValue<string> Sku
        => AsReference("sku");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermServicebusNamespaceDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermServicebusNamespaceDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
