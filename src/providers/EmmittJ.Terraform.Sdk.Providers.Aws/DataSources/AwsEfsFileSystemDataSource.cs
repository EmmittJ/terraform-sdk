using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_efs_file_system Terraform data source.
/// Retrieves information about a aws_efs_file_system.
/// </summary>
public partial class AwsEfsFileSystemDataSource(string name) : TerraformDataSource("aws_efs_file_system", name)
{
    /// <summary>
    /// The creation_token attribute.
    /// </summary>
    public TerraformValue<string> CreationToken
    {
        get => GetArgument<TerraformValue<string>>("creation_token") ?? AsReference("creation_token");
        set => SetArgument("creation_token", value);
    }

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    public TerraformValue<string> FileSystemId
    {
        get => GetArgument<TerraformValue<string>>("file_system_id") ?? AsReference("file_system_id");
        set => SetArgument("file_system_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? AsReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZoneId
        => AsReference("availability_zone_id");

    /// <summary>
    /// The availability_zone_name attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZoneName
        => AsReference("availability_zone_name");

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformValue<string> DnsName
        => AsReference("dns_name");

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformValue<bool> Encrypted
        => AsReference("encrypted");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
        => AsReference("kms_key_id");

    /// <summary>
    /// The lifecycle_policy attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> LifecyclePolicy
        => AsReference("lifecycle_policy");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The performance_mode attribute.
    /// </summary>
    public TerraformValue<string> PerformanceMode
        => AsReference("performance_mode");

    /// <summary>
    /// The protection attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Protection
        => AsReference("protection");

    /// <summary>
    /// The provisioned_throughput_in_mibps attribute.
    /// </summary>
    public TerraformValue<double> ProvisionedThroughputInMibps
        => AsReference("provisioned_throughput_in_mibps");

    /// <summary>
    /// The size_in_bytes attribute.
    /// </summary>
    public TerraformValue<double> SizeInBytes
        => AsReference("size_in_bytes");

    /// <summary>
    /// The throughput_mode attribute.
    /// </summary>
    public TerraformValue<string> ThroughputMode
        => AsReference("throughput_mode");

}
