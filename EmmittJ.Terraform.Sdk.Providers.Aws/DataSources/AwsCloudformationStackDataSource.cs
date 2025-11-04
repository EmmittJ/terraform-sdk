using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudformation_stack.
/// </summary>
public class AwsCloudformationStackDataSource : TerraformDataSource
{
    public AwsCloudformationStackDataSource(string name) : base("aws_cloudformation_stack", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("capabilities");
        this.DeclareOutput("description");
        this.DeclareOutput("disable_rollback");
        this.DeclareOutput("iam_role_arn");
        this.DeclareOutput("notification_arns");
        this.DeclareOutput("outputs");
        this.DeclareOutput("parameters");
        this.DeclareOutput("template_body");
        this.DeclareOutput("timeout_in_minutes");
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The capabilities attribute.
    /// </summary>
    public TerraformExpression Capabilities => this["capabilities"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The disable_rollback attribute.
    /// </summary>
    public TerraformExpression DisableRollback => this["disable_rollback"];

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    public TerraformExpression IamRoleArn => this["iam_role_arn"];

    /// <summary>
    /// The notification_arns attribute.
    /// </summary>
    public TerraformExpression NotificationArns => this["notification_arns"];

    /// <summary>
    /// The outputs attribute.
    /// </summary>
    public TerraformExpression Outputs => this["outputs"];

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformExpression Parameters => this["parameters"];

    /// <summary>
    /// The template_body attribute.
    /// </summary>
    public TerraformExpression TemplateBody => this["template_body"];

    /// <summary>
    /// The timeout_in_minutes attribute.
    /// </summary>
    public TerraformExpression TimeoutInMinutes => this["timeout_in_minutes"];

}
