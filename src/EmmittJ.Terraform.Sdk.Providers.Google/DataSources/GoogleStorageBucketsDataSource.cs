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
        this.DeclareOutput("buckets");
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
    /// The prefix attribute.
    /// </summary>
    public string? Prefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("prefix")?.Value;
        set => this.WithProperty("prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The buckets attribute.
    /// </summary>
    public TerraformExpression Buckets => this["buckets"];

}
