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
        this.DeclareOutput("author");
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
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
