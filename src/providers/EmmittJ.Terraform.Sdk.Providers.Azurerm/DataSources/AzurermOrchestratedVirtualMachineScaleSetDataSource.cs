using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermOrchestratedVirtualMachineScaleSetDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_orchestrated_virtual_machine_scale_set Terraform data source.
/// Retrieves information about a azurerm_orchestrated_virtual_machine_scale_set.
/// </summary>
public partial class AzurermOrchestratedVirtualMachineScaleSetDataSource(string name) : TerraformDataSource("azurerm_orchestrated_virtual_machine_scale_set", name)
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
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
        => AsReference("identity");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The network_interface attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> NetworkInterface
        => AsReference("network_interface");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermOrchestratedVirtualMachineScaleSetDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermOrchestratedVirtualMachineScaleSetDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
