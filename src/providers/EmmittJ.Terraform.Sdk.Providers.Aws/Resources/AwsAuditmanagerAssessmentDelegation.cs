using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_auditmanager_assessment_delegation Terraform resource.
/// Manages a aws_auditmanager_assessment_delegation resource.
/// </summary>
public partial class AwsAuditmanagerAssessmentDelegation(string name) : TerraformResource("aws_auditmanager_assessment_delegation", name)
{
    /// <summary>
    /// The assessment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssessmentId is required")]
    public required TerraformValue<string> AssessmentId
    {
        get => GetRequiredArgument<TerraformValue<string>>("assessment_id");
        set => SetArgument("assessment_id", value);
    }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformValue<string>? Comment
    {
        get => GetArgument<TerraformValue<string>>("comment");
        set => SetArgument("comment", value);
    }

    /// <summary>
    /// The control_set_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ControlSetId is required")]
    public required TerraformValue<string> ControlSetId
    {
        get => GetRequiredArgument<TerraformValue<string>>("control_set_id");
        set => SetArgument("control_set_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The role_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleType is required")]
    public required TerraformValue<string> RoleType
    {
        get => GetRequiredArgument<TerraformValue<string>>("role_type");
        set => SetArgument("role_type", value);
    }

    /// <summary>
    /// The delegation_id attribute.
    /// </summary>
    public TerraformValue<string> DelegationId
        => CreateReference("delegation_id");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => CreateReference("status");

}
