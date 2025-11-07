using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_discovery_engine_control resource.
/// </summary>
public class GoogleDiscoveryEngineControl : TerraformResource
{
    public GoogleDiscoveryEngineControl(string name) : base("google_discovery_engine_control", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
    }

    /// <summary>
    /// The collection ID. Currently only accepts &amp;quot;default_collection&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? CollectionId
    {
        get => GetProperty<TerraformProperty<string>>("collection_id");
        set => this.WithProperty("collection_id", value);
    }

    /// <summary>
    /// The unique id of the control.
    /// </summary>
    public TerraformProperty<string>? ControlId
    {
        get => GetProperty<TerraformProperty<string>>("control_id");
        set => this.WithProperty("control_id", value);
    }

    /// <summary>
    /// The display name of the control. This field must be a UTF-8 encoded
    /// string with a length limit of 128 characters.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The engine to add the control to.
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
    /// The solution type that the control belongs to. Possible values: [&amp;quot;SOLUTION_TYPE_RECOMMENDATION&amp;quot;, &amp;quot;SOLUTION_TYPE_SEARCH&amp;quot;, &amp;quot;SOLUTION_TYPE_CHAT&amp;quot;, &amp;quot;SOLUTION_TYPE_GENERATIVE_CHAT&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? SolutionType
    {
        get => GetProperty<TerraformProperty<string>>("solution_type");
        set => this.WithProperty("solution_type", value);
    }

    /// <summary>
    /// The use cases that the control is used for. Possible values: [&amp;quot;SEARCH_USE_CASE_SEARCH&amp;quot;, &amp;quot;SEARCH_USE_CASE_BROWSE&amp;quot;]
    /// </summary>
    public TerraformProperty<List<string>>? UseCases
    {
        get => GetProperty<TerraformProperty<List<string>>>("use_cases");
        set => this.WithProperty("use_cases", value);
    }

    /// <summary>
    /// The unique full resource name of the control. Values are of the format
    /// &#39;projects/{project}/locations/{location}/collections/{collection_id}/engines/{engine_id}/controls/{control_id}&#39;.
    /// This field must be a UTF-8 encoded string with a length limit of 1024
    /// characters.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
