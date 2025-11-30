using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermDedicatedHost.
/// Nesting mode: single
/// </summary>
public class AzurermDedicatedHostTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_dedicated_host Terraform resource.
/// Manages a azurerm_dedicated_host resource.
/// </summary>
public partial class AzurermDedicatedHost(string name) : TerraformResource("azurerm_dedicated_host", name)
{
    /// <summary>
    /// The auto_replace_on_failure attribute.
    /// </summary>
    public TerraformValue<bool>? AutoReplaceOnFailure
    {
        get => new TerraformReference<bool>(this, "auto_replace_on_failure");
        set => SetArgument("auto_replace_on_failure", value);
    }

    /// <summary>
    /// The dedicated_host_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DedicatedHostGroupId is required")]
    public required TerraformValue<string> DedicatedHostGroupId
    {
        get => new TerraformReference<string>(this, "dedicated_host_group_id");
        set => SetArgument("dedicated_host_group_id", value);
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
    /// The license_type attribute.
    /// </summary>
    public TerraformValue<string>? LicenseType
    {
        get => new TerraformReference<string>(this, "license_type");
        set => SetArgument("license_type", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The platform_fault_domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PlatformFaultDomain is required")]
    public required TerraformValue<double> PlatformFaultDomain
    {
        get => new TerraformReference<double>(this, "platform_fault_domain");
        set => SetArgument("platform_fault_domain", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    public required TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
        set => SetArgument("sku_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDedicatedHostTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDedicatedHostTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
