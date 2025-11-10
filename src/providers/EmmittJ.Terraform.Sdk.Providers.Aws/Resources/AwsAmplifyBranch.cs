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
    public required TerraformProperty<TerraformProperty<string>> AppId { get; set; }

    /// <summary>
    /// The backend_environment_arn attribute.
    /// </summary>
    [TerraformPropertyName("backend_environment_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BackendEnvironmentArn { get; set; }

    /// <summary>
    /// The basic_auth_credentials attribute.
    /// </summary>
    [TerraformPropertyName("basic_auth_credentials")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BasicAuthCredentials { get; set; }

    /// <summary>
    /// The branch_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BranchName is required")]
    [TerraformPropertyName("branch_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> BranchName { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DisplayName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// The enable_auto_build attribute.
    /// </summary>
    [TerraformPropertyName("enable_auto_build")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableAutoBuild { get; set; }

    /// <summary>
    /// The enable_basic_auth attribute.
    /// </summary>
    [TerraformPropertyName("enable_basic_auth")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableBasicAuth { get; set; }

    /// <summary>
    /// The enable_notification attribute.
    /// </summary>
    [TerraformPropertyName("enable_notification")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableNotification { get; set; }

    /// <summary>
    /// The enable_performance_mode attribute.
    /// </summary>
    [TerraformPropertyName("enable_performance_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnablePerformanceMode { get; set; }

    /// <summary>
    /// The enable_pull_request_preview attribute.
    /// </summary>
    [TerraformPropertyName("enable_pull_request_preview")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnablePullRequestPreview { get; set; }

    /// <summary>
    /// The enable_skew_protection attribute.
    /// </summary>
    [TerraformPropertyName("enable_skew_protection")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableSkewProtection { get; set; }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    [TerraformPropertyName("environment_variables")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? EnvironmentVariables { get; set; }

    /// <summary>
    /// The framework attribute.
    /// </summary>
    [TerraformPropertyName("framework")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Framework { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The pull_request_environment_name attribute.
    /// </summary>
    [TerraformPropertyName("pull_request_environment_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PullRequestEnvironmentName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The stage attribute.
    /// </summary>
    [TerraformPropertyName("stage")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Stage { get; set; }

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
    /// The ttl attribute.
    /// </summary>
    [TerraformPropertyName("ttl")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Ttl { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The associated_resources attribute.
    /// </summary>
    [TerraformPropertyName("associated_resources")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> AssociatedResources => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "associated_resources");

    /// <summary>
    /// The custom_domains attribute.
    /// </summary>
    [TerraformPropertyName("custom_domains")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> CustomDomains => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "custom_domains");

    /// <summary>
    /// The destination_branch attribute.
    /// </summary>
    [TerraformPropertyName("destination_branch")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DestinationBranch => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "destination_branch");

    /// <summary>
    /// The source_branch attribute.
    /// </summary>
    [TerraformPropertyName("source_branch")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SourceBranch => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "source_branch");

}
