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
    public TerraformProperty<string>? ApplicationId
    {
        get => GetProperty<TerraformProperty<string>>("application_id");
        set => this.WithProperty("application_id", value);
    }

    /// <summary>
    /// The certificate_permissions attribute.
    /// </summary>
    public TerraformProperty<List<string>>? CertificatePermissions
    {
        get => GetProperty<TerraformProperty<List<string>>>("certificate_permissions");
        set => this.WithProperty("certificate_permissions", value);
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
    /// The key_permissions attribute.
    /// </summary>
    public TerraformProperty<List<string>>? KeyPermissions
    {
        get => GetProperty<TerraformProperty<List<string>>>("key_permissions");
        set => this.WithProperty("key_permissions", value);
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
    /// The object_id attribute.
    /// </summary>
    public TerraformProperty<string>? ObjectId
    {
        get => GetProperty<TerraformProperty<string>>("object_id");
        set => this.WithProperty("object_id", value);
    }

    /// <summary>
    /// The secret_permissions attribute.
    /// </summary>
    public TerraformProperty<List<string>>? SecretPermissions
    {
        get => GetProperty<TerraformProperty<List<string>>>("secret_permissions");
        set => this.WithProperty("secret_permissions", value);
    }

    /// <summary>
    /// The storage_permissions attribute.
    /// </summary>
    public TerraformProperty<List<string>>? StoragePermissions
    {
        get => GetProperty<TerraformProperty<List<string>>>("storage_permissions");
        set => this.WithProperty("storage_permissions", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => this.WithProperty("tenant_id", value);
    }

}
