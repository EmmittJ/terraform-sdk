using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_data_catalog_taxonomy_iam_policy Terraform data source.
/// Retrieves information about a google_data_catalog_taxonomy_iam_policy.
/// </summary>
public partial class GoogleDataCatalogTaxonomyIamPolicyDataSource(string name) : TerraformDataSource("google_data_catalog_taxonomy_iam_policy", name)
{
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
    /// The region attribute.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The taxonomy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Taxonomy is required")]
    public required TerraformValue<string> Taxonomy
    {
        get => new TerraformReference<string>(this, "taxonomy");
        set => SetArgument("taxonomy", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    public TerraformValue<string> PolicyData
    {
        get => new TerraformReference<string>(this, "policy_data");
    }

}
