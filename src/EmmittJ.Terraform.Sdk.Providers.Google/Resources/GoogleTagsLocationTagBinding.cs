using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_tags_location_tag_binding resource.
/// </summary>
public class GoogleTagsLocationTagBinding : TerraformResource
{
    public GoogleTagsLocationTagBinding(string name) : base("google_tags_location_tag_binding", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
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
    /// The geographic location where the transfer config should reside.
    /// Examples: US, EU, asia-northeast1. The default value is US.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The full resource name of the resource the TagValue is bound to. E.g. //cloudresourcemanager.googleapis.com/projects/123
    /// </summary>
    public TerraformProperty<string>? Parent
    {
        get => GetProperty<TerraformProperty<string>>("parent");
        set => this.WithProperty("parent", value);
    }

    /// <summary>
    /// The TagValue of the TagBinding. Must be of the form tagValues/456.
    /// </summary>
    public TerraformProperty<string>? TagValue
    {
        get => GetProperty<TerraformProperty<string>>("tag_value");
        set => this.WithProperty("tag_value", value);
    }

    /// <summary>
    /// The generated id for the TagBinding. This is a string of the form: &#39;tagBindings/{full-resource-name}/{tag-value-name}&#39;
    /// </summary>
    public TerraformExpression Name => this["name"];

}
