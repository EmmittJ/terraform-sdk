using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_discovery_engine_assistant resource.
/// </summary>
public class GoogleDiscoveryEngineAssistant : TerraformResource
{
    public GoogleDiscoveryEngineAssistant(string name) : base("google_discovery_engine_assistant", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
    }

    /// <summary>
    /// The unique id of the assistant.
    /// </summary>
    public TerraformProperty<string>? AssistantId
    {
        get => GetProperty<TerraformProperty<string>>("assistant_id");
        set => this.WithProperty("assistant_id", value);
    }

    /// <summary>
    /// The unique id of the collection.
    /// </summary>
    public TerraformProperty<string>? CollectionId
    {
        get => GetProperty<TerraformProperty<string>>("collection_id");
        set => this.WithProperty("collection_id", value);
    }

    /// <summary>
    /// Description for additional information. Expected to be shown on the
    /// configuration UI, not to the users of the assistant.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The assistant display name.
    /// 
    /// It must be a UTF-8 encoded string with a length limit of 128 characters.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The unique id of the engine.
    /// </summary>
    public TerraformProperty<string>? EngineId
    {
        get => GetProperty<TerraformProperty<string>>("engine_id");
        set => this.WithProperty("engine_id", value);
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
    /// The geographic location where the data store should reside. The value can
    /// only be one of &amp;quot;global&amp;quot;, &amp;quot;us&amp;quot; and &amp;quot;eu&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The type of web grounding to use.
    /// The supported values: &#39;WEB_GROUNDING_TYPE_DISABLED&#39;, &#39;WEB_GROUNDING_TYPE_GOOGLE_SEARCH&#39;, &#39;WEB_GROUNDING_TYPE_ENTERPRISE_WEB_SEARCH&#39;.
    /// </summary>
    public TerraformProperty<string>? WebGroundingType
    {
        get => GetProperty<TerraformProperty<string>>("web_grounding_type");
        set => this.WithProperty("web_grounding_type", value);
    }

    /// <summary>
    /// Resource name of the assistant.
    /// Format:
    /// &#39;projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/assistants/{assistant}&#39;
    /// 
    /// It must be a UTF-8 encoded string with a length limit of 1024 characters.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
