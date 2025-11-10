using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_role_policy_attachments_exclusive resource.
/// </summary>
public class AwsIamRolePolicyAttachmentsExclusive : TerraformResource
{
    public AwsIamRolePolicyAttachmentsExclusive(string name) : base("aws_iam_role_policy_attachments_exclusive", name)
    {
    }

    /// <summary>
    /// The policy_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyArns is required")]
    [TerraformPropertyName("policy_arns")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? PolicyArns { get; set; }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleName is required")]
    [TerraformPropertyName("role_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleName { get; set; }

}
