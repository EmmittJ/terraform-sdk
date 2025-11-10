using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermBatchAccountDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_batch_account.
/// </summary>
public class AzurermBatchAccountDataSource : TerraformDataSource
{
    public AzurermBatchAccountDataSource(string name) : base("azurerm_batch_account", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("account_endpoint");
        this.DeclareOutput("encryption");
        this.DeclareOutput("key_vault_reference");
        this.DeclareOutput("location");
        this.DeclareOutput("pool_allocation_mode");
        this.DeclareOutput("primary_access_key");
        this.DeclareOutput("secondary_access_key");
        this.DeclareOutput("storage_account_id");
        this.DeclareOutput("tags");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermBatchAccountDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermBatchAccountDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The account_endpoint attribute.
    /// </summary>
    public TerraformExpression AccountEndpoint => this["account_endpoint"];

    /// <summary>
    /// The encryption attribute.
    /// </summary>
    public TerraformExpression Encryption => this["encryption"];

    /// <summary>
    /// The key_vault_reference attribute.
    /// </summary>
    public TerraformExpression KeyVaultReference => this["key_vault_reference"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The pool_allocation_mode attribute.
    /// </summary>
    public TerraformExpression PoolAllocationMode => this["pool_allocation_mode"];

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    public TerraformExpression PrimaryAccessKey => this["primary_access_key"];

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    public TerraformExpression SecondaryAccessKey => this["secondary_access_key"];

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformExpression StorageAccountId => this["storage_account_id"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
