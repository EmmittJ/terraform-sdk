using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataCatalogTaxonomyTimeoutsBlock : TerraformBlock
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
/// Manages a google_data_catalog_taxonomy resource.
/// </summary>
public class GoogleDataCatalogTaxonomy : TerraformResource
{
    public GoogleDataCatalogTaxonomy(string name) : base("google_data_catalog_taxonomy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("name");
        SetOutput("activated_policy_types");
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("project");
        SetOutput("region");
    }

    /// <summary>
    /// A list of policy types that are activated for this taxonomy. If not set,
    /// defaults to an empty list. Possible values: [&amp;quot;POLICY_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;FINE_GRAINED_ACCESS_CONTROL&amp;quot;]
    /// </summary>
    public List<TerraformProperty<string>> ActivatedPolicyTypes
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("activated_policy_types");
        set => SetProperty("activated_policy_types", value);
    }

    /// <summary>
    /// Description of this taxonomy. It must: contain only unicode characters,
    /// tabs, newlines, carriage returns and page breaks; and be at most 2000 bytes
    /// long when encoded in UTF-8. If not set, defaults to an empty description.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// User defined name of this taxonomy.
    /// The taxonomy display name must be unique within an organization.
    /// It must: contain only unicode letters, numbers, underscores, dashes
    /// and spaces; not start or end with spaces; and be at most 200 bytes
    /// long when encoded in UTF-8.
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
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Taxonomy location region.
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDataCatalogTaxonomyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Resource name of this taxonomy, whose format is:
    /// &amp;quot;projects/{project}/locations/{region}/taxonomies/{taxonomy}&amp;quot;.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
