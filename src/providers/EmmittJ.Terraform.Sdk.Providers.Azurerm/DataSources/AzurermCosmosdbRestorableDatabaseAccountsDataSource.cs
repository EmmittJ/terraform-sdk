using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermCosmosdbRestorableDatabaseAccountsDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermCosmosdbRestorableDatabaseAccountsDataSourceTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_cosmosdb_restorable_database_accounts Terraform data source.
/// Retrieves information about a azurerm_cosmosdb_restorable_database_accounts.
/// </summary>
public partial class AzurermCosmosdbRestorableDatabaseAccountsDataSource(string name) : TerraformDataSource("azurerm_cosmosdb_restorable_database_accounts", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The accounts attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Accounts
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "accounts").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermCosmosdbRestorableDatabaseAccountsDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermCosmosdbRestorableDatabaseAccountsDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
