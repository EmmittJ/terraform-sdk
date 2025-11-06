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
    public string? AssistantId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("assistant_id")?.Value;
        set => this.WithProperty("assistant_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The unique id of the collection.
    /// </summary>
    public string? CollectionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("collection_id")?.Value;
        set => this.WithProperty("collection_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Description for additional information. Expected to be shown on the
    /// configuration UI, not to the users of the assistant.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The assistant display name.
    /// 
    /// It must be a UTF-8 encoded string with a length limit of 128 characters.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The unique id of the engine.
    /// </summary>
    public string? EngineId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("engine_id")?.Value;
        set => this.WithProperty("engine_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The geographic location where the data store should reside. The value can
    /// only be one of &amp;quot;global&amp;quot;, &amp;quot;us&amp;quot; and &amp;quot;eu&amp;quot;.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The type of web grounding to use.
    /// The supported values: &#39;WEB_GROUNDING_TYPE_DISABLED&#39;, &#39;WEB_GROUNDING_TYPE_GOOGLE_SEARCH&#39;, &#39;WEB_GROUNDING_TYPE_ENTERPRISE_WEB_SEARCH&#39;.
    /// </summary>
    public string? WebGroundingType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("web_grounding_type")?.Value;
        set => this.WithProperty("web_grounding_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
