using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadGroupDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azuread_group.
/// </summary>
public class AzureadGroupDataSource : TerraformDataSource
{
    public AzureadGroupDataSource(string name) : base("azuread_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("assignable_to_role");
        SetOutput("auto_subscribe_new_members");
        SetOutput("behaviors");
        SetOutput("description");
        SetOutput("dynamic_membership");
        SetOutput("external_senders_allowed");
        SetOutput("hide_from_address_lists");
        SetOutput("hide_from_outlook_clients");
        SetOutput("mail");
        SetOutput("members");
        SetOutput("onpremises_domain_name");
        SetOutput("onpremises_group_type");
        SetOutput("onpremises_netbios_name");
        SetOutput("onpremises_sam_account_name");
        SetOutput("onpremises_security_identifier");
        SetOutput("onpremises_sync_enabled");
        SetOutput("owners");
        SetOutput("preferred_language");
        SetOutput("provisioning_options");
        SetOutput("proxy_addresses");
        SetOutput("theme");
        SetOutput("types");
        SetOutput("visibility");
        SetOutput("writeback_enabled");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("include_transitive_members");
        SetOutput("mail_enabled");
        SetOutput("mail_nickname");
        SetOutput("object_id");
        SetOutput("security_enabled");
    }

    /// <summary>
    /// The display name for the group
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
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
    /// Specifies whether to include transitive members (a flat list of all nested members).
    /// </summary>
    public TerraformProperty<bool> IncludeTransitiveMembers
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("include_transitive_members");
        set => SetProperty("include_transitive_members", value);
    }

    /// <summary>
    /// Whether the group is mail-enabled
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
    /// The object ID of the group
    /// </summary>
    public TerraformProperty<string> ObjectId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("object_id");
        set => SetProperty("object_id", value);
    }

    /// <summary>
    /// Whether the group is a security group
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
    public AzureadGroupDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Indicates whether this group can be assigned to an Azure Active Directory role
    /// </summary>
    public TerraformExpression AssignableToRole => this["assignable_to_role"];

    /// <summary>
    /// Indicates whether new members added to the group will be auto-subscribed to receive email notifications.
    /// </summary>
    public TerraformExpression AutoSubscribeNewMembers => this["auto_subscribe_new_members"];

    /// <summary>
    /// The group behaviors for a Microsoft 365 group
    /// </summary>
    public TerraformExpression Behaviors => this["behaviors"];

    /// <summary>
    /// The optional description of the group
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// An optional block to configure dynamic membership for the group. Cannot be used with `members`
    /// </summary>
    public TerraformExpression DynamicMembership => this["dynamic_membership"];

    /// <summary>
    /// Indicates whether people external to the organization can send messages to the group.
    /// </summary>
    public TerraformExpression ExternalSendersAllowed => this["external_senders_allowed"];

    /// <summary>
    /// Indicates whether the group is displayed in certain parts of the Outlook user interface: in the Address Book, in address lists for selecting message recipients, and in the Browse Groups dialog for searching groups.
    /// </summary>
    public TerraformExpression HideFromAddressLists => this["hide_from_address_lists"];

    /// <summary>
    /// Indicates whether the group is displayed in Outlook clients, such as Outlook for Windows and Outlook on the web.
    /// </summary>
    public TerraformExpression HideFromOutlookClients => this["hide_from_outlook_clients"];

    /// <summary>
    /// The SMTP address for the group
    /// </summary>
    public TerraformExpression Mail => this["mail"];

    /// <summary>
    /// The object IDs of the group members
    /// </summary>
    public TerraformExpression Members => this["members"];

    /// <summary>
    /// The on-premises FQDN, also called dnsDomainName, synchronized from the on-premises directory when Azure AD Connect is used
    /// </summary>
    public TerraformExpression OnpremisesDomainName => this["onpremises_domain_name"];

    /// <summary>
    /// Indicates the target on-premise group type the group will be written back as
    /// </summary>
    public TerraformExpression OnpremisesGroupType => this["onpremises_group_type"];

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
    /// The object IDs of the group owners
    /// </summary>
    public TerraformExpression Owners => this["owners"];

    /// <summary>
    /// The preferred language for a Microsoft 365 group, in ISO 639-1 notation
    /// </summary>
    public TerraformExpression PreferredLanguage => this["preferred_language"];

    /// <summary>
    /// The group provisioning options for a Microsoft 365 group
    /// </summary>
    public TerraformExpression ProvisioningOptions => this["provisioning_options"];

    /// <summary>
    /// Email addresses for the group that direct to the same group mailbox
    /// </summary>
    public TerraformExpression ProxyAddresses => this["proxy_addresses"];

    /// <summary>
    /// The colour theme for a Microsoft 365 group
    /// </summary>
    public TerraformExpression Theme => this["theme"];

    /// <summary>
    /// A list of group types configured for the group. The only supported type is `Unified`, which specifies a Microsoft 365 group
    /// </summary>
    public TerraformExpression Types => this["types"];

    /// <summary>
    /// Specifies the group join policy and group content visibility
    /// </summary>
    public TerraformExpression Visibility => this["visibility"];

    /// <summary>
    /// Whether this group is synced from Azure AD to the on-premises directory when Azure AD Connect is used
    /// </summary>
    public TerraformExpression WritebackEnabled => this["writeback_enabled"];

}
