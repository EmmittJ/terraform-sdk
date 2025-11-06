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
    public string? BuildId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("build_id")?.Value;
        set => this.WithProperty("build_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ec2_instance_type attribute.
    /// </summary>
    public string? Ec2InstanceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ec2_instance_type")?.Value;
        set => this.WithProperty("ec2_instance_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The fleet_type attribute.
    /// </summary>
    public string? FleetType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("fleet_type")?.Value;
        set => this.WithProperty("fleet_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The instance_role_arn attribute.
    /// </summary>
    public string? InstanceRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_role_arn")?.Value;
        set => this.WithProperty("instance_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The metric_groups attribute.
    /// </summary>
    public List<string>? MetricGroups
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("metric_groups")?.Value;
        set => this.WithProperty("metric_groups", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// The new_game_session_protection_policy attribute.
    /// </summary>
    public string? NewGameSessionProtectionPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("new_game_session_protection_policy")?.Value;
        set => this.WithProperty("new_game_session_protection_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The script_id attribute.
    /// </summary>
    public string? ScriptId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("script_id")?.Value;
        set => this.WithProperty("script_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
