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
        SetOutput("arn");
        SetOutput("availability_zone_id");
        SetOutput("availability_zone_name");
        SetOutput("dns_name");
        SetOutput("encrypted");
        SetOutput("kms_key_id");
        SetOutput("lifecycle_policy");
        SetOutput("name");
        SetOutput("performance_mode");
        SetOutput("protection");
        SetOutput("provisioned_throughput_in_mibps");
        SetOutput("size_in_bytes");
        SetOutput("throughput_mode");
        SetOutput("creation_token");
        SetOutput("file_system_id");
        SetOutput("id");
        SetOutput("region");
        SetOutput("tags");
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
    /// The file_system_id attribute.
    /// </summary>
    public TerraformProperty<string> FileSystemId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("file_system_id");
        set => SetProperty("file_system_id", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
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
