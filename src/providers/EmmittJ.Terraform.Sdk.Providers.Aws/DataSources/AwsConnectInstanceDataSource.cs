using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_connect_instance.
/// </summary>
public class AwsConnectInstanceDataSource : TerraformDataSource
{
    public AwsConnectInstanceDataSource(string name) : base("aws_connect_instance", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The instance_alias attribute.
    /// </summary>
    [TerraformPropertyName("instance_alias")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> InstanceAlias { get; set; } = default!;

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    [TerraformPropertyName("instance_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> InstanceId { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The auto_resolve_best_voices_enabled attribute.
    /// </summary>
    [TerraformPropertyName("auto_resolve_best_voices_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> AutoResolveBestVoicesEnabled => new TerraformReference(this, "auto_resolve_best_voices_enabled");

    /// <summary>
    /// The contact_flow_logs_enabled attribute.
    /// </summary>
    [TerraformPropertyName("contact_flow_logs_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ContactFlowLogsEnabled => new TerraformReference(this, "contact_flow_logs_enabled");

    /// <summary>
    /// The contact_lens_enabled attribute.
    /// </summary>
    [TerraformPropertyName("contact_lens_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ContactLensEnabled => new TerraformReference(this, "contact_lens_enabled");

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    [TerraformPropertyName("created_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatedTime => new TerraformReference(this, "created_time");

    /// <summary>
    /// The early_media_enabled attribute.
    /// </summary>
    [TerraformPropertyName("early_media_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EarlyMediaEnabled => new TerraformReference(this, "early_media_enabled");

    /// <summary>
    /// The identity_management_type attribute.
    /// </summary>
    [TerraformPropertyName("identity_management_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IdentityManagementType => new TerraformReference(this, "identity_management_type");

    /// <summary>
    /// The inbound_calls_enabled attribute.
    /// </summary>
    [TerraformPropertyName("inbound_calls_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> InboundCallsEnabled => new TerraformReference(this, "inbound_calls_enabled");

    /// <summary>
    /// The multi_party_conference_enabled attribute.
    /// </summary>
    [TerraformPropertyName("multi_party_conference_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> MultiPartyConferenceEnabled => new TerraformReference(this, "multi_party_conference_enabled");

    /// <summary>
    /// The outbound_calls_enabled attribute.
    /// </summary>
    [TerraformPropertyName("outbound_calls_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> OutboundCallsEnabled => new TerraformReference(this, "outbound_calls_enabled");

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    [TerraformPropertyName("service_role")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServiceRole => new TerraformReference(this, "service_role");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

}
