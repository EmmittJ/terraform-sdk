using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSubscriptionsDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_subscriptions Terraform data source.
/// Retrieves information about a azurerm_subscriptions.
/// </summary>
public partial class AzurermSubscriptionsDataSource(string name) : TerraformDataSource("azurerm_subscriptions", name)
{
    /// <summary>
    /// The display_name_contains attribute.
    /// </summary>
    public TerraformValue<string>? DisplayNameContains
    {
        get => new TerraformReference<string>(this, "display_name_contains");
        set => SetArgument("display_name_contains", value);
    }

    /// <summary>
    /// The display_name_prefix attribute.
    /// </summary>
    public TerraformValue<string>? DisplayNamePrefix
    {
        get => new TerraformReference<string>(this, "display_name_prefix");
        set => SetArgument("display_name_prefix", value);
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
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSubscriptionsDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSubscriptionsDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
