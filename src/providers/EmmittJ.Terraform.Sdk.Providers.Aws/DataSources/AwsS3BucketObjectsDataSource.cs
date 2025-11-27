using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_s3_bucket_objects Terraform data source.
/// Retrieves information about a aws_s3_bucket_objects.
/// </summary>
[Obsolete("This resource is deprecated.")]
public partial class AwsS3BucketObjectsDataSource(string name) : TerraformDataSource("aws_s3_bucket_objects", name)
{
    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [Obsolete("This property is deprecated.")]
    public required TerraformValue<string> Bucket
    {
        get => new TerraformReference<string>(this, "bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The delimiter attribute.
    /// </summary>
    public TerraformValue<string>? Delimiter
    {
        get => new TerraformReference<string>(this, "delimiter");
        set => SetArgument("delimiter", value);
    }

    /// <summary>
    /// The encoding_type attribute.
    /// </summary>
    public TerraformValue<string>? EncodingType
    {
        get => new TerraformReference<string>(this, "encoding_type");
        set => SetArgument("encoding_type", value);
    }

    /// <summary>
    /// The fetch_owner attribute.
    /// </summary>
    public TerraformValue<bool>? FetchOwner
    {
        get => new TerraformReference<bool>(this, "fetch_owner");
        set => SetArgument("fetch_owner", value);
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
    /// The max_keys attribute.
    /// </summary>
    public TerraformValue<double>? MaxKeys
    {
        get => new TerraformReference<double>(this, "max_keys");
        set => SetArgument("max_keys", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => new TerraformReference<string>(this, "prefix");
        set => SetArgument("prefix", value);
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
    /// The start_after attribute.
    /// </summary>
    public TerraformValue<string>? StartAfter
    {
        get => new TerraformReference<string>(this, "start_after");
        set => SetArgument("start_after", value);
    }

    /// <summary>
    /// The common_prefixes attribute.
    /// </summary>
    public TerraformList<string> CommonPrefixes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "common_prefixes").ResolveNodes(ctx));
    }

    /// <summary>
    /// The keys attribute.
    /// </summary>
    public TerraformList<string> KeysAttribute
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "keys").ResolveNodes(ctx));
    }

    /// <summary>
    /// The owners attribute.
    /// </summary>
    public TerraformList<string> Owners
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "owners").ResolveNodes(ctx));
    }

}
