using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_efs_file_system.
/// </summary>
public class AwsEfsFileSystemDataSource : TerraformDataSource
{
    public AwsEfsFileSystemDataSource(string name) : base("aws_efs_file_system", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("availability_zone_id");
        this.WithOutput("availability_zone_name");
        this.WithOutput("dns_name");
        this.WithOutput("encrypted");
        this.WithOutput("kms_key_id");
        this.WithOutput("lifecycle_policy");
        this.WithOutput("name");
        this.WithOutput("performance_mode");
        this.WithOutput("protection");
        this.WithOutput("provisioned_throughput_in_mibps");
        this.WithOutput("size_in_bytes");
        this.WithOutput("throughput_mode");
    }

    /// <summary>
    /// The creation_token attribute.
    /// </summary>
    public TerraformProperty<string>? CreationToken
    {
        get => GetProperty<TerraformProperty<string>>("creation_token");
        set => this.WithProperty("creation_token", value);
    }

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    public TerraformProperty<string>? FileSystemId
    {
        get => GetProperty<TerraformProperty<string>>("file_system_id");
        set => this.WithProperty("file_system_id", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
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
    /// The availability_zone_name attribute.
    /// </summary>
    public TerraformExpression AvailabilityZoneName => this["availability_zone_name"];

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformExpression DnsName => this["dns_name"];

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformExpression Encrypted => this["encrypted"];

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformExpression KmsKeyId => this["kms_key_id"];

    /// <summary>
    /// The lifecycle_policy attribute.
    /// </summary>
    public TerraformExpression LifecyclePolicy => this["lifecycle_policy"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The performance_mode attribute.
    /// </summary>
    public TerraformExpression PerformanceMode => this["performance_mode"];

    /// <summary>
    /// The protection attribute.
    /// </summary>
    public TerraformExpression Protection => this["protection"];

    /// <summary>
    /// The provisioned_throughput_in_mibps attribute.
    /// </summary>
    public TerraformExpression ProvisionedThroughputInMibps => this["provisioned_throughput_in_mibps"];

    /// <summary>
    /// The size_in_bytes attribute.
    /// </summary>
    public TerraformExpression SizeInBytes => this["size_in_bytes"];

    /// <summary>
    /// The throughput_mode attribute.
    /// </summary>
    public TerraformExpression ThroughputMode => this["throughput_mode"];

}
