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
    public string? AssignmentName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("assignment_name")?.Value;
        set => this.WithProperty("assignment_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The assignment_status attribute.
    /// </summary>
    public string? AssignmentStatus
    {
        get => GetProperty<TerraformLiteralProperty<string>>("assignment_status")?.Value;
        set => this.WithProperty("assignment_status", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public string? AwsAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("aws_account_id")?.Value;
        set => this.WithProperty("aws_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    public string? Namespace
    {
        get => GetProperty<TerraformLiteralProperty<string>>("namespace")?.Value;
        set => this.WithProperty("namespace", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The policy_arn attribute.
    /// </summary>
    public string? PolicyArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_arn")?.Value;
        set => this.WithProperty("policy_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
