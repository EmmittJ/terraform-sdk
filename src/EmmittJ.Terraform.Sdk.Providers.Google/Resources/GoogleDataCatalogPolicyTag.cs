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
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// User defined name of this policy tag. It must: be unique within the parent
    /// taxonomy; contain only unicode letters, numbers, underscores, dashes and spaces;
    /// not start or end with spaces; and be at most 200 bytes long when encoded in UTF-8.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// Resource name of this policy tag&#39;s parent policy tag.
    /// If empty, it means this policy tag is a top level policy tag.
    /// If not set, defaults to an empty string.
    /// </summary>
    public TerraformProperty<string>? ParentPolicyTag
    {
        get => GetProperty<TerraformProperty<string>>("parent_policy_tag");
        set => this.WithProperty("parent_policy_tag", value);
    }

    /// <summary>
    /// Taxonomy the policy tag is associated with
    /// </summary>
    public TerraformProperty<string>? Taxonomy
    {
        get => GetProperty<TerraformProperty<string>>("taxonomy");
        set => this.WithProperty("taxonomy", value);
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
