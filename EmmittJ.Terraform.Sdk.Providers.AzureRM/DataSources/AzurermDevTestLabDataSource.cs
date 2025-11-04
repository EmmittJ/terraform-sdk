using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_dev_test_lab.
/// </summary>
public class AzurermDevTestLabDataSource : TerraformDataSource
{
    public AzurermDevTestLabDataSource(string name) : base("azurerm_dev_test_lab", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("artifacts_storage_account_id");
        this.DeclareOutput("default_premium_storage_account_id");
        this.DeclareOutput("default_storage_account_id");
        this.DeclareOutput("key_vault_id");
        this.DeclareOutput("location");
        this.DeclareOutput("premium_data_disk_storage_account_id");
        this.DeclareOutput("storage_type");
        this.DeclareOutput("tags");
        this.DeclareOutput("unique_identifier");
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
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The artifacts_storage_account_id attribute.
    /// </summary>
    public TerraformExpression ArtifactsStorageAccountId => this["artifacts_storage_account_id"];

    /// <summary>
    /// The default_premium_storage_account_id attribute.
    /// </summary>
    public TerraformExpression DefaultPremiumStorageAccountId => this["default_premium_storage_account_id"];

    /// <summary>
    /// The default_storage_account_id attribute.
    /// </summary>
    public TerraformExpression DefaultStorageAccountId => this["default_storage_account_id"];

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    public TerraformExpression KeyVaultId => this["key_vault_id"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The premium_data_disk_storage_account_id attribute.
    /// </summary>
    public TerraformExpression PremiumDataDiskStorageAccountId => this["premium_data_disk_storage_account_id"];

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformExpression StorageType => this["storage_type"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The unique_identifier attribute.
    /// </summary>
    public TerraformExpression UniqueIdentifier => this["unique_identifier"];

}
