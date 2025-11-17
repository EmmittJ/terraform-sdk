using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermVirtualDesktopApplication.
/// Nesting mode: single
/// </summary>
public class AzurermVirtualDesktopApplicationTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_virtual_desktop_application Terraform resource.
/// Manages a azurerm_virtual_desktop_application resource.
/// </summary>
public partial class AzurermVirtualDesktopApplication(string name) : TerraformResource("azurerm_virtual_desktop_application", name)
{
    /// <summary>
    /// The application_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationGroupId is required")]
    public required TerraformValue<string> ApplicationGroupId
    {
        get => new TerraformReference<string>(this, "application_group_id");
        set => SetArgument("application_group_id", value);
    }

    /// <summary>
    /// The command_line_argument_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CommandLineArgumentPolicy is required")]
    public required TerraformValue<string> CommandLineArgumentPolicy
    {
        get => new TerraformReference<string>(this, "command_line_argument_policy");
        set => SetArgument("command_line_argument_policy", value);
    }

    /// <summary>
    /// The command_line_arguments attribute.
    /// </summary>
    public TerraformValue<string>? CommandLineArguments
    {
        get => new TerraformReference<string>(this, "command_line_arguments");
        set => SetArgument("command_line_arguments", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    public TerraformValue<string> FriendlyName
    {
        get => new TerraformReference<string>(this, "friendly_name");
        set => SetArgument("friendly_name", value);
    }

    /// <summary>
    /// The icon_index attribute.
    /// </summary>
    public TerraformValue<double>? IconIndex
    {
        get => new TerraformReference<double>(this, "icon_index");
        set => SetArgument("icon_index", value);
    }

    /// <summary>
    /// The icon_path attribute.
    /// </summary>
    public TerraformValue<string> IconPath
    {
        get => new TerraformReference<string>(this, "icon_path");
        set => SetArgument("icon_path", value);
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
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The show_in_portal attribute.
    /// </summary>
    public TerraformValue<bool>? ShowInPortal
    {
        get => new TerraformReference<bool>(this, "show_in_portal");
        set => SetArgument("show_in_portal", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVirtualDesktopApplicationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVirtualDesktopApplicationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
