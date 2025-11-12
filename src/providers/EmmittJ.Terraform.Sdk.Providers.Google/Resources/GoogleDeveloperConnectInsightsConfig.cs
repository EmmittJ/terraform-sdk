using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for artifact_configs in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDeveloperConnectInsightsConfigArtifactConfigsBlock() : TerraformBlock("artifact_configs")
{
    /// <summary>
    /// The URI of the artifact that is deployed.
    /// e.g. &#39;us-docker.pkg.dev/my-project/my-repo/image&#39;.
    /// The URI does not include the tag / digest because it captures a lineage of
    /// artifacts.
    /// </summary>
    [TerraformProperty("uri")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Uri { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDeveloperConnectInsightsConfigTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_developer_connect_insights_config resource.
/// </summary>
public partial class GoogleDeveloperConnectInsightsConfig : TerraformResource
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
    [TerraformProperty("annotations")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Annotations { get; set; }

    /// <summary>
    /// The name of the App Hub Application.
    /// Format:
    /// projects/{project}/locations/{location}/applications/{application}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppHubApplication is required")]
    [TerraformProperty("app_hub_application")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AppHubApplication { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// ID of the requesting InsightsConfig.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InsightsConfigId is required")]
    [TerraformProperty("insights_config_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InsightsConfigId { get; set; }

    /// <summary>
    /// Set of labels associated with an InsightsConfig.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for artifact_configs.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("artifact_configs")]
    public TerraformList<GoogleDeveloperConnectInsightsConfigArtifactConfigsBlock> ArtifactConfigs { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleDeveloperConnectInsightsConfigTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// [Output only] Create timestamp
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_annotations")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveAnnotations { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// Any errors that occurred while setting up the InsightsConfig.
    /// Each error will be in the format: &#39;field_name: error_message&#39;, e.g.
    /// GetAppHubApplication: Permission denied while getting App Hub
    /// application. Please grant permissions to the P4SA.
    /// </summary>
    [TerraformProperty("errors")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Errors { get; }

    /// <summary>
    /// Identifier. The name of the InsightsConfig.
    /// Format:
    /// projects/{project}/locations/{location}/insightsConfigs/{insightsConfig}
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// Reconciling (https://google.aip.dev/128#reconciliation).
    /// Set to true if the current state of InsightsConfig does not match the
    /// user&#39;s intended state, and the service is actively updating the resource to
    /// reconcile them. This can happen due to user-triggered updates or
    /// system actions like failover or maintenance.
    /// </summary>
    [TerraformProperty("reconciling")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Reconciling { get; }

    /// <summary>
    /// The runtime configurations where the application is deployed.
    /// </summary>
    [TerraformProperty("runtime_configs")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> RuntimeConfigs { get; }

    /// <summary>
    /// The state of the InsightsConfig.
    /// Possible values:
    /// STATE_UNSPECIFIED
    /// PENDING
    /// COMPLETE
    /// ERROR
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// [Output only] Update timestamp
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
