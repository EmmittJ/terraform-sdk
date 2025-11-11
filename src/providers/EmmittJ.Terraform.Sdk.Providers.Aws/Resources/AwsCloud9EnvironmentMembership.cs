using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloud9_environment_membership resource.
/// </summary>
public partial class AwsCloud9EnvironmentMembership : TerraformResource
{
    public AwsCloud9EnvironmentMembership(string name) : base("aws_cloud9_environment_membership", name)
    {
    }

    /// <summary>
    /// The environment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvironmentId is required")]
    [TerraformProperty("environment_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> EnvironmentId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permissions is required")]
    [TerraformProperty("permissions")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Permissions { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The user_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserArn is required")]
    [TerraformProperty("user_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> UserArn { get; set; }

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    [TerraformProperty("user_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UserId { get; }

}
