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
        get => new TerraformReference<string>(this, "account_id");
        set => SetArgument("account_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The alias attribute.
    /// </summary>
    public TerraformValue<string> Alias
    {
        get => new TerraformReference<string>(this, "alias");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    public TerraformValue<string> Bucket
    {
        get => new TerraformReference<string>(this, "bucket");
    }

    /// <summary>
    /// The bucket_account_id attribute.
    /// </summary>
    public TerraformValue<string> BucketAccountId
    {
        get => new TerraformReference<string>(this, "bucket_account_id");
    }

    /// <summary>
    /// The data_source_id attribute.
    /// </summary>
    public TerraformValue<string> DataSourceId
    {
        get => new TerraformReference<string>(this, "data_source_id");
    }

    /// <summary>
    /// The data_source_type attribute.
    /// </summary>
    public TerraformValue<string> DataSourceTypeAttribute
    {
        get => new TerraformReference<string>(this, "data_source_type");
    }

    /// <summary>
    /// The endpoints attribute.
    /// </summary>
    public TerraformMap<string> Endpoints
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "endpoints").ResolveNodes(ctx));
    }

    /// <summary>
    /// The network_origin attribute.
    /// </summary>
    public TerraformValue<string> NetworkOrigin
    {
        get => new TerraformReference<string>(this, "network_origin");
    }

    /// <summary>
    /// The public_access_block_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PublicAccessBlockConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "public_access_block_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The vpc_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> VpcConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "vpc_configuration").ResolveNodes(ctx));
    }

}
