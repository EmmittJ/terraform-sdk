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
        set => SetProperty("read", value);
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
        SetOutput("certificates_count");
        SetOutput("expires");
        SetOutput("hex");
        SetOutput("key");
        SetOutput("not_before");
        SetOutput("pem");
        SetOutput("tags");
        SetOutput("id");
        SetOutput("key_vault_id");
        SetOutput("name");
        SetOutput("version");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    public required TerraformProperty<string> KeyVaultId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_vault_id");
        set => SetProperty("key_vault_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string> Version
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version");
        set => SetProperty("version", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermKeyVaultCertificateDataDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
