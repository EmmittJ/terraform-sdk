using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadGroupsDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azuread_groups.
/// </summary>
public class AzureadGroupsDataSource : TerraformDataSource
{
    public AzureadGroupsDataSource(string name) : base("azuread_groups", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// Common display name prefix of the groups
    /// </summary>
    public TerraformProperty<string>? DisplayNamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("display_name_prefix");
        set => this.WithProperty("display_name_prefix", value);
    }

    /// <summary>
    /// The display names of the groups
    /// </summary>
    public List<TerraformProperty<string>>? DisplayNames
    {
        get => GetProperty<List<TerraformProperty<string>>>("display_names");
        set => this.WithProperty("display_names", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Ignore missing groups and return groups that were found. The data source will still fail if no groups are found
    /// </summary>
    public TerraformProperty<bool>? IgnoreMissing
    {
        get => GetProperty<TerraformProperty<bool>>("ignore_missing");
        set => this.WithProperty("ignore_missing", value);
    }

    /// <summary>
    /// Whether the groups are mail-enabled
    /// </summary>
    public TerraformProperty<bool>? MailEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("mail_enabled");
        set => this.WithProperty("mail_enabled", value);
    }

    /// <summary>
    /// The object IDs of the groups
    /// </summary>
    public List<TerraformProperty<string>>? ObjectIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("object_ids");
        set => this.WithProperty("object_ids", value);
    }

    /// <summary>
    /// Retrieve all groups with no filter
    /// </summary>
    public TerraformProperty<bool>? ReturnAll
    {
        get => GetProperty<TerraformProperty<bool>>("return_all");
        set => this.WithProperty("return_all", value);
    }

    /// <summary>
    /// Whether the groups are security-enabled
    /// </summary>
    public TerraformProperty<bool>? SecurityEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("security_enabled");
        set => this.WithProperty("security_enabled", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadGroupsDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzureadGroupsDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
