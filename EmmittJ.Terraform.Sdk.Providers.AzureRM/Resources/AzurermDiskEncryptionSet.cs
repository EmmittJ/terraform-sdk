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
    public bool? AutoKeyRotationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_key_rotation_enabled")?.Value;
        set => this.WithProperty("auto_key_rotation_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    public string? EncryptionType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("encryption_type")?.Value;
        set => this.WithProperty("encryption_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The federated_client_id attribute.
    /// </summary>
    public string? FederatedClientId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("federated_client_id")?.Value;
        set => this.WithProperty("federated_client_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The key_vault_key_id attribute.
    /// </summary>
    public string? KeyVaultKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_vault_key_id")?.Value;
        set => this.WithProperty("key_vault_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The managed_hsm_key_id attribute.
    /// </summary>
    public string? ManagedHsmKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("managed_hsm_key_id")?.Value;
        set => this.WithProperty("managed_hsm_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The key_vault_key_url attribute.
    /// </summary>
    public TerraformExpression KeyVaultKeyUrl => this["key_vault_key_url"];

}
