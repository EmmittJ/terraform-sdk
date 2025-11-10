using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualDesktopApplicationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_virtual_desktop_application resource.
/// </summary>
public class AzurermVirtualDesktopApplication : TerraformResource
{
    public AzurermVirtualDesktopApplication(string name) : base("azurerm_virtual_desktop_application", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("application_group_id");
        SetOutput("command_line_argument_policy");
        SetOutput("command_line_arguments");
        SetOutput("description");
        SetOutput("friendly_name");
        SetOutput("icon_index");
        SetOutput("icon_path");
        SetOutput("id");
        SetOutput("name");
        SetOutput("path");
        SetOutput("show_in_portal");
    }

    /// <summary>
    /// The application_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationGroupId is required")]
    public required TerraformProperty<string> ApplicationGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("application_group_id");
        set => SetProperty("application_group_id", value);
    }

    /// <summary>
    /// The command_line_argument_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CommandLineArgumentPolicy is required")]
    public required TerraformProperty<string> CommandLineArgumentPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("command_line_argument_policy");
        set => SetProperty("command_line_argument_policy", value);
    }

    /// <summary>
    /// The command_line_arguments attribute.
    /// </summary>
    public TerraformProperty<string> CommandLineArguments
    {
        get => GetRequiredOutput<TerraformProperty<string>>("command_line_arguments");
        set => SetProperty("command_line_arguments", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    public TerraformProperty<string> FriendlyName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("friendly_name");
        set => SetProperty("friendly_name", value);
    }

    /// <summary>
    /// The icon_index attribute.
    /// </summary>
    public TerraformProperty<double> IconIndex
    {
        get => GetRequiredOutput<TerraformProperty<double>>("icon_index");
        set => SetProperty("icon_index", value);
    }

    /// <summary>
    /// The icon_path attribute.
    /// </summary>
    public TerraformProperty<string> IconPath
    {
        get => GetRequiredOutput<TerraformProperty<string>>("icon_path");
        set => SetProperty("icon_path", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformProperty<string> Path
    {
        get => GetRequiredOutput<TerraformProperty<string>>("path");
        set => SetProperty("path", value);
    }

    /// <summary>
    /// The show_in_portal attribute.
    /// </summary>
    public TerraformProperty<bool> ShowInPortal
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("show_in_portal");
        set => SetProperty("show_in_portal", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVirtualDesktopApplicationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
