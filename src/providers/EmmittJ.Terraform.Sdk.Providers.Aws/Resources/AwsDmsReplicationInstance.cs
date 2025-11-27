using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for kerberos_authentication_settings in AwsDmsReplicationInstance.
/// Nesting mode: list
/// </summary>
public class AwsDmsReplicationInstanceKerberosAuthenticationSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kerberos_authentication_settings";

    /// <summary>
    /// The key_cache_secret_iam_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyCacheSecretIamArn is required")]
    public required TerraformValue<string> KeyCacheSecretIamArn
    {
        get => new TerraformReference<string>(this, "key_cache_secret_iam_arn");
        set => SetArgument("key_cache_secret_iam_arn", value);
    }

    /// <summary>
    /// The key_cache_secret_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyCacheSecretId is required")]
    public required TerraformValue<string> KeyCacheSecretId
    {
        get => new TerraformReference<string>(this, "key_cache_secret_id");
        set => SetArgument("key_cache_secret_id", value);
    }

    /// <summary>
    /// The krb5_file_contents attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Krb5FileContents is required")]
    public required TerraformValue<string> Krb5FileContents
    {
        get => new TerraformReference<string>(this, "krb5_file_contents");
        set => SetArgument("krb5_file_contents", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsDmsReplicationInstance.
/// Nesting mode: single
/// </summary>
public class AwsDmsReplicationInstanceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_dms_replication_instance Terraform resource.
/// Manages a aws_dms_replication_instance resource.
/// </summary>
public partial class AwsDmsReplicationInstance(string name) : TerraformResource("aws_dms_replication_instance", name)
{
    /// <summary>
    /// The allocated_storage attribute.
    /// </summary>
    public TerraformValue<double> AllocatedStorage
    {
        get => new TerraformReference<double>(this, "allocated_storage");
        set => SetArgument("allocated_storage", value);
    }

    /// <summary>
    /// The allow_major_version_upgrade attribute.
    /// </summary>
    public TerraformValue<bool>? AllowMajorVersionUpgrade
    {
        get => new TerraformReference<bool>(this, "allow_major_version_upgrade");
        set => SetArgument("allow_major_version_upgrade", value);
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    public TerraformValue<bool>? ApplyImmediately
    {
        get => new TerraformReference<bool>(this, "apply_immediately");
        set => SetArgument("apply_immediately", value);
    }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public TerraformValue<bool> AutoMinorVersionUpgrade
    {
        get => new TerraformReference<bool>(this, "auto_minor_version_upgrade");
        set => SetArgument("auto_minor_version_upgrade", value);
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
    {
        get => new TerraformReference<string>(this, "availability_zone");
        set => SetArgument("availability_zone", value);
    }

    /// <summary>
    /// The dns_name_servers attribute.
    /// </summary>
    public TerraformValue<string>? DnsNameServers
    {
        get => new TerraformReference<string>(this, "dns_name_servers");
        set => SetArgument("dns_name_servers", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformValue<string> EngineVersion
    {
        get => new TerraformReference<string>(this, "engine_version");
        set => SetArgument("engine_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyArn
    {
        get => new TerraformReference<string>(this, "kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    public TerraformValue<bool> MultiAz
    {
        get => new TerraformReference<bool>(this, "multi_az");
        set => SetArgument("multi_az", value);
    }

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    public TerraformValue<string> NetworkType
    {
        get => new TerraformReference<string>(this, "network_type");
        set => SetArgument("network_type", value);
    }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public TerraformValue<string> PreferredMaintenanceWindow
    {
        get => new TerraformReference<string>(this, "preferred_maintenance_window");
        set => SetArgument("preferred_maintenance_window", value);
    }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformValue<bool> PubliclyAccessible
    {
        get => new TerraformReference<bool>(this, "publicly_accessible");
        set => SetArgument("publicly_accessible", value);
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
    /// The replication_instance_class attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationInstanceClass is required")]
    public required TerraformValue<string> ReplicationInstanceClass
    {
        get => new TerraformReference<string>(this, "replication_instance_class");
        set => SetArgument("replication_instance_class", value);
    }

    /// <summary>
    /// The replication_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationInstanceId is required")]
    public required TerraformValue<string> ReplicationInstanceId
    {
        get => new TerraformReference<string>(this, "replication_instance_id");
        set => SetArgument("replication_instance_id", value);
    }

    /// <summary>
    /// The replication_subnet_group_id attribute.
    /// </summary>
    public TerraformValue<string> ReplicationSubnetGroupId
    {
        get => new TerraformReference<string>(this, "replication_subnet_group_id");
        set => SetArgument("replication_subnet_group_id", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> VpcSecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "vpc_security_group_ids").ResolveNodes(ctx));
        set => SetArgument("vpc_security_group_ids", value);
    }

    /// <summary>
    /// The replication_instance_arn attribute.
    /// </summary>
    public TerraformValue<string> ReplicationInstanceArn
    {
        get => new TerraformReference<string>(this, "replication_instance_arn");
    }

    /// <summary>
    /// The replication_instance_private_ips attribute.
    /// </summary>
    public TerraformList<string> ReplicationInstancePrivateIps
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "replication_instance_private_ips").ResolveNodes(ctx));
    }

    /// <summary>
    /// The replication_instance_public_ips attribute.
    /// </summary>
    public TerraformList<string> ReplicationInstancePublicIps
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "replication_instance_public_ips").ResolveNodes(ctx));
    }

    /// <summary>
    /// KerberosAuthenticationSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KerberosAuthenticationSettings block(s) allowed")]
    public TerraformList<AwsDmsReplicationInstanceKerberosAuthenticationSettingsBlock>? KerberosAuthenticationSettings
    {
        get => GetArgument<TerraformList<AwsDmsReplicationInstanceKerberosAuthenticationSettingsBlock>>("kerberos_authentication_settings");
        set => SetArgument("kerberos_authentication_settings", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsDmsReplicationInstanceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsDmsReplicationInstanceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
