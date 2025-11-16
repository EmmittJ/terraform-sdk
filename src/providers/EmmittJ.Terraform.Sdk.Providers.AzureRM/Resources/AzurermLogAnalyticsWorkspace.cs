using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermLogAnalyticsWorkspaceIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
    {
        get => new TerraformReference<string>(this, "principal_id");
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLogAnalyticsWorkspaceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_log_analytics_workspace Terraform resource.
/// Manages a azurerm_log_analytics_workspace resource.
/// </summary>
public partial class AzurermLogAnalyticsWorkspace(string name) : TerraformResource("azurerm_log_analytics_workspace", name)
{
    /// <summary>
    /// The allow_resource_only_permissions attribute.
    /// </summary>
    public TerraformValue<bool>? AllowResourceOnlyPermissions
    {
        get => new TerraformReference<bool>(this, "allow_resource_only_permissions");
        set => SetArgument("allow_resource_only_permissions", value);
    }

    /// <summary>
    /// The cmk_for_query_forced attribute.
    /// </summary>
    public TerraformValue<bool>? CmkForQueryForced
    {
        get => new TerraformReference<bool>(this, "cmk_for_query_forced");
        set => SetArgument("cmk_for_query_forced", value);
    }

    /// <summary>
    /// The daily_quota_gb attribute.
    /// </summary>
    public TerraformValue<double>? DailyQuotaGb
    {
        get => new TerraformReference<double>(this, "daily_quota_gb");
        set => SetArgument("daily_quota_gb", value);
    }

    /// <summary>
    /// The data_collection_rule_id attribute.
    /// </summary>
    public TerraformValue<string>? DataCollectionRuleId
    {
        get => new TerraformReference<string>(this, "data_collection_rule_id");
        set => SetArgument("data_collection_rule_id", value);
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
    /// The immediate_data_purge_on_30_days_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ImmediateDataPurgeOn30DaysEnabled
    {
        get => new TerraformReference<bool>(this, "immediate_data_purge_on_30_days_enabled");
        set => SetArgument("immediate_data_purge_on_30_days_enabled", value);
    }

    /// <summary>
    /// The internet_ingestion_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? InternetIngestionEnabled
    {
        get => new TerraformReference<bool>(this, "internet_ingestion_enabled");
        set => SetArgument("internet_ingestion_enabled", value);
    }

    /// <summary>
    /// The internet_query_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? InternetQueryEnabled
    {
        get => new TerraformReference<bool>(this, "internet_query_enabled");
        set => SetArgument("internet_query_enabled", value);
    }

    /// <summary>
    /// The local_authentication_disabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool> LocalAuthenticationDisabled
    {
        get => new TerraformReference<bool>(this, "local_authentication_disabled");
        set => SetArgument("local_authentication_disabled", value);
    }

    /// <summary>
    /// The local_authentication_enabled attribute.
    /// </summary>
    public TerraformValue<bool> LocalAuthenticationEnabled
    {
        get => new TerraformReference<bool>(this, "local_authentication_enabled");
        set => SetArgument("local_authentication_enabled", value);
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
    /// The reservation_capacity_in_gb_per_day attribute.
    /// </summary>
    public TerraformValue<double>? ReservationCapacityInGbPerDay
    {
        get => new TerraformReference<double>(this, "reservation_capacity_in_gb_per_day");
        set => SetArgument("reservation_capacity_in_gb_per_day", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    public TerraformValue<double> RetentionInDays
    {
        get => new TerraformReference<double>(this, "retention_in_days");
        set => SetArgument("retention_in_days", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformValue<string> Sku
    {
        get => new TerraformReference<string>(this, "sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public AzurermLogAnalyticsWorkspaceIdentityBlock? Identity
    {
        get => GetArgument<AzurermLogAnalyticsWorkspaceIdentityBlock>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermLogAnalyticsWorkspaceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermLogAnalyticsWorkspaceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
