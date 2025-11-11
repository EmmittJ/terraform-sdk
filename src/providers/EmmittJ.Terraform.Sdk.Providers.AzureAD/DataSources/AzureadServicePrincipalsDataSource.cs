using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadServicePrincipalsDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azuread_service_principals.
/// </summary>
public partial class AzureadServicePrincipalsDataSource : TerraformDataSource
{
    public AzureadServicePrincipalsDataSource(string name) : base("azuread_service_principals", name)
    {
    }

    /// <summary>
    /// The client IDs of the applications associated with the service principals
    /// </summary>
    [TerraformProperty("client_ids")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> ClientIds { get; set; }

    /// <summary>
    /// The display names of the applications associated with the service principals
    /// </summary>
    [TerraformProperty("display_names")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> DisplayNames { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Ignore missing service principals and return the service principals that were found. The data source will still fail if no service principals are found
    /// </summary>
    [TerraformProperty("ignore_missing")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IgnoreMissing { get; set; }

    /// <summary>
    /// The object IDs of the service principals
    /// </summary>
    [TerraformProperty("object_ids")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> ObjectIds { get; set; }

    /// <summary>
    /// Fetch all service principals with no filter and return all that were found. The data source will still fail if no service principals are found.
    /// </summary>
    [TerraformProperty("return_all")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ReturnAll { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzureadServicePrincipalsDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// A list of service_principals
    /// </summary>
    [TerraformProperty("service_principals")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ServicePrincipals { get; }

}
