using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for actions in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataLossPreventionDiscoveryConfigActionsBlock() : TerraformBlock("actions")
{
}

/// <summary>
/// Block type for org_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataLossPreventionDiscoveryConfigOrgConfigBlock() : TerraformBlock("org_config")
{
    /// <summary>
    /// The project that will run the scan. The DLP service account that exists within this project must have access to all resources that are profiled, and the cloud DLP API must be enabled.
    /// </summary>
    [TerraformProperty("project_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ProjectId { get; set; }

}

/// <summary>
/// Block type for other_cloud_starting_location in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataLossPreventionDiscoveryConfigOtherCloudStartingLocationBlock() : TerraformBlock("other_cloud_starting_location")
{
}

/// <summary>
/// Block type for targets in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataLossPreventionDiscoveryConfigTargetsBlock() : TerraformBlock("targets")
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDataLossPreventionDiscoveryConfigTimeoutsBlock() : TerraformBlock("timeouts")
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
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_data_loss_prevention_discovery_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDataLossPreventionDiscoveryConfig : TerraformResource
{
    public GoogleDataLossPreventionDiscoveryConfig(string name) : base("google_data_loss_prevention_discovery_config", name)
    {
    }

    /// <summary>
    /// Display Name (max 1000 Chars)
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Detection logic for profile generation
    /// </summary>
    [TerraformProperty("inspect_templates")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? InspectTemplates { get; set; }

    /// <summary>
    /// Location to create the discovery config in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The parent of the discovery config in any of the following formats:
    /// 
    /// * &#39;projects/{{project}}/locations/{{location}}&#39;
    /// * &#39;organizations/{{organization_id}}/locations/{{location}}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformProperty("parent")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Parent { get; set; }

    /// <summary>
    /// Required. A status for this configuration Possible values: [&amp;quot;RUNNING&amp;quot;, &amp;quot;PAUSED&amp;quot;]
    /// </summary>
    [TerraformProperty("status")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Status { get; set; }

    /// <summary>
    /// Block for actions.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("actions")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigActionsBlock> Actions { get; set; } = new();

    /// <summary>
    /// Block for org_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OrgConfig block(s) allowed")]
    [TerraformProperty("org_config")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigOrgConfigBlock> OrgConfig { get; set; } = new();

    /// <summary>
    /// Block for other_cloud_starting_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OtherCloudStartingLocation block(s) allowed")]
    [TerraformProperty("other_cloud_starting_location")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigOtherCloudStartingLocationBlock> OtherCloudStartingLocation { get; set; } = new();

    /// <summary>
    /// Block for targets.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("targets")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlock> Targets { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleDataLossPreventionDiscoveryConfigTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Output only. The creation timestamp of a DiscoveryConfig.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Output only. A stream of errors encountered when the config was activated. Repeated errors may result in the config automatically being paused. Output only field. Will return the last 100 errors. Whenever the config is modified this list will be cleared.
    /// </summary>
    [TerraformProperty("errors")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Errors { get; }

    /// <summary>
    /// Output only. The timestamp of the last time this config was executed
    /// </summary>
    [TerraformProperty("last_run_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastRunTime { get; }

    /// <summary>
    /// Unique resource name for the DiscoveryConfig, assigned by the service when the DiscoveryConfig is created.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// Output only. The last update timestamp of a DiscoveryConfig.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
