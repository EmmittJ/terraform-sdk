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
    public TerraformProperty<string>? BalancingStrategy
    {
        get => GetProperty<TerraformProperty<string>>("balancing_strategy");
        set => this.WithProperty("balancing_strategy", value);
    }

    /// <summary>
    /// The game_server_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? GameServerGroupName
    {
        get => GetProperty<TerraformProperty<string>>("game_server_group_name");
        set => this.WithProperty("game_server_group_name", value);
    }

    /// <summary>
    /// The game_server_protection_policy attribute.
    /// </summary>
    public TerraformProperty<string>? GameServerProtectionPolicy
    {
        get => GetProperty<TerraformProperty<string>>("game_server_protection_policy");
        set => this.WithProperty("game_server_protection_policy", value);
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
    /// The max_size attribute.
    /// </summary>
    public TerraformProperty<double>? MaxSize
    {
        get => GetProperty<TerraformProperty<double>>("max_size");
        set => this.WithProperty("max_size", value);
    }

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    public TerraformProperty<double>? MinSize
    {
        get => GetProperty<TerraformProperty<double>>("min_size");
        set => this.WithProperty("min_size", value);
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
    /// The role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The vpc_subnets attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? VpcSubnets
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("vpc_subnets");
        set => this.WithProperty("vpc_subnets", value);
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
