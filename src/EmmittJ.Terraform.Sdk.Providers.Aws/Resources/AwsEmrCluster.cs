using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_emr_cluster resource.
/// </summary>
public class AwsEmrCluster : TerraformResource
{
    public AwsEmrCluster(string name) : base("aws_emr_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("cluster_state");
        this.DeclareOutput("master_public_dns");
    }

    /// <summary>
    /// The additional_info attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AdditionalInfo
    {
        get => GetProperty<TerraformLiteralProperty<string>>("additional_info");
        set => this.WithProperty("additional_info", value);
    }

    /// <summary>
    /// The applications attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Applications
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("applications");
        set => this.WithProperty("applications", value);
    }

    /// <summary>
    /// The autoscaling_role attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AutoscalingRole
    {
        get => GetProperty<TerraformLiteralProperty<string>>("autoscaling_role");
        set => this.WithProperty("autoscaling_role", value);
    }

    /// <summary>
    /// The configurations attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Configurations
    {
        get => GetProperty<TerraformLiteralProperty<string>>("configurations");
        set => this.WithProperty("configurations", value);
    }

    /// <summary>
    /// The configurations_json attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ConfigurationsJson
    {
        get => GetProperty<TerraformLiteralProperty<string>>("configurations_json");
        set => this.WithProperty("configurations_json", value);
    }

    /// <summary>
    /// The custom_ami_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CustomAmiId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_ami_id");
        set => this.WithProperty("custom_ami_id", value);
    }

    /// <summary>
    /// The ebs_root_volume_size attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? EbsRootVolumeSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("ebs_root_volume_size");
        set => this.WithProperty("ebs_root_volume_size", value);
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
    /// The keep_job_flow_alive_when_no_steps attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? KeepJobFlowAliveWhenNoSteps
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("keep_job_flow_alive_when_no_steps");
        set => this.WithProperty("keep_job_flow_alive_when_no_steps", value);
    }

    /// <summary>
    /// The list_steps_states attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? ListStepsStates
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("list_steps_states");
        set => this.WithProperty("list_steps_states", value);
    }

    /// <summary>
    /// The log_encryption_kms_key_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LogEncryptionKmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("log_encryption_kms_key_id");
        set => this.WithProperty("log_encryption_kms_key_id", value);
    }

    /// <summary>
    /// The log_uri attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LogUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("log_uri");
        set => this.WithProperty("log_uri", value);
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
    /// The os_release_label attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? OsReleaseLabel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("os_release_label");
        set => this.WithProperty("os_release_label", value);
    }

    /// <summary>
    /// The placement_group_config attribute.
    /// </summary>
    public TerraformLiteralProperty<List<object>>? PlacementGroupConfig
    {
        get => GetProperty<TerraformLiteralProperty<List<object>>>("placement_group_config");
        set => this.WithProperty("placement_group_config", value);
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
    /// The release_label attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ReleaseLabel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("release_label");
        set => this.WithProperty("release_label", value);
    }

    /// <summary>
    /// The scale_down_behavior attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ScaleDownBehavior
    {
        get => GetProperty<TerraformLiteralProperty<string>>("scale_down_behavior");
        set => this.WithProperty("scale_down_behavior", value);
    }

    /// <summary>
    /// The security_configuration attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SecurityConfiguration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("security_configuration");
        set => this.WithProperty("security_configuration", value);
    }

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ServiceRole
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_role");
        set => this.WithProperty("service_role", value);
    }

    /// <summary>
    /// The step attribute.
    /// </summary>
    public TerraformLiteralProperty<List<object>>? Step
    {
        get => GetProperty<TerraformLiteralProperty<List<object>>>("step");
        set => this.WithProperty("step", value);
    }

    /// <summary>
    /// The step_concurrency_level attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? StepConcurrencyLevel
    {
        get => GetProperty<TerraformLiteralProperty<double>>("step_concurrency_level");
        set => this.WithProperty("step_concurrency_level", value);
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
    /// The termination_protection attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? TerminationProtection
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("termination_protection");
        set => this.WithProperty("termination_protection", value);
    }

    /// <summary>
    /// The unhealthy_node_replacement attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? UnhealthyNodeReplacement
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("unhealthy_node_replacement");
        set => this.WithProperty("unhealthy_node_replacement", value);
    }

    /// <summary>
    /// The visible_to_all_users attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? VisibleToAllUsers
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("visible_to_all_users");
        set => this.WithProperty("visible_to_all_users", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The cluster_state attribute.
    /// </summary>
    public TerraformExpression ClusterState => this["cluster_state"];

    /// <summary>
    /// The master_public_dns attribute.
    /// </summary>
    public TerraformExpression MasterPublicDns => this["master_public_dns"];

}
