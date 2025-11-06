using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ssoadmin_application_assignments.
/// </summary>
public class AwsSsoadminApplicationAssignmentsDataSource : TerraformDataSource
{
    public AwsSsoadminApplicationAssignmentsDataSource(string name) : base("aws_ssoadmin_application_assignments", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("application_assignments");
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The application_arn attribute.
    /// </summary>
    public string? ApplicationArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_arn")?.Value;
        set => this.WithProperty("application_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The application_assignments attribute.
    /// </summary>
    public TerraformExpression ApplicationAssignments => this["application_assignments"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
