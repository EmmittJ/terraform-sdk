using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_amplify_branch resource.
/// </summary>
public partial class AwsAmplifyBranch : TerraformResource
{
    public AwsAmplifyBranch(string name) : base("aws_amplify_branch", name)
    {
    }

    /// <summary>
    /// The app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppId is required")]
    [TerraformProperty("app_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AppId { get; set; }

    /// <summary>
    /// The backend_environment_arn attribute.
    /// </summary>
    [TerraformProperty("backend_environment_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BackendEnvironmentArn { get; set; }

    /// <summary>
    /// The basic_auth_credentials attribute.
    /// </summary>
    [TerraformProperty("basic_auth_credentials")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BasicAuthCredentials { get; set; }

    /// <summary>
    /// The branch_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BranchName is required")]
    [TerraformProperty("branch_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BranchName { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The enable_auto_build attribute.
    /// </summary>
    [TerraformProperty("enable_auto_build")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableAutoBuild { get; set; }

    /// <summary>
    /// The enable_basic_auth attribute.
    /// </summary>
    [TerraformProperty("enable_basic_auth")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableBasicAuth { get; set; }

    /// <summary>
    /// The enable_notification attribute.
    /// </summary>
    [TerraformProperty("enable_notification")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableNotification { get; set; }

    /// <summary>
    /// The enable_performance_mode attribute.
    /// </summary>
    [TerraformProperty("enable_performance_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnablePerformanceMode { get; set; }

    /// <summary>
    /// The enable_pull_request_preview attribute.
    /// </summary>
    [TerraformProperty("enable_pull_request_preview")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnablePullRequestPreview { get; set; }

    /// <summary>
    /// The enable_skew_protection attribute.
    /// </summary>
    [TerraformProperty("enable_skew_protection")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableSkewProtection { get; set; }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    [TerraformProperty("environment_variables")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? EnvironmentVariables { get; set; }

    /// <summary>
    /// The framework attribute.
    /// </summary>
    [TerraformProperty("framework")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Framework { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The pull_request_environment_name attribute.
    /// </summary>
    [TerraformProperty("pull_request_environment_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PullRequestEnvironmentName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The stage attribute.
    /// </summary>
    [TerraformProperty("stage")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Stage { get; set; }

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
    /// The ttl attribute.
    /// </summary>
    [TerraformProperty("ttl")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Ttl { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The associated_resources attribute.
    /// </summary>
    [TerraformProperty("associated_resources")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> AssociatedResources { get; }

    /// <summary>
    /// The custom_domains attribute.
    /// </summary>
    [TerraformProperty("custom_domains")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> CustomDomains { get; }

    /// <summary>
    /// The destination_branch attribute.
    /// </summary>
    [TerraformProperty("destination_branch")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DestinationBranch { get; }

    /// <summary>
    /// The source_branch attribute.
    /// </summary>
    [TerraformProperty("source_branch")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SourceBranch { get; }

}
