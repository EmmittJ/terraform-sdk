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
    public List<string>? ActivatedPolicyTypes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("activated_policy_types")?.Value;
        set => this.WithProperty("activated_policy_types", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// Description of this taxonomy. It must: contain only unicode characters,
    /// tabs, newlines, carriage returns and page breaks; and be at most 2000 bytes
    /// long when encoded in UTF-8. If not set, defaults to an empty description.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// User defined name of this taxonomy.
    /// The taxonomy display name must be unique within an organization.
    /// It must: contain only unicode letters, numbers, underscores, dashes
    /// and spaces; not start or end with spaces; and be at most 200 bytes
    /// long when encoded in UTF-8.
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
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Taxonomy location region.
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Resource name of this taxonomy, whose format is:
    /// &amp;quot;projects/{project}/locations/{region}/taxonomies/{taxonomy}&amp;quot;.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
