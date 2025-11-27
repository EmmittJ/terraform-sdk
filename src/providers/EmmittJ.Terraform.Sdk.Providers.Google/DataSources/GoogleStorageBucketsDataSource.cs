using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_storage_buckets Terraform data source.
/// Retrieves information about a google_storage_buckets.
/// </summary>
public partial class GoogleStorageBucketsDataSource(string name) : TerraformDataSource("google_storage_buckets", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The buckets attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Buckets
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "buckets").ResolveNodes(ctx));
    }

}
