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
    public TerraformProperty<string>? CertificateVirtualPath
    {
        get => GetProperty<TerraformProperty<string>>("certificate_virtual_path");
        set => this.WithProperty("certificate_virtual_path", value);
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
    /// The key_vault_secret_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultSecretId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_secret_id");
        set => this.WithProperty("key_vault_secret_id", value);
    }

    /// <summary>
    /// The key_virtual_path attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVirtualPath
    {
        get => GetProperty<TerraformProperty<string>>("key_virtual_path");
        set => this.WithProperty("key_virtual_path", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The nginx_deployment_id attribute.
    /// </summary>
    public TerraformProperty<string>? NginxDeploymentId
    {
        get => GetProperty<TerraformProperty<string>>("nginx_deployment_id");
        set => this.WithProperty("nginx_deployment_id", value);
    }

}
