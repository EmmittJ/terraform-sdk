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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The instance_alias attribute.
    /// </summary>
    [TerraformPropertyName("instance_alias")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> InstanceAlias { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "instance_alias");

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    [TerraformPropertyName("instance_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> InstanceId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "instance_id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The auto_resolve_best_voices_enabled attribute.
    /// </summary>
    [TerraformPropertyName("auto_resolve_best_voices_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AutoResolveBestVoicesEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "auto_resolve_best_voices_enabled");

    /// <summary>
    /// The contact_flow_logs_enabled attribute.
    /// </summary>
    [TerraformPropertyName("contact_flow_logs_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ContactFlowLogsEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "contact_flow_logs_enabled");

    /// <summary>
    /// The contact_lens_enabled attribute.
    /// </summary>
    [TerraformPropertyName("contact_lens_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ContactLensEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "contact_lens_enabled");

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    [TerraformPropertyName("created_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_time");

    /// <summary>
    /// The early_media_enabled attribute.
    /// </summary>
    [TerraformPropertyName("early_media_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EarlyMediaEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "early_media_enabled");

    /// <summary>
    /// The identity_management_type attribute.
    /// </summary>
    [TerraformPropertyName("identity_management_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IdentityManagementType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "identity_management_type");

    /// <summary>
    /// The inbound_calls_enabled attribute.
    /// </summary>
    [TerraformPropertyName("inbound_calls_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> InboundCallsEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "inbound_calls_enabled");

    /// <summary>
    /// The multi_party_conference_enabled attribute.
    /// </summary>
    [TerraformPropertyName("multi_party_conference_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> MultiPartyConferenceEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "multi_party_conference_enabled");

    /// <summary>
    /// The outbound_calls_enabled attribute.
    /// </summary>
    [TerraformPropertyName("outbound_calls_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> OutboundCallsEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "outbound_calls_enabled");

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    [TerraformPropertyName("service_role")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServiceRole => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "service_role");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

}
