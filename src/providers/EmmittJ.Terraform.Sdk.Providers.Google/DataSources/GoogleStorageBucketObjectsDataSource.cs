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
        SetOutput("bucket_objects");
        SetOutput("bucket");
        SetOutput("id");
        SetOutput("match_glob");
        SetOutput("prefix");
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformProperty<string> Bucket
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bucket");
        set => SetProperty("bucket", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The match_glob attribute.
    /// </summary>
    public TerraformProperty<string> MatchGlob
    {
        get => GetRequiredOutput<TerraformProperty<string>>("match_glob");
        set => SetProperty("match_glob", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformProperty<string> Prefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("prefix");
        set => SetProperty("prefix", value);
    }

    /// <summary>
    /// The bucket_objects attribute.
    /// </summary>
    public TerraformExpression BucketObjects => this["bucket_objects"];

}
