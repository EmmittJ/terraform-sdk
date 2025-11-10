using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_key_vault_certificate ephemeral resource (temporary credentials/tokens).
/// Ephemeral resources are used for temporary credentials, tokens, and secrets.
/// </summary>
public class AzurermKeyVaultCertificateEphemeralResource : TerraformEphemeralResource
{
    public AzurermKeyVaultCertificateEphemeralResource(string name) : base("azurerm_key_vault_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("certificate_count");
        this.DeclareOutput("expiration_date");
        this.DeclareOutput("hex");
        this.DeclareOutput("key");
        this.DeclareOutput("not_before_date");
        this.DeclareOutput("pem");
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
    /// The certificate_count attribute.
    /// </summary>
    public TerraformExpression CertificateCount => this["certificate_count"];

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    public TerraformExpression ExpirationDate => this["expiration_date"];

    /// <summary>
    /// The hex attribute.
    /// </summary>
    public TerraformExpression Hex => this["hex"];

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformExpression Key => this["key"];

    /// <summary>
    /// The not_before_date attribute.
    /// </summary>
    public TerraformExpression NotBeforeDate => this["not_before_date"];

    /// <summary>
    /// The pem attribute.
    /// </summary>
    public TerraformExpression Pem => this["pem"];

}
