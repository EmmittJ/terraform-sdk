using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Manages a azuread_group_without_members resource.
/// </summary>
public class AzureadGroupWithoutMembers : TerraformResource
{
    public AzureadGroupWithoutMembers(string name) : base("azuread_group_without_members", name)
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
    public HashSet<string>? AdministrativeUnitIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("administrative_unit_ids")?.Value;
        set => this.WithProperty("administrative_unit_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// Indicates whether this group can be assigned to an Azure Active Directory role. This property can only be `true` for security-enabled groups.
    /// </summary>
    public bool? AssignableToRole
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("assignable_to_role")?.Value;
        set => this.WithProperty("assignable_to_role", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Indicates whether new members added to the group will be auto-subscribed to receive email notifications.
    /// </summary>
    public bool? AutoSubscribeNewMembers
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_subscribe_new_members")?.Value;
        set => this.WithProperty("auto_subscribe_new_members", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The group behaviours for a Microsoft 365 group
    /// </summary>
    public HashSet<string>? Behaviors
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("behaviors")?.Value;
        set => this.WithProperty("behaviors", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The description for the group
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The display name for the group
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Indicates whether people external to the organization can send messages to the group.
    /// </summary>
    public bool? ExternalSendersAllowed
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("external_senders_allowed")?.Value;
        set => this.WithProperty("external_senders_allowed", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Indicates whether the group is displayed in certain parts of the Outlook user interface: in the Address Book, in address lists for selecting message recipients, and in the Browse Groups dialog for searching groups.
    /// </summary>
    public bool? HideFromAddressLists
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("hide_from_address_lists")?.Value;
        set => this.WithProperty("hide_from_address_lists", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Indicates whether the group is displayed in Outlook clients, such as Outlook for Windows and Outlook on the web.
    /// </summary>
    public bool? HideFromOutlookClients
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("hide_from_outlook_clients")?.Value;
        set => this.WithProperty("hide_from_outlook_clients", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// Whether the group is a mail enabled, with a shared group mailbox. At least one of `mail_enabled` or `security_enabled` must be specified. A group can be mail enabled _and_ security enabled
    /// </summary>
    public bool? MailEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("mail_enabled")?.Value;
        set => this.WithProperty("mail_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The mail alias for the group, unique in the organisation
    /// </summary>
    public string? MailNickname
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mail_nickname")?.Value;
        set => this.WithProperty("mail_nickname", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Indicates the target on-premise group type the group will be written back as
    /// </summary>
    public string? OnpremisesGroupType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("onpremises_group_type")?.Value;
        set => this.WithProperty("onpremises_group_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A set of owners who own this group. Supported object types are Users or Service Principals
    /// </summary>
    public HashSet<string>? Owners
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("owners")?.Value;
        set => this.WithProperty("owners", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// If `true`, will return an error if an existing group is found with the same name
    /// </summary>
    public bool? PreventDuplicateNames
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("prevent_duplicate_names")?.Value;
        set => this.WithProperty("prevent_duplicate_names", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The group provisioning options for a Microsoft 365 group
    /// </summary>
    public HashSet<string>? ProvisioningOptions
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("provisioning_options")?.Value;
        set => this.WithProperty("provisioning_options", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// Whether the group is a security group for controlling access to in-app resources. At least one of `security_enabled` or `mail_enabled` must be specified. A group can be security enabled _and_ mail enabled
    /// </summary>
    public bool? SecurityEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("security_enabled")?.Value;
        set => this.WithProperty("security_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The colour theme for a Microsoft 365 group
    /// </summary>
    public string? Theme
    {
        get => GetProperty<TerraformLiteralProperty<string>>("theme")?.Value;
        set => this.WithProperty("theme", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A set of group types to configure for the group. `Unified` specifies a Microsoft 365 group. Required when `mail_enabled` is true
    /// </summary>
    public HashSet<string>? Types
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("types")?.Value;
        set => this.WithProperty("types", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// Specifies the group join policy and group content visibility
    /// </summary>
    public string? Visibility
    {
        get => GetProperty<TerraformLiteralProperty<string>>("visibility")?.Value;
        set => this.WithProperty("visibility", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Whether this group should be synced from Azure AD to the on-premises directory when Azure AD Connect is used
    /// </summary>
    public bool? WritebackEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("writeback_enabled")?.Value;
        set => this.WithProperty("writeback_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
