using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for timeouts in AzureadGroupsDataSource.
/// Nesting mode: single
/// </summary>
public class AzureadGroupsDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azuread_groups Terraform data source.
/// Retrieves information about a azuread_groups.
/// </summary>
public partial class AzureadGroupsDataSource(string name) : TerraformDataSource("azuread_groups", name)
{
    /// <summary>
    /// Common display name prefix of the groups
    /// </summary>
    public TerraformValue<string>? DisplayNamePrefix
    {
        get => GetArgument<TerraformValue<string>>("display_name_prefix");
        set => SetArgument("display_name_prefix", value);
    }

    /// <summary>
    /// The display names of the groups
    /// </summary>
    public TerraformList<string>? DisplayNames
    {
        get => GetArgument<TerraformList<string>>("display_names");
        set => SetArgument("display_names", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Ignore missing groups and return groups that were found. The data source will still fail if no groups are found
    /// </summary>
    public TerraformValue<bool>? IgnoreMissing
    {
        get => GetArgument<TerraformValue<bool>>("ignore_missing");
        set => SetArgument("ignore_missing", value);
    }

    /// <summary>
    /// Whether the groups are mail-enabled
    /// </summary>
    public TerraformValue<bool>? MailEnabled
    {
        get => GetArgument<TerraformValue<bool>>("mail_enabled");
        set => SetArgument("mail_enabled", value);
    }

    /// <summary>
    /// The object IDs of the groups
    /// </summary>
    public TerraformList<string>? ObjectIds
    {
        get => GetArgument<TerraformList<string>>("object_ids");
        set => SetArgument("object_ids", value);
    }

    /// <summary>
    /// Retrieve all groups with no filter
    /// </summary>
    public TerraformValue<bool>? ReturnAll
    {
        get => GetArgument<TerraformValue<bool>>("return_all");
        set => SetArgument("return_all", value);
    }

    /// <summary>
    /// Whether the groups are security-enabled
    /// </summary>
    public TerraformValue<bool>? SecurityEnabled
    {
        get => GetArgument<TerraformValue<bool>>("security_enabled");
        set => SetArgument("security_enabled", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadGroupsDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadGroupsDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
