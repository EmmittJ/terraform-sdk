using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_auditmanager_assessment_report resource.
/// </summary>
public class AwsAuditmanagerAssessmentReport : TerraformResource
{
    public AwsAuditmanagerAssessmentReport(string name) : base("aws_auditmanager_assessment_report", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("author");
        SetOutput("id");
        SetOutput("status");
        SetOutput("assessment_id");
        SetOutput("description");
        SetOutput("name");
        SetOutput("region");
    }

    /// <summary>
    /// The assessment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssessmentId is required")]
    public required TerraformProperty<string> AssessmentId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("assessment_id");
        set => SetProperty("assessment_id", value);
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
    /// The author attribute.
    /// </summary>
    public TerraformExpression Author => this["author"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
