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
        SetOutput("control_id");
        SetOutput("control_status_updated_at");
        SetOutput("description");
        SetOutput("related_requirements");
        SetOutput("remediation_url");
        SetOutput("severity_rating");
        SetOutput("title");
        SetOutput("control_status");
        SetOutput("disabled_reason");
        SetOutput("id");
        SetOutput("region");
        SetOutput("standards_control_arn");
    }

    /// <summary>
    /// The control_status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ControlStatus is required")]
    public required TerraformProperty<string> ControlStatus
    {
        get => GetRequiredOutput<TerraformProperty<string>>("control_status");
        set => SetProperty("control_status", value);
    }

    /// <summary>
    /// The disabled_reason attribute.
    /// </summary>
    public TerraformProperty<string> DisabledReason
    {
        get => GetRequiredOutput<TerraformProperty<string>>("disabled_reason");
        set => SetProperty("disabled_reason", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
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
    /// The standards_control_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StandardsControlArn is required")]
    public required TerraformProperty<string> StandardsControlArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("standards_control_arn");
        set => SetProperty("standards_control_arn", value);
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
