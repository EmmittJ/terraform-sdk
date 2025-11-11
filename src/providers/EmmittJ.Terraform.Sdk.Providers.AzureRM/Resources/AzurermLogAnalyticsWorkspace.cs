using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermLogAnalyticsWorkspaceIdentityBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformPropertyName("identity_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLogAnalyticsWorkspaceTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

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
    [TerraformPropertyName("allow_resource_only_permissions")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AllowResourceOnlyPermissions { get; set; }

    /// <summary>
    /// The cmk_for_query_forced attribute.
    /// </summary>
    [TerraformPropertyName("cmk_for_query_forced")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? CmkForQueryForced { get; set; }

    /// <summary>
    /// The daily_quota_gb attribute.
    /// </summary>
    [TerraformPropertyName("daily_quota_gb")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? DailyQuotaGb { get; set; }

    /// <summary>
    /// The data_collection_rule_id attribute.
    /// </summary>
    [TerraformPropertyName("data_collection_rule_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DataCollectionRuleId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The immediate_data_purge_on_30_days_enabled attribute.
    /// </summary>
    [TerraformPropertyName("immediate_data_purge_on_30_days_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ImmediateDataPurgeOn30DaysEnabled { get; set; }

    /// <summary>
    /// The internet_ingestion_enabled attribute.
    /// </summary>
    [TerraformPropertyName("internet_ingestion_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? InternetIngestionEnabled { get; set; }

    /// <summary>
    /// The internet_query_enabled attribute.
    /// </summary>
    [TerraformPropertyName("internet_query_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? InternetQueryEnabled { get; set; }

    /// <summary>
    /// The local_authentication_disabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("local_authentication_disabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> LocalAuthenticationDisabled { get; set; } = default!;

    /// <summary>
    /// The local_authentication_enabled attribute.
    /// </summary>
    [TerraformPropertyName("local_authentication_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> LocalAuthenticationEnabled { get; set; } = default!;

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The reservation_capacity_in_gb_per_day attribute.
    /// </summary>
    [TerraformPropertyName("reservation_capacity_in_gb_per_day")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ReservationCapacityInGbPerDay { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    [TerraformPropertyName("retention_in_days")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> RetentionInDays { get; set; } = default!;

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformPropertyName("sku")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Sku { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermLogAnalyticsWorkspaceIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermLogAnalyticsWorkspaceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The primary_shared_key attribute.
    /// </summary>
    [TerraformPropertyName("primary_shared_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimarySharedKey => new TerraformReference(this, "primary_shared_key");

    /// <summary>
    /// The secondary_shared_key attribute.
    /// </summary>
    [TerraformPropertyName("secondary_shared_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondarySharedKey => new TerraformReference(this, "secondary_shared_key");

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [TerraformPropertyName("workspace_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> WorkspaceId => new TerraformReference(this, "workspace_id");

}
