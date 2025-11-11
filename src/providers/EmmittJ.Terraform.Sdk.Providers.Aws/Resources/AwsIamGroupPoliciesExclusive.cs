using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_group_policies_exclusive resource.
/// </summary>
public partial class AwsIamGroupPoliciesExclusive : TerraformResource
{
    public AwsIamGroupPoliciesExclusive(string name) : base("aws_iam_group_policies_exclusive", name)
    {
    }

    /// <summary>
    /// The group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupName is required")]
    [TerraformProperty("group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> GroupName { get; set; }

    /// <summary>
    /// The policy_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyNames is required")]
    [TerraformProperty("policy_names")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> PolicyNames { get; set; }

}
