using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_memorydb_snapshot Terraform data source.
/// Retrieves information about a aws_memorydb_snapshot.
/// </summary>
public partial class AwsMemorydbSnapshotDataSource(string name) : TerraformDataSource("aws_memorydb_snapshot", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The cluster_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ClusterConfiguration
        => AsReference("cluster_configuration");

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    public TerraformValue<string> ClusterName
        => AsReference("cluster_name");

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyArn
        => AsReference("kms_key_arn");

    /// <summary>
    /// The source attribute.
    /// </summary>
    public TerraformValue<string> Source
        => AsReference("source");

}
