using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_securityhub_standards_control resource.
/// </summary>
public class AwsSecurityhubStandardsControl : TerraformResource
{
    public AwsSecurityhubStandardsControl(string name) : base("aws_securityhub_standards_control", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("control_id");
        this.DeclareOutput("control_status_updated_at");
        this.DeclareOutput("description");
        this.DeclareOutput("related_requirements");
        this.DeclareOutput("remediation_url");
        this.DeclareOutput("severity_rating");
        this.DeclareOutput("title");
    }

    /// <summary>
    /// The control_status attribute.
    /// </summary>
    public string? ControlStatus
    {
        get => GetProperty<TerraformLiteralProperty<string>>("control_status")?.Value;
        set => this.WithProperty("control_status", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The disabled_reason attribute.
    /// </summary>
    public string? DisabledReason
    {
        get => GetProperty<TerraformLiteralProperty<string>>("disabled_reason")?.Value;
        set => this.WithProperty("disabled_reason", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The standards_control_arn attribute.
    /// </summary>
    public string? StandardsControlArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("standards_control_arn")?.Value;
        set => this.WithProperty("standards_control_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The control_id attribute.
    /// </summary>
    public TerraformExpression ControlId => this["control_id"];

    /// <summary>
    /// The control_status_updated_at attribute.
    /// </summary>
    public TerraformExpression ControlStatusUpdatedAt => this["control_status_updated_at"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The related_requirements attribute.
    /// </summary>
    public TerraformExpression RelatedRequirements => this["related_requirements"];

    /// <summary>
    /// The remediation_url attribute.
    /// </summary>
    public TerraformExpression RemediationUrl => this["remediation_url"];

    /// <summary>
    /// The severity_rating attribute.
    /// </summary>
    public TerraformExpression SeverityRating => this["severity_rating"];

    /// <summary>
    /// The title attribute.
    /// </summary>
    public TerraformExpression Title => this["title"];

}
