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
    public TerraformProperty<string>? RootFile
    {
        get => GetProperty<TerraformProperty<string>>("root_file");
        set => this.WithProperty("root_file", value);
    }

}
