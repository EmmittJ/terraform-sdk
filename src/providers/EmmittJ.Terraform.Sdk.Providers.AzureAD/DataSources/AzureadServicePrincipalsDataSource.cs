using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadServicePrincipalsDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> ClientIds { get; set; } = default!;

    /// <summary>
    /// The display names of the applications associated with the service principals
    /// </summary>
    [TerraformPropertyName("display_names")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> DisplayNames { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Ignore missing service principals and return the service principals that were found. The data source will still fail if no service principals are found
    /// </summary>
    [TerraformPropertyName("ignore_missing")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IgnoreMissing { get; set; }

    /// <summary>
    /// The object IDs of the service principals
    /// </summary>
    [TerraformPropertyName("object_ids")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> ObjectIds { get; set; } = default!;

    /// <summary>
    /// Fetch all service principals with no filter and return all that were found. The data source will still fail if no service principals are found.
    /// </summary>
    [TerraformPropertyName("return_all")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ReturnAll { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadServicePrincipalsDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// A list of service_principals
    /// </summary>
    [TerraformPropertyName("service_principals")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ServicePrincipals => new TerraformReference(this, "service_principals");

}
