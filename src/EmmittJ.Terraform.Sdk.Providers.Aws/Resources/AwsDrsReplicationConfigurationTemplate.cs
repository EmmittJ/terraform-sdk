using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_drs_replication_configuration_template resource.
/// </summary>
public class AwsDrsReplicationConfigurationTemplate : TerraformResource
{
    public AwsDrsReplicationConfigurationTemplate(string name) : base("aws_drs_replication_configuration_template", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("id");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The associate_default_security_group attribute.
    /// </summary>
    public bool? AssociateDefaultSecurityGroup
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("associate_default_security_group")?.Value;
        set => this.WithProperty("associate_default_security_group", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The auto_replicate_new_disks attribute.
    /// </summary>
    public bool? AutoReplicateNewDisks
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_replicate_new_disks")?.Value;
        set => this.WithProperty("auto_replicate_new_disks", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The bandwidth_throttling attribute.
    /// </summary>
    public double? BandwidthThrottling
    {
        get => GetProperty<TerraformLiteralProperty<double>>("bandwidth_throttling")?.Value;
        set => this.WithProperty("bandwidth_throttling", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The create_public_ip attribute.
    /// </summary>
    public bool? CreatePublicIp
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("create_public_ip")?.Value;
        set => this.WithProperty("create_public_ip", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The data_plane_routing attribute.
    /// </summary>
    public string? DataPlaneRouting
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_plane_routing")?.Value;
        set => this.WithProperty("data_plane_routing", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The default_large_staging_disk_type attribute.
    /// </summary>
    public string? DefaultLargeStagingDiskType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_large_staging_disk_type")?.Value;
        set => this.WithProperty("default_large_staging_disk_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ebs_encryption attribute.
    /// </summary>
    public string? EbsEncryption
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ebs_encryption")?.Value;
        set => this.WithProperty("ebs_encryption", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ebs_encryption_key_arn attribute.
    /// </summary>
    public string? EbsEncryptionKeyArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ebs_encryption_key_arn")?.Value;
        set => this.WithProperty("ebs_encryption_key_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The replication_server_instance_type attribute.
    /// </summary>
    public string? ReplicationServerInstanceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("replication_server_instance_type")?.Value;
        set => this.WithProperty("replication_server_instance_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The replication_servers_security_groups_ids attribute.
    /// </summary>
    public List<string>? ReplicationServersSecurityGroupsIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("replication_servers_security_groups_ids")?.Value;
        set => this.WithProperty("replication_servers_security_groups_ids", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The staging_area_subnet_id attribute.
    /// </summary>
    public string? StagingAreaSubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("staging_area_subnet_id")?.Value;
        set => this.WithProperty("staging_area_subnet_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The staging_area_tags attribute.
    /// </summary>
    public Dictionary<string, string>? StagingAreaTags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("staging_area_tags")?.Value;
        set => this.WithProperty("staging_area_tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
    /// The use_dedicated_replication_server attribute.
    /// </summary>
    public bool? UseDedicatedReplicationServer
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("use_dedicated_replication_server")?.Value;
        set => this.WithProperty("use_dedicated_replication_server", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
