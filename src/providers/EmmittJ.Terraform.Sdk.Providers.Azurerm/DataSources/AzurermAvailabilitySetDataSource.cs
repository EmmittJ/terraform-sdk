using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermAvailabilitySetDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermAvailabilitySetDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_availability_set Terraform data source.
/// Retrieves information about a azurerm_availability_set.
/// </summary>
public partial class AzurermAvailabilitySetDataSource(string name) : TerraformDataSource("azurerm_availability_set", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
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
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => CreateReference("location");

    /// <summary>
    /// The managed attribute.
    /// </summary>
    public TerraformValue<bool> Managed
        => CreateReference("managed");

    /// <summary>
    /// The platform_fault_domain_count attribute.
    /// </summary>
    public TerraformValue<double> PlatformFaultDomainCount
        => CreateReference("platform_fault_domain_count");

    /// <summary>
    /// The platform_update_domain_count attribute.
    /// </summary>
    public TerraformValue<double> PlatformUpdateDomainCount
        => CreateReference("platform_update_domain_count");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAvailabilitySetDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAvailabilitySetDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
