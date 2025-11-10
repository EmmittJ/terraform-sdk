using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for kerberos_authentication_settings in .
/// Nesting mode: list
/// </summary>
public class AwsDmsReplicationInstanceKerberosAuthenticationSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The key_cache_secret_iam_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyCacheSecretIamArn is required")]
    public required TerraformProperty<string> KeyCacheSecretIamArn
    {
        set => SetProperty("key_cache_secret_iam_arn", value);
    }

    /// <summary>
    /// The key_cache_secret_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyCacheSecretId is required")]
    public required TerraformProperty<string> KeyCacheSecretId
    {
        set => SetProperty("key_cache_secret_id", value);
    }

    /// <summary>
    /// The krb5_file_contents attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Krb5FileContents is required")]
    public required TerraformProperty<string> Krb5FileContents
    {
        set => SetProperty("krb5_file_contents", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDmsReplicationInstanceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_dms_replication_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsDmsReplicationInstance : TerraformResource
{
    public AwsDmsReplicationInstance(string name) : base("aws_dms_replication_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("replication_instance_arn");
        SetOutput("replication_instance_private_ips");
        SetOutput("replication_instance_public_ips");
        SetOutput("allocated_storage");
        SetOutput("allow_major_version_upgrade");
        SetOutput("apply_immediately");
        SetOutput("auto_minor_version_upgrade");
        SetOutput("availability_zone");
        SetOutput("dns_name_servers");
        SetOutput("engine_version");
        SetOutput("id");
        SetOutput("kms_key_arn");
        SetOutput("multi_az");
        SetOutput("network_type");
        SetOutput("preferred_maintenance_window");
        SetOutput("publicly_accessible");
        SetOutput("region");
        SetOutput("replication_instance_class");
        SetOutput("replication_instance_id");
        SetOutput("replication_subnet_group_id");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("vpc_security_group_ids");
    }

    /// <summary>
    /// The allocated_storage attribute.
    /// </summary>
    public TerraformProperty<double> AllocatedStorage
    {
        get => GetRequiredOutput<TerraformProperty<double>>("allocated_storage");
        set => SetProperty("allocated_storage", value);
    }

    /// <summary>
    /// The allow_major_version_upgrade attribute.
    /// </summary>
    public TerraformProperty<bool> AllowMajorVersionUpgrade
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("allow_major_version_upgrade");
        set => SetProperty("allow_major_version_upgrade", value);
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    public TerraformProperty<bool> ApplyImmediately
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("apply_immediately");
        set => SetProperty("apply_immediately", value);
    }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public TerraformProperty<bool> AutoMinorVersionUpgrade
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("auto_minor_version_upgrade");
        set => SetProperty("auto_minor_version_upgrade", value);
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformProperty<string> AvailabilityZone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("availability_zone");
        set => SetProperty("availability_zone", value);
    }

    /// <summary>
    /// The dns_name_servers attribute.
    /// </summary>
    public TerraformProperty<string> DnsNameServers
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dns_name_servers");
        set => SetProperty("dns_name_servers", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformProperty<string> EngineVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("engine_version");
        set => SetProperty("engine_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string> KmsKeyArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_arn");
        set => SetProperty("kms_key_arn", value);
    }

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    public TerraformProperty<bool> MultiAz
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("multi_az");
        set => SetProperty("multi_az", value);
    }

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    public TerraformProperty<string> NetworkType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network_type");
        set => SetProperty("network_type", value);
    }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public TerraformProperty<string> PreferredMaintenanceWindow
    {
        get => GetRequiredOutput<TerraformProperty<string>>("preferred_maintenance_window");
        set => SetProperty("preferred_maintenance_window", value);
    }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformProperty<bool> PubliclyAccessible
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("publicly_accessible");
        set => SetProperty("publicly_accessible", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The replication_instance_class attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationInstanceClass is required")]
    public required TerraformProperty<string> ReplicationInstanceClass
    {
        get => GetRequiredOutput<TerraformProperty<string>>("replication_instance_class");
        set => SetProperty("replication_instance_class", value);
    }

    /// <summary>
    /// The replication_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationInstanceId is required")]
    public required TerraformProperty<string> ReplicationInstanceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("replication_instance_id");
        set => SetProperty("replication_instance_id", value);
    }

    /// <summary>
    /// The replication_subnet_group_id attribute.
    /// </summary>
    public TerraformProperty<string> ReplicationSubnetGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("replication_subnet_group_id");
        set => SetProperty("replication_subnet_group_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> VpcSecurityGroupIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("vpc_security_group_ids");
        set => SetProperty("vpc_security_group_ids", value);
    }

    /// <summary>
    /// Block for kerberos_authentication_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KerberosAuthenticationSettings block(s) allowed")]
    public List<AwsDmsReplicationInstanceKerberosAuthenticationSettingsBlock>? KerberosAuthenticationSettings
    {
        set => SetProperty("kerberos_authentication_settings", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDmsReplicationInstanceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The replication_instance_arn attribute.
    /// </summary>
    public TerraformExpression ReplicationInstanceArn => this["replication_instance_arn"];

    /// <summary>
    /// The replication_instance_private_ips attribute.
    /// </summary>
    public TerraformExpression ReplicationInstancePrivateIps => this["replication_instance_private_ips"];

    /// <summary>
    /// The replication_instance_public_ips attribute.
    /// </summary>
    public TerraformExpression ReplicationInstancePublicIps => this["replication_instance_public_ips"];

}
