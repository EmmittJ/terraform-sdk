using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNginxCertificateDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

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
        this.WithOutput("certificate_virtual_path");
        this.WithOutput("error_code");
        this.WithOutput("error_message");
        this.WithOutput("key_vault_secret_creation_date");
        this.WithOutput("key_vault_secret_id");
        this.WithOutput("key_vault_secret_version");
        this.WithOutput("key_virtual_path");
        this.WithOutput("sha1_thumbprint");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The nginx_deployment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NginxDeploymentId is required")]
    public required TerraformProperty<string> NginxDeploymentId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("nginx_deployment_id");
        set => this.WithProperty("nginx_deployment_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNginxCertificateDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermNginxCertificateDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
