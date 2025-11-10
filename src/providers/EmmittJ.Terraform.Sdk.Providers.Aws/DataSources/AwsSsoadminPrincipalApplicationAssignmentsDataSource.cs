using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for application_assignments in .
/// Nesting mode: list
/// </summary>
public class AwsSsoadminPrincipalApplicationAssignmentsDataSourceApplicationAssignmentsBlock : TerraformBlock
{
    /// <summary>
    /// The application_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ApplicationArn
    {
        set => SetProperty("application_arn", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        set => SetProperty("principal_id", value);
    }

    /// <summary>
    /// The principal_type attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalType
    {
        set => SetProperty("principal_type", value);
    }

}

/// <summary>
/// Retrieves information about a aws_ssoadmin_principal_application_assignments.
/// </summary>
public class AwsSsoadminPrincipalApplicationAssignmentsDataSource : TerraformDataSource
{
    public AwsSsoadminPrincipalApplicationAssignmentsDataSource(string name) : base("aws_ssoadmin_principal_application_assignments", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("instance_arn");
        SetOutput("principal_id");
        SetOutput("principal_type");
        SetOutput("region");
    }

    /// <summary>
    /// The instance_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceArn is required")]
    public required TerraformProperty<string> InstanceArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_arn");
        set => SetProperty("instance_arn", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalId is required")]
    public required TerraformProperty<string> PrincipalId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("principal_id");
        set => SetProperty("principal_id", value);
    }

    /// <summary>
    /// The principal_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalType is required")]
    public required TerraformProperty<string> PrincipalType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("principal_type");
        set => SetProperty("principal_type", value);
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
    /// Block for application_assignments.
    /// Nesting mode: list
    /// </summary>
    public List<AwsSsoadminPrincipalApplicationAssignmentsDataSourceApplicationAssignmentsBlock>? ApplicationAssignments
    {
        set => SetProperty("application_assignments", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
