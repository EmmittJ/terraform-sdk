using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermDevTestVirtualNetworkDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermDevTestVirtualNetworkDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_dev_test_virtual_network Terraform data source.
/// Retrieves information about a azurerm_dev_test_virtual_network.
/// </summary>
public partial class AzurermDevTestVirtualNetworkDataSource(string name) : TerraformDataSource("azurerm_dev_test_virtual_network", name)
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
    /// The lab_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LabName is required")]
    public required TerraformValue<string> LabName
    {
        get => GetRequiredArgument<TerraformValue<string>>("lab_name");
        set => SetArgument("lab_name", value);
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
    /// The allowed_subnets attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AllowedSubnets
        => AsReference("allowed_subnets");

    /// <summary>
    /// The subnet_overrides attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SubnetOverrides
        => AsReference("subnet_overrides");

    /// <summary>
    /// The unique_identifier attribute.
    /// </summary>
    public TerraformValue<string> UniqueIdentifier
        => AsReference("unique_identifier");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDevTestVirtualNetworkDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDevTestVirtualNetworkDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
