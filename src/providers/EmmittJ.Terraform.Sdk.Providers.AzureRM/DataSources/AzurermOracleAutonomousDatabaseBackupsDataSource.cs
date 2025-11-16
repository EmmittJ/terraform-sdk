using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Represents a azurerm_oracle_autonomous_database_backups Terraform data source.
/// Retrieves information about a azurerm_oracle_autonomous_database_backups.
/// </summary>
public partial class AzurermOracleAutonomousDatabaseBackupsDataSource(string name) : TerraformDataSource("azurerm_oracle_autonomous_database_backups", name)
{
    /// <summary>
    /// The autonomous_database_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutonomousDatabaseId is required")]
    public required TerraformValue<string> AutonomousDatabaseId
    {
        get => new TerraformReference<string>(this, "autonomous_database_id");
        set => SetArgument("autonomous_database_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The autonomous_database_backups attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AutonomousDatabaseBackups
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "autonomous_database_backups").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermOracleAutonomousDatabaseBackupsDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermOracleAutonomousDatabaseBackupsDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
