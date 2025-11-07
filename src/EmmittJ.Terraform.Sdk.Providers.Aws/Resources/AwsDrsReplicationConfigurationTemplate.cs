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
    public TerraformLiteralProperty<bool>? AssociateDefaultSecurityGroup
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("associate_default_security_group");
        set => this.WithProperty("associate_default_security_group", value);
    }

    /// <summary>
    /// The auto_replicate_new_disks attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AutoReplicateNewDisks
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_replicate_new_disks");
        set => this.WithProperty("auto_replicate_new_disks", value);
    }

    /// <summary>
    /// The bandwidth_throttling attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? BandwidthThrottling
    {
        get => GetProperty<TerraformLiteralProperty<double>>("bandwidth_throttling");
        set => this.WithProperty("bandwidth_throttling", value);
    }

    /// <summary>
    /// The create_public_ip attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? CreatePublicIp
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("create_public_ip");
        set => this.WithProperty("create_public_ip", value);
    }

    /// <summary>
    /// The data_plane_routing attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DataPlaneRouting
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_plane_routing");
        set => this.WithProperty("data_plane_routing", value);
    }

    /// <summary>
    /// The default_large_staging_disk_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DefaultLargeStagingDiskType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_large_staging_disk_type");
        set => this.WithProperty("default_large_staging_disk_type", value);
    }

    /// <summary>
    /// The ebs_encryption attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EbsEncryption
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ebs_encryption");
        set => this.WithProperty("ebs_encryption", value);
    }

    /// <summary>
    /// The ebs_encryption_key_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EbsEncryptionKeyArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ebs_encryption_key_arn");
        set => this.WithProperty("ebs_encryption_key_arn", value);
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
    /// The replication_server_instance_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ReplicationServerInstanceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("replication_server_instance_type");
        set => this.WithProperty("replication_server_instance_type", value);
    }

    /// <summary>
    /// The replication_servers_security_groups_ids attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? ReplicationServersSecurityGroupsIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("replication_servers_security_groups_ids");
        set => this.WithProperty("replication_servers_security_groups_ids", value);
    }

    /// <summary>
    /// The staging_area_subnet_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StagingAreaSubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("staging_area_subnet_id");
        set => this.WithProperty("staging_area_subnet_id", value);
    }

    /// <summary>
    /// The staging_area_tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? StagingAreaTags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("staging_area_tags");
        set => this.WithProperty("staging_area_tags", value);
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
    /// The use_dedicated_replication_server attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? UseDedicatedReplicationServer
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("use_dedicated_replication_server");
        set => this.WithProperty("use_dedicated_replication_server", value);
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
