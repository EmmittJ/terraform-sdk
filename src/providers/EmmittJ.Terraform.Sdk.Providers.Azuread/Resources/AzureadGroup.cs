using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for dynamic_membership in AzureadGroup.
/// Nesting mode: list
/// </summary>
public class AzureadGroupDynamicMembershipBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dynamic_membership";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// Rule to determine members for a dynamic group. Required when `group_types` contains &#39;DynamicMembership&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    public required TerraformValue<string> Rule
    {
        get => GetRequiredArgument<TerraformValue<string>>("rule");
        set => SetArgument("rule", value);
    }

}


/// <summary>
/// Block type for timeouts in AzureadGroup.
/// Nesting mode: single
/// </summary>
public class AzureadGroupTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azuread_group Terraform resource.
/// Manages a azuread_group resource.
/// </summary>
public partial class AzureadGroup(string name) : TerraformResource("azuread_group", name)
{
    /// <summary>
    /// The administrative unit IDs in which the group should be. If empty, the group will be created at the tenant level.
    /// </summary>
    public TerraformSet<string>? AdministrativeUnitIds
    {
        get => GetArgument<TerraformSet<string>>("administrative_unit_ids");
        set => SetArgument("administrative_unit_ids", value);
    }

    /// <summary>
    /// Indicates whether this group can be assigned to an Azure Active Directory role. This property can only be `true` for security-enabled groups.
    /// </summary>
    public TerraformValue<bool>? AssignableToRole
    {
        get => GetArgument<TerraformValue<bool>>("assignable_to_role");
        set => SetArgument("assignable_to_role", value);
    }

    /// <summary>
    /// Indicates whether new members added to the group will be auto-subscribed to receive email notifications.
    /// </summary>
    public TerraformValue<bool> AutoSubscribeNewMembers
    {
        get => GetArgument<TerraformValue<bool>>("auto_subscribe_new_members") ?? CreateReference("auto_subscribe_new_members");
        set => SetArgument("auto_subscribe_new_members", value);
    }

    /// <summary>
    /// The group behaviours for a Microsoft 365 group
    /// </summary>
    public TerraformSet<string>? Behaviors
    {
        get => GetArgument<TerraformSet<string>>("behaviors");
        set => SetArgument("behaviors", value);
    }

    /// <summary>
    /// The description for the group
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display name for the group
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetRequiredArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// Indicates whether people external to the organization can send messages to the group.
    /// </summary>
    public TerraformValue<bool> ExternalSendersAllowed
    {
        get => GetArgument<TerraformValue<bool>>("external_senders_allowed") ?? CreateReference("external_senders_allowed");
        set => SetArgument("external_senders_allowed", value);
    }

    /// <summary>
    /// Indicates whether the group is displayed in certain parts of the Outlook user interface: in the Address Book, in address lists for selecting message recipients, and in the Browse Groups dialog for searching groups.
    /// </summary>
    public TerraformValue<bool> HideFromAddressLists
    {
        get => GetArgument<TerraformValue<bool>>("hide_from_address_lists") ?? CreateReference("hide_from_address_lists");
        set => SetArgument("hide_from_address_lists", value);
    }

    /// <summary>
    /// Indicates whether the group is displayed in Outlook clients, such as Outlook for Windows and Outlook on the web.
    /// </summary>
    public TerraformValue<bool> HideFromOutlookClients
    {
        get => GetArgument<TerraformValue<bool>>("hide_from_outlook_clients") ?? CreateReference("hide_from_outlook_clients");
        set => SetArgument("hide_from_outlook_clients", value);
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
    /// Whether the group is a mail enabled, with a shared group mailbox. At least one of `mail_enabled` or `security_enabled` must be specified. A group can be mail enabled _and_ security enabled
    /// </summary>
    public TerraformValue<bool>? MailEnabled
    {
        get => GetArgument<TerraformValue<bool>>("mail_enabled");
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
    /// A set of members who should be present in this group. Supported object types are Users, Groups or Service Principals
    /// </summary>
    public TerraformSet<string> Members
    {
        get => GetArgument<TerraformSet<string>>("members") ?? CreateReference("members");
        set => SetArgument("members", value);
    }

    /// <summary>
    /// Indicates the target on-premise group type the group will be written back as
    /// </summary>
    public TerraformValue<string> OnpremisesGroupType
    {
        get => GetArgument<TerraformValue<string>>("onpremises_group_type") ?? CreateReference("onpremises_group_type");
        set => SetArgument("onpremises_group_type", value);
    }

    /// <summary>
    /// A set of owners who own this group. Supported object types are Users or Service Principals
    /// </summary>
    public TerraformSet<string> Owners
    {
        get => GetArgument<TerraformSet<string>>("owners") ?? CreateReference("owners");
        set => SetArgument("owners", value);
    }

    /// <summary>
    /// If `true`, will return an error if an existing group is found with the same name
    /// </summary>
    public TerraformValue<bool>? PreventDuplicateNames
    {
        get => GetArgument<TerraformValue<bool>>("prevent_duplicate_names");
        set => SetArgument("prevent_duplicate_names", value);
    }

    /// <summary>
    /// The group provisioning options for a Microsoft 365 group
    /// </summary>
    public TerraformSet<string>? ProvisioningOptions
    {
        get => GetArgument<TerraformSet<string>>("provisioning_options");
        set => SetArgument("provisioning_options", value);
    }

    /// <summary>
    /// Whether the group is a security group for controlling access to in-app resources. At least one of `security_enabled` or `mail_enabled` must be specified. A group can be security enabled _and_ mail enabled
    /// </summary>
    public TerraformValue<bool>? SecurityEnabled
    {
        get => GetArgument<TerraformValue<bool>>("security_enabled");
        set => SetArgument("security_enabled", value);
    }

    /// <summary>
    /// The colour theme for a Microsoft 365 group
    /// </summary>
    public TerraformValue<string>? Theme
    {
        get => GetArgument<TerraformValue<string>>("theme");
        set => SetArgument("theme", value);
    }

    /// <summary>
    /// A set of group types to configure for the group. `Unified` specifies a Microsoft 365 group. Required when `mail_enabled` is true
    /// </summary>
    public TerraformSet<string>? Types
    {
        get => GetArgument<TerraformSet<string>>("types");
        set => SetArgument("types", value);
    }

    /// <summary>
    /// Specifies the group join policy and group content visibility
    /// </summary>
    public TerraformValue<string> Visibility
    {
        get => GetArgument<TerraformValue<string>>("visibility") ?? CreateReference("visibility");
        set => SetArgument("visibility", value);
    }

    /// <summary>
    /// Whether this group should be synced from Azure AD to the on-premises directory when Azure AD Connect is used
    /// </summary>
    public TerraformValue<bool>? WritebackEnabled
    {
        get => GetArgument<TerraformValue<bool>>("writeback_enabled");
        set => SetArgument("writeback_enabled", value);
    }

    /// <summary>
    /// The SMTP address for the group
    /// </summary>
    public TerraformValue<string> Mail
        => CreateReference("mail");

    /// <summary>
    /// The object ID of the group
    /// </summary>
    public TerraformValue<string> ObjectId
        => CreateReference("object_id");

    /// <summary>
    /// The on-premises FQDN, also called dnsDomainName, synchronized from the on-premises directory when Azure AD Connect is used
    /// </summary>
    public TerraformValue<string> OnpremisesDomainName
        => CreateReference("onpremises_domain_name");

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
    /// The preferred language for a Microsoft 365 group, in ISO 639-1 notation
    /// </summary>
    public TerraformValue<string> PreferredLanguage
        => CreateReference("preferred_language");

    /// <summary>
    /// Email addresses for the group that direct to the same group mailbox
    /// </summary>
    public TerraformList<string> ProxyAddresses
        => CreateReference("proxy_addresses");

    /// <summary>
    /// DynamicMembership block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DynamicMembership block(s) allowed")]
    public TerraformList<AzureadGroupDynamicMembershipBlock>? DynamicMembership
    {
        get => GetArgument<TerraformList<AzureadGroupDynamicMembershipBlock>>("dynamic_membership");
        set => SetArgument("dynamic_membership", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadGroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadGroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
