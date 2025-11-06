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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The geographic location where the transfer config should reside.
    /// Examples: US, EU, asia-northeast1. The default value is US.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The full resource name of the resource the TagValue is bound to. E.g. //cloudresourcemanager.googleapis.com/projects/123
    /// </summary>
    public string? Parent
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent")?.Value;
        set => this.WithProperty("parent", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The TagValue of the TagBinding. Must be of the form tagValues/456.
    /// </summary>
    public string? TagValue
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tag_value")?.Value;
        set => this.WithProperty("tag_value", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The generated id for the TagBinding. This is a string of the form: &#39;tagBindings/{full-resource-name}/{tag-value-name}&#39;
    /// </summary>
    public TerraformExpression Name => this["name"];

}
