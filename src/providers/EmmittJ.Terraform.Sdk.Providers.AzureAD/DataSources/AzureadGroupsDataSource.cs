using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadGroupsDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azuread_groups.
/// </summary>
public partial class AzureadGroupsDataSource : TerraformDataSource
{
    public AzureadGroupsDataSource(string name) : base("azuread_groups", name)
    {
    }

    /// <summary>
    /// Common display name prefix of the groups
    /// </summary>
    [TerraformProperty("display_name_prefix")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DisplayNamePrefix { get; set; }

    /// <summary>
    /// The display names of the groups
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
    /// Ignore missing groups and return groups that were found. The data source will still fail if no groups are found
    /// </summary>
    [TerraformProperty("ignore_missing")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IgnoreMissing { get; set; }

    /// <summary>
    /// Whether the groups are mail-enabled
    /// </summary>
    [TerraformProperty("mail_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> MailEnabled { get; set; }

    /// <summary>
    /// The object IDs of the groups
    /// </summary>
    [TerraformProperty("object_ids")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> ObjectIds { get; set; }

    /// <summary>
    /// Retrieve all groups with no filter
    /// </summary>
    [TerraformProperty("return_all")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ReturnAll { get; set; }

    /// <summary>
    /// Whether the groups are security-enabled
    /// </summary>
    [TerraformProperty("security_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> SecurityEnabled { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzureadGroupsDataSourceTimeoutsBlock Timeouts { get; set; } = new();

}
