using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for identities in .
/// Nesting mode: list
/// </summary>
public class AwsQuicksightIamPolicyAssignmentIdentitiesBlock : TerraformBlock
{
    /// <summary>
    /// The group attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Group
    {
        set => SetProperty("group", value);
    }

    /// <summary>
    /// The user attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? User
    {
        set => SetProperty("user", value);
    }

}

/// <summary>
/// Manages a aws_quicksight_iam_policy_assignment resource.
/// </summary>
public class AwsQuicksightIamPolicyAssignment : TerraformResource
{
    public AwsQuicksightIamPolicyAssignment(string name) : base("aws_quicksight_iam_policy_assignment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("assignment_id");
        SetOutput("id");
        SetOutput("assignment_name");
        SetOutput("assignment_status");
        SetOutput("aws_account_id");
        SetOutput("namespace");
        SetOutput("policy_arn");
        SetOutput("region");
    }

    /// <summary>
    /// The assignment_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssignmentName is required")]
    public required TerraformProperty<string> AssignmentName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("assignment_name");
        set => SetProperty("assignment_name", value);
    }

    /// <summary>
    /// The assignment_status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssignmentStatus is required")]
    public required TerraformProperty<string> AssignmentStatus
    {
        get => GetRequiredOutput<TerraformProperty<string>>("assignment_status");
        set => SetProperty("assignment_status", value);
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformProperty<string> AwsAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("aws_account_id");
        set => SetProperty("aws_account_id", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    public TerraformProperty<string> Namespace
    {
        get => GetRequiredOutput<TerraformProperty<string>>("namespace");
        set => SetProperty("namespace", value);
    }

    /// <summary>
    /// The policy_arn attribute.
    /// </summary>
    public TerraformProperty<string> PolicyArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy_arn");
        set => SetProperty("policy_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Block for identities.
    /// Nesting mode: list
    /// </summary>
    public List<AwsQuicksightIamPolicyAssignmentIdentitiesBlock>? Identities
    {
        set => SetProperty("identities", value);
    }

    /// <summary>
    /// The assignment_id attribute.
    /// </summary>
    public TerraformExpression AssignmentId => this["assignment_id"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
