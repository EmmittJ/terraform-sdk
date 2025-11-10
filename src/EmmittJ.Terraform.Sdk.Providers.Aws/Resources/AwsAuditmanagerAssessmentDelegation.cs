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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssessmentId is required")]
    public required TerraformProperty<string> AssessmentId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("assessment_id");
        set => this.WithProperty("assessment_id", value);
    }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformProperty<string>? Comment
    {
        get => GetProperty<TerraformProperty<string>>("comment");
        set => this.WithProperty("comment", value);
    }

    /// <summary>
    /// The control_set_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ControlSetId is required")]
    public required TerraformProperty<string> ControlSetId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("control_set_id");
        set => this.WithProperty("control_set_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
    }

    /// <summary>
    /// The role_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleType is required")]
    public required TerraformProperty<string> RoleType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("role_type");
        set => this.WithProperty("role_type", value);
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
