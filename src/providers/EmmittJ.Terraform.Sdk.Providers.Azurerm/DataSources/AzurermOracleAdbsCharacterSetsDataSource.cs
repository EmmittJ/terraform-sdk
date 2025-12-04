using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermOracleAdbsCharacterSetsDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermOracleAdbsCharacterSetsDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_oracle_adbs_character_sets Terraform data source.
/// Retrieves information about a azurerm_oracle_adbs_character_sets.
/// </summary>
public partial class AzurermOracleAdbsCharacterSetsDataSource(string name) : TerraformDataSource("azurerm_oracle_adbs_character_sets", name)
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
    /// The character_sets attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CharacterSets
        => AsReference("character_sets");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermOracleAdbsCharacterSetsDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermOracleAdbsCharacterSetsDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
