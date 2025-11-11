using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for actions in .
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigActionsBlock
{
}

/// <summary>
/// Block type for org_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigOrgConfigBlock
{
    /// <summary>
    /// The project that will run the scan. The DLP service account that exists within this project must have access to all resources that are profiled, and the cloud DLP API must be enabled.
    /// </summary>
    [TerraformPropertyName("project_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ProjectId { get; set; }

}

/// <summary>
/// Block type for other_cloud_starting_location in .
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigOtherCloudStartingLocationBlock
{
}

/// <summary>
/// Block type for targets in .
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTimeoutsBlock
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
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_data_loss_prevention_discovery_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDataLossPreventionDiscoveryConfig : TerraformResource
{
    public GoogleDataLossPreventionDiscoveryConfig(string name) : base("google_data_loss_prevention_discovery_config", name)
    {
    }

    /// <summary>
    /// Display Name (max 1000 Chars)
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Detection logic for profile generation
    /// </summary>
    [TerraformPropertyName("inspect_templates")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? InspectTemplates { get; set; }

    /// <summary>
    /// Location to create the discovery config in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The parent of the discovery config in any of the following formats:
    /// 
    /// * &#39;projects/{{project}}/locations/{{location}}&#39;
    /// * &#39;organizations/{{organization_id}}/locations/{{location}}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformPropertyName("parent")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Parent { get; set; }

    /// <summary>
    /// Required. A status for this configuration Possible values: [&amp;quot;RUNNING&amp;quot;, &amp;quot;PAUSED&amp;quot;]
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Status { get; set; }

    /// <summary>
    /// Block for actions.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("actions")]
    public TerraformList<TerraformBlock<GoogleDataLossPreventionDiscoveryConfigActionsBlock>>? Actions { get; set; }

    /// <summary>
    /// Block for org_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OrgConfig block(s) allowed")]
    [TerraformPropertyName("org_config")]
    public TerraformList<TerraformBlock<GoogleDataLossPreventionDiscoveryConfigOrgConfigBlock>>? OrgConfig { get; set; }

    /// <summary>
    /// Block for other_cloud_starting_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OtherCloudStartingLocation block(s) allowed")]
    [TerraformPropertyName("other_cloud_starting_location")]
    public TerraformList<TerraformBlock<GoogleDataLossPreventionDiscoveryConfigOtherCloudStartingLocationBlock>>? OtherCloudStartingLocation { get; set; }

    /// <summary>
    /// Block for targets.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("targets")]
    public TerraformList<TerraformBlock<GoogleDataLossPreventionDiscoveryConfigTargetsBlock>>? Targets { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDataLossPreventionDiscoveryConfigTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Output only. The creation timestamp of a DiscoveryConfig.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// Output only. A stream of errors encountered when the config was activated. Repeated errors may result in the config automatically being paused. Output only field. Will return the last 100 errors. Whenever the config is modified this list will be cleared.
    /// </summary>
    [TerraformPropertyName("errors")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Errors => new TerraformReference(this, "errors");

    /// <summary>
    /// Output only. The timestamp of the last time this config was executed
    /// </summary>
    [TerraformPropertyName("last_run_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastRunTime => new TerraformReference(this, "last_run_time");

    /// <summary>
    /// Unique resource name for the DiscoveryConfig, assigned by the service when the DiscoveryConfig is created.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// Output only. The last update timestamp of a DiscoveryConfig.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}
