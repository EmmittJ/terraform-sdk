using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for pit_policy in .
/// Nesting mode: list
/// </summary>
public class AwsDrsReplicationConfigurationTemplatePitPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    public required TerraformProperty<double> Interval
    {
        get => GetProperty<TerraformProperty<double>>("interval");
        set => WithProperty("interval", value);
    }

    /// <summary>
    /// The retention_duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionDuration is required")]
    public required TerraformProperty<double> RetentionDuration
    {
        get => GetProperty<TerraformProperty<double>>("retention_duration");
        set => WithProperty("retention_duration", value);
    }

    /// <summary>
    /// The rule_id attribute.
    /// </summary>
    public TerraformProperty<double>? RuleId
    {
        get => GetProperty<TerraformProperty<double>>("rule_id");
        set => WithProperty("rule_id", value);
    }

    /// <summary>
    /// The units attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Units is required")]
    public required TerraformProperty<string> Units
    {
        get => GetProperty<TerraformProperty<string>>("units");
        set => WithProperty("units", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDrsReplicationConfigurationTemplateTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssociateDefaultSecurityGroup is required")]
    public required TerraformProperty<bool> AssociateDefaultSecurityGroup
    {
        get => GetProperty<TerraformProperty<bool>>("associate_default_security_group");
        set => this.WithProperty("associate_default_security_group", value);
    }

    /// <summary>
    /// The auto_replicate_new_disks attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoReplicateNewDisks
    {
        get => GetProperty<TerraformProperty<bool>>("auto_replicate_new_disks");
        set => this.WithProperty("auto_replicate_new_disks", value);
    }

    /// <summary>
    /// The bandwidth_throttling attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BandwidthThrottling is required")]
    public required TerraformProperty<double> BandwidthThrottling
    {
        get => GetProperty<TerraformProperty<double>>("bandwidth_throttling");
        set => this.WithProperty("bandwidth_throttling", value);
    }

    /// <summary>
    /// The create_public_ip attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreatePublicIp is required")]
    public required TerraformProperty<bool> CreatePublicIp
    {
        get => GetProperty<TerraformProperty<bool>>("create_public_ip");
        set => this.WithProperty("create_public_ip", value);
    }

    /// <summary>
    /// The data_plane_routing attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataPlaneRouting is required")]
    public required TerraformProperty<string> DataPlaneRouting
    {
        get => GetProperty<TerraformProperty<string>>("data_plane_routing");
        set => this.WithProperty("data_plane_routing", value);
    }

    /// <summary>
    /// The default_large_staging_disk_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultLargeStagingDiskType is required")]
    public required TerraformProperty<string> DefaultLargeStagingDiskType
    {
        get => GetProperty<TerraformProperty<string>>("default_large_staging_disk_type");
        set => this.WithProperty("default_large_staging_disk_type", value);
    }

    /// <summary>
    /// The ebs_encryption attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EbsEncryption is required")]
    public required TerraformProperty<string> EbsEncryption
    {
        get => GetProperty<TerraformProperty<string>>("ebs_encryption");
        set => this.WithProperty("ebs_encryption", value);
    }

    /// <summary>
    /// The ebs_encryption_key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? EbsEncryptionKeyArn
    {
        get => GetProperty<TerraformProperty<string>>("ebs_encryption_key_arn");
        set => this.WithProperty("ebs_encryption_key_arn", value);
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
    /// The replication_server_instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationServerInstanceType is required")]
    public required TerraformProperty<string> ReplicationServerInstanceType
    {
        get => GetProperty<TerraformProperty<string>>("replication_server_instance_type");
        set => this.WithProperty("replication_server_instance_type", value);
    }

    /// <summary>
    /// The replication_servers_security_groups_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationServersSecurityGroupsIds is required")]
    public List<TerraformProperty<string>>? ReplicationServersSecurityGroupsIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("replication_servers_security_groups_ids");
        set => this.WithProperty("replication_servers_security_groups_ids", value);
    }

    /// <summary>
    /// The staging_area_subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StagingAreaSubnetId is required")]
    public required TerraformProperty<string> StagingAreaSubnetId
    {
        get => GetProperty<TerraformProperty<string>>("staging_area_subnet_id");
        set => this.WithProperty("staging_area_subnet_id", value);
    }

    /// <summary>
    /// The staging_area_tags attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StagingAreaTags is required")]
    public Dictionary<string, TerraformProperty<string>>? StagingAreaTags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("staging_area_tags");
        set => this.WithProperty("staging_area_tags", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The use_dedicated_replication_server attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UseDedicatedReplicationServer is required")]
    public required TerraformProperty<bool> UseDedicatedReplicationServer
    {
        get => GetProperty<TerraformProperty<bool>>("use_dedicated_replication_server");
        set => this.WithProperty("use_dedicated_replication_server", value);
    }

    /// <summary>
    /// Block for pit_policy.
    /// Nesting mode: list
    /// </summary>
    public List<AwsDrsReplicationConfigurationTemplatePitPolicyBlock>? PitPolicy
    {
        get => GetProperty<List<AwsDrsReplicationConfigurationTemplatePitPolicyBlock>>("pit_policy");
        set => this.WithProperty("pit_policy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDrsReplicationConfigurationTemplateTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsDrsReplicationConfigurationTemplateTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
