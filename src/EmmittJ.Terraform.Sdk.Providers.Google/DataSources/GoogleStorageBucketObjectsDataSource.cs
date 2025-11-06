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
    public string? Bucket
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bucket")?.Value;
        set => this.WithProperty("bucket", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The match_glob attribute.
    /// </summary>
    public string? MatchGlob
    {
        get => GetProperty<TerraformLiteralProperty<string>>("match_glob")?.Value;
        set => this.WithProperty("match_glob", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public string? Prefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("prefix")?.Value;
        set => this.WithProperty("prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The bucket_objects attribute.
    /// </summary>
    public TerraformExpression BucketObjects => this["bucket_objects"];

}
