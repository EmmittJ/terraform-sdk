using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNginxConfigurationDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_nginx_configuration.
/// </summary>
public class AzurermNginxConfigurationDataSource : TerraformDataSource
{
    public AzurermNginxConfigurationDataSource(string name) : base("azurerm_nginx_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("config_file");
        SetOutput("package_data");
        SetOutput("protected_file");
        SetOutput("root_file");
        SetOutput("id");
        SetOutput("nginx_deployment_id");
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNginxConfigurationDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The config_file attribute.
    /// </summary>
    public TerraformExpression ConfigFile => this["config_file"];

    /// <summary>
    /// The package_data attribute.
    /// </summary>
    public TerraformExpression PackageData => this["package_data"];

    /// <summary>
    /// The protected_file attribute.
    /// </summary>
    public TerraformExpression ProtectedFile => this["protected_file"];

    /// <summary>
    /// The root_file attribute.
    /// </summary>
    public TerraformExpression RootFile => this["root_file"];

}
