using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLogAnalyticsWorkspaceIdentityBlock : TerraformBlockBase
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformProperty("identity_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermLogAnalyticsWorkspaceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_log_analytics_workspace resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermLogAnalyticsWorkspace : TerraformResource
{
    public AzurermLogAnalyticsWorkspace(string name) : base("azurerm_log_analytics_workspace", name)
    {
    }

    /// <summary>
    /// The allow_resource_only_permissions attribute.
    /// </summary>
    [TerraformProperty("allow_resource_only_permissions")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AllowResourceOnlyPermissions { get; set; }

    /// <summary>
    /// The cmk_for_query_forced attribute.
    /// </summary>
    [TerraformProperty("cmk_for_query_forced")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CmkForQueryForced { get; set; }

    /// <summary>
    /// The daily_quota_gb attribute.
    /// </summary>
    [TerraformProperty("daily_quota_gb")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? DailyQuotaGb { get; set; }

    /// <summary>
    /// The data_collection_rule_id attribute.
    /// </summary>
    [TerraformProperty("data_collection_rule_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DataCollectionRuleId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The immediate_data_purge_on_30_days_enabled attribute.
    /// </summary>
    [TerraformProperty("immediate_data_purge_on_30_days_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ImmediateDataPurgeOn30DaysEnabled { get; set; }

    /// <summary>
    /// The internet_ingestion_enabled attribute.
    /// </summary>
    [TerraformProperty("internet_ingestion_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? InternetIngestionEnabled { get; set; }

    /// <summary>
    /// The internet_query_enabled attribute.
    /// </summary>
    [TerraformProperty("internet_query_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? InternetQueryEnabled { get; set; }

    /// <summary>
    /// The local_authentication_disabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("local_authentication_disabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> LocalAuthenticationDisabled { get; set; }

    /// <summary>
    /// The local_authentication_enabled attribute.
    /// </summary>
    [TerraformProperty("local_authentication_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> LocalAuthenticationEnabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The reservation_capacity_in_gb_per_day attribute.
    /// </summary>
    [TerraformProperty("reservation_capacity_in_gb_per_day")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ReservationCapacityInGbPerDay { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    [TerraformProperty("retention_in_days")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> RetentionInDays { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformProperty("sku")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Sku { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public partial TerraformList<TerraformBlock<AzurermLogAnalyticsWorkspaceIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermLogAnalyticsWorkspaceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The primary_shared_key attribute.
    /// </summary>
    [TerraformProperty("primary_shared_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimarySharedKey { get; }

    /// <summary>
    /// The secondary_shared_key attribute.
    /// </summary>
    [TerraformProperty("secondary_shared_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondarySharedKey { get; }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [TerraformProperty("workspace_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> WorkspaceId { get; }

}
