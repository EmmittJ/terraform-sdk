using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_opsworks_instance resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AwsOpsworksInstance : TerraformResource
{
    public AwsOpsworksInstance(string name) : base("aws_opsworks_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("ec2_instance_id");
        this.DeclareOutput("last_service_error_id");
        this.DeclareOutput("platform");
        this.DeclareOutput("private_dns");
        this.DeclareOutput("private_ip");
        this.DeclareOutput("public_dns");
        this.DeclareOutput("public_ip");
        this.DeclareOutput("registered_by");
        this.DeclareOutput("reported_agent_version");
        this.DeclareOutput("reported_os_family");
        this.DeclareOutput("reported_os_name");
        this.DeclareOutput("reported_os_version");
        this.DeclareOutput("root_device_volume_id");
        this.DeclareOutput("ssh_host_dsa_key_fingerprint");
        this.DeclareOutput("ssh_host_rsa_key_fingerprint");
    }

    /// <summary>
    /// The agent_version attribute.
    /// </summary>
    public string? AgentVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("agent_version")?.Value;
        set => this.WithProperty("agent_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ami_id attribute.
    /// </summary>
    public string? AmiId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ami_id")?.Value;
        set => this.WithProperty("ami_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The architecture attribute.
    /// </summary>
    public string? Architecture
    {
        get => GetProperty<TerraformLiteralProperty<string>>("architecture")?.Value;
        set => this.WithProperty("architecture", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The auto_scaling_type attribute.
    /// </summary>
    public string? AutoScalingType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("auto_scaling_type")?.Value;
        set => this.WithProperty("auto_scaling_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public string? AvailabilityZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("availability_zone")?.Value;
        set => this.WithProperty("availability_zone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public string? CreatedAt
    {
        get => GetProperty<TerraformLiteralProperty<string>>("created_at")?.Value;
        set => this.WithProperty("created_at", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The delete_ebs attribute.
    /// </summary>
    public bool? DeleteEbs
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("delete_ebs")?.Value;
        set => this.WithProperty("delete_ebs", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The delete_eip attribute.
    /// </summary>
    public bool? DeleteEip
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("delete_eip")?.Value;
        set => this.WithProperty("delete_eip", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    public bool? EbsOptimized
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ebs_optimized")?.Value;
        set => this.WithProperty("ebs_optimized", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The ecs_cluster_arn attribute.
    /// </summary>
    public string? EcsClusterArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ecs_cluster_arn")?.Value;
        set => this.WithProperty("ecs_cluster_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The elastic_ip attribute.
    /// </summary>
    public string? ElasticIp
    {
        get => GetProperty<TerraformLiteralProperty<string>>("elastic_ip")?.Value;
        set => this.WithProperty("elastic_ip", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    public string? Hostname
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hostname")?.Value;
        set => this.WithProperty("hostname", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The infrastructure_class attribute.
    /// </summary>
    public string? InfrastructureClass
    {
        get => GetProperty<TerraformLiteralProperty<string>>("infrastructure_class")?.Value;
        set => this.WithProperty("infrastructure_class", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The install_updates_on_boot attribute.
    /// </summary>
    public bool? InstallUpdatesOnBoot
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("install_updates_on_boot")?.Value;
        set => this.WithProperty("install_updates_on_boot", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The instance_profile_arn attribute.
    /// </summary>
    public string? InstanceProfileArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_profile_arn")?.Value;
        set => this.WithProperty("instance_profile_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public string? InstanceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_type")?.Value;
        set => this.WithProperty("instance_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The layer_ids attribute.
    /// </summary>
    public List<string>? LayerIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("layer_ids")?.Value;
        set => this.WithProperty("layer_ids", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The os attribute.
    /// </summary>
    public string? Os
    {
        get => GetProperty<TerraformLiteralProperty<string>>("os")?.Value;
        set => this.WithProperty("os", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The root_device_type attribute.
    /// </summary>
    public string? RootDeviceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("root_device_type")?.Value;
        set => this.WithProperty("root_device_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public List<string>? SecurityGroupIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("security_group_ids")?.Value;
        set => this.WithProperty("security_group_ids", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The ssh_key_name attribute.
    /// </summary>
    public string? SshKeyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ssh_key_name")?.Value;
        set => this.WithProperty("ssh_key_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The stack_id attribute.
    /// </summary>
    public string? StackId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stack_id")?.Value;
        set => this.WithProperty("stack_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public string? State
    {
        get => GetProperty<TerraformLiteralProperty<string>>("state")?.Value;
        set => this.WithProperty("state", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public string? Status
    {
        get => GetProperty<TerraformLiteralProperty<string>>("status")?.Value;
        set => this.WithProperty("status", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public string? SubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnet_id")?.Value;
        set => this.WithProperty("subnet_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tenancy attribute.
    /// </summary>
    public string? Tenancy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tenancy")?.Value;
        set => this.WithProperty("tenancy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The virtualization_type attribute.
    /// </summary>
    public string? VirtualizationType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtualization_type")?.Value;
        set => this.WithProperty("virtualization_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ec2_instance_id attribute.
    /// </summary>
    public TerraformExpression Ec2InstanceId => this["ec2_instance_id"];

    /// <summary>
    /// The last_service_error_id attribute.
    /// </summary>
    public TerraformExpression LastServiceErrorId => this["last_service_error_id"];

    /// <summary>
    /// The platform attribute.
    /// </summary>
    public TerraformExpression Platform => this["platform"];

    /// <summary>
    /// The private_dns attribute.
    /// </summary>
    public TerraformExpression PrivateDns => this["private_dns"];

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    public TerraformExpression PrivateIp => this["private_ip"];

    /// <summary>
    /// The public_dns attribute.
    /// </summary>
    public TerraformExpression PublicDns => this["public_dns"];

    /// <summary>
    /// The public_ip attribute.
    /// </summary>
    public TerraformExpression PublicIp => this["public_ip"];

    /// <summary>
    /// The registered_by attribute.
    /// </summary>
    public TerraformExpression RegisteredBy => this["registered_by"];

    /// <summary>
    /// The reported_agent_version attribute.
    /// </summary>
    public TerraformExpression ReportedAgentVersion => this["reported_agent_version"];

    /// <summary>
    /// The reported_os_family attribute.
    /// </summary>
    public TerraformExpression ReportedOsFamily => this["reported_os_family"];

    /// <summary>
    /// The reported_os_name attribute.
    /// </summary>
    public TerraformExpression ReportedOsName => this["reported_os_name"];

    /// <summary>
    /// The reported_os_version attribute.
    /// </summary>
    public TerraformExpression ReportedOsVersion => this["reported_os_version"];

    /// <summary>
    /// The root_device_volume_id attribute.
    /// </summary>
    public TerraformExpression RootDeviceVolumeId => this["root_device_volume_id"];

    /// <summary>
    /// The ssh_host_dsa_key_fingerprint attribute.
    /// </summary>
    public TerraformExpression SshHostDsaKeyFingerprint => this["ssh_host_dsa_key_fingerprint"];

    /// <summary>
    /// The ssh_host_rsa_key_fingerprint attribute.
    /// </summary>
    public TerraformExpression SshHostRsaKeyFingerprint => this["ssh_host_rsa_key_fingerprint"];

}
