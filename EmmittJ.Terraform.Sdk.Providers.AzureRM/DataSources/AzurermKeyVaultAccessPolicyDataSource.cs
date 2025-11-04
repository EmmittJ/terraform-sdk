using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_key_vault_access_policy.
/// </summary>
public class AzurermKeyVaultAccessPolicyDataSource : TerraformDataSource
{
    public AzurermKeyVaultAccessPolicyDataSource(string name) : base("azurerm_key_vault_access_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("certificate_permissions");
        this.DeclareOutput("key_permissions");
        this.DeclareOutput("secret_permissions");
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The certificate_permissions attribute.
    /// </summary>
    public TerraformExpression CertificatePermissions => this["certificate_permissions"];

    /// <summary>
    /// The key_permissions attribute.
    /// </summary>
    public TerraformExpression KeyPermissions => this["key_permissions"];

    /// <summary>
    /// The secret_permissions attribute.
    /// </summary>
    public TerraformExpression SecretPermissions => this["secret_permissions"];

}
