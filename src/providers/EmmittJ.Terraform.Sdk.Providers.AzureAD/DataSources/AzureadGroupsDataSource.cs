using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadGroupsDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DisplayNamePrefix { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name_prefix");

    /// <summary>
    /// The display names of the groups
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
    /// Ignore missing groups and return groups that were found. The data source will still fail if no groups are found
    /// </summary>
    [TerraformPropertyName("ignore_missing")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IgnoreMissing { get; set; }

    /// <summary>
    /// Whether the groups are mail-enabled
    /// </summary>
    [TerraformPropertyName("mail_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> MailEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "mail_enabled");

    /// <summary>
    /// The object IDs of the groups
    /// </summary>
    [TerraformPropertyName("object_ids")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> ObjectIds { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "object_ids");

    /// <summary>
    /// Retrieve all groups with no filter
    /// </summary>
    [TerraformPropertyName("return_all")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ReturnAll { get; set; }

    /// <summary>
    /// Whether the groups are security-enabled
    /// </summary>
    [TerraformPropertyName("security_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> SecurityEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "security_enabled");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadGroupsDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

}
