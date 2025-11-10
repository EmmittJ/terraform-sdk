using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_storage_buckets.
/// </summary>
public class GoogleStorageBucketsDataSource : TerraformDataSource
{
    public GoogleStorageBucketsDataSource(string name) : base("google_storage_buckets", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("buckets");
        SetOutput("id");
        SetOutput("prefix");
        SetOutput("project");
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
    /// The prefix attribute.
    /// </summary>
    public TerraformProperty<string> Prefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("prefix");
        set => SetProperty("prefix", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The buckets attribute.
    /// </summary>
    public TerraformExpression Buckets => this["buckets"];

}
