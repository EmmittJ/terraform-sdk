using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermOracleAutonomousDatabaseBackupsDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_oracle_autonomous_database_backups.
/// </summary>
public class AzurermOracleAutonomousDatabaseBackupsDataSource : TerraformDataSource
{
    public AzurermOracleAutonomousDatabaseBackupsDataSource(string name) : base("azurerm_oracle_autonomous_database_backups", name)
    {
    }

    /// <summary>
    /// The autonomous_database_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutonomousDatabaseId is required")]
    [TerraformArgument("autonomous_database_id")]
    public required TerraformValue<string> AutonomousDatabaseId
    {
        get => new TerraformReference<string>(this, "autonomous_database_id");
        set => SetArgument("autonomous_database_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermOracleAutonomousDatabaseBackupsDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The autonomous_database_backups attribute.
    /// </summary>
    [TerraformArgument("autonomous_database_backups")]
    public TerraformList<object> AutonomousDatabaseBackups
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "autonomous_database_backups").ResolveNodes(ctx));
    }

}
