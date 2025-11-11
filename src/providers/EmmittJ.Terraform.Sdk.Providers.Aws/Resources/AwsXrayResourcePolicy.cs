using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_xray_resource_policy resource.
/// </summary>
public class AwsXrayResourcePolicy : TerraformResource
{
    public AwsXrayResourcePolicy(string name) : base("aws_xray_resource_policy", name)
    {
    }

    /// <summary>
    /// The bypass_policy_lockout_check attribute.
    /// </summary>
    [TerraformPropertyName("bypass_policy_lockout_check")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? BypassPolicyLockoutCheck { get; set; }

    /// <summary>
    /// The policy_document attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyDocument is required")]
    [TerraformPropertyName("policy_document")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PolicyDocument { get; set; }

    /// <summary>
    /// The policy_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyName is required")]
    [TerraformPropertyName("policy_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PolicyName { get; set; }

    /// <summary>
    /// The policy_revision_id attribute.
    /// </summary>
    [TerraformPropertyName("policy_revision_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PolicyRevisionId { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The last_updated_time attribute.
    /// </summary>
    [TerraformPropertyName("last_updated_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastUpdatedTime => new TerraformReference(this, "last_updated_time");

}
