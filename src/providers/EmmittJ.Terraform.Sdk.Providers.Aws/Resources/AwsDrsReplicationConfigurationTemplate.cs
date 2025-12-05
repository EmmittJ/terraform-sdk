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
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    public required TerraformValue<double> Interval
    {
        get => GetRequiredArgument<TerraformValue<double>>("interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// The retention_duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionDuration is required")]
    public required TerraformValue<double> RetentionDuration
    {
        get => GetRequiredArgument<TerraformValue<double>>("retention_duration");
        set => SetArgument("retention_duration", value);
    }

    /// <summary>
    /// The rule_id attribute.
    /// </summary>
    public TerraformValue<double>? RuleId
    {
        get => GetArgument<TerraformValue<double>>("rule_id");
        set => SetArgument("rule_id", value);
    }

    /// <summary>
    /// The units attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Units is required")]
    public required TerraformValue<string> Units
    {
        get => GetRequiredArgument<TerraformValue<string>>("units");
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
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
        get => GetRequiredArgument<TerraformValue<bool>>("associate_default_security_group");
        set => SetArgument("associate_default_security_group", value);
    }

    /// <summary>
    /// The auto_replicate_new_disks attribute.
    /// </summary>
    public TerraformValue<bool> AutoReplicateNewDisks
    {
        get => GetArgument<TerraformValue<bool>>("auto_replicate_new_disks") ?? CreateReference("auto_replicate_new_disks");
        set => SetArgument("auto_replicate_new_disks", value);
    }

    /// <summary>
    /// The bandwidth_throttling attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BandwidthThrottling is required")]
    public required TerraformValue<double> BandwidthThrottling
    {
        get => GetRequiredArgument<TerraformValue<double>>("bandwidth_throttling");
        set => SetArgument("bandwidth_throttling", value);
    }

    /// <summary>
    /// The create_public_ip attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreatePublicIp is required")]
    public required TerraformValue<bool> CreatePublicIp
    {
        get => GetRequiredArgument<TerraformValue<bool>>("create_public_ip");
        set => SetArgument("create_public_ip", value);
    }

    /// <summary>
    /// The data_plane_routing attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataPlaneRouting is required")]
    public required TerraformValue<string> DataPlaneRouting
    {
        get => GetRequiredArgument<TerraformValue<string>>("data_plane_routing");
        set => SetArgument("data_plane_routing", value);
    }

    /// <summary>
    /// The default_large_staging_disk_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultLargeStagingDiskType is required")]
    public required TerraformValue<string> DefaultLargeStagingDiskType
    {
        get => GetRequiredArgument<TerraformValue<string>>("default_large_staging_disk_type");
        set => SetArgument("default_large_staging_disk_type", value);
    }

    /// <summary>
    /// The ebs_encryption attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EbsEncryption is required")]
    public required TerraformValue<string> EbsEncryption
    {
        get => GetRequiredArgument<TerraformValue<string>>("ebs_encryption");
        set => SetArgument("ebs_encryption", value);
    }

    /// <summary>
    /// The ebs_encryption_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? EbsEncryptionKeyArn
    {
        get => GetArgument<TerraformValue<string>>("ebs_encryption_key_arn");
        set => SetArgument("ebs_encryption_key_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The replication_server_instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationServerInstanceType is required")]
    public required TerraformValue<string> ReplicationServerInstanceType
    {
        get => GetRequiredArgument<TerraformValue<string>>("replication_server_instance_type");
        set => SetArgument("replication_server_instance_type", value);
    }

    /// <summary>
    /// The replication_servers_security_groups_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationServersSecurityGroupsIds is required")]
    public TerraformList<string>? ReplicationServersSecurityGroupsIds
    {
        get => GetArgument<TerraformList<string>>("replication_servers_security_groups_ids");
        set => SetArgument("replication_servers_security_groups_ids", value);
    }

    /// <summary>
    /// The staging_area_subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StagingAreaSubnetId is required")]
    public required TerraformValue<string> StagingAreaSubnetId
    {
        get => GetRequiredArgument<TerraformValue<string>>("staging_area_subnet_id");
        set => SetArgument("staging_area_subnet_id", value);
    }

    /// <summary>
    /// The staging_area_tags attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StagingAreaTags is required")]
    public required TerraformMap<string> StagingAreaTags
    {
        get => GetRequiredArgument<TerraformMap<string>>("staging_area_tags");
        set => SetArgument("staging_area_tags", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The use_dedicated_replication_server attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UseDedicatedReplicationServer is required")]
    public required TerraformValue<bool> UseDedicatedReplicationServer
    {
        get => GetRequiredArgument<TerraformValue<bool>>("use_dedicated_replication_server");
        set => SetArgument("use_dedicated_replication_server", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => CreateReference("tags_all");

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
