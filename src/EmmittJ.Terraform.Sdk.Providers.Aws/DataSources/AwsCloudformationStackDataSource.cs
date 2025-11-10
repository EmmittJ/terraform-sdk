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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
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
