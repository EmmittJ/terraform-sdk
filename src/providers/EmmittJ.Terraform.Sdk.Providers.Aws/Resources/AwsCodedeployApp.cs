using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_codedeploy_app resource.
/// </summary>
public partial class AwsCodedeployApp : TerraformResource
{
    public AwsCodedeployApp(string name) : base("aws_codedeploy_app", name)
    {
    }

    /// <summary>
    /// The compute_platform attribute.
    /// </summary>
    [TerraformProperty("compute_platform")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ComputePlatform { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

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
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The application_id attribute.
    /// </summary>
    [TerraformProperty("application_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ApplicationId { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The github_account_name attribute.
    /// </summary>
    [TerraformProperty("github_account_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> GithubAccountName { get; }

    /// <summary>
    /// The linked_to_github attribute.
    /// </summary>
    [TerraformProperty("linked_to_github")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> LinkedToGithub { get; }

}
