using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_auditmanager_assessment_delegation resource.
/// </summary>
public class AwsAuditmanagerAssessmentDelegation : TerraformResource
{
    public AwsAuditmanagerAssessmentDelegation(string name) : base("aws_auditmanager_assessment_delegation", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("delegation_id");
        this.DeclareOutput("id");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The assessment_id attribute.
    /// </summary>
    public string? AssessmentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("assessment_id")?.Value;
        set => this.WithProperty("assessment_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    public string? Comment
    {
        get => GetProperty<TerraformLiteralProperty<string>>("comment")?.Value;
        set => this.WithProperty("comment", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The control_set_id attribute.
    /// </summary>
    public string? ControlSetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("control_set_id")?.Value;
        set => this.WithProperty("control_set_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public string? RoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_arn")?.Value;
        set => this.WithProperty("role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The role_type attribute.
    /// </summary>
    public string? RoleType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_type")?.Value;
        set => this.WithProperty("role_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The delegation_id attribute.
    /// </summary>
    public TerraformExpression DelegationId => this["delegation_id"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
