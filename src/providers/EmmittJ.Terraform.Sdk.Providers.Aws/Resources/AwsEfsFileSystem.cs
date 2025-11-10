using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for lifecycle_policy in .
/// Nesting mode: list
/// </summary>
public class AwsEfsFileSystemLifecyclePolicyBlock : TerraformBlock
{
    /// <summary>
    /// The transition_to_archive attribute.
    /// </summary>
    public TerraformProperty<string>? TransitionToArchive
    {
        set => SetProperty("transition_to_archive", value);
    }

    /// <summary>
    /// The transition_to_ia attribute.
    /// </summary>
    public TerraformProperty<string>? TransitionToIa
    {
        set => SetProperty("transition_to_ia", value);
    }

    /// <summary>
    /// The transition_to_primary_storage_class attribute.
    /// </summary>
    public TerraformProperty<string>? TransitionToPrimaryStorageClass
    {
        set => SetProperty("transition_to_primary_storage_class", value);
    }

}

/// <summary>
/// Block type for protection in .
/// Nesting mode: list
/// </summary>
public class AwsEfsFileSystemProtectionBlock : TerraformBlock
{
    /// <summary>
    /// The replication_overwrite attribute.
    /// </summary>
    public TerraformProperty<string>? ReplicationOverwrite
    {
        set => SetProperty("replication_overwrite", value);
    }

}

/// <summary>
/// Manages a aws_efs_file_system resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsEfsFileSystem : TerraformResource
{
    public AwsEfsFileSystem(string name) : base("aws_efs_file_system", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("availability_zone_id");
        SetOutput("dns_name");
        SetOutput("name");
        SetOutput("number_of_mount_targets");
        SetOutput("owner_id");
        SetOutput("size_in_bytes");
        SetOutput("availability_zone_name");
        SetOutput("creation_token");
        SetOutput("encrypted");
        SetOutput("id");
        SetOutput("kms_key_id");
        SetOutput("performance_mode");
        SetOutput("provisioned_throughput_in_mibps");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("throughput_mode");
    }

    /// <summary>
    /// The availability_zone_name attribute.
    /// </summary>
    public TerraformProperty<string> AvailabilityZoneName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("availability_zone_name");
        set => SetProperty("availability_zone_name", value);
    }

    /// <summary>
    /// The creation_token attribute.
    /// </summary>
    public TerraformProperty<string> CreationToken
    {
        get => GetRequiredOutput<TerraformProperty<string>>("creation_token");
        set => SetProperty("creation_token", value);
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformProperty<bool> Encrypted
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("encrypted");
        set => SetProperty("encrypted", value);
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
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string> KmsKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_id");
        set => SetProperty("kms_key_id", value);
    }

    /// <summary>
    /// The performance_mode attribute.
    /// </summary>
    public TerraformProperty<string> PerformanceMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("performance_mode");
        set => SetProperty("performance_mode", value);
    }

    /// <summary>
    /// The provisioned_throughput_in_mibps attribute.
    /// </summary>
    public TerraformProperty<double> ProvisionedThroughputInMibps
    {
        get => GetRequiredOutput<TerraformProperty<double>>("provisioned_throughput_in_mibps");
        set => SetProperty("provisioned_throughput_in_mibps", value);
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
    /// The throughput_mode attribute.
    /// </summary>
    public TerraformProperty<string> ThroughputMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("throughput_mode");
        set => SetProperty("throughput_mode", value);
    }

    /// <summary>
    /// Block for lifecycle_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 LifecyclePolicy block(s) allowed")]
    public List<AwsEfsFileSystemLifecyclePolicyBlock>? LifecyclePolicy
    {
        set => SetProperty("lifecycle_policy", value);
    }

    /// <summary>
    /// Block for protection.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Protection block(s) allowed")]
    public List<AwsEfsFileSystemProtectionBlock>? Protection
    {
        set => SetProperty("protection", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    public TerraformExpression AvailabilityZoneId => this["availability_zone_id"];

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformExpression DnsName => this["dns_name"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The number_of_mount_targets attribute.
    /// </summary>
    public TerraformExpression NumberOfMountTargets => this["number_of_mount_targets"];

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

    /// <summary>
    /// The size_in_bytes attribute.
    /// </summary>
    public TerraformExpression SizeInBytes => this["size_in_bytes"];

}
