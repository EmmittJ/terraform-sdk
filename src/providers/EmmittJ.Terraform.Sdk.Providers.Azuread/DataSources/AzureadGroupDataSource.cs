using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for timeouts in AzureadGroupDataSource.
/// Nesting mode: single
/// </summary>
public class AzureadGroupDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azuread_group Terraform data source.
/// Retrieves information about a azuread_group.
/// </summary>
public partial class AzureadGroupDataSource(string name) : TerraformDataSource("azuread_group", name)
{
    /// <summary>
    /// The display name for the group
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name") ?? CreateReference("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Specifies whether to include transitive members (a flat list of all nested members).
    /// </summary>
    public TerraformValue<bool>? IncludeTransitiveMembers
    {
        get => GetArgument<TerraformValue<bool>>("include_transitive_members");
        set => SetArgument("include_transitive_members", value);
    }

    /// <summary>
    /// Whether the group is mail-enabled
    /// </summary>
    public TerraformValue<bool> MailEnabled
    {
        get => GetArgument<TerraformValue<bool>>("mail_enabled") ?? CreateReference("mail_enabled");
        set => SetArgument("mail_enabled", value);
    }

    /// <summary>
    /// The mail alias for the group, unique in the organisation
    /// </summary>
    public TerraformValue<string> MailNickname
    {
        get => GetArgument<TerraformValue<string>>("mail_nickname") ?? CreateReference("mail_nickname");
        set => SetArgument("mail_nickname", value);
    }

    /// <summary>
    /// The object ID of the group
    /// </summary>
    public TerraformValue<string> ObjectId
    {
        get => GetArgument<TerraformValue<string>>("object_id") ?? CreateReference("object_id");
        set => SetArgument("object_id", value);
    }

    /// <summary>
    /// Whether the group is a security group
    /// </summary>
    public TerraformValue<bool> SecurityEnabled
    {
        get => GetArgument<TerraformValue<bool>>("security_enabled") ?? CreateReference("security_enabled");
        set => SetArgument("security_enabled", value);
    }

    /// <summary>
    /// Indicates whether this group can be assigned to an Azure Active Directory role
    /// </summary>
    public TerraformValue<bool> AssignableToRole
        => CreateReference("assignable_to_role");

    /// <summary>
    /// Indicates whether new members added to the group will be auto-subscribed to receive email notifications.
    /// </summary>
    public TerraformValue<bool> AutoSubscribeNewMembers
        => CreateReference("auto_subscribe_new_members");

    /// <summary>
    /// The group behaviors for a Microsoft 365 group
    /// </summary>
    public TerraformList<string> Behaviors
        => CreateReference("behaviors");

    /// <summary>
    /// The optional description of the group
    /// </summary>
    public TerraformValue<string> Description
        => CreateReference("description");

    /// <summary>
    /// An optional block to configure dynamic membership for the group. Cannot be used with `members`
    /// </summary>
    public TerraformList<TerraformMap<object>> DynamicMembership
        => CreateReference("dynamic_membership");

    /// <summary>
    /// Indicates whether people external to the organization can send messages to the group.
    /// </summary>
    public TerraformValue<bool> ExternalSendersAllowed
        => CreateReference("external_senders_allowed");

    /// <summary>
    /// Indicates whether the group is displayed in certain parts of the Outlook user interface: in the Address Book, in address lists for selecting message recipients, and in the Browse Groups dialog for searching groups.
    /// </summary>
    public TerraformValue<bool> HideFromAddressLists
        => CreateReference("hide_from_address_lists");

    /// <summary>
    /// Indicates whether the group is displayed in Outlook clients, such as Outlook for Windows and Outlook on the web.
    /// </summary>
    public TerraformValue<bool> HideFromOutlookClients
        => CreateReference("hide_from_outlook_clients");

    /// <summary>
    /// The SMTP address for the group
    /// </summary>
    public TerraformValue<string> Mail
        => CreateReference("mail");

    /// <summary>
    /// The object IDs of the group members
    /// </summary>
    public TerraformList<string> Members
        => CreateReference("members");

    /// <summary>
    /// The on-premises FQDN, also called dnsDomainName, synchronized from the on-premises directory when Azure AD Connect is used
    /// </summary>
    public TerraformValue<string> OnpremisesDomainName
        => CreateReference("onpremises_domain_name");

    /// <summary>
    /// Indicates the target on-premise group type the group will be written back as
    /// </summary>
    public TerraformValue<string> OnpremisesGroupType
        => CreateReference("onpremises_group_type");

    /// <summary>
    /// The on-premises NetBIOS name, synchronized from the on-premises directory when Azure AD Connect is used
    /// </summary>
    public TerraformValue<string> OnpremisesNetbiosName
        => CreateReference("onpremises_netbios_name");

    /// <summary>
    /// The on-premises SAM account name, synchronized from the on-premises directory when Azure AD Connect is used
    /// </summary>
    public TerraformValue<string> OnpremisesSamAccountName
        => CreateReference("onpremises_sam_account_name");

    /// <summary>
    /// The on-premises security identifier (SID), synchronized from the on-premises directory when Azure AD Connect is used
    /// </summary>
    public TerraformValue<string> OnpremisesSecurityIdentifier
        => CreateReference("onpremises_security_identifier");

    /// <summary>
    /// Whether this group is synchronized from an on-premises directory (true), no longer synchronized (false), or has never been synchronized (null)
    /// </summary>
    public TerraformValue<bool> OnpremisesSyncEnabled
        => CreateReference("onpremises_sync_enabled");

    /// <summary>
    /// The object IDs of the group owners
    /// </summary>
    public TerraformList<string> Owners
        => CreateReference("owners");

    /// <summary>
    /// The preferred language for a Microsoft 365 group, in ISO 639-1 notation
    /// </summary>
    public TerraformValue<string> PreferredLanguage
        => CreateReference("preferred_language");

    /// <summary>
    /// The group provisioning options for a Microsoft 365 group
    /// </summary>
    public TerraformList<string> ProvisioningOptions
        => CreateReference("provisioning_options");

    /// <summary>
    /// Email addresses for the group that direct to the same group mailbox
    /// </summary>
    public TerraformList<string> ProxyAddresses
        => CreateReference("proxy_addresses");

    /// <summary>
    /// The colour theme for a Microsoft 365 group
    /// </summary>
    public TerraformValue<string> Theme
        => CreateReference("theme");

    /// <summary>
    /// A list of group types configured for the group. The only supported type is `Unified`, which specifies a Microsoft 365 group
    /// </summary>
    public TerraformList<string> Types
        => CreateReference("types");

    /// <summary>
    /// Specifies the group join policy and group content visibility
    /// </summary>
    public TerraformValue<string> Visibility
        => CreateReference("visibility");

    /// <summary>
    /// Whether this group is synced from Azure AD to the on-premises directory when Azure AD Connect is used
    /// </summary>
    public TerraformValue<bool> WritebackEnabled
        => CreateReference("writeback_enabled");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadGroupDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadGroupDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
