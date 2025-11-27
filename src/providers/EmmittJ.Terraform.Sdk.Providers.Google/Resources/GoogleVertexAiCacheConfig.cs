using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleVertexAiCacheConfig.
/// Nesting mode: single
/// </summary>
public class GoogleVertexAiCacheConfigTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_vertex_ai_cache_config Terraform resource.
/// Manages a google_vertex_ai_cache_config resource.
/// </summary>
public partial class GoogleVertexAiCacheConfig(string name) : TerraformResource("google_vertex_ai_cache_config", name)
{
    /// <summary>
    /// If set to true, disables GenAI caching. Otherwise caching is enabled.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisableCache is required")]
    public required TerraformValue<bool> DisableCache
    {
        get => new TerraformReference<bool>(this, "disable_cache");
        set => SetArgument("disable_cache", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Identifier. name of the cache config. Format: - &#39;projects/{project}/cacheConfig&#39;.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleVertexAiCacheConfigTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleVertexAiCacheConfigTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
