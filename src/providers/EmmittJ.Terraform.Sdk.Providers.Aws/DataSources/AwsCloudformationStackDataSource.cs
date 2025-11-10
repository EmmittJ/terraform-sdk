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
        SetOutput("capabilities");
        SetOutput("description");
        SetOutput("disable_rollback");
        SetOutput("iam_role_arn");
        SetOutput("notification_arns");
        SetOutput("outputs");
        SetOutput("parameters");
        SetOutput("template_body");
        SetOutput("timeout_in_minutes");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("tags");
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
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
