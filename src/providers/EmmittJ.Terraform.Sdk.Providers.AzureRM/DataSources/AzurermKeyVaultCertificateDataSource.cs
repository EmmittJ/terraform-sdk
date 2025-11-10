using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultCertificateDataSourceTimeoutsBlock : TerraformBlock
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
        this.WithOutput("certificate_data");
        this.WithOutput("certificate_data_base64");
        this.WithOutput("certificate_policy");
        this.WithOutput("expires");
        this.WithOutput("not_before");
        this.WithOutput("resource_manager_id");
        this.WithOutput("resource_manager_versionless_id");
        this.WithOutput("secret_id");
        this.WithOutput("tags");
        this.WithOutput("thumbprint");
        this.WithOutput("versionless_id");
        this.WithOutput("versionless_secret_id");
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
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    public required TerraformProperty<string> KeyVaultId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("key_vault_id");
        set => this.WithProperty("key_vault_id", value);
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
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermKeyVaultCertificateDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermKeyVaultCertificateDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
