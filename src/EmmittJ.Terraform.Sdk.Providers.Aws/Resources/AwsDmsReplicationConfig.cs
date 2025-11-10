using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for compute_config in .
/// Nesting mode: list
/// </summary>
public class AwsDmsReplicationConfigComputeConfigBlock : TerraformBlock
{
    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformProperty<string>? AvailabilityZone
    {
        get => GetProperty<TerraformProperty<string>>("availability_zone");
        set => WithProperty("availability_zone", value);
    }

    /// <summary>
    /// The dns_name_servers attribute.
    /// </summary>
    public TerraformProperty<string>? DnsNameServers
    {
        get => GetProperty<TerraformProperty<string>>("dns_name_servers");
        set => WithProperty("dns_name_servers", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_id");
        set => WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// The max_capacity_units attribute.
    /// </summary>
    public TerraformProperty<double>? MaxCapacityUnits
    {
        get => GetProperty<TerraformProperty<double>>("max_capacity_units");
        set => WithProperty("max_capacity_units", value);
    }

    /// <summary>
    /// The min_capacity_units attribute.
    /// </summary>
    public TerraformProperty<double>? MinCapacityUnits
    {
        get => GetProperty<TerraformProperty<double>>("min_capacity_units");
        set => WithProperty("min_capacity_units", value);
    }

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    public TerraformProperty<bool>? MultiAz
    {
        get => GetProperty<TerraformProperty<bool>>("multi_az");
        set => WithProperty("multi_az", value);
    }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public TerraformProperty<string>? PreferredMaintenanceWindow
    {
        get => GetProperty<TerraformProperty<string>>("preferred_maintenance_window");
        set => WithProperty("preferred_maintenance_window", value);
    }

    /// <summary>
    /// The replication_subnet_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationSubnetGroupId is required")]
    public required TerraformProperty<string> ReplicationSubnetGroupId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("replication_subnet_group_id");
        set => WithProperty("replication_subnet_group_id", value);
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? VpcSecurityGroupIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("vpc_security_group_ids");
        set => WithProperty("vpc_security_group_ids", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDmsReplicationConfigTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_dms_replication_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsDmsReplicationConfig : TerraformResource
{
    public AwsDmsReplicationConfig(string name) : base("aws_dms_replication_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// The replication_config_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationConfigIdentifier is required")]
    public required TerraformProperty<string> ReplicationConfigIdentifier
    {
        get => GetRequiredProperty<TerraformProperty<string>>("replication_config_identifier");
        set => this.WithProperty("replication_config_identifier", value);
    }

    /// <summary>
    /// The replication_settings attribute.
    /// </summary>
    public TerraformProperty<string>? ReplicationSettings
    {
        get => GetProperty<TerraformProperty<string>>("replication_settings");
        set => this.WithProperty("replication_settings", value);
    }

    /// <summary>
    /// The replication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationType is required")]
    public required TerraformProperty<string> ReplicationType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("replication_type");
        set => this.WithProperty("replication_type", value);
    }

    /// <summary>
    /// The resource_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("resource_identifier");
        set => this.WithProperty("resource_identifier", value);
    }

    /// <summary>
    /// The source_endpoint_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceEndpointArn is required")]
    public required TerraformProperty<string> SourceEndpointArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("source_endpoint_arn");
        set => this.WithProperty("source_endpoint_arn", value);
    }

    /// <summary>
    /// The start_replication attribute.
    /// </summary>
    public TerraformProperty<bool>? StartReplication
    {
        get => GetProperty<TerraformProperty<bool>>("start_replication");
        set => this.WithProperty("start_replication", value);
    }

    /// <summary>
    /// The supplemental_settings attribute.
    /// </summary>
    public TerraformProperty<string>? SupplementalSettings
    {
        get => GetProperty<TerraformProperty<string>>("supplemental_settings");
        set => this.WithProperty("supplemental_settings", value);
    }

    /// <summary>
    /// The table_mappings attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableMappings is required")]
    public required TerraformProperty<string> TableMappings
    {
        get => GetRequiredProperty<TerraformProperty<string>>("table_mappings");
        set => this.WithProperty("table_mappings", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The target_endpoint_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetEndpointArn is required")]
    public required TerraformProperty<string> TargetEndpointArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("target_endpoint_arn");
        set => this.WithProperty("target_endpoint_arn", value);
    }

    /// <summary>
    /// Block for compute_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ComputeConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ComputeConfig block(s) allowed")]
    public List<AwsDmsReplicationConfigComputeConfigBlock>? ComputeConfig
    {
        get => GetProperty<List<AwsDmsReplicationConfigComputeConfigBlock>>("compute_config");
        set => this.WithProperty("compute_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDmsReplicationConfigTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsDmsReplicationConfigTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
