using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_storage_bucket_objects.
/// </summary>
public class GoogleStorageBucketObjectsDataSource : TerraformDataSource
{
    public GoogleStorageBucketObjectsDataSource(string name) : base("google_storage_bucket_objects", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("bucket_objects");
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    public TerraformProperty<string>? Bucket
    {
        get => GetProperty<TerraformProperty<string>>("bucket");
        set => this.WithProperty("bucket", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The match_glob attribute.
    /// </summary>
    public TerraformProperty<string>? MatchGlob
    {
        get => GetProperty<TerraformProperty<string>>("match_glob");
        set => this.WithProperty("match_glob", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformProperty<string>? Prefix
    {
        get => GetProperty<TerraformProperty<string>>("prefix");
        set => this.WithProperty("prefix", value);
    }

    /// <summary>
    /// The bucket_objects attribute.
    /// </summary>
    public TerraformExpression BucketObjects => this["bucket_objects"];

}
