using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_xray_resource_policy resource.
/// </summary>
public partial class AwsXrayResourcePolicy : TerraformResource
{
    public AwsXrayResourcePolicy(string name) : base("aws_xray_resource_policy", name)
    {
    }

    /// <summary>
    /// The bypass_policy_lockout_check attribute.
    /// </summary>
    [TerraformProperty("bypass_policy_lockout_check")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? BypassPolicyLockoutCheck { get; set; }

    /// <summary>
    /// The policy_document attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyDocument is required")]
    [TerraformProperty("policy_document")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PolicyDocument { get; set; }

    /// <summary>
    /// The policy_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyName is required")]
    [TerraformProperty("policy_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PolicyName { get; set; }

    /// <summary>
    /// The policy_revision_id attribute.
    /// </summary>
    [TerraformProperty("policy_revision_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> PolicyRevisionId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The last_updated_time attribute.
    /// </summary>
    [TerraformProperty("last_updated_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LastUpdatedTime { get; }

}
