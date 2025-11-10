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
        set => SetProperty("content", value);
    }

    /// <summary>
    /// The virtual_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualPath is required")]
    public required TerraformProperty<string> VirtualPath
    {
        set => SetProperty("virtual_path", value);
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
        set => SetProperty("content", value);
    }

    /// <summary>
    /// The content_hash attribute.
    /// </summary>
    public TerraformProperty<string>? ContentHash
    {
        set => SetProperty("content_hash", value);
    }

    /// <summary>
    /// The virtual_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualPath is required")]
    public required TerraformProperty<string> VirtualPath
    {
        set => SetProperty("virtual_path", value);
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
        SetOutput("id");
        SetOutput("nginx_deployment_id");
        SetOutput("package_data");
        SetOutput("root_file");
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
    /// The nginx_deployment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NginxDeploymentId is required")]
    public required TerraformProperty<string> NginxDeploymentId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("nginx_deployment_id");
        set => SetProperty("nginx_deployment_id", value);
    }

    /// <summary>
    /// The package_data attribute.
    /// </summary>
    public TerraformProperty<string> PackageData
    {
        get => GetRequiredOutput<TerraformProperty<string>>("package_data");
        set => SetProperty("package_data", value);
    }

    /// <summary>
    /// The root_file attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RootFile is required")]
    public required TerraformProperty<string> RootFile
    {
        get => GetRequiredOutput<TerraformProperty<string>>("root_file");
        set => SetProperty("root_file", value);
    }

    /// <summary>
    /// Block for config_file.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermNginxConfigurationConfigFileBlock>? ConfigFile
    {
        set => SetProperty("config_file", value);
    }

    /// <summary>
    /// Block for protected_file.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermNginxConfigurationProtectedFileBlock>? ProtectedFile
    {
        set => SetProperty("protected_file", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNginxConfigurationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
