using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadApplicationPublishedAppIdsDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azuread_application_published_app_ids.
/// </summary>
public class AzureadApplicationPublishedAppIdsDataSource : TerraformDataSource
{
    public AzureadApplicationPublishedAppIdsDataSource(string name) : base("azuread_application_published_app_ids", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadApplicationPublishedAppIdsDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// A mapping of application names and application IDs
    /// </summary>
    [TerraformPropertyName("result")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Result => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "result");

}
