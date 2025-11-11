using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_amplify_branch resource.
/// </summary>
public class AwsAmplifyBranch : TerraformResource
{
    public AwsAmplifyBranch(string name) : base("aws_amplify_branch", name)
    {
    }

    /// <summary>
    /// The app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppId is required")]
    [TerraformPropertyName("app_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AppId { get; set; }

    /// <summary>
    /// The backend_environment_arn attribute.
    /// </summary>
    [TerraformPropertyName("backend_environment_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? BackendEnvironmentArn { get; set; }

    /// <summary>
    /// The basic_auth_credentials attribute.
    /// </summary>
    [TerraformPropertyName("basic_auth_credentials")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? BasicAuthCredentials { get; set; }

    /// <summary>
    /// The branch_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BranchName is required")]
    [TerraformPropertyName("branch_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> BranchName { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DisplayName { get; set; } = default!;

    /// <summary>
    /// The enable_auto_build attribute.
    /// </summary>
    [TerraformPropertyName("enable_auto_build")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableAutoBuild { get; set; }

    /// <summary>
    /// The enable_basic_auth attribute.
    /// </summary>
    [TerraformPropertyName("enable_basic_auth")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableBasicAuth { get; set; }

    /// <summary>
    /// The enable_notification attribute.
    /// </summary>
    [TerraformPropertyName("enable_notification")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableNotification { get; set; }

    /// <summary>
    /// The enable_performance_mode attribute.
    /// </summary>
    [TerraformPropertyName("enable_performance_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnablePerformanceMode { get; set; }

    /// <summary>
    /// The enable_pull_request_preview attribute.
    /// </summary>
    [TerraformPropertyName("enable_pull_request_preview")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnablePullRequestPreview { get; set; }

    /// <summary>
    /// The enable_skew_protection attribute.
    /// </summary>
    [TerraformPropertyName("enable_skew_protection")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableSkewProtection { get; set; }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    [TerraformPropertyName("environment_variables")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? EnvironmentVariables { get; set; }

    /// <summary>
    /// The framework attribute.
    /// </summary>
    [TerraformPropertyName("framework")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Framework { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The pull_request_environment_name attribute.
    /// </summary>
    [TerraformPropertyName("pull_request_environment_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PullRequestEnvironmentName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The stage attribute.
    /// </summary>
    [TerraformPropertyName("stage")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Stage { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    [TerraformPropertyName("ttl")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Ttl { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The associated_resources attribute.
    /// </summary>
    [TerraformPropertyName("associated_resources")]
    // Output-only attribute - read-only reference
    public TerraformList<string> AssociatedResources => new TerraformReference(this, "associated_resources");

    /// <summary>
    /// The custom_domains attribute.
    /// </summary>
    [TerraformPropertyName("custom_domains")]
    // Output-only attribute - read-only reference
    public TerraformList<string> CustomDomains => new TerraformReference(this, "custom_domains");

    /// <summary>
    /// The destination_branch attribute.
    /// </summary>
    [TerraformPropertyName("destination_branch")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DestinationBranch => new TerraformReference(this, "destination_branch");

    /// <summary>
    /// The source_branch attribute.
    /// </summary>
    [TerraformPropertyName("source_branch")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SourceBranch => new TerraformReference(this, "source_branch");

}
