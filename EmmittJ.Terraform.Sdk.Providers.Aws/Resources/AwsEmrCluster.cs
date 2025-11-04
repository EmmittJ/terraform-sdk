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
    public string? AdditionalInfo
    {
        get => GetProperty<TerraformLiteralProperty<string>>("additional_info")?.Value;
        set => this.WithProperty("additional_info", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The applications attribute.
    /// </summary>
    public HashSet<string>? Applications
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("applications")?.Value;
        set => this.WithProperty("applications", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The autoscaling_role attribute.
    /// </summary>
    public string? AutoscalingRole
    {
        get => GetProperty<TerraformLiteralProperty<string>>("autoscaling_role")?.Value;
        set => this.WithProperty("autoscaling_role", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The configurations attribute.
    /// </summary>
    public string? Configurations
    {
        get => GetProperty<TerraformLiteralProperty<string>>("configurations")?.Value;
        set => this.WithProperty("configurations", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The configurations_json attribute.
    /// </summary>
    public string? ConfigurationsJson
    {
        get => GetProperty<TerraformLiteralProperty<string>>("configurations_json")?.Value;
        set => this.WithProperty("configurations_json", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The custom_ami_id attribute.
    /// </summary>
    public string? CustomAmiId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_ami_id")?.Value;
        set => this.WithProperty("custom_ami_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ebs_root_volume_size attribute.
    /// </summary>
    public double? EbsRootVolumeSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("ebs_root_volume_size")?.Value;
        set => this.WithProperty("ebs_root_volume_size", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The keep_job_flow_alive_when_no_steps attribute.
    /// </summary>
    public bool? KeepJobFlowAliveWhenNoSteps
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("keep_job_flow_alive_when_no_steps")?.Value;
        set => this.WithProperty("keep_job_flow_alive_when_no_steps", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The list_steps_states attribute.
    /// </summary>
    public HashSet<string>? ListStepsStates
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("list_steps_states")?.Value;
        set => this.WithProperty("list_steps_states", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The log_encryption_kms_key_id attribute.
    /// </summary>
    public string? LogEncryptionKmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("log_encryption_kms_key_id")?.Value;
        set => this.WithProperty("log_encryption_kms_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The log_uri attribute.
    /// </summary>
    public string? LogUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("log_uri")?.Value;
        set => this.WithProperty("log_uri", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The placement_group_config attribute.
    /// </summary>
    public List<object>? PlacementGroupConfig
    {
        get => GetProperty<TerraformLiteralProperty<List<object>>>("placement_group_config")?.Value;
        set => this.WithProperty("placement_group_config", value == null ? null : new TerraformLiteralProperty<List<object>>(value));
    }

    /// <summary>
    /// The release_label attribute.
    /// </summary>
    public string? ReleaseLabel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("release_label")?.Value;
        set => this.WithProperty("release_label", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The scale_down_behavior attribute.
    /// </summary>
    public string? ScaleDownBehavior
    {
        get => GetProperty<TerraformLiteralProperty<string>>("scale_down_behavior")?.Value;
        set => this.WithProperty("scale_down_behavior", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The security_configuration attribute.
    /// </summary>
    public string? SecurityConfiguration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("security_configuration")?.Value;
        set => this.WithProperty("security_configuration", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    public string? ServiceRole
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_role")?.Value;
        set => this.WithProperty("service_role", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The step attribute.
    /// </summary>
    public List<object>? Step
    {
        get => GetProperty<TerraformLiteralProperty<List<object>>>("step")?.Value;
        set => this.WithProperty("step", value == null ? null : new TerraformLiteralProperty<List<object>>(value));
    }

    /// <summary>
    /// The step_concurrency_level attribute.
    /// </summary>
    public double? StepConcurrencyLevel
    {
        get => GetProperty<TerraformLiteralProperty<double>>("step_concurrency_level")?.Value;
        set => this.WithProperty("step_concurrency_level", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The termination_protection attribute.
    /// </summary>
    public bool? TerminationProtection
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("termination_protection")?.Value;
        set => this.WithProperty("termination_protection", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The unhealthy_node_replacement attribute.
    /// </summary>
    public bool? UnhealthyNodeReplacement
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("unhealthy_node_replacement")?.Value;
        set => this.WithProperty("unhealthy_node_replacement", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The visible_to_all_users attribute.
    /// </summary>
    public bool? VisibleToAllUsers
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("visible_to_all_users")?.Value;
        set => this.WithProperty("visible_to_all_users", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
