using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lakeformation_resource resource.
/// </summary>
public partial class AwsLakeformationResource : TerraformResource
{
    public AwsLakeformationResource(string name) : base("aws_lakeformation_resource", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    [TerraformProperty("arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Arn { get; set; }

    /// <summary>
    /// The hybrid_access_enabled attribute.
    /// </summary>
    [TerraformProperty("hybrid_access_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> HybridAccessEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformProperty("role_arn")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The use_service_linked_role attribute.
    /// </summary>
    [TerraformProperty("use_service_linked_role")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? UseServiceLinkedRole { get; set; }

    /// <summary>
    /// The with_federation attribute.
    /// </summary>
    [TerraformProperty("with_federation")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> WithFederation { get; set; }

    /// <summary>
    /// The with_privileged_access attribute.
    /// </summary>
    [TerraformProperty("with_privileged_access")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> WithPrivilegedAccess { get; set; }

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    [TerraformProperty("last_modified")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastModified { get; }

}
