using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_xray_resource_policy Terraform resource.
/// Manages a aws_xray_resource_policy resource.
/// </summary>
public partial class AwsXrayResourcePolicy(string name) : TerraformResource("aws_xray_resource_policy", name)
{
    /// <summary>
    /// The bypass_policy_lockout_check attribute.
    /// </summary>
    public TerraformValue<bool>? BypassPolicyLockoutCheck
    {
        get => GetArgument<TerraformValue<bool>>("bypass_policy_lockout_check");
        set => SetArgument("bypass_policy_lockout_check", value);
    }

    /// <summary>
    /// The policy_document attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyDocument is required")]
    public required TerraformValue<string> PolicyDocument
    {
        get => GetRequiredArgument<TerraformValue<string>>("policy_document");
        set => SetArgument("policy_document", value);
    }

    /// <summary>
    /// The policy_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyName is required")]
    public required TerraformValue<string> PolicyName
    {
        get => GetRequiredArgument<TerraformValue<string>>("policy_name");
        set => SetArgument("policy_name", value);
    }

    /// <summary>
    /// The policy_revision_id attribute.
    /// </summary>
    public TerraformValue<string> PolicyRevisionId
    {
        get => GetArgument<TerraformValue<string>>("policy_revision_id") ?? AsReference("policy_revision_id");
        set => SetArgument("policy_revision_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The last_updated_time attribute.
    /// </summary>
    public TerraformValue<string> LastUpdatedTime
        => AsReference("last_updated_time");

}
