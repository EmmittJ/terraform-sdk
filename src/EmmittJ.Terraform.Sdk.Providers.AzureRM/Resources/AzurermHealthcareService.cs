using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_healthcare_service resource.
/// </summary>
public class AzurermHealthcareService : TerraformResource
{
    public AzurermHealthcareService(string name) : base("azurerm_healthcare_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The access_policy_object_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? AccessPolicyObjectIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("access_policy_object_ids");
        set => this.WithProperty("access_policy_object_ids", value);
    }

    /// <summary>
    /// The configuration_export_storage_account_name attribute.
    /// </summary>
    public TerraformProperty<string>? ConfigurationExportStorageAccountName
    {
        get => GetProperty<TerraformProperty<string>>("configuration_export_storage_account_name");
        set => this.WithProperty("configuration_export_storage_account_name", value);
    }

    /// <summary>
    /// The cosmosdb_key_vault_key_versionless_id attribute.
    /// </summary>
    public TerraformProperty<string>? CosmosdbKeyVaultKeyVersionlessId
    {
        get => GetProperty<TerraformProperty<string>>("cosmosdb_key_vault_key_versionless_id");
        set => this.WithProperty("cosmosdb_key_vault_key_versionless_id", value);
    }

    /// <summary>
    /// The cosmosdb_throughput attribute.
    /// </summary>
    public TerraformProperty<double>? CosmosdbThroughput
    {
        get => GetProperty<TerraformProperty<double>>("cosmosdb_throughput");
        set => this.WithProperty("cosmosdb_throughput", value);
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
    /// The kind attribute.
    /// </summary>
    public TerraformProperty<string>? Kind
    {
        get => GetProperty<TerraformProperty<string>>("kind");
        set => this.WithProperty("kind", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_network_access_enabled");
        set => this.WithProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

}
