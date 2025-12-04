using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermOracleDbSystemShapesDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermOracleDbSystemShapesDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_oracle_db_system_shapes Terraform data source.
/// Retrieves information about a azurerm_oracle_db_system_shapes.
/// </summary>
public partial class AzurermOracleDbSystemShapesDataSource(string name) : TerraformDataSource("azurerm_oracle_db_system_shapes", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Filter the versions by zone
    /// </summary>
    public TerraformValue<string>? Zone
    {
        get => GetArgument<TerraformValue<string>>("zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// The db_system_shapes attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DbSystemShapes
        => AsReference("db_system_shapes");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermOracleDbSystemShapesDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermOracleDbSystemShapesDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
