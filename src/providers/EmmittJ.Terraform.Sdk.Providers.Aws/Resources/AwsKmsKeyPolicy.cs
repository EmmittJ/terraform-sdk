using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_kms_key_policy Terraform resource.
/// Manages a aws_kms_key_policy resource.
/// </summary>
public partial class AwsKmsKeyPolicy(string name) : TerraformResource("aws_kms_key_policy", name)
{
    /// <summary>
    /// The bypass_policy_lockout_safety_check attribute.
    /// </summary>
    public TerraformValue<bool>? BypassPolicyLockoutSafetyCheck
    {
        get => new TerraformReference<bool>(this, "bypass_policy_lockout_safety_check");
        set => SetArgument("bypass_policy_lockout_safety_check", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    public required TerraformValue<string> KeyId
    {
        get => new TerraformReference<string>(this, "key_id");
        set => SetArgument("key_id", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Policy is required")]
    public required TerraformValue<string> Policy
    {
        get => new TerraformReference<string>(this, "policy");
        set => SetArgument("policy", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

}
