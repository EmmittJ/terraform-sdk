using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermEventhubDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermEventhubDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_eventhub Terraform data source.
/// Retrieves information about a azurerm_eventhub.
/// </summary>
public partial class AzurermEventhubDataSource(string name) : TerraformDataSource("azurerm_eventhub", name)
{
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
    /// The namespace_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceName is required")]
    public required TerraformValue<string> NamespaceName
    {
        get => GetArgument<TerraformValue<string>>("namespace_name");
        set => SetArgument("namespace_name", value);
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
    /// The partition_count attribute.
    /// </summary>
    public TerraformValue<double> PartitionCount
        => AsReference("partition_count");

    /// <summary>
    /// The partition_ids attribute.
    /// </summary>
    public TerraformList<string> PartitionIds
        => AsReference("partition_ids");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermEventhubDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermEventhubDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
