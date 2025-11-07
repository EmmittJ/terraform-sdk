using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_nginx_certificate.
/// </summary>
public class AzurermNginxCertificateDataSource : TerraformDataSource
{
    public AzurermNginxCertificateDataSource(string name) : base("azurerm_nginx_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("certificate_virtual_path");
        this.DeclareOutput("error_code");
        this.DeclareOutput("error_message");
        this.DeclareOutput("key_vault_secret_creation_date");
        this.DeclareOutput("key_vault_secret_id");
        this.DeclareOutput("key_vault_secret_version");
        this.DeclareOutput("key_virtual_path");
        this.DeclareOutput("sha1_thumbprint");
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The certificate_virtual_path attribute.
    /// </summary>
    public TerraformExpression CertificateVirtualPath => this["certificate_virtual_path"];

    /// <summary>
    /// The error_code attribute.
    /// </summary>
    public TerraformExpression ErrorCode => this["error_code"];

    /// <summary>
    /// The error_message attribute.
    /// </summary>
    public TerraformExpression ErrorMessage => this["error_message"];

    /// <summary>
    /// The key_vault_secret_creation_date attribute.
    /// </summary>
    public TerraformExpression KeyVaultSecretCreationDate => this["key_vault_secret_creation_date"];

    /// <summary>
    /// The key_vault_secret_id attribute.
    /// </summary>
    public TerraformExpression KeyVaultSecretId => this["key_vault_secret_id"];

    /// <summary>
    /// The key_vault_secret_version attribute.
    /// </summary>
    public TerraformExpression KeyVaultSecretVersion => this["key_vault_secret_version"];

    /// <summary>
    /// The key_virtual_path attribute.
    /// </summary>
    public TerraformExpression KeyVirtualPath => this["key_virtual_path"];

    /// <summary>
    /// The sha1_thumbprint attribute.
    /// </summary>
    public TerraformExpression Sha1Thumbprint => this["sha1_thumbprint"];

}
