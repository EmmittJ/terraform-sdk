using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSubscriptionDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermSubscriptionDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_subscription Terraform data source.
/// Retrieves information about a azurerm_subscription.
/// </summary>
public partial class AzurermSubscriptionDataSource(string name) : TerraformDataSource("azurerm_subscription", name)
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
    /// The subscription_id attribute.
    /// </summary>
    public TerraformValue<string>? SubscriptionId
    {
        get => GetArgument<TerraformValue<string>>("subscription_id");
        set => SetArgument("subscription_id", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
        => AsReference("display_name");

    /// <summary>
    /// The location_placement_id attribute.
    /// </summary>
    public TerraformValue<string> LocationPlacementId
        => AsReference("location_placement_id");

    /// <summary>
    /// The quota_id attribute.
    /// </summary>
    public TerraformValue<string> QuotaId
        => AsReference("quota_id");

    /// <summary>
    /// The spending_limit attribute.
    /// </summary>
    public TerraformValue<string> SpendingLimit
        => AsReference("spending_limit");

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
        => AsReference("tenant_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSubscriptionDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSubscriptionDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
