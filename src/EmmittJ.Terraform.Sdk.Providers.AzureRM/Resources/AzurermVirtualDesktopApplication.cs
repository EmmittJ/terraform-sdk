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
    public TerraformLiteralProperty<string>? ApplicationGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_group_id");
        set => this.WithProperty("application_group_id", value);
    }

    /// <summary>
    /// The command_line_argument_policy attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CommandLineArgumentPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("command_line_argument_policy");
        set => this.WithProperty("command_line_argument_policy", value);
    }

    /// <summary>
    /// The command_line_arguments attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CommandLineArguments
    {
        get => GetProperty<TerraformLiteralProperty<string>>("command_line_arguments");
        set => this.WithProperty("command_line_arguments", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FriendlyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("friendly_name");
        set => this.WithProperty("friendly_name", value);
    }

    /// <summary>
    /// The icon_index attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? IconIndex
    {
        get => GetProperty<TerraformLiteralProperty<double>>("icon_index");
        set => this.WithProperty("icon_index", value);
    }

    /// <summary>
    /// The icon_path attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IconPath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("icon_path");
        set => this.WithProperty("icon_path", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Path
    {
        get => GetProperty<TerraformLiteralProperty<string>>("path");
        set => this.WithProperty("path", value);
    }

    /// <summary>
    /// The show_in_portal attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ShowInPortal
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("show_in_portal");
        set => this.WithProperty("show_in_portal", value);
    }

}
