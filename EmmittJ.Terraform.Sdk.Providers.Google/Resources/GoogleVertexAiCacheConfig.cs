using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_vertex_ai_cache_config resource.
/// </summary>
public class GoogleVertexAiCacheConfig : TerraformResource
{
    public GoogleVertexAiCacheConfig(string name) : base("google_vertex_ai_cache_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
    }

    /// <summary>
    /// If set to true, disables GenAI caching. Otherwise caching is enabled.
    /// </summary>
    public bool? DisableCache
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disable_cache")?.Value;
        set => this.WithProperty("disable_cache", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Identifier. name of the cache config. Format: - &#39;projects/{project}/cacheConfig&#39;.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
