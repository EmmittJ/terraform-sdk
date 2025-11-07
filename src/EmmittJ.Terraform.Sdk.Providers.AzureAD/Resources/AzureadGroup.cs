using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Manages a azuread_group resource.
/// </summary>
public class AzureadGroup : TerraformResource
{
    public AzureadGroup(string name) : base("azuread_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("mail");
        this.DeclareOutput("object_id");
        this.DeclareOutput("onpremises_domain_name");
        this.DeclareOutput("onpremises_netbios_name");
        this.DeclareOutput("onpremises_sam_account_name");
        this.DeclareOutput("onpremises_security_identifier");
        this.DeclareOutput("onpremises_sync_enabled");
        this.DeclareOutput("preferred_language");
        this.DeclareOutput("proxy_addresses");
    }

    /// <summary>
    /// The administrative unit IDs in which the group should be. If empty, the group will be created at the tenant level.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? AdministrativeUnitIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("administrative_unit_ids");
        set => this.WithProperty("administrative_unit_ids", value);
    }

    /// <summary>
    /// Indicates whether this group can be assigned to an Azure Active Directory role. This property can only be `true` for security-enabled groups.
    /// </summary>
    public TerraformLiteralProperty<bool>? AssignableToRole
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("assignable_to_role");
        set => this.WithProperty("assignable_to_role", value);
    }

    /// <summary>
    /// Indicates whether new members added to the group will be auto-subscribed to receive email notifications.
    /// </summary>
    public TerraformLiteralProperty<bool>? AutoSubscribeNewMembers
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_subscribe_new_members");
        set => this.WithProperty("auto_subscribe_new_members", value);
    }

    /// <summary>
    /// The group behaviours for a Microsoft 365 group
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Behaviors
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("behaviors");
        set => this.WithProperty("behaviors", value);
    }

    /// <summary>
    /// The description for the group
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display name for the group
    /// </summary>
    public TerraformLiteralProperty<string>? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// Indicates whether people external to the organization can send messages to the group.
    /// </summary>
    public TerraformLiteralProperty<bool>? ExternalSendersAllowed
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("external_senders_allowed");
        set => this.WithProperty("external_senders_allowed", value);
    }

    /// <summary>
    /// Indicates whether the group is displayed in certain parts of the Outlook user interface: in the Address Book, in address lists for selecting message recipients, and in the Browse Groups dialog for searching groups.
    /// </summary>
    public TerraformLiteralProperty<bool>? HideFromAddressLists
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("hide_from_address_lists");
        set => this.WithProperty("hide_from_address_lists", value);
    }

    /// <summary>
    /// Indicates whether the group is displayed in Outlook clients, such as Outlook for Windows and Outlook on the web.
    /// </summary>
    public TerraformLiteralProperty<bool>? HideFromOutlookClients
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("hide_from_outlook_clients");
        set => this.WithProperty("hide_from_outlook_clients", value);
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
    /// Whether the group is a mail enabled, with a shared group mailbox. At least one of `mail_enabled` or `security_enabled` must be specified. A group can be mail enabled _and_ security enabled
    /// </summary>
    public TerraformLiteralProperty<bool>? MailEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("mail_enabled");
        set => this.WithProperty("mail_enabled", value);
    }

    /// <summary>
    /// The mail alias for the group, unique in the organisation
    /// </summary>
    public TerraformLiteralProperty<string>? MailNickname
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mail_nickname");
        set => this.WithProperty("mail_nickname", value);
    }

    /// <summary>
    /// A set of members who should be present in this group. Supported object types are Users, Groups or Service Principals
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Members
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("members");
        set => this.WithProperty("members", value);
    }

    /// <summary>
    /// Indicates the target on-premise group type the group will be written back as
    /// </summary>
    public TerraformLiteralProperty<string>? OnpremisesGroupType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("onpremises_group_type");
        set => this.WithProperty("onpremises_group_type", value);
    }

    /// <summary>
    /// A set of owners who own this group. Supported object types are Users or Service Principals
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Owners
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("owners");
        set => this.WithProperty("owners", value);
    }

    /// <summary>
    /// If `true`, will return an error if an existing group is found with the same name
    /// </summary>
    public TerraformLiteralProperty<bool>? PreventDuplicateNames
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("prevent_duplicate_names");
        set => this.WithProperty("prevent_duplicate_names", value);
    }

    /// <summary>
    /// The group provisioning options for a Microsoft 365 group
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? ProvisioningOptions
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("provisioning_options");
        set => this.WithProperty("provisioning_options", value);
    }

    /// <summary>
    /// Whether the group is a security group for controlling access to in-app resources. At least one of `security_enabled` or `mail_enabled` must be specified. A group can be security enabled _and_ mail enabled
    /// </summary>
    public TerraformLiteralProperty<bool>? SecurityEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("security_enabled");
        set => this.WithProperty("security_enabled", value);
    }

    /// <summary>
    /// The colour theme for a Microsoft 365 group
    /// </summary>
    public TerraformLiteralProperty<string>? Theme
    {
        get => GetProperty<TerraformLiteralProperty<string>>("theme");
        set => this.WithProperty("theme", value);
    }

    /// <summary>
    /// A set of group types to configure for the group. `Unified` specifies a Microsoft 365 group. Required when `mail_enabled` is true
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Types
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("types");
        set => this.WithProperty("types", value);
    }

    /// <summary>
    /// Specifies the group join policy and group content visibility
    /// </summary>
    public TerraformLiteralProperty<string>? Visibility
    {
        get => GetProperty<TerraformLiteralProperty<string>>("visibility");
        set => this.WithProperty("visibility", value);
    }

    /// <summary>
    /// Whether this group should be synced from Azure AD to the on-premises directory when Azure AD Connect is used
    /// </summary>
    public TerraformLiteralProperty<bool>? WritebackEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("writeback_enabled");
        set => this.WithProperty("writeback_enabled", value);
    }

    /// <summary>
    /// The SMTP address for the group
    /// </summary>
    public TerraformExpression Mail => this["mail"];

    /// <summary>
    /// The object ID of the group
    /// </summary>
    public TerraformExpression ObjectId => this["object_id"];

    /// <summary>
    /// The on-premises FQDN, also called dnsDomainName, synchronized from the on-premises directory when Azure AD Connect is used
    /// </summary>
    public TerraformExpression OnpremisesDomainName => this["onpremises_domain_name"];

    /// <summary>
    /// The on-premises NetBIOS name, synchronized from the on-premises directory when Azure AD Connect is used
    /// </summary>
    public TerraformExpression OnpremisesNetbiosName => this["onpremises_netbios_name"];

    /// <summary>
    /// The on-premises SAM account name, synchronized from the on-premises directory when Azure AD Connect is used
    /// </summary>
    public TerraformExpression OnpremisesSamAccountName => this["onpremises_sam_account_name"];

    /// <summary>
    /// The on-premises security identifier (SID), synchronized from the on-premises directory when Azure AD Connect is used
    /// </summary>
    public TerraformExpression OnpremisesSecurityIdentifier => this["onpremises_security_identifier"];

    /// <summary>
    /// Whether this group is synchronized from an on-premises directory (true), no longer synchronized (false), or has never been synchronized (null)
    /// </summary>
    public TerraformExpression OnpremisesSyncEnabled => this["onpremises_sync_enabled"];

    /// <summary>
    /// The preferred language for a Microsoft 365 group, in ISO 639-1 notation
    /// </summary>
    public TerraformExpression PreferredLanguage => this["preferred_language"];

    /// <summary>
    /// Email addresses for the group that direct to the same group mailbox
    /// </summary>
    public TerraformExpression ProxyAddresses => this["proxy_addresses"];

}
