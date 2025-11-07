using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The nginx_deployment_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NginxDeploymentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("nginx_deployment_id");
        set => this.WithProperty("nginx_deployment_id", value);
    }

    /// <summary>
    /// The package_data attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PackageData
    {
        get => GetProperty<TerraformLiteralProperty<string>>("package_data");
        set => this.WithProperty("package_data", value);
    }

    /// <summary>
    /// The root_file attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RootFile
    {
        get => GetProperty<TerraformLiteralProperty<string>>("root_file");
        set => this.WithProperty("root_file", value);
    }

}
