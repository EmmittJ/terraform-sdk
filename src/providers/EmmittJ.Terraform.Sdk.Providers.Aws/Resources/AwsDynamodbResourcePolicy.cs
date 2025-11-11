using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_dynamodb_resource_policy resource.
/// </summary>
public partial class AwsDynamodbResourcePolicy : TerraformResource
{
    public AwsDynamodbResourcePolicy(string name) : base("aws_dynamodb_resource_policy", name)
    {
    }

    /// <summary>
    /// The confirm_remove_self_resource_access attribute.
    /// </summary>
    [TerraformProperty("confirm_remove_self_resource_access")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> ConfirmRemoveSelfResourceAccess { get; set; }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Policy is required")]
    [TerraformProperty("policy")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Policy { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceArn is required")]
    [TerraformProperty("resource_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The revision_id attribute.
    /// </summary>
    [TerraformProperty("revision_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RevisionId { get; }

}
