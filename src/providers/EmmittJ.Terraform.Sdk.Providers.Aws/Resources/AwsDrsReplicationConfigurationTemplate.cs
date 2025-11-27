using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for pit_policy in AwsDrsReplicationConfigurationTemplate.
/// Nesting mode: list
/// </summary>
public class AwsDrsReplicationConfigurationTemplatePitPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pit_policy";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    public required TerraformValue<double> Interval
    {
        get => new TerraformReference<double>(this, "interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// The retention_duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionDuration is required")]
    public required TerraformValue<double> RetentionDuration
    {
        get => new TerraformReference<double>(this, "retention_duration");
        set => SetArgument("retention_duration", value);
    }

    /// <summary>
    /// The rule_id attribute.
    /// </summary>
    public TerraformValue<double>? RuleId
    {
        get => new TerraformReference<double>(this, "rule_id");
        set => SetArgument("rule_id", value);
    }

    /// <summary>
    /// The units attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Units is required")]
    public required TerraformValue<string> Units
    {
        get => new TerraformReference<string>(this, "units");
        set => SetArgument("units", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsDrsReplicationConfigurationTemplate.
/// Nesting mode: single
/// </summary>
public class AwsDrsReplicationConfigurationTemplateTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_drs_replication_configuration_template Terraform resource.
/// Manages a aws_drs_replication_configuration_template resource.
/// </summary>
public partial class AwsDrsReplicationConfigurationTemplate(string name) : TerraformResource("aws_drs_replication_configuration_template", name)
{
    /// <summary>
    /// The associate_default_security_group attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssociateDefaultSecurityGroup is required")]
    public required TerraformValue<bool> AssociateDefaultSecurityGroup
    {
        get => new TerraformReference<bool>(this, "associate_default_security_group");
        set => SetArgument("associate_default_security_group", value);
    }

    /// <summary>
    /// The auto_replicate_new_disks attribute.
    /// </summary>
    public TerraformValue<bool> AutoReplicateNewDisks
    {
        get => new TerraformReference<bool>(this, "auto_replicate_new_disks");
        set => SetArgument("auto_replicate_new_disks", value);
    }

    /// <summary>
    /// The bandwidth_throttling attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BandwidthThrottling is required")]
    public required TerraformValue<double> BandwidthThrottling
    {
        get => new TerraformReference<double>(this, "bandwidth_throttling");
        set => SetArgument("bandwidth_throttling", value);
    }

    /// <summary>
    /// The create_public_ip attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreatePublicIp is required")]
    public required TerraformValue<bool> CreatePublicIp
    {
        get => new TerraformReference<bool>(this, "create_public_ip");
        set => SetArgument("create_public_ip", value);
    }

    /// <summary>
    /// The data_plane_routing attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataPlaneRouting is required")]
    public required TerraformValue<string> DataPlaneRouting
    {
        get => new TerraformReference<string>(this, "data_plane_routing");
        set => SetArgument("data_plane_routing", value);
    }

    /// <summary>
    /// The default_large_staging_disk_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultLargeStagingDiskType is required")]
    public required TerraformValue<string> DefaultLargeStagingDiskType
    {
        get => new TerraformReference<string>(this, "default_large_staging_disk_type");
        set => SetArgument("default_large_staging_disk_type", value);
    }

    /// <summary>
    /// The ebs_encryption attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EbsEncryption is required")]
    public required TerraformValue<string> EbsEncryption
    {
        get => new TerraformReference<string>(this, "ebs_encryption");
        set => SetArgument("ebs_encryption", value);
    }

    /// <summary>
    /// The ebs_encryption_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? EbsEncryptionKeyArn
    {
        get => new TerraformReference<string>(this, "ebs_encryption_key_arn");
        set => SetArgument("ebs_encryption_key_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The replication_server_instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationServerInstanceType is required")]
    public required TerraformValue<string> ReplicationServerInstanceType
    {
        get => new TerraformReference<string>(this, "replication_server_instance_type");
        set => SetArgument("replication_server_instance_type", value);
    }

    /// <summary>
    /// The replication_servers_security_groups_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationServersSecurityGroupsIds is required")]
    public TerraformList<string>? ReplicationServersSecurityGroupsIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "replication_servers_security_groups_ids").ResolveNodes(ctx));
        set => SetArgument("replication_servers_security_groups_ids", value);
    }

    /// <summary>
    /// The staging_area_subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StagingAreaSubnetId is required")]
    public required TerraformValue<string> StagingAreaSubnetId
    {
        get => new TerraformReference<string>(this, "staging_area_subnet_id");
        set => SetArgument("staging_area_subnet_id", value);
    }

    /// <summary>
    /// The staging_area_tags attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StagingAreaTags is required")]
    public required TerraformMap<string> StagingAreaTags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "staging_area_tags").ResolveNodes(ctx));
        set => SetArgument("staging_area_tags", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The use_dedicated_replication_server attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UseDedicatedReplicationServer is required")]
    public required TerraformValue<bool> UseDedicatedReplicationServer
    {
        get => new TerraformReference<bool>(this, "use_dedicated_replication_server");
        set => SetArgument("use_dedicated_replication_server", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

    /// <summary>
    /// PitPolicy block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsDrsReplicationConfigurationTemplatePitPolicyBlock>? PitPolicy
    {
        get => GetArgument<TerraformList<AwsDrsReplicationConfigurationTemplatePitPolicyBlock>>("pit_policy");
        set => SetArgument("pit_policy", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsDrsReplicationConfigurationTemplateTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsDrsReplicationConfigurationTemplateTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
