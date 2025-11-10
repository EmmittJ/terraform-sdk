using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for config_file in .
/// Nesting mode: set
/// </summary>
public class AzurermNginxConfigurationConfigFileBlock : TerraformBlock
{
    /// <summary>
    /// The content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    public required TerraformProperty<string> Content
    {
        get => GetProperty<TerraformProperty<string>>("content");
        set => WithProperty("content", value);
    }

    /// <summary>
    /// The virtual_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualPath is required")]
    public required TerraformProperty<string> VirtualPath
    {
        get => GetProperty<TerraformProperty<string>>("virtual_path");
        set => WithProperty("virtual_path", value);
    }

}

/// <summary>
/// Block type for protected_file in .
/// Nesting mode: set
/// </summary>
public class AzurermNginxConfigurationProtectedFileBlock : TerraformBlock
{
    /// <summary>
    /// The content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    public required TerraformProperty<string> Content
    {
        get => GetProperty<TerraformProperty<string>>("content");
        set => WithProperty("content", value);
    }

    /// <summary>
    /// The content_hash attribute.
    /// </summary>
    public TerraformProperty<string>? ContentHash
    {
        get => GetProperty<TerraformProperty<string>>("content_hash");
        set => WithProperty("content_hash", value);
    }

    /// <summary>
    /// The virtual_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualPath is required")]
    public required TerraformProperty<string> VirtualPath
    {
        get => GetProperty<TerraformProperty<string>>("virtual_path");
        set => WithProperty("virtual_path", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNginxConfigurationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_nginx_configuration resource.
/// </summary>
public class AzurermNginxConfiguration : TerraformResource
{
    public AzurermNginxConfiguration(string name) : base("azurerm_nginx_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The nginx_deployment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NginxDeploymentId is required")]
    public required TerraformProperty<string> NginxDeploymentId
    {
        get => GetProperty<TerraformProperty<string>>("nginx_deployment_id");
        set => this.WithProperty("nginx_deployment_id", value);
    }

    /// <summary>
    /// The package_data attribute.
    /// </summary>
    public TerraformProperty<string>? PackageData
    {
        get => GetProperty<TerraformProperty<string>>("package_data");
        set => this.WithProperty("package_data", value);
    }

    /// <summary>
    /// The root_file attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RootFile is required")]
    public required TerraformProperty<string> RootFile
    {
        get => GetProperty<TerraformProperty<string>>("root_file");
        set => this.WithProperty("root_file", value);
    }

    /// <summary>
    /// Block for config_file.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermNginxConfigurationConfigFileBlock>? ConfigFile
    {
        get => GetProperty<HashSet<AzurermNginxConfigurationConfigFileBlock>>("config_file");
        set => this.WithProperty("config_file", value);
    }

    /// <summary>
    /// Block for protected_file.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermNginxConfigurationProtectedFileBlock>? ProtectedFile
    {
        get => GetProperty<HashSet<AzurermNginxConfigurationProtectedFileBlock>>("protected_file");
        set => this.WithProperty("protected_file", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNginxConfigurationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermNginxConfigurationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
