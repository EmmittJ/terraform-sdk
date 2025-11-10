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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        this.WithOutput("outputs");
    }

    /// <summary>
    /// The capabilities attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Capabilities
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("capabilities");
        set => this.WithProperty("capabilities", value);
    }

    /// <summary>
    /// The disable_rollback attribute.
    /// </summary>
    public TerraformProperty<bool>? DisableRollback
    {
        get => GetProperty<TerraformProperty<bool>>("disable_rollback");
        set => this.WithProperty("disable_rollback", value);
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? IamRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("iam_role_arn");
        set => this.WithProperty("iam_role_arn", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The notification_arns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? NotificationArns
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("notification_arns");
        set => this.WithProperty("notification_arns", value);
    }

    /// <summary>
    /// The on_failure attribute.
    /// </summary>
    public TerraformProperty<string>? OnFailure
    {
        get => GetProperty<TerraformProperty<string>>("on_failure");
        set => this.WithProperty("on_failure", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Parameters
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("parameters");
        set => this.WithProperty("parameters", value);
    }

    /// <summary>
    /// The policy_body attribute.
    /// </summary>
    public TerraformProperty<string>? PolicyBody
    {
        get => GetProperty<TerraformProperty<string>>("policy_body");
        set => this.WithProperty("policy_body", value);
    }

    /// <summary>
    /// The policy_url attribute.
    /// </summary>
    public TerraformProperty<string>? PolicyUrl
    {
        get => GetProperty<TerraformProperty<string>>("policy_url");
        set => this.WithProperty("policy_url", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The template_body attribute.
    /// </summary>
    public TerraformProperty<string>? TemplateBody
    {
        get => GetProperty<TerraformProperty<string>>("template_body");
        set => this.WithProperty("template_body", value);
    }

    /// <summary>
    /// The template_url attribute.
    /// </summary>
    public TerraformProperty<string>? TemplateUrl
    {
        get => GetProperty<TerraformProperty<string>>("template_url");
        set => this.WithProperty("template_url", value);
    }

    /// <summary>
    /// The timeout_in_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? TimeoutInMinutes
    {
        get => GetProperty<TerraformProperty<double>>("timeout_in_minutes");
        set => this.WithProperty("timeout_in_minutes", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsCloudformationStackTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsCloudformationStackTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The outputs attribute.
    /// </summary>
    public TerraformExpression Outputs => this["outputs"];

}
