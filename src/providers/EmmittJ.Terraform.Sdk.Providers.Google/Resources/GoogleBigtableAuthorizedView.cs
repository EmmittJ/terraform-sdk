using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for subset_view in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigtableAuthorizedViewSubsetViewBlock : TerraformBlockBase
{
    /// <summary>
    /// Base64-encoded row prefixes to be included in the authorized view. To provide access to all rows, include the empty string as a prefix (&amp;quot;&amp;quot;).
    /// </summary>
    [TerraformProperty("row_prefixes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? RowPrefixes { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleBigtableAuthorizedViewTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_bigtable_authorized_view resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleBigtableAuthorizedView : TerraformResource
{
    public GoogleBigtableAuthorizedView(string name) : base("google_bigtable_authorized_view", name)
    {
    }

    /// <summary>
    /// A field to make the authorized view protected against data loss i.e. when set to PROTECTED, deleting the authorized view, the table containing the authorized view, and the instance containing the authorized view would be prohibited.
    /// If not provided, currently deletion protection will be set to UNPROTECTED as it is the API default value. Note this field configs the deletion protection provided by the API in the backend, and should not be confused with Terraform-side deletion protection.
    /// </summary>
    [TerraformProperty("deletion_protection")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DeletionProtection { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name of the Bigtable instance in which the authorized view belongs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceName is required")]
    [TerraformProperty("instance_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InstanceName { get; set; }

    /// <summary>
    /// The name of the authorized view. Must be 1-50 characters and must only contain hyphens, underscores, periods, letters and numbers.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The name of the Bigtable table in which the authorized view belongs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    [TerraformProperty("table_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TableName { get; set; }

    /// <summary>
    /// Block for subset_view.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SubsetView block(s) allowed")]
    [TerraformProperty("subset_view")]
    public partial TerraformList<TerraformBlock<GoogleBigtableAuthorizedViewSubsetViewBlock>>? SubsetView { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleBigtableAuthorizedViewTimeoutsBlock>? Timeouts { get; set; }

}
