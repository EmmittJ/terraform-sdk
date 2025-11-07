using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
        this.DeclareOutput("name");
    }

    /// <summary>
    /// A list of policy types that are activated for this taxonomy. If not set,
    /// defaults to an empty list. Possible values: [&amp;quot;POLICY_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;FINE_GRAINED_ACCESS_CONTROL&amp;quot;]
    /// </summary>
    public TerraformProperty<List<string>>? ActivatedPolicyTypes
    {
        get => GetProperty<TerraformProperty<List<string>>>("activated_policy_types");
        set => this.WithProperty("activated_policy_types", value);
    }

    /// <summary>
    /// Description of this taxonomy. It must: contain only unicode characters,
    /// tabs, newlines, carriage returns and page breaks; and be at most 2000 bytes
    /// long when encoded in UTF-8. If not set, defaults to an empty description.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// User defined name of this taxonomy.
    /// The taxonomy display name must be unique within an organization.
    /// It must: contain only unicode letters, numbers, underscores, dashes
    /// and spaces; not start or end with spaces; and be at most 200 bytes
    /// long when encoded in UTF-8.
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
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Taxonomy location region.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Resource name of this taxonomy, whose format is:
    /// &amp;quot;projects/{project}/locations/{region}/taxonomies/{taxonomy}&amp;quot;.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
