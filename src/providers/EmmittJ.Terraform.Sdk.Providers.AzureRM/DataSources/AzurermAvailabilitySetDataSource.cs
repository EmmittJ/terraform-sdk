using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "read");
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
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The managed attribute.
    /// </summary>
    public TerraformValue<bool> Managed
    {
        get => new TerraformReference<bool>(this, "managed");
    }

    /// <summary>
    /// The platform_fault_domain_count attribute.
    /// </summary>
    public TerraformValue<double> PlatformFaultDomainCount
    {
        get => new TerraformReference<double>(this, "platform_fault_domain_count");
    }

    /// <summary>
    /// The platform_update_domain_count attribute.
    /// </summary>
    public TerraformValue<double> PlatformUpdateDomainCount
    {
        get => new TerraformReference<double>(this, "platform_update_domain_count");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAvailabilitySetDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAvailabilitySetDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
