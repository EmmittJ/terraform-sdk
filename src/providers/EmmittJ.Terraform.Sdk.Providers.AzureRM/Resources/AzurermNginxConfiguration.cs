using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for config_file in .
/// Nesting mode: set
/// </summary>
public class AzurermNginxConfigurationConfigFileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "config_file";

    /// <summary>
    /// The content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    public required TerraformValue<string> Content
    {
        get => new TerraformReference<string>(this, "content");
        set => SetArgument("content", value);
    }

    /// <summary>
    /// The virtual_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualPath is required")]
    public required TerraformValue<string> VirtualPath
    {
        get => new TerraformReference<string>(this, "virtual_path");
        set => SetArgument("virtual_path", value);
    }

}

/// <summary>
/// Block type for protected_file in .
/// Nesting mode: set
/// </summary>
public class AzurermNginxConfigurationProtectedFileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "protected_file";

    /// <summary>
    /// The content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    public required TerraformValue<string> Content
    {
        get => new TerraformReference<string>(this, "content");
        set => SetArgument("content", value);
    }

    /// <summary>
    /// The content_hash attribute.
    /// </summary>
    public TerraformValue<string> ContentHash
    {
        get => new TerraformReference<string>(this, "content_hash");
    }

    /// <summary>
    /// The virtual_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualPath is required")]
    public required TerraformValue<string> VirtualPath
    {
        get => new TerraformReference<string>(this, "virtual_path");
        set => SetArgument("virtual_path", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNginxConfigurationTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_nginx_configuration Terraform resource.
/// Manages a azurerm_nginx_configuration resource.
/// </summary>
public partial class AzurermNginxConfiguration(string name) : TerraformResource("azurerm_nginx_configuration", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The nginx_deployment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NginxDeploymentId is required")]
    public required TerraformValue<string> NginxDeploymentId
    {
        get => new TerraformReference<string>(this, "nginx_deployment_id");
        set => SetArgument("nginx_deployment_id", value);
    }

    /// <summary>
    /// The package_data attribute.
    /// </summary>
    public TerraformValue<string>? PackageData
    {
        get => new TerraformReference<string>(this, "package_data");
        set => SetArgument("package_data", value);
    }

    /// <summary>
    /// The root_file attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RootFile is required")]
    public required TerraformValue<string> RootFile
    {
        get => new TerraformReference<string>(this, "root_file");
        set => SetArgument("root_file", value);
    }

    /// <summary>
    /// ConfigFile block (nesting mode: set).
    /// </summary>
    public AzurermNginxConfigurationConfigFileBlock? ConfigFile
    {
        get => GetArgument<AzurermNginxConfigurationConfigFileBlock>("config_file");
        set => SetArgument("config_file", value);
    }

    /// <summary>
    /// ProtectedFile block (nesting mode: set).
    /// </summary>
    public AzurermNginxConfigurationProtectedFileBlock? ProtectedFile
    {
        get => GetArgument<AzurermNginxConfigurationProtectedFileBlock>("protected_file");
        set => SetArgument("protected_file", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNginxConfigurationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNginxConfigurationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
