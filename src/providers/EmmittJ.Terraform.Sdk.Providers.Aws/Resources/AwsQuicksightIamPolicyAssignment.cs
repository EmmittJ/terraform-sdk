using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for identities in AwsQuicksightIamPolicyAssignment.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightIamPolicyAssignmentIdentitiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identities";

    /// <summary>
    /// The group attribute.
    /// </summary>
    public TerraformSet<string>? Group
    {
        get => GetArgument<TerraformSet<string>>("group");
        set => SetArgument("group", value);
    }

    /// <summary>
    /// The user attribute.
    /// </summary>
    public TerraformSet<string>? User
    {
        get => GetArgument<TerraformSet<string>>("user");
        set => SetArgument("user", value);
    }

}


/// <summary>
/// Represents a aws_quicksight_iam_policy_assignment Terraform resource.
/// Manages a aws_quicksight_iam_policy_assignment resource.
/// </summary>
public partial class AwsQuicksightIamPolicyAssignment(string name) : TerraformResource("aws_quicksight_iam_policy_assignment", name)
{
    /// <summary>
    /// The assignment_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssignmentName is required")]
    public required TerraformValue<string> AssignmentName
    {
        get => GetRequiredArgument<TerraformValue<string>>("assignment_name");
        set => SetArgument("assignment_name", value);
    }

    /// <summary>
    /// The assignment_status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssignmentStatus is required")]
    public required TerraformValue<string> AssignmentStatus
    {
        get => GetRequiredArgument<TerraformValue<string>>("assignment_status");
        set => SetArgument("assignment_status", value);
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformValue<string> AwsAccountId
    {
        get => GetArgument<TerraformValue<string>>("aws_account_id") ?? CreateReference("aws_account_id");
        set => SetArgument("aws_account_id", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    public TerraformValue<string> NamespaceAttribute
    {
        get => GetArgument<TerraformValue<string>>("namespace") ?? CreateReference("namespace");
        set => SetArgument("namespace", value);
    }

    /// <summary>
    /// The policy_arn attribute.
    /// </summary>
    public TerraformValue<string>? PolicyArn
    {
        get => GetArgument<TerraformValue<string>>("policy_arn");
        set => SetArgument("policy_arn", value);
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
    /// The assignment_id attribute.
    /// </summary>
    public TerraformValue<string> AssignmentId
        => CreateReference("assignment_id");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// Identities block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsQuicksightIamPolicyAssignmentIdentitiesBlock>? Identities
    {
        get => GetArgument<TerraformList<AwsQuicksightIamPolicyAssignmentIdentitiesBlock>>("identities");
        set => SetArgument("identities", value);
    }

}
