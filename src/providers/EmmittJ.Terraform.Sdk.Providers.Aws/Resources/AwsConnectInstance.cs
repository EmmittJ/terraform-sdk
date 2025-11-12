using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsConnectInstanceTimeoutsBlock() : TerraformBlock("timeouts")
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

}

/// <summary>
/// Manages a aws_connect_instance resource.
/// </summary>
public partial class AwsConnectInstance : TerraformResource
{
    public AwsConnectInstance(string name) : base("aws_connect_instance", name)
    {
    }

    /// <summary>
    /// The auto_resolve_best_voices_enabled attribute.
    /// </summary>
    [TerraformProperty("auto_resolve_best_voices_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AutoResolveBestVoicesEnabled { get; set; }

    /// <summary>
    /// The contact_flow_logs_enabled attribute.
    /// </summary>
    [TerraformProperty("contact_flow_logs_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ContactFlowLogsEnabled { get; set; }

    /// <summary>
    /// The contact_lens_enabled attribute.
    /// </summary>
    [TerraformProperty("contact_lens_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ContactLensEnabled { get; set; }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    [TerraformProperty("directory_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DirectoryId { get; set; }

    /// <summary>
    /// The early_media_enabled attribute.
    /// </summary>
    [TerraformProperty("early_media_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EarlyMediaEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The identity_management_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityManagementType is required")]
    [TerraformProperty("identity_management_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IdentityManagementType { get; set; }

    /// <summary>
    /// The inbound_calls_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InboundCallsEnabled is required")]
    [TerraformProperty("inbound_calls_enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> InboundCallsEnabled { get; set; }

    /// <summary>
    /// The instance_alias attribute.
    /// </summary>
    [TerraformProperty("instance_alias")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InstanceAlias { get; set; }

    /// <summary>
    /// The multi_party_conference_enabled attribute.
    /// </summary>
    [TerraformProperty("multi_party_conference_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? MultiPartyConferenceEnabled { get; set; }

    /// <summary>
    /// The outbound_calls_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutboundCallsEnabled is required")]
    [TerraformProperty("outbound_calls_enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> OutboundCallsEnabled { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsConnectInstanceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    [TerraformProperty("created_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedTime { get; }

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    [TerraformProperty("service_role")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ServiceRole { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

}
