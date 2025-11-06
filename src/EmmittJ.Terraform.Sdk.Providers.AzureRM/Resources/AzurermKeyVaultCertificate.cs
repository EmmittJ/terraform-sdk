using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_key_vault_certificate resource.
/// </summary>
public class AzurermKeyVaultCertificate : TerraformResource
{
    public AzurermKeyVaultCertificate(string name) : base("azurerm_key_vault_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("certificate_attribute");
        this.DeclareOutput("certificate_data");
        this.DeclareOutput("certificate_data_base64");
        this.DeclareOutput("resource_manager_id");
        this.DeclareOutput("resource_manager_versionless_id");
        this.DeclareOutput("secret_id");
        this.DeclareOutput("thumbprint");
        this.DeclareOutput("version");
        this.DeclareOutput("versionless_id");
        this.DeclareOutput("versionless_secret_id");
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
    /// The key_vault_id attribute.
    /// </summary>
    public string? KeyVaultId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_vault_id")?.Value;
        set => this.WithProperty("key_vault_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The certificate_attribute attribute.
    /// </summary>
    public TerraformExpression CertificateAttribute => this["certificate_attribute"];

    /// <summary>
    /// The certificate_data attribute.
    /// </summary>
    public TerraformExpression CertificateData => this["certificate_data"];

    /// <summary>
    /// The certificate_data_base64 attribute.
    /// </summary>
    public TerraformExpression CertificateDataBase64 => this["certificate_data_base64"];

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
    /// The thumbprint attribute.
    /// </summary>
    public TerraformExpression Thumbprint => this["thumbprint"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

    /// <summary>
    /// The versionless_id attribute.
    /// </summary>
    public TerraformExpression VersionlessId => this["versionless_id"];

    /// <summary>
    /// The versionless_secret_id attribute.
    /// </summary>
    public TerraformExpression VersionlessSecretId => this["versionless_secret_id"];

}
