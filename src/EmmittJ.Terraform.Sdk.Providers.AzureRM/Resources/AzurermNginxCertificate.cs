using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_nginx_certificate resource.
/// </summary>
public class AzurermNginxCertificate : TerraformResource
{
    public AzurermNginxCertificate(string name) : base("azurerm_nginx_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The certificate_virtual_path attribute.
    /// </summary>
    public string? CertificateVirtualPath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_virtual_path")?.Value;
        set => this.WithProperty("certificate_virtual_path", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The key_vault_secret_id attribute.
    /// </summary>
    public string? KeyVaultSecretId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_vault_secret_id")?.Value;
        set => this.WithProperty("key_vault_secret_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The key_virtual_path attribute.
    /// </summary>
    public string? KeyVirtualPath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_virtual_path")?.Value;
        set => this.WithProperty("key_virtual_path", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The nginx_deployment_id attribute.
    /// </summary>
    public string? NginxDeploymentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("nginx_deployment_id")?.Value;
        set => this.WithProperty("nginx_deployment_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
