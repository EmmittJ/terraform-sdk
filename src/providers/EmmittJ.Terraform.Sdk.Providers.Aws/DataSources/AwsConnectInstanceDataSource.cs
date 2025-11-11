using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_connect_instance.
/// </summary>
public partial class AwsConnectInstanceDataSource : TerraformDataSource
{
    public AwsConnectInstanceDataSource(string name) : base("aws_connect_instance", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The instance_alias attribute.
    /// </summary>
    [TerraformProperty("instance_alias")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> InstanceAlias { get; set; }

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    [TerraformProperty("instance_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> InstanceId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The auto_resolve_best_voices_enabled attribute.
    /// </summary>
    [TerraformProperty("auto_resolve_best_voices_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> AutoResolveBestVoicesEnabled { get; }

    /// <summary>
    /// The contact_flow_logs_enabled attribute.
    /// </summary>
    [TerraformProperty("contact_flow_logs_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> ContactFlowLogsEnabled { get; }

    /// <summary>
    /// The contact_lens_enabled attribute.
    /// </summary>
    [TerraformProperty("contact_lens_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> ContactLensEnabled { get; }

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    [TerraformProperty("created_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreatedTime { get; }

    /// <summary>
    /// The early_media_enabled attribute.
    /// </summary>
    [TerraformProperty("early_media_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> EarlyMediaEnabled { get; }

    /// <summary>
    /// The identity_management_type attribute.
    /// </summary>
    [TerraformProperty("identity_management_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> IdentityManagementType { get; }

    /// <summary>
    /// The inbound_calls_enabled attribute.
    /// </summary>
    [TerraformProperty("inbound_calls_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> InboundCallsEnabled { get; }

    /// <summary>
    /// The multi_party_conference_enabled attribute.
    /// </summary>
    [TerraformProperty("multi_party_conference_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> MultiPartyConferenceEnabled { get; }

    /// <summary>
    /// The outbound_calls_enabled attribute.
    /// </summary>
    [TerraformProperty("outbound_calls_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> OutboundCallsEnabled { get; }

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    [TerraformProperty("service_role")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ServiceRole { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

}
