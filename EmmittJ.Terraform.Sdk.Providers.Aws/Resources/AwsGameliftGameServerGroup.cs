using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_gamelift_game_server_group resource.
/// </summary>
public class AwsGameliftGameServerGroup : TerraformResource
{
    public AwsGameliftGameServerGroup(string name) : base("aws_gamelift_game_server_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("auto_scaling_group_arn");
    }

    /// <summary>
    /// The balancing_strategy attribute.
    /// </summary>
    public string? BalancingStrategy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("balancing_strategy")?.Value;
        set => this.WithProperty("balancing_strategy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The game_server_group_name attribute.
    /// </summary>
    public string? GameServerGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("game_server_group_name")?.Value;
        set => this.WithProperty("game_server_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The game_server_protection_policy attribute.
    /// </summary>
    public string? GameServerProtectionPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("game_server_protection_policy")?.Value;
        set => this.WithProperty("game_server_protection_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The max_size attribute.
    /// </summary>
    public double? MaxSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_size")?.Value;
        set => this.WithProperty("max_size", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    public double? MinSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("min_size")?.Value;
        set => this.WithProperty("min_size", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public string? RoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_arn")?.Value;
        set => this.WithProperty("role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The vpc_subnets attribute.
    /// </summary>
    public HashSet<string>? VpcSubnets
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("vpc_subnets")?.Value;
        set => this.WithProperty("vpc_subnets", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The auto_scaling_group_arn attribute.
    /// </summary>
    public TerraformExpression AutoScalingGroupArn => this["auto_scaling_group_arn"];

}
