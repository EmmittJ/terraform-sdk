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
    public TerraformLiteralProperty<HashSet<string>>? Capabilities
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("capabilities");
        set => this.WithProperty("capabilities", value);
    }

    /// <summary>
    /// The disable_rollback attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? DisableRollback
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disable_rollback");
        set => this.WithProperty("disable_rollback", value);
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IamRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iam_role_arn");
        set => this.WithProperty("iam_role_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The notification_arns attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? NotificationArns
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("notification_arns");
        set => this.WithProperty("notification_arns", value);
    }

    /// <summary>
    /// The on_failure attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? OnFailure
    {
        get => GetProperty<TerraformLiteralProperty<string>>("on_failure");
        set => this.WithProperty("on_failure", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Parameters
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("parameters");
        set => this.WithProperty("parameters", value);
    }

    /// <summary>
    /// The policy_body attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PolicyBody
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_body");
        set => this.WithProperty("policy_body", value);
    }

    /// <summary>
    /// The policy_url attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PolicyUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_url");
        set => this.WithProperty("policy_url", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The template_body attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TemplateBody
    {
        get => GetProperty<TerraformLiteralProperty<string>>("template_body");
        set => this.WithProperty("template_body", value);
    }

    /// <summary>
    /// The template_url attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TemplateUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("template_url");
        set => this.WithProperty("template_url", value);
    }

    /// <summary>
    /// The timeout_in_minutes attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? TimeoutInMinutes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("timeout_in_minutes");
        set => this.WithProperty("timeout_in_minutes", value);
    }

    /// <summary>
    /// The outputs attribute.
    /// </summary>
    public TerraformExpression Outputs => this["outputs"];

}
