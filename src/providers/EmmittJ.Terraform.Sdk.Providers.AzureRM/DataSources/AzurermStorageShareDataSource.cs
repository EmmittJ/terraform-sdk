using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for acl in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageShareDataSourceAclBlock : TerraformBlock
{
    /// <summary>
    /// The access_policy attribute.
    /// </summary>
    public List<TerraformProperty<object>>? AccessPolicy
    {
        get => GetProperty<List<TerraformProperty<object>>>("access_policy");
        set => WithProperty("access_policy", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageShareDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_storage_share.
/// </summary>
public class AzurermStorageShareDataSource : TerraformDataSource
{
    public AzurermStorageShareDataSource(string name) : base("azurerm_storage_share", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("quota");
        this.WithOutput("resource_manager_id");
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
    /// The metadata attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Metadata
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("metadata");
        set => this.WithProperty("metadata", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountId
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_id");
        set => this.WithProperty("storage_account_id", value);
    }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountName
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_name");
        set => this.WithProperty("storage_account_name", value);
    }

    /// <summary>
    /// Block for acl.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermStorageShareDataSourceAclBlock>? Acl
    {
        get => GetProperty<List<AzurermStorageShareDataSourceAclBlock>>("acl");
        set => this.WithProperty("acl", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStorageShareDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermStorageShareDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The quota attribute.
    /// </summary>
    public TerraformExpression Quota => this["quota"];

    /// <summary>
    /// The resource_manager_id attribute.
    /// </summary>
    public TerraformExpression ResourceManagerId => this["resource_manager_id"];

}
