using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for actions in .
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigActionsBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for org_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigOrgConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The project that will run the scan. The DLP service account that exists within this project must have access to all resources that are profiled, and the cloud DLP API must be enabled.
    /// </summary>
    [TerraformPropertyName("project_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ProjectId { get; set; }

}

/// <summary>
/// Block type for other_cloud_starting_location in .
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigOtherCloudStartingLocationBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for targets in .
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    public TerraformProperty<TerraformProperty<string>>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Detection logic for profile generation
    /// </summary>
    [TerraformPropertyName("inspect_templates")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? InspectTemplates { get; set; }

    /// <summary>
    /// Location to create the discovery config in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The parent of the discovery config in any of the following formats:
    /// 
    /// * &#39;projects/{{project}}/locations/{{location}}&#39;
    /// * &#39;organizations/{{organization_id}}/locations/{{location}}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformPropertyName("parent")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Parent { get; set; }

    /// <summary>
    /// Required. A status for this configuration Possible values: [&amp;quot;RUNNING&amp;quot;, &amp;quot;PAUSED&amp;quot;]
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Status { get; set; }

    /// <summary>
    /// Block for actions.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("actions")]
    public TerraformList<TerraformBlock<GoogleDataLossPreventionDiscoveryConfigActionsBlock>>? Actions { get; set; } = new();

    /// <summary>
    /// Block for org_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OrgConfig block(s) allowed")]
    [TerraformPropertyName("org_config")]
    public TerraformList<TerraformBlock<GoogleDataLossPreventionDiscoveryConfigOrgConfigBlock>>? OrgConfig { get; set; } = new();

    /// <summary>
    /// Block for other_cloud_starting_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OtherCloudStartingLocation block(s) allowed")]
    [TerraformPropertyName("other_cloud_starting_location")]
    public TerraformList<TerraformBlock<GoogleDataLossPreventionDiscoveryConfigOtherCloudStartingLocationBlock>>? OtherCloudStartingLocation { get; set; } = new();

    /// <summary>
    /// Block for targets.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("targets")]
    public TerraformList<TerraformBlock<GoogleDataLossPreventionDiscoveryConfigTargetsBlock>>? Targets { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDataLossPreventionDiscoveryConfigTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Output only. The creation timestamp of a DiscoveryConfig.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// Output only. A stream of errors encountered when the config was activated. Repeated errors may result in the config automatically being paused. Output only field. Will return the last 100 errors. Whenever the config is modified this list will be cleared.
    /// </summary>
    [TerraformPropertyName("errors")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Errors => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "errors");

    /// <summary>
    /// Output only. The timestamp of the last time this config was executed
    /// </summary>
    [TerraformPropertyName("last_run_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastRunTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_run_time");

    /// <summary>
    /// Unique resource name for the DiscoveryConfig, assigned by the service when the DiscoveryConfig is created.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// Output only. The last update timestamp of a DiscoveryConfig.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
