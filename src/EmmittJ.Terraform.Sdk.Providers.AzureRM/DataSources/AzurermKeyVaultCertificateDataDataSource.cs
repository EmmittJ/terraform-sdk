using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultCertificateDataDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_key_vault_certificate_data.
/// </summary>
public class AzurermKeyVaultCertificateDataDataSource : TerraformDataSource
{
    public AzurermKeyVaultCertificateDataDataSource(string name) : base("azurerm_key_vault_certificate_data", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("certificates_count");
        this.DeclareOutput("expires");
        this.DeclareOutput("hex");
        this.DeclareOutput("key");
        this.DeclareOutput("not_before");
        this.DeclareOutput("pem");
        this.DeclareOutput("tags");
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
        get => GetProperty<TerraformProperty<string>>("key_vault_id");
        set => this.WithProperty("key_vault_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
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
    public AzurermKeyVaultCertificateDataDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermKeyVaultCertificateDataDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The certificates_count attribute.
    /// </summary>
    public TerraformExpression CertificatesCount => this["certificates_count"];

    /// <summary>
    /// The expires attribute.
    /// </summary>
    public TerraformExpression Expires => this["expires"];

    /// <summary>
    /// The hex attribute.
    /// </summary>
    public TerraformExpression Hex => this["hex"];

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformExpression Key => this["key"];

    /// <summary>
    /// The not_before attribute.
    /// </summary>
    public TerraformExpression NotBefore => this["not_before"];

    /// <summary>
    /// The pem attribute.
    /// </summary>
    public TerraformExpression Pem => this["pem"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
