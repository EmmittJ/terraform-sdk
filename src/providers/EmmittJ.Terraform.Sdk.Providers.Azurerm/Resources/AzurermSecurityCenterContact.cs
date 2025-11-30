using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSecurityCenterContact.
/// Nesting mode: single
/// </summary>
public class AzurermSecurityCenterContactTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_security_center_contact Terraform resource.
/// Manages a azurerm_security_center_contact resource.
/// </summary>
public partial class AzurermSecurityCenterContact(string name) : TerraformResource("azurerm_security_center_contact", name)
{
    /// <summary>
    /// The alert_notifications attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlertNotifications is required")]
    public required TerraformValue<bool> AlertNotifications
    {
        get => new TerraformReference<bool>(this, "alert_notifications");
        set => SetArgument("alert_notifications", value);
    }

    /// <summary>
    /// The alerts_to_admins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlertsToAdmins is required")]
    public required TerraformValue<bool> AlertsToAdmins
    {
        get => new TerraformReference<bool>(this, "alerts_to_admins");
        set => SetArgument("alerts_to_admins", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    public required TerraformValue<string> Email
    {
        get => new TerraformReference<string>(this, "email");
        set => SetArgument("email", value);
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
    /// The phone attribute.
    /// </summary>
    public TerraformValue<string>? Phone
    {
        get => new TerraformReference<string>(this, "phone");
        set => SetArgument("phone", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSecurityCenterContactTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSecurityCenterContactTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
