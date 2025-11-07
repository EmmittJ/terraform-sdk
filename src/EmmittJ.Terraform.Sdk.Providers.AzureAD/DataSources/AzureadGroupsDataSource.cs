using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

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
    public TerraformLiteralProperty<string>? DisplayNamePrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name_prefix");
        set => this.WithProperty("display_name_prefix", value);
    }

    /// <summary>
    /// The display names of the groups
    /// </summary>
    public TerraformLiteralProperty<List<string>>? DisplayNames
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("display_names");
        set => this.WithProperty("display_names", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Ignore missing groups and return groups that were found. The data source will still fail if no groups are found
    /// </summary>
    public TerraformLiteralProperty<bool>? IgnoreMissing
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ignore_missing");
        set => this.WithProperty("ignore_missing", value);
    }

    /// <summary>
    /// Whether the groups are mail-enabled
    /// </summary>
    public TerraformLiteralProperty<bool>? MailEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("mail_enabled");
        set => this.WithProperty("mail_enabled", value);
    }

    /// <summary>
    /// The object IDs of the groups
    /// </summary>
    public TerraformLiteralProperty<List<string>>? ObjectIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("object_ids");
        set => this.WithProperty("object_ids", value);
    }

    /// <summary>
    /// Retrieve all groups with no filter
    /// </summary>
    public TerraformLiteralProperty<bool>? ReturnAll
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("return_all");
        set => this.WithProperty("return_all", value);
    }

    /// <summary>
    /// Whether the groups are security-enabled
    /// </summary>
    public TerraformLiteralProperty<bool>? SecurityEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("security_enabled");
        set => this.WithProperty("security_enabled", value);
    }

}
