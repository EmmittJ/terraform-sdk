using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataCatalogPolicyTagTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

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
        SetOutput("child_policy_tags");
        SetOutput("name");
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("parent_policy_tag");
        SetOutput("taxonomy");
    }

    /// <summary>
    /// Description of this policy tag. It must: contain only unicode characters, tabs,
    /// newlines, carriage returns and page breaks; and be at most 2000 bytes long when
    /// encoded in UTF-8. If not set, defaults to an empty description.
    /// If not set, defaults to an empty description.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// User defined name of this policy tag. It must: be unique within the parent
    /// taxonomy; contain only unicode letters, numbers, underscores, dashes and spaces;
    /// not start or end with spaces; and be at most 200 bytes long when encoded in UTF-8.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Resource name of this policy tag&#39;s parent policy tag.
    /// If empty, it means this policy tag is a top level policy tag.
    /// If not set, defaults to an empty string.
    /// </summary>
    public TerraformProperty<string> ParentPolicyTag
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parent_policy_tag");
        set => SetProperty("parent_policy_tag", value);
    }

    /// <summary>
    /// Taxonomy the policy tag is associated with
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Taxonomy is required")]
    public required TerraformProperty<string> Taxonomy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("taxonomy");
        set => SetProperty("taxonomy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDataCatalogPolicyTagTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
