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
        set => SetProperty("read", value);
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
        SetOutput("display_name_prefix");
        SetOutput("display_names");
        SetOutput("id");
        SetOutput("ignore_missing");
        SetOutput("mail_enabled");
        SetOutput("object_ids");
        SetOutput("return_all");
        SetOutput("security_enabled");
    }

    /// <summary>
    /// Common display name prefix of the groups
    /// </summary>
    public TerraformProperty<string> DisplayNamePrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name_prefix");
        set => SetProperty("display_name_prefix", value);
    }

    /// <summary>
    /// The display names of the groups
    /// </summary>
    public List<TerraformProperty<string>> DisplayNames
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("display_names");
        set => SetProperty("display_names", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Ignore missing groups and return groups that were found. The data source will still fail if no groups are found
    /// </summary>
    public TerraformProperty<bool> IgnoreMissing
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("ignore_missing");
        set => SetProperty("ignore_missing", value);
    }

    /// <summary>
    /// Whether the groups are mail-enabled
    /// </summary>
    public TerraformProperty<bool> MailEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("mail_enabled");
        set => SetProperty("mail_enabled", value);
    }

    /// <summary>
    /// The object IDs of the groups
    /// </summary>
    public List<TerraformProperty<string>> ObjectIds
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("object_ids");
        set => SetProperty("object_ids", value);
    }

    /// <summary>
    /// Retrieve all groups with no filter
    /// </summary>
    public TerraformProperty<bool> ReturnAll
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("return_all");
        set => SetProperty("return_all", value);
    }

    /// <summary>
    /// Whether the groups are security-enabled
    /// </summary>
    public TerraformProperty<bool> SecurityEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("security_enabled");
        set => SetProperty("security_enabled", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadGroupsDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
