using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_efs_file_system resource.
/// </summary>
public class AwsEfsFileSystem : TerraformResource
{
    public AwsEfsFileSystem(string name) : base("aws_efs_file_system", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("availability_zone_id");
        this.DeclareOutput("dns_name");
        this.DeclareOutput("name");
        this.DeclareOutput("number_of_mount_targets");
        this.DeclareOutput("owner_id");
        this.DeclareOutput("size_in_bytes");
    }

    /// <summary>
    /// The availability_zone_name attribute.
    /// </summary>
    public string? AvailabilityZoneName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("availability_zone_name")?.Value;
        set => this.WithProperty("availability_zone_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The encrypted attribute.
    /// </summary>
    public bool? Encrypted
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("encrypted")?.Value;
        set => this.WithProperty("encrypted", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The kms_key_id attribute.
    /// </summary>
    public string? KmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_id")?.Value;
        set => this.WithProperty("kms_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The performance_mode attribute.
    /// </summary>
    public string? PerformanceMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("performance_mode")?.Value;
        set => this.WithProperty("performance_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The provisioned_throughput_in_mibps attribute.
    /// </summary>
    public double? ProvisionedThroughputInMibps
    {
        get => GetProperty<TerraformLiteralProperty<double>>("provisioned_throughput_in_mibps")?.Value;
        set => this.WithProperty("provisioned_throughput_in_mibps", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The throughput_mode attribute.
    /// </summary>
    public string? ThroughputMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("throughput_mode")?.Value;
        set => this.WithProperty("throughput_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
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
