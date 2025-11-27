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
        get => new TerraformReference<string>(this, "creation_token");
        set => SetArgument("creation_token", value);
    }

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    public TerraformValue<string> FileSystemId
    {
        get => new TerraformReference<string>(this, "file_system_id");
        set => SetArgument("file_system_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZoneId
    {
        get => new TerraformReference<string>(this, "availability_zone_id");
    }

    /// <summary>
    /// The availability_zone_name attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZoneName
    {
        get => new TerraformReference<string>(this, "availability_zone_name");
    }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformValue<string> DnsName
    {
        get => new TerraformReference<string>(this, "dns_name");
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformValue<bool> Encrypted
    {
        get => new TerraformReference<bool>(this, "encrypted");
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
    }

    /// <summary>
    /// The lifecycle_policy attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> LifecyclePolicy
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "lifecycle_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The performance_mode attribute.
    /// </summary>
    public TerraformValue<string> PerformanceMode
    {
        get => new TerraformReference<string>(this, "performance_mode");
    }

    /// <summary>
    /// The protection attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Protection
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "protection").ResolveNodes(ctx));
    }

    /// <summary>
    /// The provisioned_throughput_in_mibps attribute.
    /// </summary>
    public TerraformValue<double> ProvisionedThroughputInMibps
    {
        get => new TerraformReference<double>(this, "provisioned_throughput_in_mibps");
    }

    /// <summary>
    /// The size_in_bytes attribute.
    /// </summary>
    public TerraformValue<double> SizeInBytes
    {
        get => new TerraformReference<double>(this, "size_in_bytes");
    }

    /// <summary>
    /// The throughput_mode attribute.
    /// </summary>
    public TerraformValue<string> ThroughputMode
    {
        get => new TerraformReference<string>(this, "throughput_mode");
    }

}
