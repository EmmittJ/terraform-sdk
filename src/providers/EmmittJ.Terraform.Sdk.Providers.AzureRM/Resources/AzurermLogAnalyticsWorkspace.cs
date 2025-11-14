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
    [TerraformArgument("identity_ids")]
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_log_analytics_workspace resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermLogAnalyticsWorkspace : TerraformResource
{
    public AzurermLogAnalyticsWorkspace(string name) : base("azurerm_log_analytics_workspace", name)
    {
    }

    /// <summary>
    /// The allow_resource_only_permissions attribute.
    /// </summary>
    [TerraformArgument("allow_resource_only_permissions")]
    public TerraformValue<bool>? AllowResourceOnlyPermissions
    {
        get => new TerraformReference<bool>(this, "allow_resource_only_permissions");
        set => SetArgument("allow_resource_only_permissions", value);
    }

    /// <summary>
    /// The cmk_for_query_forced attribute.
    /// </summary>
    [TerraformArgument("cmk_for_query_forced")]
    public TerraformValue<bool>? CmkForQueryForced
    {
        get => new TerraformReference<bool>(this, "cmk_for_query_forced");
        set => SetArgument("cmk_for_query_forced", value);
    }

    /// <summary>
    /// The daily_quota_gb attribute.
    /// </summary>
    [TerraformArgument("daily_quota_gb")]
    public TerraformValue<double>? DailyQuotaGb
    {
        get => new TerraformReference<double>(this, "daily_quota_gb");
        set => SetArgument("daily_quota_gb", value);
    }

    /// <summary>
    /// The data_collection_rule_id attribute.
    /// </summary>
    [TerraformArgument("data_collection_rule_id")]
    public TerraformValue<string>? DataCollectionRuleId
    {
        get => new TerraformReference<string>(this, "data_collection_rule_id");
        set => SetArgument("data_collection_rule_id", value);
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
    /// The immediate_data_purge_on_30_days_enabled attribute.
    /// </summary>
    [TerraformArgument("immediate_data_purge_on_30_days_enabled")]
    public TerraformValue<bool>? ImmediateDataPurgeOn30DaysEnabled
    {
        get => new TerraformReference<bool>(this, "immediate_data_purge_on_30_days_enabled");
        set => SetArgument("immediate_data_purge_on_30_days_enabled", value);
    }

    /// <summary>
    /// The internet_ingestion_enabled attribute.
    /// </summary>
    [TerraformArgument("internet_ingestion_enabled")]
    public TerraformValue<bool>? InternetIngestionEnabled
    {
        get => new TerraformReference<bool>(this, "internet_ingestion_enabled");
        set => SetArgument("internet_ingestion_enabled", value);
    }

    /// <summary>
    /// The internet_query_enabled attribute.
    /// </summary>
    [TerraformArgument("internet_query_enabled")]
    public TerraformValue<bool>? InternetQueryEnabled
    {
        get => new TerraformReference<bool>(this, "internet_query_enabled");
        set => SetArgument("internet_query_enabled", value);
    }

    /// <summary>
    /// The local_authentication_disabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformArgument("local_authentication_disabled")]
    public TerraformValue<bool> LocalAuthenticationDisabled
    {
        get => new TerraformReference<bool>(this, "local_authentication_disabled");
        set => SetArgument("local_authentication_disabled", value);
    }

    /// <summary>
    /// The local_authentication_enabled attribute.
    /// </summary>
    [TerraformArgument("local_authentication_enabled")]
    public TerraformValue<bool> LocalAuthenticationEnabled
    {
        get => new TerraformReference<bool>(this, "local_authentication_enabled");
        set => SetArgument("local_authentication_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The reservation_capacity_in_gb_per_day attribute.
    /// </summary>
    [TerraformArgument("reservation_capacity_in_gb_per_day")]
    public TerraformValue<double>? ReservationCapacityInGbPerDay
    {
        get => new TerraformReference<double>(this, "reservation_capacity_in_gb_per_day");
        set => SetArgument("reservation_capacity_in_gb_per_day", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    [TerraformArgument("retention_in_days")]
    public TerraformValue<double> RetentionInDays
    {
        get => new TerraformReference<double>(this, "retention_in_days");
        set => SetArgument("retention_in_days", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformArgument("sku")]
    public TerraformValue<string> Sku
    {
        get => new TerraformReference<string>(this, "sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermLogAnalyticsWorkspaceIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermLogAnalyticsWorkspaceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The primary_shared_key attribute.
    /// </summary>
    [TerraformArgument("primary_shared_key")]
    public TerraformValue<string> PrimarySharedKey
    {
        get => new TerraformReference<string>(this, "primary_shared_key");
    }

    /// <summary>
    /// The secondary_shared_key attribute.
    /// </summary>
    [TerraformArgument("secondary_shared_key")]
    public TerraformValue<string> SecondarySharedKey
    {
        get => new TerraformReference<string>(this, "secondary_shared_key");
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [TerraformArgument("workspace_id")]
    public TerraformValue<string> WorkspaceId
    {
        get => new TerraformReference<string>(this, "workspace_id");
    }

}
