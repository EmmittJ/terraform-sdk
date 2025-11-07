using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_project_usage_export_bucket resource.
/// </summary>
public class GoogleProjectUsageExportBucket : TerraformResource
{
    public GoogleProjectUsageExportBucket(string name) : base("google_project_usage_export_bucket", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The bucket to store reports in.
    /// </summary>
    public TerraformLiteralProperty<string>? BucketName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bucket_name");
        set => this.WithProperty("bucket_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// A prefix for the reports, for instance, the project name.
    /// </summary>
    public TerraformLiteralProperty<string>? Prefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("prefix");
        set => this.WithProperty("prefix", value);
    }

    /// <summary>
    /// The project to set the export bucket on. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

}
