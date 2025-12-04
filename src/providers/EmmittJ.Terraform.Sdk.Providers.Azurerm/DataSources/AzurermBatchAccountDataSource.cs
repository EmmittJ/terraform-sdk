using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermBatchAccountDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermBatchAccountDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_batch_account Terraform data source.
/// Retrieves information about a azurerm_batch_account.
/// </summary>
public partial class AzurermBatchAccountDataSource(string name) : TerraformDataSource("azurerm_batch_account", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The account_endpoint attribute.
    /// </summary>
    public TerraformValue<string> AccountEndpoint
        => AsReference("account_endpoint");

    /// <summary>
    /// The encryption attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Encryption
        => AsReference("encryption");

    /// <summary>
    /// The key_vault_reference attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> KeyVaultReference
        => AsReference("key_vault_reference");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The pool_allocation_mode attribute.
    /// </summary>
    public TerraformValue<string> PoolAllocationMode
        => AsReference("pool_allocation_mode");

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    public TerraformValue<string> PrimaryAccessKey
        => AsReference("primary_access_key");

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    public TerraformValue<string> SecondaryAccessKey
        => AsReference("secondary_access_key");

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformValue<string> StorageAccountId
        => AsReference("storage_account_id");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermBatchAccountDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermBatchAccountDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
