using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_codedeploy_deployment_group resource.
/// </summary>
public class AwsCodedeployDeploymentGroup : TerraformResource
{
    public AwsCodedeployDeploymentGroup(string name) : base("aws_codedeploy_deployment_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("compute_platform");
        this.DeclareOutput("deployment_group_id");
    }

    /// <summary>
    /// The app_name attribute.
    /// </summary>
    public string? AppName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app_name")?.Value;
        set => this.WithProperty("app_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The autoscaling_groups attribute.
    /// </summary>
    public HashSet<string>? AutoscalingGroups
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("autoscaling_groups")?.Value;
        set => this.WithProperty("autoscaling_groups", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The deployment_config_name attribute.
    /// </summary>
    public string? DeploymentConfigName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("deployment_config_name")?.Value;
        set => this.WithProperty("deployment_config_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The deployment_group_name attribute.
    /// </summary>
    public string? DeploymentGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("deployment_group_name")?.Value;
        set => this.WithProperty("deployment_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The outdated_instances_strategy attribute.
    /// </summary>
    public string? OutdatedInstancesStrategy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("outdated_instances_strategy")?.Value;
        set => this.WithProperty("outdated_instances_strategy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service_role_arn attribute.
    /// </summary>
    public string? ServiceRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_role_arn")?.Value;
        set => this.WithProperty("service_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The termination_hook_enabled attribute.
    /// </summary>
    public bool? TerminationHookEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("termination_hook_enabled")?.Value;
        set => this.WithProperty("termination_hook_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The compute_platform attribute.
    /// </summary>
    public TerraformExpression ComputePlatform => this["compute_platform"];

    /// <summary>
    /// The deployment_group_id attribute.
    /// </summary>
    public TerraformExpression DeploymentGroupId => this["deployment_group_id"];

}
