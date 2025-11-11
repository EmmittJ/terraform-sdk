using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for artifact_configs in .
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectInsightsConfigArtifactConfigsBlock
{
    /// <summary>
    /// The URI of the artifact that is deployed.
    /// e.g. &#39;us-docker.pkg.dev/my-project/my-repo/image&#39;.
    /// The URI does not include the tag / digest because it captures a lineage of
    /// artifacts.
    /// </summary>
    [TerraformPropertyName("uri")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Uri { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDeveloperConnectInsightsConfigTimeoutsBlock
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
/// Manages a google_developer_connect_insights_config resource.
/// </summary>
public class GoogleDeveloperConnectInsightsConfig : TerraformResource
{
    public GoogleDeveloperConnectInsightsConfig(string name) : base("google_developer_connect_insights_config", name)
    {
    }

    /// <summary>
    /// User specified annotations. See https://google.aip.dev/148#annotations
    /// for more details such as format and size limitations.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    [TerraformPropertyName("annotations")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Annotations { get; set; }

    /// <summary>
    /// The name of the App Hub Application.
    /// Format:
    /// projects/{project}/locations/{location}/applications/{application}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppHubApplication is required")]
    [TerraformPropertyName("app_hub_application")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AppHubApplication { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// ID of the requesting InsightsConfig.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InsightsConfigId is required")]
    [TerraformPropertyName("insights_config_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> InsightsConfigId { get; set; }

    /// <summary>
    /// Set of labels associated with an InsightsConfig.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Block for artifact_configs.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("artifact_configs")]
    public TerraformList<TerraformBlock<GoogleDeveloperConnectInsightsConfigArtifactConfigsBlock>>? ArtifactConfigs { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDeveloperConnectInsightsConfigTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// [Output only] Create timestamp
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_annotations")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveAnnotations => new TerraformReference(this, "effective_annotations");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// Any errors that occurred while setting up the InsightsConfig.
    /// Each error will be in the format: &#39;field_name: error_message&#39;, e.g.
    /// GetAppHubApplication: Permission denied while getting App Hub
    /// application. Please grant permissions to the P4SA.
    /// </summary>
    [TerraformPropertyName("errors")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Errors => new TerraformReference(this, "errors");

    /// <summary>
    /// Identifier. The name of the InsightsConfig.
    /// Format:
    /// projects/{project}/locations/{location}/insightsConfigs/{insightsConfig}
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// Reconciling (https://google.aip.dev/128#reconciliation).
    /// Set to true if the current state of InsightsConfig does not match the
    /// user&#39;s intended state, and the service is actively updating the resource to
    /// reconcile them. This can happen due to user-triggered updates or
    /// system actions like failover or maintenance.
    /// </summary>
    [TerraformPropertyName("reconciling")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Reconciling => new TerraformReference(this, "reconciling");

    /// <summary>
    /// The runtime configurations where the application is deployed.
    /// </summary>
    [TerraformPropertyName("runtime_configs")]
    // Output-only attribute - read-only reference
    public TerraformList<object> RuntimeConfigs => new TerraformReference(this, "runtime_configs");

    /// <summary>
    /// The state of the InsightsConfig.
    /// Possible values:
    /// STATE_UNSPECIFIED
    /// PENDING
    /// COMPLETE
    /// ERROR
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

    /// <summary>
    /// [Output only] Update timestamp
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}
