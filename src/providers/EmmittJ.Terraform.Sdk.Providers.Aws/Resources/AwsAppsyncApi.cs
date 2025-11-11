using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for event_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncApiEventConfigBlock
{
}

/// <summary>
/// Manages a aws_appsync_api resource.
/// </summary>
public class AwsAppsyncApi : TerraformResource
{
    public AwsAppsyncApi(string name) : base("aws_appsync_api", name)
    {
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The owner_contact attribute.
    /// </summary>
    [TerraformPropertyName("owner_contact")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OwnerContact { get; set; }

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
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for event_config.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("event_config")]
    public TerraformList<TerraformBlock<AwsAppsyncApiEventConfigBlock>>? EventConfig { get; set; }

    /// <summary>
    /// The api_arn attribute.
    /// </summary>
    [TerraformPropertyName("api_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ApiArn => new TerraformReference(this, "api_arn");

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [TerraformPropertyName("api_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ApiId => new TerraformReference(this, "api_id");

    /// <summary>
    /// The dns attribute.
    /// </summary>
    [TerraformPropertyName("dns")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Dns => new TerraformReference(this, "dns");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TagsAll => new TerraformReference(this, "tags_all");

    /// <summary>
    /// The waf_web_acl_arn attribute.
    /// </summary>
    [TerraformPropertyName("waf_web_acl_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> WafWebAclArn => new TerraformReference(this, "waf_web_acl_arn");

    /// <summary>
    /// The xray_enabled attribute.
    /// </summary>
    [TerraformPropertyName("xray_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> XrayEnabled => new TerraformReference(this, "xray_enabled");

}
