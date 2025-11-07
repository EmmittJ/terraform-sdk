using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_gamelift_fleet resource.
/// </summary>
public class AwsGameliftFleet : TerraformResource
{
    public AwsGameliftFleet(string name) : base("aws_gamelift_fleet", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("build_arn");
        this.DeclareOutput("log_paths");
        this.DeclareOutput("operating_system");
        this.DeclareOutput("script_arn");
    }

    /// <summary>
    /// The build_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? BuildId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("build_id");
        set => this.WithProperty("build_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The ec2_instance_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Ec2InstanceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ec2_instance_type");
        set => this.WithProperty("ec2_instance_type", value);
    }

    /// <summary>
    /// The fleet_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FleetType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("fleet_type");
        set => this.WithProperty("fleet_type", value);
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
    /// The instance_role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? InstanceRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_role_arn");
        set => this.WithProperty("instance_role_arn", value);
    }

    /// <summary>
    /// The metric_groups attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? MetricGroups
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("metric_groups");
        set => this.WithProperty("metric_groups", value);
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
    /// The new_game_session_protection_policy attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NewGameSessionProtectionPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("new_game_session_protection_policy");
        set => this.WithProperty("new_game_session_protection_policy", value);
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
    /// The script_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ScriptId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("script_id");
        set => this.WithProperty("script_id", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The build_arn attribute.
    /// </summary>
    public TerraformExpression BuildArn => this["build_arn"];

    /// <summary>
    /// The log_paths attribute.
    /// </summary>
    public TerraformExpression LogPaths => this["log_paths"];

    /// <summary>
    /// The operating_system attribute.
    /// </summary>
    public TerraformExpression OperatingSystem => this["operating_system"];

    /// <summary>
    /// The script_arn attribute.
    /// </summary>
    public TerraformExpression ScriptArn => this["script_arn"];

}
