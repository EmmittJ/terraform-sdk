using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPublicMaintenanceConfigurationsDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_public_maintenance_configurations Terraform data source.
/// Retrieves information about a azurerm_public_maintenance_configurations.
/// </summary>
public partial class AzurermPublicMaintenanceConfigurationsDataSource(string name) : TerraformDataSource("azurerm_public_maintenance_configurations", name)
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
    public TerraformValue<string>? Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The recur_every attribute.
    /// </summary>
    public TerraformValue<string>? RecurEvery
    {
        get => new TerraformReference<string>(this, "recur_every");
        set => SetArgument("recur_every", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformValue<string>? Scope
    {
        get => new TerraformReference<string>(this, "scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// The configs attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Configs
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "configs").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermPublicMaintenanceConfigurationsDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermPublicMaintenanceConfigurationsDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
