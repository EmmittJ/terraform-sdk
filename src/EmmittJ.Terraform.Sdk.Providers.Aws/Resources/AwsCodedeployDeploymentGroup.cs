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
    public TerraformLiteralProperty<string>? AppName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app_name");
        set => this.WithProperty("app_name", value);
    }

    /// <summary>
    /// The autoscaling_groups attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? AutoscalingGroups
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("autoscaling_groups");
        set => this.WithProperty("autoscaling_groups", value);
    }

    /// <summary>
    /// The deployment_config_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DeploymentConfigName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("deployment_config_name");
        set => this.WithProperty("deployment_config_name", value);
    }

    /// <summary>
    /// The deployment_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DeploymentGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("deployment_group_name");
        set => this.WithProperty("deployment_group_name", value);
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
    /// The outdated_instances_strategy attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? OutdatedInstancesStrategy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("outdated_instances_strategy");
        set => this.WithProperty("outdated_instances_strategy", value);
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
    /// The service_role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ServiceRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_role_arn");
        set => this.WithProperty("service_role_arn", value);
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
    /// The termination_hook_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? TerminationHookEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("termination_hook_enabled");
        set => this.WithProperty("termination_hook_enabled", value);
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
