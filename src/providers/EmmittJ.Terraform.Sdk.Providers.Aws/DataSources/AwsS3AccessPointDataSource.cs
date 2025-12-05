using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_s3_access_point Terraform data source.
/// Retrieves information about a aws_s3_access_point.
/// </summary>
public partial class AwsS3AccessPointDataSource(string name) : TerraformDataSource("aws_s3_access_point", name)
{
    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformValue<string> AccountId
    {
        get => GetArgument<TerraformValue<string>>("account_id") ?? CreateReference("account_id");
        set => SetArgument("account_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The alias attribute.
    /// </summary>
    public TerraformValue<string> Alias
        => CreateReference("alias");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    public TerraformValue<string> Bucket
        => CreateReference("bucket");

    /// <summary>
    /// The bucket_account_id attribute.
    /// </summary>
    public TerraformValue<string> BucketAccountId
        => CreateReference("bucket_account_id");

    /// <summary>
    /// The data_source_id attribute.
    /// </summary>
    public TerraformValue<string> DataSourceId
        => CreateReference("data_source_id");

    /// <summary>
    /// The data_source_type attribute.
    /// </summary>
    public TerraformValue<string> DataSourceTypeAttribute
        => CreateReference("data_source_type");

    /// <summary>
    /// The endpoints attribute.
    /// </summary>
    public TerraformMap<string> Endpoints
        => CreateReference("endpoints");

    /// <summary>
    /// The network_origin attribute.
    /// </summary>
    public TerraformValue<string> NetworkOrigin
        => CreateReference("network_origin");

    /// <summary>
    /// The public_access_block_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PublicAccessBlockConfiguration
        => CreateReference("public_access_block_configuration");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// The vpc_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> VpcConfiguration
        => CreateReference("vpc_configuration");

}
