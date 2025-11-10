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
        set => SetProperty("availability_zone", value);
    }

    /// <summary>
    /// The dns_name_servers attribute.
    /// </summary>
    public TerraformProperty<string>? DnsNameServers
    {
        set => SetProperty("dns_name_servers", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        set => SetProperty("kms_key_id", value);
    }

    /// <summary>
    /// The max_capacity_units attribute.
    /// </summary>
    public TerraformProperty<double>? MaxCapacityUnits
    {
        set => SetProperty("max_capacity_units", value);
    }

    /// <summary>
    /// The min_capacity_units attribute.
    /// </summary>
    public TerraformProperty<double>? MinCapacityUnits
    {
        set => SetProperty("min_capacity_units", value);
    }

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    public TerraformProperty<bool>? MultiAz
    {
        set => SetProperty("multi_az", value);
    }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public TerraformProperty<string>? PreferredMaintenanceWindow
    {
        set => SetProperty("preferred_maintenance_window", value);
    }

    /// <summary>
    /// The replication_subnet_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationSubnetGroupId is required")]
    public required TerraformProperty<string> ReplicationSubnetGroupId
    {
        set => SetProperty("replication_subnet_group_id", value);
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? VpcSecurityGroupIds
    {
        set => SetProperty("vpc_security_group_ids", value);
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
        SetOutput("arn");
        SetOutput("id");
        SetOutput("region");
        SetOutput("replication_config_identifier");
        SetOutput("replication_settings");
        SetOutput("replication_type");
        SetOutput("resource_identifier");
        SetOutput("source_endpoint_arn");
        SetOutput("start_replication");
        SetOutput("supplemental_settings");
        SetOutput("table_mappings");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("target_endpoint_arn");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The replication_config_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationConfigIdentifier is required")]
    public required TerraformProperty<string> ReplicationConfigIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("replication_config_identifier");
        set => SetProperty("replication_config_identifier", value);
    }

    /// <summary>
    /// The replication_settings attribute.
    /// </summary>
    public TerraformProperty<string> ReplicationSettings
    {
        get => GetRequiredOutput<TerraformProperty<string>>("replication_settings");
        set => SetProperty("replication_settings", value);
    }

    /// <summary>
    /// The replication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationType is required")]
    public required TerraformProperty<string> ReplicationType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("replication_type");
        set => SetProperty("replication_type", value);
    }

    /// <summary>
    /// The resource_identifier attribute.
    /// </summary>
    public TerraformProperty<string> ResourceIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_identifier");
        set => SetProperty("resource_identifier", value);
    }

    /// <summary>
    /// The source_endpoint_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceEndpointArn is required")]
    public required TerraformProperty<string> SourceEndpointArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_endpoint_arn");
        set => SetProperty("source_endpoint_arn", value);
    }

    /// <summary>
    /// The start_replication attribute.
    /// </summary>
    public TerraformProperty<bool> StartReplication
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("start_replication");
        set => SetProperty("start_replication", value);
    }

    /// <summary>
    /// The supplemental_settings attribute.
    /// </summary>
    public TerraformProperty<string> SupplementalSettings
    {
        get => GetRequiredOutput<TerraformProperty<string>>("supplemental_settings");
        set => SetProperty("supplemental_settings", value);
    }

    /// <summary>
    /// The table_mappings attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableMappings is required")]
    public required TerraformProperty<string> TableMappings
    {
        get => GetRequiredOutput<TerraformProperty<string>>("table_mappings");
        set => SetProperty("table_mappings", value);
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
    /// The target_endpoint_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetEndpointArn is required")]
    public required TerraformProperty<string> TargetEndpointArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_endpoint_arn");
        set => SetProperty("target_endpoint_arn", value);
    }

    /// <summary>
    /// Block for compute_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ComputeConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ComputeConfig block(s) allowed")]
    public List<AwsDmsReplicationConfigComputeConfigBlock>? ComputeConfig
    {
        set => SetProperty("compute_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDmsReplicationConfigTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
