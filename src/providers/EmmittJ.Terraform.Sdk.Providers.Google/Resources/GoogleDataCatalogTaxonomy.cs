using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleDataCatalogTaxonomy.
/// Nesting mode: single
/// </summary>
public class GoogleDataCatalogTaxonomyTimeoutsBlock : TerraformBlock
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
/// Represents a google_data_catalog_taxonomy Terraform resource.
/// Manages a google_data_catalog_taxonomy resource.
/// </summary>
public partial class GoogleDataCatalogTaxonomy(string name) : TerraformResource("google_data_catalog_taxonomy", name)
{
    /// <summary>
    /// A list of policy types that are activated for this taxonomy. If not set,
    /// defaults to an empty list. Possible values: [&amp;quot;POLICY_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;FINE_GRAINED_ACCESS_CONTROL&amp;quot;]
    /// </summary>
    public TerraformList<string>? ActivatedPolicyTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "activated_policy_types").ResolveNodes(ctx));
        set => SetArgument("activated_policy_types", value);
    }

    /// <summary>
    /// Description of this taxonomy. It must: contain only unicode characters,
    /// tabs, newlines, carriage returns and page breaks; and be at most 2000 bytes
    /// long when encoded in UTF-8. If not set, defaults to an empty description.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// User defined name of this taxonomy.
    /// The taxonomy display name must be unique within an organization.
    /// It must: contain only unicode letters, numbers, underscores, dashes
    /// and spaces; not start or end with spaces; and be at most 200 bytes
    /// long when encoded in UTF-8.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
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
    /// Taxonomy location region.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// Resource name of this taxonomy, whose format is:
    /// &amp;quot;projects/{project}/locations/{region}/taxonomies/{taxonomy}&amp;quot;.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDataCatalogTaxonomyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDataCatalogTaxonomyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
