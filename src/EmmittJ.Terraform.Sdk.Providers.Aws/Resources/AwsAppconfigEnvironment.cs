using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for monitor in .
/// Nesting mode: set
/// </summary>
public class AwsAppconfigEnvironmentMonitorBlock : TerraformBlock
{
    /// <summary>
    /// The alarm_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlarmArn is required")]
    public required TerraformProperty<string> AlarmArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("alarm_arn");
        set => WithProperty("alarm_arn", value);
    }

    /// <summary>
    /// The alarm_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? AlarmRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("alarm_role_arn");
        set => WithProperty("alarm_role_arn", value);
    }

}

/// <summary>
/// Manages a aws_appconfig_environment resource.
/// </summary>
public class AwsAppconfigEnvironment : TerraformResource
{
    public AwsAppconfigEnvironment(string name) : base("aws_appconfig_environment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("environment_id");
        this.DeclareOutput("id");
        this.DeclareOutput("state");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    public required TerraformProperty<string> ApplicationId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("application_id");
        set => this.WithProperty("application_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// Block for monitor.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsAppconfigEnvironmentMonitorBlock>? Monitor
    {
        get => GetProperty<HashSet<AwsAppconfigEnvironmentMonitorBlock>>("monitor");
        set => this.WithProperty("monitor", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The environment_id attribute.
    /// </summary>
    public TerraformExpression EnvironmentId => this["environment_id"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
