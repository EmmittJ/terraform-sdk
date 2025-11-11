using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for event_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppsyncApiEventConfigBlock : TerraformBlockBase
{
}

/// <summary>
/// Manages a aws_appsync_api resource.
/// </summary>
public partial class AwsAppsyncApi : TerraformResource
{
    public AwsAppsyncApi(string name) : base("aws_appsync_api", name)
    {
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The owner_contact attribute.
    /// </summary>
    [TerraformProperty("owner_contact")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? OwnerContact { get; set; }

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
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for event_config.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("event_config")]
    public TerraformList<TerraformBlock<AwsAppsyncApiEventConfigBlock>>? EventConfig { get; set; }

    /// <summary>
    /// The api_arn attribute.
    /// </summary>
    [TerraformProperty("api_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ApiArn { get; }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [TerraformProperty("api_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ApiId { get; }

    /// <summary>
    /// The dns attribute.
    /// </summary>
    [TerraformProperty("dns")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Dns { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TagsAll { get; }

    /// <summary>
    /// The waf_web_acl_arn attribute.
    /// </summary>
    [TerraformProperty("waf_web_acl_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> WafWebAclArn { get; }

    /// <summary>
    /// The xray_enabled attribute.
    /// </summary>
    [TerraformProperty("xray_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> XrayEnabled { get; }

}
