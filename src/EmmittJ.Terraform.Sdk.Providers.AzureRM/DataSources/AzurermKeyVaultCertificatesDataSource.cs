using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_key_vault_certificates.
/// </summary>
public class AzurermKeyVaultCertificatesDataSource : TerraformDataSource
{
    public AzurermKeyVaultCertificatesDataSource(string name) : base("azurerm_key_vault_certificates", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("certificates");
        this.DeclareOutput("names");
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
    /// The include_pending attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludePending
    {
        get => GetProperty<TerraformProperty<bool>>("include_pending");
        set => this.WithProperty("include_pending", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_id");
        set => this.WithProperty("key_vault_id", value);
    }

    /// <summary>
    /// The certificates attribute.
    /// </summary>
    public TerraformExpression Certificates => this["certificates"];

    /// <summary>
    /// The names attribute.
    /// </summary>
    public TerraformExpression Names => this["names"];

}
