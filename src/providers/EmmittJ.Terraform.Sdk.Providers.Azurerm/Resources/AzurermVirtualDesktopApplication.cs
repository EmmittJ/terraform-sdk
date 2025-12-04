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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
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
        get => GetArgument<TerraformValue<string>>("application_group_id");
        set => SetArgument("application_group_id", value);
    }

    /// <summary>
    /// The command_line_argument_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CommandLineArgumentPolicy is required")]
    public required TerraformValue<string> CommandLineArgumentPolicy
    {
        get => GetArgument<TerraformValue<string>>("command_line_argument_policy");
        set => SetArgument("command_line_argument_policy", value);
    }

    /// <summary>
    /// The command_line_arguments attribute.
    /// </summary>
    public TerraformValue<string>? CommandLineArguments
    {
        get => GetArgument<TerraformValue<string>>("command_line_arguments");
        set => SetArgument("command_line_arguments", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    public TerraformValue<string>? FriendlyName
    {
        get => GetArgument<TerraformValue<string>>("friendly_name");
        set => SetArgument("friendly_name", value);
    }

    /// <summary>
    /// The icon_index attribute.
    /// </summary>
    public TerraformValue<double>? IconIndex
    {
        get => GetArgument<TerraformValue<double>>("icon_index");
        set => SetArgument("icon_index", value);
    }

    /// <summary>
    /// The icon_path attribute.
    /// </summary>
    public TerraformValue<string>? IconPath
    {
        get => GetArgument<TerraformValue<string>>("icon_path");
        set => SetArgument("icon_path", value);
    }

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
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The show_in_portal attribute.
    /// </summary>
    public TerraformValue<bool>? ShowInPortal
    {
        get => GetArgument<TerraformValue<bool>>("show_in_portal");
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
