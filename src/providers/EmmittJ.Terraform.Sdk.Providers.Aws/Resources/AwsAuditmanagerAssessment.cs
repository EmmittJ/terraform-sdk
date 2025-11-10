using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for assessment_reports_destination in .
/// Nesting mode: list
/// </summary>
public class AwsAuditmanagerAssessmentAssessmentReportsDestinationBlock : TerraformBlock
{
    /// <summary>
    /// The destination attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    public required TerraformProperty<string> Destination
    {
        set => SetProperty("destination", value);
    }

    /// <summary>
    /// The destination_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationType is required")]
    public required TerraformProperty<string> DestinationType
    {
        set => SetProperty("destination_type", value);
    }

}

/// <summary>
/// Block type for roles in .
/// Nesting mode: set
/// </summary>
public class AwsAuditmanagerAssessmentRolesBlock : TerraformBlock
{
    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// The role_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleType is required")]
    public required TerraformProperty<string> RoleType
    {
        set => SetProperty("role_type", value);
    }

}

/// <summary>
/// Block type for scope in .
/// Nesting mode: list
/// </summary>
public class AwsAuditmanagerAssessmentScopeBlock : TerraformBlock
{
}

/// <summary>
/// Manages a aws_auditmanager_assessment resource.
/// </summary>
public class AwsAuditmanagerAssessment : TerraformResource
{
    public AwsAuditmanagerAssessment(string name) : base("aws_auditmanager_assessment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("id");
        SetOutput("roles_all");
        SetOutput("status");
        SetOutput("tags_all");
        SetOutput("description");
        SetOutput("framework_id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The framework_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrameworkId is required")]
    public required TerraformProperty<string> FrameworkId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("framework_id");
        set => SetProperty("framework_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for assessment_reports_destination.
    /// Nesting mode: list
    /// </summary>
    public List<AwsAuditmanagerAssessmentAssessmentReportsDestinationBlock>? AssessmentReportsDestination
    {
        set => SetProperty("assessment_reports_destination", value);
    }

    /// <summary>
    /// Block for roles.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsAuditmanagerAssessmentRolesBlock>? Roles
    {
        set => SetProperty("roles", value);
    }

    /// <summary>
    /// Block for scope.
    /// Nesting mode: list
    /// </summary>
    public List<AwsAuditmanagerAssessmentScopeBlock>? Scope
    {
        set => SetProperty("scope", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The roles_all attribute.
    /// </summary>
    public TerraformExpression RolesAll => this["roles_all"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
