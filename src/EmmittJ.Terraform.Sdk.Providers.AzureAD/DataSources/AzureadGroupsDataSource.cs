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
    public string? DisplayNamePrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name_prefix")?.Value;
        set => this.WithProperty("display_name_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The display names of the groups
    /// </summary>
    public List<string>? DisplayNames
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("display_names")?.Value;
        set => this.WithProperty("display_names", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Ignore missing groups and return groups that were found. The data source will still fail if no groups are found
    /// </summary>
    public bool? IgnoreMissing
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ignore_missing")?.Value;
        set => this.WithProperty("ignore_missing", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Whether the groups are mail-enabled
    /// </summary>
    public bool? MailEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("mail_enabled")?.Value;
        set => this.WithProperty("mail_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The object IDs of the groups
    /// </summary>
    public List<string>? ObjectIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("object_ids")?.Value;
        set => this.WithProperty("object_ids", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// Retrieve all groups with no filter
    /// </summary>
    public bool? ReturnAll
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("return_all")?.Value;
        set => this.WithProperty("return_all", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Whether the groups are security-enabled
    /// </summary>
    public bool? SecurityEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("security_enabled")?.Value;
        set => this.WithProperty("security_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

}
