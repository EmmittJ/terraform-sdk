using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_key_vault_certificate.
/// </summary>
public class AzurermKeyVaultCertificateDataSource : TerraformDataSource
{
    public AzurermKeyVaultCertificateDataSource(string name) : base("azurerm_key_vault_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("certificate_data");
        this.DeclareOutput("certificate_data_base64");
        this.DeclareOutput("certificate_policy");
        this.DeclareOutput("expires");
        this.DeclareOutput("not_before");
        this.DeclareOutput("resource_manager_id");
        this.DeclareOutput("resource_manager_versionless_id");
        this.DeclareOutput("secret_id");
        this.DeclareOutput("tags");
        this.DeclareOutput("thumbprint");
        this.DeclareOutput("versionless_id");
        this.DeclareOutput("versionless_secret_id");
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
    /// The key_vault_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KeyVaultId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_vault_id");
        set => this.WithProperty("key_vault_id", value);
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
    /// The version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Version
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

    /// <summary>
    /// The certificate_data attribute.
    /// </summary>
    public TerraformExpression CertificateData => this["certificate_data"];

    /// <summary>
    /// The certificate_data_base64 attribute.
    /// </summary>
    public TerraformExpression CertificateDataBase64 => this["certificate_data_base64"];

    /// <summary>
    /// The certificate_policy attribute.
    /// </summary>
    public TerraformExpression CertificatePolicy => this["certificate_policy"];

    /// <summary>
    /// The expires attribute.
    /// </summary>
    public TerraformExpression Expires => this["expires"];

    /// <summary>
    /// The not_before attribute.
    /// </summary>
    public TerraformExpression NotBefore => this["not_before"];

    /// <summary>
    /// The resource_manager_id attribute.
    /// </summary>
    public TerraformExpression ResourceManagerId => this["resource_manager_id"];

    /// <summary>
    /// The resource_manager_versionless_id attribute.
    /// </summary>
    public TerraformExpression ResourceManagerVersionlessId => this["resource_manager_versionless_id"];

    /// <summary>
    /// The secret_id attribute.
    /// </summary>
    public TerraformExpression SecretId => this["secret_id"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformExpression Thumbprint => this["thumbprint"];

    /// <summary>
    /// The versionless_id attribute.
    /// </summary>
    public TerraformExpression VersionlessId => this["versionless_id"];

    /// <summary>
    /// The versionless_secret_id attribute.
    /// </summary>
    public TerraformExpression VersionlessSecretId => this["versionless_secret_id"];

}
