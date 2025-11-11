using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auth_request in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppfabricAppAuthorizationConnectionAuthRequestBlock : TerraformBlockBase
{
    /// <summary>
    /// The code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Code is required")]
    [TerraformProperty("code")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Code { get; set; }

    /// <summary>
    /// The redirect_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RedirectUri is required")]
    [TerraformProperty("redirect_uri")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RedirectUri { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsAppfabricAppAuthorizationConnectionTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

}

/// <summary>
/// Manages a aws_appfabric_app_authorization_connection resource.
/// </summary>
public partial class AwsAppfabricAppAuthorizationConnection : TerraformResource
{
    public AwsAppfabricAppAuthorizationConnection(string name) : base("aws_appfabric_app_authorization_connection", name)
    {
    }

    /// <summary>
    /// The app_authorization_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppAuthorizationArn is required")]
    [TerraformProperty("app_authorization_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AppAuthorizationArn { get; set; }

    /// <summary>
    /// The app_bundle_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppBundleArn is required")]
    [TerraformProperty("app_bundle_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AppBundleArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for auth_request.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("auth_request")]
    public partial TerraformList<TerraformBlock<AwsAppfabricAppAuthorizationConnectionAuthRequestBlock>>? AuthRequest { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsAppfabricAppAuthorizationConnectionTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The app attribute.
    /// </summary>
    [TerraformProperty("app")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> App { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The tenant attribute.
    /// </summary>
    [TerraformProperty("tenant")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Tenant { get; }

}
