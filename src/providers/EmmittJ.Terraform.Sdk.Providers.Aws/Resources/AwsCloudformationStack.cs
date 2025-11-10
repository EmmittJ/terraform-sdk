using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsCloudformationStackTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

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
        SetOutput("outputs");
        SetOutput("capabilities");
        SetOutput("disable_rollback");
        SetOutput("iam_role_arn");
        SetOutput("id");
        SetOutput("name");
        SetOutput("notification_arns");
        SetOutput("on_failure");
        SetOutput("parameters");
        SetOutput("policy_body");
        SetOutput("policy_url");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("template_body");
        SetOutput("template_url");
        SetOutput("timeout_in_minutes");
    }

    /// <summary>
    /// The capabilities attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Capabilities
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("capabilities");
        set => SetProperty("capabilities", value);
    }

    /// <summary>
    /// The disable_rollback attribute.
    /// </summary>
    public TerraformProperty<bool> DisableRollback
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("disable_rollback");
        set => SetProperty("disable_rollback", value);
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    public TerraformProperty<string> IamRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("iam_role_arn");
        set => SetProperty("iam_role_arn", value);
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
    /// The notification_arns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> NotificationArns
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("notification_arns");
        set => SetProperty("notification_arns", value);
    }

    /// <summary>
    /// The on_failure attribute.
    /// </summary>
    public TerraformProperty<string> OnFailure
    {
        get => GetRequiredOutput<TerraformProperty<string>>("on_failure");
        set => SetProperty("on_failure", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Parameters
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("parameters");
        set => SetProperty("parameters", value);
    }

    /// <summary>
    /// The policy_body attribute.
    /// </summary>
    public TerraformProperty<string> PolicyBody
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy_body");
        set => SetProperty("policy_body", value);
    }

    /// <summary>
    /// The policy_url attribute.
    /// </summary>
    public TerraformProperty<string> PolicyUrl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy_url");
        set => SetProperty("policy_url", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The template_body attribute.
    /// </summary>
    public TerraformProperty<string> TemplateBody
    {
        get => GetRequiredOutput<TerraformProperty<string>>("template_body");
        set => SetProperty("template_body", value);
    }

    /// <summary>
    /// The template_url attribute.
    /// </summary>
    public TerraformProperty<string> TemplateUrl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("template_url");
        set => SetProperty("template_url", value);
    }

    /// <summary>
    /// The timeout_in_minutes attribute.
    /// </summary>
    public TerraformProperty<double> TimeoutInMinutes
    {
        get => GetRequiredOutput<TerraformProperty<double>>("timeout_in_minutes");
        set => SetProperty("timeout_in_minutes", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsCloudformationStackTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The outputs attribute.
    /// </summary>
    public TerraformExpression Outputs => this["outputs"];

}
