using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_key_vault_access_policy resource.
/// </summary>
public class AzurermKeyVaultAccessPolicy : TerraformResource
{
    public AzurermKeyVaultAccessPolicy(string name) : base("azurerm_key_vault_access_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The application_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ApplicationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_id");
        set => this.WithProperty("application_id", value);
    }

    /// <summary>
    /// The certificate_permissions attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? CertificatePermissions
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("certificate_permissions");
        set => this.WithProperty("certificate_permissions", value);
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
    /// The key_permissions attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? KeyPermissions
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("key_permissions");
        set => this.WithProperty("key_permissions", value);
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
    /// The object_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ObjectId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("object_id");
        set => this.WithProperty("object_id", value);
    }

    /// <summary>
    /// The secret_permissions attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? SecretPermissions
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("secret_permissions");
        set => this.WithProperty("secret_permissions", value);
    }

    /// <summary>
    /// The storage_permissions attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? StoragePermissions
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("storage_permissions");
        set => this.WithProperty("storage_permissions", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TenantId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tenant_id");
        set => this.WithProperty("tenant_id", value);
    }

}
