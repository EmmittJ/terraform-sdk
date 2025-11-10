using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleVertexAiCacheConfigTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisableCache is required")]
    public required TerraformProperty<bool> DisableCache
    {
        get => GetProperty<TerraformProperty<bool>>("disable_cache");
        set => this.WithProperty("disable_cache", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleVertexAiCacheConfigTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleVertexAiCacheConfigTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Identifier. name of the cache config. Format: - &#39;projects/{project}/cacheConfig&#39;.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
