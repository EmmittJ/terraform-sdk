using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSecurityCenterAutoProvisioning.
/// Nesting mode: single
/// </summary>
public class AzurermSecurityCenterAutoProvisioningTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_security_center_auto_provisioning Terraform resource.
/// Manages a azurerm_security_center_auto_provisioning resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public partial class AzurermSecurityCenterAutoProvisioning(string name) : TerraformResource("azurerm_security_center_auto_provisioning", name)
{
    /// <summary>
    /// The auto_provision attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoProvision is required")]
    public required TerraformValue<string> AutoProvision
    {
        get => new TerraformReference<string>(this, "auto_provision");
        set => SetArgument("auto_provision", value);
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
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSecurityCenterAutoProvisioningTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSecurityCenterAutoProvisioningTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
