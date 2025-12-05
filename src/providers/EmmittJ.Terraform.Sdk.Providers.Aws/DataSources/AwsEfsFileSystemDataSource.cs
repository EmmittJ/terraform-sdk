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
        get => GetArgument<TerraformValue<string>>("creation_token") ?? CreateReference("creation_token");
        set => SetArgument("creation_token", value);
    }

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    public TerraformValue<string> FileSystemId
    {
        get => GetArgument<TerraformValue<string>>("file_system_id") ?? CreateReference("file_system_id");
        set => SetArgument("file_system_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? CreateReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZoneId
        => CreateReference("availability_zone_id");

    /// <summary>
    /// The availability_zone_name attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZoneName
        => CreateReference("availability_zone_name");

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformValue<string> DnsName
        => CreateReference("dns_name");

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformValue<bool> Encrypted
        => CreateReference("encrypted");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
        => CreateReference("kms_key_id");

    /// <summary>
    /// The lifecycle_policy attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> LifecyclePolicy
        => CreateReference("lifecycle_policy");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// The performance_mode attribute.
    /// </summary>
    public TerraformValue<string> PerformanceMode
        => CreateReference("performance_mode");

    /// <summary>
    /// The protection attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Protection
        => CreateReference("protection");

    /// <summary>
    /// The provisioned_throughput_in_mibps attribute.
    /// </summary>
    public TerraformValue<double> ProvisionedThroughputInMibps
        => CreateReference("provisioned_throughput_in_mibps");

    /// <summary>
    /// The size_in_bytes attribute.
    /// </summary>
    public TerraformValue<double> SizeInBytes
        => CreateReference("size_in_bytes");

    /// <summary>
    /// The throughput_mode attribute.
    /// </summary>
    public TerraformValue<string> ThroughputMode
        => CreateReference("throughput_mode");

}
