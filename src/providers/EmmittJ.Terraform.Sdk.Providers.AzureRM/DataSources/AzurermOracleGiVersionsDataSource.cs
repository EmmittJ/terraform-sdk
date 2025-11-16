using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermOracleGiVersionsDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_oracle_gi_versions Terraform data source.
/// Retrieves information about a azurerm_oracle_gi_versions.
/// </summary>
public partial class AzurermOracleGiVersionsDataSource(string name) : TerraformDataSource("azurerm_oracle_gi_versions", name)
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
    /// Filter the versions by system shape. Possible values are &#39;ExaDbXS&#39;, &#39;Exadata.X9M&#39;, and &#39;Exadata.X11M&#39;.
    /// </summary>
    public TerraformValue<string>? Shape
    {
        get => new TerraformReference<string>(this, "shape");
        set => SetArgument("shape", value);
    }

    /// <summary>
    /// Filter the versions by zone
    /// </summary>
    public TerraformValue<string>? Zone
    {
        get => new TerraformReference<string>(this, "zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// The versions attribute.
    /// </summary>
    public TerraformList<string> Versions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "versions").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermOracleGiVersionsDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermOracleGiVersionsDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
