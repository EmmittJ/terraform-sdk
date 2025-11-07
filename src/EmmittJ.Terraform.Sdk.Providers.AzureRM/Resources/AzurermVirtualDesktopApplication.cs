using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    }

    /// <summary>
    /// The application_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? ApplicationGroupId
    {
        get => GetProperty<TerraformProperty<string>>("application_group_id");
        set => this.WithProperty("application_group_id", value);
    }

    /// <summary>
    /// The command_line_argument_policy attribute.
    /// </summary>
    public TerraformProperty<string>? CommandLineArgumentPolicy
    {
        get => GetProperty<TerraformProperty<string>>("command_line_argument_policy");
        set => this.WithProperty("command_line_argument_policy", value);
    }

    /// <summary>
    /// The command_line_arguments attribute.
    /// </summary>
    public TerraformProperty<string>? CommandLineArguments
    {
        get => GetProperty<TerraformProperty<string>>("command_line_arguments");
        set => this.WithProperty("command_line_arguments", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    public TerraformProperty<string>? FriendlyName
    {
        get => GetProperty<TerraformProperty<string>>("friendly_name");
        set => this.WithProperty("friendly_name", value);
    }

    /// <summary>
    /// The icon_index attribute.
    /// </summary>
    public TerraformProperty<double>? IconIndex
    {
        get => GetProperty<TerraformProperty<double>>("icon_index");
        set => this.WithProperty("icon_index", value);
    }

    /// <summary>
    /// The icon_path attribute.
    /// </summary>
    public TerraformProperty<string>? IconPath
    {
        get => GetProperty<TerraformProperty<string>>("icon_path");
        set => this.WithProperty("icon_path", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformProperty<string>? Path
    {
        get => GetProperty<TerraformProperty<string>>("path");
        set => this.WithProperty("path", value);
    }

    /// <summary>
    /// The show_in_portal attribute.
    /// </summary>
    public TerraformProperty<bool>? ShowInPortal
    {
        get => GetProperty<TerraformProperty<bool>>("show_in_portal");
        set => this.WithProperty("show_in_portal", value);
    }

}
