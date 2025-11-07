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
    public TerraformLiteralProperty<string>? AvailabilityZoneName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("availability_zone_name");
        set => this.WithProperty("availability_zone_name", value);
    }

    /// <summary>
    /// The creation_token attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CreationToken
    {
        get => GetProperty<TerraformLiteralProperty<string>>("creation_token");
        set => this.WithProperty("creation_token", value);
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Encrypted
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("encrypted");
        set => this.WithProperty("encrypted", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_id");
        set => this.WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// The performance_mode attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PerformanceMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("performance_mode");
        set => this.WithProperty("performance_mode", value);
    }

    /// <summary>
    /// The provisioned_throughput_in_mibps attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? ProvisionedThroughputInMibps
    {
        get => GetProperty<TerraformLiteralProperty<double>>("provisioned_throughput_in_mibps");
        set => this.WithProperty("provisioned_throughput_in_mibps", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The throughput_mode attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ThroughputMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("throughput_mode");
        set => this.WithProperty("throughput_mode", value);
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
