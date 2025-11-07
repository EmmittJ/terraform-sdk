using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("assignment_id");
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The assignment_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AssignmentName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("assignment_name");
        set => this.WithProperty("assignment_name", value);
    }

    /// <summary>
    /// The assignment_status attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AssignmentStatus
    {
        get => GetProperty<TerraformLiteralProperty<string>>("assignment_status");
        set => this.WithProperty("assignment_status", value);
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AwsAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("aws_account_id");
        set => this.WithProperty("aws_account_id", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Namespace
    {
        get => GetProperty<TerraformLiteralProperty<string>>("namespace");
        set => this.WithProperty("namespace", value);
    }

    /// <summary>
    /// The policy_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PolicyArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_arn");
        set => this.WithProperty("policy_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
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
