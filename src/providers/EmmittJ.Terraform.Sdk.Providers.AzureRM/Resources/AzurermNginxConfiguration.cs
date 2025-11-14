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
    [TerraformArgument("content")]
    public required TerraformValue<string> Content
    {
        get => new TerraformReference<string>(this, "content");
        set => SetArgument("content", value);
    }

    /// <summary>
    /// The virtual_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualPath is required")]
    [TerraformArgument("virtual_path")]
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
    [TerraformArgument("content")]
    public required TerraformValue<string> Content
    {
        get => new TerraformReference<string>(this, "content");
        set => SetArgument("content", value);
    }


    /// <summary>
    /// The virtual_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualPath is required")]
    [TerraformArgument("virtual_path")]
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
/// Manages a azurerm_nginx_configuration resource.
/// </summary>
public class AzurermNginxConfiguration : TerraformResource
{
    public AzurermNginxConfiguration(string name) : base("azurerm_nginx_configuration", name)
    {
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
    /// The nginx_deployment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NginxDeploymentId is required")]
    [TerraformArgument("nginx_deployment_id")]
    public required TerraformValue<string> NginxDeploymentId
    {
        get => new TerraformReference<string>(this, "nginx_deployment_id");
        set => SetArgument("nginx_deployment_id", value);
    }

    /// <summary>
    /// The package_data attribute.
    /// </summary>
    [TerraformArgument("package_data")]
    public TerraformValue<string>? PackageData
    {
        get => new TerraformReference<string>(this, "package_data");
        set => SetArgument("package_data", value);
    }

    /// <summary>
    /// The root_file attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RootFile is required")]
    [TerraformArgument("root_file")]
    public required TerraformValue<string> RootFile
    {
        get => new TerraformReference<string>(this, "root_file");
        set => SetArgument("root_file", value);
    }

    /// <summary>
    /// Block for config_file.
    /// Nesting mode: set
    /// </summary>
    [TerraformArgument("config_file")]
    public TerraformSet<AzurermNginxConfigurationConfigFileBlock> ConfigFile { get; set; } = new();

    /// <summary>
    /// Block for protected_file.
    /// Nesting mode: set
    /// </summary>
    [TerraformArgument("protected_file")]
    public TerraformSet<AzurermNginxConfigurationProtectedFileBlock> ProtectedFile { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermNginxConfigurationTimeoutsBlock Timeouts { get; set; } = new();

}
