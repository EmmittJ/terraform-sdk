using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_data_catalog_policy_tag resource.
/// </summary>
public class GoogleDataCatalogPolicyTag : TerraformResource
{
    public GoogleDataCatalogPolicyTag(string name) : base("google_data_catalog_policy_tag", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("child_policy_tags");
        this.DeclareOutput("name");
    }

    /// <summary>
    /// Description of this policy tag. It must: contain only unicode characters, tabs,
    /// newlines, carriage returns and page breaks; and be at most 2000 bytes long when
    /// encoded in UTF-8. If not set, defaults to an empty description.
    /// If not set, defaults to an empty description.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// User defined name of this policy tag. It must: be unique within the parent
    /// taxonomy; contain only unicode letters, numbers, underscores, dashes and spaces;
    /// not start or end with spaces; and be at most 200 bytes long when encoded in UTF-8.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Resource name of this policy tag&#39;s parent policy tag.
    /// If empty, it means this policy tag is a top level policy tag.
    /// If not set, defaults to an empty string.
    /// </summary>
    public string? ParentPolicyTag
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent_policy_tag")?.Value;
        set => this.WithProperty("parent_policy_tag", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Taxonomy the policy tag is associated with
    /// </summary>
    public string? Taxonomy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("taxonomy")?.Value;
        set => this.WithProperty("taxonomy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Resource names of child policy tags of this policy tag.
    /// </summary>
    public TerraformExpression ChildPolicyTags => this["child_policy_tags"];

    /// <summary>
    /// Resource name of this policy tag, whose format is:
    /// &amp;quot;projects/{project}/locations/{region}/taxonomies/{taxonomy}/policyTags/{policytag}&amp;quot;
    /// </summary>
    public TerraformExpression Name => this["name"];

}
