using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_storage_bucket_objects Terraform data source.
/// Retrieves information about a google_storage_bucket_objects.
/// </summary>
public partial class GoogleStorageBucketObjectsDataSource(string name) : TerraformDataSource("google_storage_bucket_objects", name)
{
    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => new TerraformReference<string>(this, "bucket");
        set => SetArgument("bucket", value);
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
    /// The match_glob attribute.
    /// </summary>
    public TerraformValue<string>? MatchGlob
    {
        get => new TerraformReference<string>(this, "match_glob");
        set => SetArgument("match_glob", value);
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
    /// The bucket_objects attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> BucketObjects
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "bucket_objects").ResolveNodes(ctx));
    }

}
