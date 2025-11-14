using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_virtual_desktop_application resource.
/// </summary>
public class AzurermVirtualDesktopApplication : TerraformResource
{
    public AzurermVirtualDesktopApplication(string name) : base("azurerm_virtual_desktop_application", name)
    {
    }

    /// <summary>
    /// The application_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationGroupId is required")]
    [TerraformArgument("application_group_id")]
    public required TerraformValue<string> ApplicationGroupId
    {
        get => new TerraformReference<string>(this, "application_group_id");
        set => SetArgument("application_group_id", value);
    }

    /// <summary>
    /// The command_line_argument_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CommandLineArgumentPolicy is required")]
    [TerraformArgument("command_line_argument_policy")]
    public required TerraformValue<string> CommandLineArgumentPolicy
    {
        get => new TerraformReference<string>(this, "command_line_argument_policy");
        set => SetArgument("command_line_argument_policy", value);
    }

    /// <summary>
    /// The command_line_arguments attribute.
    /// </summary>
    [TerraformArgument("command_line_arguments")]
    public TerraformValue<string>? CommandLineArguments
    {
        get => new TerraformReference<string>(this, "command_line_arguments");
        set => SetArgument("command_line_arguments", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    [TerraformArgument("friendly_name")]
    public TerraformValue<string> FriendlyName
    {
        get => new TerraformReference<string>(this, "friendly_name");
        set => SetArgument("friendly_name", value);
    }

    /// <summary>
    /// The icon_index attribute.
    /// </summary>
    [TerraformArgument("icon_index")]
    public TerraformValue<double>? IconIndex
    {
        get => new TerraformReference<double>(this, "icon_index");
        set => SetArgument("icon_index", value);
    }

    /// <summary>
    /// The icon_path attribute.
    /// </summary>
    [TerraformArgument("icon_path")]
    public TerraformValue<string> IconPath
    {
        get => new TerraformReference<string>(this, "icon_path");
        set => SetArgument("icon_path", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    [TerraformArgument("path")]
    public required TerraformValue<string> Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The show_in_portal attribute.
    /// </summary>
    [TerraformArgument("show_in_portal")]
    public TerraformValue<bool>? ShowInPortal
    {
        get => new TerraformReference<bool>(this, "show_in_portal");
        set => SetArgument("show_in_portal", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermVirtualDesktopApplicationTimeoutsBlock Timeouts { get; set; } = new();

}
