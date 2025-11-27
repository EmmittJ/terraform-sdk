using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_organizations_policy_attachment Terraform resource.
/// Manages a aws_organizations_policy_attachment resource.
/// </summary>
public partial class AwsOrganizationsPolicyAttachment(string name) : TerraformResource("aws_organizations_policy_attachment", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The policy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyId is required")]
    public required TerraformValue<string> PolicyId
    {
        get => new TerraformReference<string>(this, "policy_id");
        set => SetArgument("policy_id", value);
    }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    public TerraformValue<bool>? SkipDestroy
    {
        get => new TerraformReference<bool>(this, "skip_destroy");
        set => SetArgument("skip_destroy", value);
    }

    /// <summary>
    /// The target_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetId is required")]
    public required TerraformValue<string> TargetId
    {
        get => new TerraformReference<string>(this, "target_id");
        set => SetArgument("target_id", value);
    }

}
