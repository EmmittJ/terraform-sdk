using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("config_file");
        this.DeclareOutput("package_data");
        this.DeclareOutput("protected_file");
        this.DeclareOutput("root_file");
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
    public TerraformProperty<string>? NginxDeploymentId
    {
        get => GetProperty<TerraformProperty<string>>("nginx_deployment_id");
        set => this.WithProperty("nginx_deployment_id", value);
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
