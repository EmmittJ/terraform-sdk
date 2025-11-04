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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The nginx_deployment_id attribute.
    /// </summary>
    public string? NginxDeploymentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("nginx_deployment_id")?.Value;
        set => this.WithProperty("nginx_deployment_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The package_data attribute.
    /// </summary>
    public string? PackageData
    {
        get => GetProperty<TerraformLiteralProperty<string>>("package_data")?.Value;
        set => this.WithProperty("package_data", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The root_file attribute.
    /// </summary>
    public string? RootFile
    {
        get => GetProperty<TerraformLiteralProperty<string>>("root_file")?.Value;
        set => this.WithProperty("root_file", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
