using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_disk_encryption_set resource.
/// </summary>
public class AzurermDiskEncryptionSet : TerraformResource
{
    public AzurermDiskEncryptionSet(string name) : base("azurerm_disk_encryption_set", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("key_vault_key_url");
    }

    /// <summary>
    /// The auto_key_rotation_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AutoKeyRotationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_key_rotation_enabled");
        set => this.WithProperty("auto_key_rotation_enabled", value);
    }

    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EncryptionType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("encryption_type");
        set => this.WithProperty("encryption_type", value);
    }

    /// <summary>
    /// The federated_client_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FederatedClientId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("federated_client_id");
        set => this.WithProperty("federated_client_id", value);
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
    /// The key_vault_key_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KeyVaultKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_vault_key_id");
        set => this.WithProperty("key_vault_key_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The managed_hsm_key_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ManagedHsmKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("managed_hsm_key_id");
        set => this.WithProperty("managed_hsm_key_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The key_vault_key_url attribute.
    /// </summary>
    public TerraformExpression KeyVaultKeyUrl => this["key_vault_key_url"];

}
