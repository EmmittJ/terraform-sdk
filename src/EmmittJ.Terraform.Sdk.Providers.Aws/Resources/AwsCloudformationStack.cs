using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudformation_stack resource.
/// </summary>
public class AwsCloudformationStack : TerraformResource
{
    public AwsCloudformationStack(string name) : base("aws_cloudformation_stack", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("outputs");
    }

    /// <summary>
    /// The capabilities attribute.
    /// </summary>
    public HashSet<string>? Capabilities
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("capabilities")?.Value;
        set => this.WithProperty("capabilities", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The disable_rollback attribute.
    /// </summary>
    public bool? DisableRollback
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disable_rollback")?.Value;
        set => this.WithProperty("disable_rollback", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    public string? IamRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iam_role_arn")?.Value;
        set => this.WithProperty("iam_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The notification_arns attribute.
    /// </summary>
    public HashSet<string>? NotificationArns
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("notification_arns")?.Value;
        set => this.WithProperty("notification_arns", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The on_failure attribute.
    /// </summary>
    public string? OnFailure
    {
        get => GetProperty<TerraformLiteralProperty<string>>("on_failure")?.Value;
        set => this.WithProperty("on_failure", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, string>? Parameters
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("parameters")?.Value;
        set => this.WithProperty("parameters", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The policy_body attribute.
    /// </summary>
    public string? PolicyBody
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_body")?.Value;
        set => this.WithProperty("policy_body", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The policy_url attribute.
    /// </summary>
    public string? PolicyUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_url")?.Value;
        set => this.WithProperty("policy_url", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The template_body attribute.
    /// </summary>
    public string? TemplateBody
    {
        get => GetProperty<TerraformLiteralProperty<string>>("template_body")?.Value;
        set => this.WithProperty("template_body", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The template_url attribute.
    /// </summary>
    public string? TemplateUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("template_url")?.Value;
        set => this.WithProperty("template_url", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The timeout_in_minutes attribute.
    /// </summary>
    public double? TimeoutInMinutes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("timeout_in_minutes")?.Value;
        set => this.WithProperty("timeout_in_minutes", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The outputs attribute.
    /// </summary>
    public TerraformExpression Outputs => this["outputs"];

}
