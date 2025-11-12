using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for credential in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppfabricAppAuthorizationCredentialBlock() : TerraformBlock("credential")
{
}

/// <summary>
/// Block type for tenant in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppfabricAppAuthorizationTenantBlock() : TerraformBlock("tenant")
{
    /// <summary>
    /// The tenant_display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantDisplayName is required")]
    [TerraformProperty("tenant_display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TenantDisplayName { get; set; }

    /// <summary>
    /// The tenant_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantIdentifier is required")]
    [TerraformProperty("tenant_identifier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TenantIdentifier { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsAppfabricAppAuthorizationTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_appfabric_app_authorization resource.
/// </summary>
public partial class AwsAppfabricAppAuthorization : TerraformResource
{
    public AwsAppfabricAppAuthorization(string name) : base("aws_appfabric_app_authorization", name)
    {
    }

    /// <summary>
    /// The app attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "App is required")]
    [TerraformProperty("app")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> App { get; set; }

    /// <summary>
    /// The app_bundle_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppBundleArn is required")]
    [TerraformProperty("app_bundle_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AppBundleArn { get; set; }

    /// <summary>
    /// The auth_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthType is required")]
    [TerraformProperty("auth_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AuthType { get; set; }

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
    /// Block for credential.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("credential")]
    public TerraformList<AwsAppfabricAppAuthorizationCredentialBlock> Credential { get; set; } = new();

    /// <summary>
    /// Block for tenant.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("tenant")]
    public TerraformList<AwsAppfabricAppAuthorizationTenantBlock> Tenant { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsAppfabricAppAuthorizationTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The auth_url attribute.
    /// </summary>
    [TerraformProperty("auth_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AuthUrl { get; }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The persona attribute.
    /// </summary>
    [TerraformProperty("persona")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Persona { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TagsAll { get; }

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    [TerraformProperty("updated_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdatedAt { get; }

}
