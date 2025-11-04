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
        this.DeclareOutput("arn");
        this.DeclareOutput("availability_zone_id");
        this.DeclareOutput("availability_zone_name");
        this.DeclareOutput("dns_name");
        this.DeclareOutput("encrypted");
        this.DeclareOutput("kms_key_id");
        this.DeclareOutput("lifecycle_policy");
        this.DeclareOutput("name");
        this.DeclareOutput("performance_mode");
        this.DeclareOutput("protection");
        this.DeclareOutput("provisioned_throughput_in_mibps");
        this.DeclareOutput("size_in_bytes");
        this.DeclareOutput("throughput_mode");
    }

    /// <summary>
    /// The creation_token attribute.
    /// </summary>
    public string? CreationToken
    {
        get => GetProperty<TerraformLiteralProperty<string>>("creation_token")?.Value;
        set => this.WithProperty("creation_token", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    public string? FileSystemId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("file_system_id")?.Value;
        set => this.WithProperty("file_system_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
