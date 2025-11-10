using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsConnectInstanceTimeoutsBlock : ITerraformBlock
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

}

/// <summary>
/// Manages a aws_connect_instance resource.
/// </summary>
public class AwsConnectInstance : TerraformResource
{
    public AwsConnectInstance(string name) : base("aws_connect_instance", name)
    {
    }

    /// <summary>
    /// The auto_resolve_best_voices_enabled attribute.
    /// </summary>
    [TerraformPropertyName("auto_resolve_best_voices_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AutoResolveBestVoicesEnabled { get; set; }

    /// <summary>
    /// The contact_flow_logs_enabled attribute.
    /// </summary>
    [TerraformPropertyName("contact_flow_logs_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ContactFlowLogsEnabled { get; set; }

    /// <summary>
    /// The contact_lens_enabled attribute.
    /// </summary>
    [TerraformPropertyName("contact_lens_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ContactLensEnabled { get; set; }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    [TerraformPropertyName("directory_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DirectoryId { get; set; }

    /// <summary>
    /// The early_media_enabled attribute.
    /// </summary>
    [TerraformPropertyName("early_media_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EarlyMediaEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The identity_management_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityManagementType is required")]
    [TerraformPropertyName("identity_management_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> IdentityManagementType { get; set; }

    /// <summary>
    /// The inbound_calls_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InboundCallsEnabled is required")]
    [TerraformPropertyName("inbound_calls_enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> InboundCallsEnabled { get; set; }

    /// <summary>
    /// The instance_alias attribute.
    /// </summary>
    [TerraformPropertyName("instance_alias")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? InstanceAlias { get; set; }

    /// <summary>
    /// The multi_party_conference_enabled attribute.
    /// </summary>
    [TerraformPropertyName("multi_party_conference_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? MultiPartyConferenceEnabled { get; set; }

    /// <summary>
    /// The outbound_calls_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutboundCallsEnabled is required")]
    [TerraformPropertyName("outbound_calls_enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> OutboundCallsEnabled { get; set; }

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
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsConnectInstanceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    [TerraformPropertyName("created_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_time");

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
