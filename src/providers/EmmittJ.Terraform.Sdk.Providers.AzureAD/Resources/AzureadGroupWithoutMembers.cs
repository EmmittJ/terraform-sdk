using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for dynamic_membership in .
/// Nesting mode: list
/// </summary>
public class AzureadGroupWithoutMembersDynamicMembershipBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// Rule to determine members for a dynamic group. Required when `group_types` contains &#39;DynamicMembership&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    public required TerraformProperty<string> Rule
    {
        set => SetProperty("rule", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadGroupWithoutMembersTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azuread_group_without_members resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzureadGroupWithoutMembers : TerraformResource
{
    public AzureadGroupWithoutMembers(string name) : base("azuread_group_without_members", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("mail");
        SetOutput("object_id");
        SetOutput("onpremises_domain_name");
        SetOutput("onpremises_netbios_name");
        SetOutput("onpremises_sam_account_name");
        SetOutput("onpremises_security_identifier");
        SetOutput("onpremises_sync_enabled");
        SetOutput("preferred_language");
        SetOutput("proxy_addresses");
        SetOutput("administrative_unit_ids");
        SetOutput("assignable_to_role");
        SetOutput("auto_subscribe_new_members");
        SetOutput("behaviors");
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("external_senders_allowed");
        SetOutput("hide_from_address_lists");
        SetOutput("hide_from_outlook_clients");
        SetOutput("id");
        SetOutput("mail_enabled");
        SetOutput("mail_nickname");
        SetOutput("onpremises_group_type");
        SetOutput("owners");
        SetOutput("prevent_duplicate_names");
        SetOutput("provisioning_options");
        SetOutput("security_enabled");
        SetOutput("theme");
        SetOutput("types");
        SetOutput("visibility");
        SetOutput("writeback_enabled");
    }

    /// <summary>
    /// The administrative unit IDs in which the group should be. If empty, the group will be created at the tenant level.
    /// </summary>
    public HashSet<TerraformProperty<string>> AdministrativeUnitIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("administrative_unit_ids");
        set => SetProperty("administrative_unit_ids", value);
    }

    /// <summary>
    /// Indicates whether this group can be assigned to an Azure Active Directory role. This property can only be `true` for security-enabled groups.
    /// </summary>
    public TerraformProperty<bool> AssignableToRole
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("assignable_to_role");
        set => SetProperty("assignable_to_role", value);
    }

    /// <summary>
    /// Indicates whether new members added to the group will be auto-subscribed to receive email notifications.
    /// </summary>
    public TerraformProperty<bool> AutoSubscribeNewMembers
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("auto_subscribe_new_members");
        set => SetProperty("auto_subscribe_new_members", value);
    }

    /// <summary>
    /// The group behaviours for a Microsoft 365 group
    /// </summary>
    public HashSet<TerraformProperty<string>> Behaviors
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("behaviors");
        set => SetProperty("behaviors", value);
    }

    /// <summary>
    /// The description for the group
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The display name for the group
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// Indicates whether people external to the organization can send messages to the group.
    /// </summary>
    public TerraformProperty<bool> ExternalSendersAllowed
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("external_senders_allowed");
        set => SetProperty("external_senders_allowed", value);
    }

    /// <summary>
    /// Indicates whether the group is displayed in certain parts of the Outlook user interface: in the Address Book, in address lists for selecting message recipients, and in the Browse Groups dialog for searching groups.
    /// </summary>
    public TerraformProperty<bool> HideFromAddressLists
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("hide_from_address_lists");
        set => SetProperty("hide_from_address_lists", value);
    }

    /// <summary>
    /// Indicates whether the group is displayed in Outlook clients, such as Outlook for Windows and Outlook on the web.
    /// </summary>
    public TerraformProperty<bool> HideFromOutlookClients
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("hide_from_outlook_clients");
        set => SetProperty("hide_from_outlook_clients", value);
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
    /// Whether the group is a mail enabled, with a shared group mailbox. At least one of `mail_enabled` or `security_enabled` must be specified. A group can be mail enabled _and_ security enabled
    /// </summary>
    public TerraformProperty<bool> MailEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("mail_enabled");
        set => SetProperty("mail_enabled", value);
    }

    /// <summary>
    /// The mail alias for the group, unique in the organisation
    /// </summary>
    public TerraformProperty<string> MailNickname
    {
        get => GetRequiredOutput<TerraformProperty<string>>("mail_nickname");
        set => SetProperty("mail_nickname", value);
    }

    /// <summary>
    /// Indicates the target on-premise group type the group will be written back as
    /// </summary>
    public TerraformProperty<string> OnpremisesGroupType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("onpremises_group_type");
        set => SetProperty("onpremises_group_type", value);
    }

    /// <summary>
    /// A set of owners who own this group. Supported object types are Users or Service Principals
    /// </summary>
    public HashSet<TerraformProperty<string>> Owners
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("owners");
        set => SetProperty("owners", value);
    }

    /// <summary>
    /// If `true`, will return an error if an existing group is found with the same name
    /// </summary>
    public TerraformProperty<bool> PreventDuplicateNames
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("prevent_duplicate_names");
        set => SetProperty("prevent_duplicate_names", value);
    }

    /// <summary>
    /// The group provisioning options for a Microsoft 365 group
    /// </summary>
    public HashSet<TerraformProperty<string>> ProvisioningOptions
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("provisioning_options");
        set => SetProperty("provisioning_options", value);
    }

    /// <summary>
    /// Whether the group is a security group for controlling access to in-app resources. At least one of `security_enabled` or `mail_enabled` must be specified. A group can be security enabled _and_ mail enabled
    /// </summary>
    public TerraformProperty<bool> SecurityEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("security_enabled");
        set => SetProperty("security_enabled", value);
    }

    /// <summary>
    /// The colour theme for a Microsoft 365 group
    /// </summary>
    public TerraformProperty<string> Theme
    {
        get => GetRequiredOutput<TerraformProperty<string>>("theme");
        set => SetProperty("theme", value);
    }

    /// <summary>
    /// A set of group types to configure for the group. `Unified` specifies a Microsoft 365 group. Required when `mail_enabled` is true
    /// </summary>
    public HashSet<TerraformProperty<string>> Types
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("types");
        set => SetProperty("types", value);
    }

    /// <summary>
    /// Specifies the group join policy and group content visibility
    /// </summary>
    public TerraformProperty<string> Visibility
    {
        get => GetRequiredOutput<TerraformProperty<string>>("visibility");
        set => SetProperty("visibility", value);
    }

    /// <summary>
    /// Whether this group should be synced from Azure AD to the on-premises directory when Azure AD Connect is used
    /// </summary>
    public TerraformProperty<bool> WritebackEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("writeback_enabled");
        set => SetProperty("writeback_enabled", value);
    }

    /// <summary>
    /// Block for dynamic_membership.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DynamicMembership block(s) allowed")]
    public List<AzureadGroupWithoutMembersDynamicMembershipBlock>? DynamicMembership
    {
        set => SetProperty("dynamic_membership", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadGroupWithoutMembersTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
