using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadGroupsDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azuread_groups.
/// </summary>
public class AzureadGroupsDataSource : TerraformDataSource
{
    public AzureadGroupsDataSource(string name) : base("azuread_groups", name)
    {
    }

    /// <summary>
    /// Common display name prefix of the groups
    /// </summary>
    [TerraformPropertyName("display_name_prefix")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DisplayNamePrefix { get; set; } = default!;

    /// <summary>
    /// The display names of the groups
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
    /// Ignore missing groups and return groups that were found. The data source will still fail if no groups are found
    /// </summary>
    [TerraformPropertyName("ignore_missing")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IgnoreMissing { get; set; }

    /// <summary>
    /// Whether the groups are mail-enabled
    /// </summary>
    [TerraformPropertyName("mail_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> MailEnabled { get; set; } = default!;

    /// <summary>
    /// The object IDs of the groups
    /// </summary>
    [TerraformPropertyName("object_ids")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> ObjectIds { get; set; } = default!;

    /// <summary>
    /// Retrieve all groups with no filter
    /// </summary>
    [TerraformPropertyName("return_all")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ReturnAll { get; set; }

    /// <summary>
    /// Whether the groups are security-enabled
    /// </summary>
    [TerraformPropertyName("security_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> SecurityEnabled { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadGroupsDataSourceTimeoutsBlock>? Timeouts { get; set; }

}
