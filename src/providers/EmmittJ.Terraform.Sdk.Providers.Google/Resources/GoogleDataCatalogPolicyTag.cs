using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleDataCatalogPolicyTag.
/// Nesting mode: single
/// </summary>
public class GoogleDataCatalogPolicyTagTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_data_catalog_policy_tag Terraform resource.
/// Manages a google_data_catalog_policy_tag resource.
/// </summary>
public partial class GoogleDataCatalogPolicyTag(string name) : TerraformResource("google_data_catalog_policy_tag", name)
{
    /// <summary>
    /// Description of this policy tag. It must: contain only unicode characters, tabs,
    /// newlines, carriage returns and page breaks; and be at most 2000 bytes long when
    /// encoded in UTF-8. If not set, defaults to an empty description.
    /// If not set, defaults to an empty description.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// User defined name of this policy tag. It must: be unique within the parent
    /// taxonomy; contain only unicode letters, numbers, underscores, dashes and spaces;
    /// not start or end with spaces; and be at most 200 bytes long when encoded in UTF-8.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Resource name of this policy tag&#39;s parent policy tag.
    /// If empty, it means this policy tag is a top level policy tag.
    /// If not set, defaults to an empty string.
    /// </summary>
    public TerraformValue<string>? ParentPolicyTag
    {
        get => GetArgument<TerraformValue<string>>("parent_policy_tag");
        set => SetArgument("parent_policy_tag", value);
    }

    /// <summary>
    /// Taxonomy the policy tag is associated with
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Taxonomy is required")]
    public required TerraformValue<string> Taxonomy
    {
        get => GetArgument<TerraformValue<string>>("taxonomy");
        set => SetArgument("taxonomy", value);
    }

    /// <summary>
    /// Resource names of child policy tags of this policy tag.
    /// </summary>
    public TerraformList<string> ChildPolicyTags
        => AsReference("child_policy_tags");

    /// <summary>
    /// Resource name of this policy tag, whose format is:
    /// &amp;quot;projects/{project}/locations/{region}/taxonomies/{taxonomy}/policyTags/{policytag}&amp;quot;
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDataCatalogPolicyTagTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDataCatalogPolicyTagTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
