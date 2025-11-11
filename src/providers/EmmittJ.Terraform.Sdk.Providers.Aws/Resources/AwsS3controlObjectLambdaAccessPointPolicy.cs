using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_s3control_object_lambda_access_point_policy resource.
/// </summary>
public partial class AwsS3controlObjectLambdaAccessPointPolicy : TerraformResource
{
    public AwsS3controlObjectLambdaAccessPointPolicy(string name) : base("aws_s3control_object_lambda_access_point_policy", name)
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [TerraformProperty("account_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AccountId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Policy is required")]
    [TerraformProperty("policy")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Policy { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The has_public_access_policy attribute.
    /// </summary>
    [TerraformProperty("has_public_access_policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> HasPublicAccessPolicy { get; }

}
