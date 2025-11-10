using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadServicePrincipalsDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azuread_service_principals.
/// </summary>
public class AzureadServicePrincipalsDataSource : TerraformDataSource
{
    public AzureadServicePrincipalsDataSource(string name) : base("azuread_service_principals", name)
    {
    }

    /// <summary>
    /// The client IDs of the applications associated with the service principals
    /// </summary>
    [TerraformPropertyName("client_ids")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> ClientIds { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "client_ids");

    /// <summary>
    /// The display names of the applications associated with the service principals
    /// </summary>
    [TerraformPropertyName("display_names")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> DisplayNames { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "display_names");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Ignore missing service principals and return the service principals that were found. The data source will still fail if no service principals are found
    /// </summary>
    [TerraformPropertyName("ignore_missing")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IgnoreMissing { get; set; }

    /// <summary>
    /// The object IDs of the service principals
    /// </summary>
    [TerraformPropertyName("object_ids")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> ObjectIds { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "object_ids");

    /// <summary>
    /// Fetch all service principals with no filter and return all that were found. The data source will still fail if no service principals are found.
    /// </summary>
    [TerraformPropertyName("return_all")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ReturnAll { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadServicePrincipalsDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// A list of service_principals
    /// </summary>
    [TerraformPropertyName("service_principals")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ServicePrincipals => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "service_principals");

}
