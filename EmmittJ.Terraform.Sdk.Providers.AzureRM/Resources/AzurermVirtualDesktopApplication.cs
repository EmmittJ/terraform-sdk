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
    public string? ApplicationGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_group_id")?.Value;
        set => this.WithProperty("application_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The command_line_argument_policy attribute.
    /// </summary>
    public string? CommandLineArgumentPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("command_line_argument_policy")?.Value;
        set => this.WithProperty("command_line_argument_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The command_line_arguments attribute.
    /// </summary>
    public string? CommandLineArguments
    {
        get => GetProperty<TerraformLiteralProperty<string>>("command_line_arguments")?.Value;
        set => this.WithProperty("command_line_arguments", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    public string? FriendlyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("friendly_name")?.Value;
        set => this.WithProperty("friendly_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The icon_index attribute.
    /// </summary>
    public double? IconIndex
    {
        get => GetProperty<TerraformLiteralProperty<double>>("icon_index")?.Value;
        set => this.WithProperty("icon_index", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The icon_path attribute.
    /// </summary>
    public string? IconPath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("icon_path")?.Value;
        set => this.WithProperty("icon_path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public string? Path
    {
        get => GetProperty<TerraformLiteralProperty<string>>("path")?.Value;
        set => this.WithProperty("path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The show_in_portal attribute.
    /// </summary>
    public bool? ShowInPortal
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("show_in_portal")?.Value;
        set => this.WithProperty("show_in_portal", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

}
