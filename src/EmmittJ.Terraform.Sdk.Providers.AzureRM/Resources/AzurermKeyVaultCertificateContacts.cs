using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_key_vault_certificate_contacts resource.
/// </summary>
public class AzurermKeyVaultCertificateContacts : TerraformResource
{
    public AzurermKeyVaultCertificateContacts(string name) : base("azurerm_key_vault_certificate_contacts", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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

}
