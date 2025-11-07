using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_iam_workforce_pool_provider resource.
/// </summary>
public class GoogleIamWorkforcePoolProvider : TerraformResource
{
    public GoogleIamWorkforcePoolProvider(string name) : base("google_iam_workforce_pool_provider", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
        this.DeclareOutput("state");
    }

    /// <summary>
    /// A [Common Expression Language](https://opensource.google/projects/cel) expression, in
    /// plain text, to restrict what otherwise valid authentication credentials issued by the
    /// provider should not be accepted.
    /// 
    /// The expression must output a boolean representing whether to allow the federation.
    /// 
    /// The following keywords may be referenced in the expressions:
    ///   * &#39;assertion&#39;: JSON representing the authentication credential issued by the provider.
    ///   * &#39;google&#39;: The Google attributes mapped from the assertion in the &#39;attribute_mappings&#39;.
    ///     &#39;google.profile_photo&#39; and &#39;google.display_name&#39; are not supported.
    ///   * &#39;attribute&#39;: The custom attributes mapped from the assertion in the &#39;attribute_mappings&#39;.
    /// 
    /// The maximum length of the attribute condition expression is 4096 characters.
    /// If unspecified, all valid authentication credentials will be accepted.
    /// 
    /// The following example shows how to only allow credentials with a mapped &#39;google.groups&#39; value of &#39;admins&#39;:
    /// &#39;&#39;&#39;
    /// &amp;quot;&#39;admins&#39; in google.groups&amp;quot;
    /// &#39;&#39;&#39;
    /// </summary>
    public TerraformProperty<string>? AttributeCondition
    {
        get => GetProperty<TerraformProperty<string>>("attribute_condition");
        set => this.WithProperty("attribute_condition", value);
    }

    /// <summary>
    /// Maps attributes from the authentication credentials issued by an external identity provider
    /// to Google Cloud attributes, such as &#39;subject&#39; and &#39;segment&#39;.
    /// 
    /// Each key must be a string specifying the Google Cloud IAM attribute to map to.
    /// 
    /// The following keys are supported:
    ///   * &#39;google.subject&#39;: The principal IAM is authenticating. You can reference this value in IAM bindings.
    ///     This is also the subject that appears in Cloud Logging logs. This is a required field and
    ///     the mapped subject cannot exceed 127 bytes.
    ///   * &#39;google.groups&#39;: Groups the authenticating user belongs to. You can grant groups access to
    ///     resources using an IAM &#39;principalSet&#39; binding; access applies to all members of the group.
    ///   * &#39;google.display_name&#39;: The name of the authenticated user. This is an optional field and
    ///     the mapped display name cannot exceed 100 bytes. If not set, &#39;google.subject&#39; will be displayed instead.
    ///     This attribute cannot be referenced in IAM bindings.
    ///   * &#39;google.profile_photo&#39;: The URL that specifies the authenticated user&#39;s thumbnail photo.
    ///     This is an optional field. When set, the image will be visible as the user&#39;s profile picture.
    ///     If not set, a generic user icon will be displayed instead.
    ///     This attribute cannot be referenced in IAM bindings.
    /// 
    /// You can also provide custom attributes by specifying &#39;attribute.{custom_attribute}&#39;, where {custom_attribute}
    /// is the name of the custom attribute to be mapped. You can define a maximum of 50 custom attributes.
    /// The maximum length of a mapped attribute key is 100 characters, and the key may only contain the characters [a-z0-9_].
    /// 
    /// You can reference these attributes in IAM policies to define fine-grained access for a workforce pool
    /// to Google Cloud resources. For example:
    ///   * &#39;google.subject&#39;:
    ///     &#39;principal://iam.googleapis.com/locations/{location}/workforcePools/{pool}/subject/{value}&#39;
    ///   * &#39;google.groups&#39;:
    ///     &#39;principalSet://iam.googleapis.com/locations/{location}/workforcePools/{pool}/group/{value}&#39;
    ///   * &#39;attribute.{custom_attribute}&#39;:
    ///     &#39;principalSet://iam.googleapis.com/locations/{location}/workforcePools/{pool}/attribute.{custom_attribute}/{value}&#39;
    /// 
    /// Each value must be a [Common Expression Language](https://opensource.google/projects/cel)
    /// function that maps an identity provider credential to the normalized attribute specified
    /// by the corresponding map key.
    /// 
    /// You can use the &#39;assertion&#39; keyword in the expression to access a JSON representation of
    /// the authentication credential issued by the provider.
    /// 
    /// The maximum length of an attribute mapping expression is 2048 characters. When evaluated,
    /// the total size of all mapped attributes must not exceed 8KB.
    /// 
    /// For OIDC providers, you must supply a custom mapping that includes the &#39;google.subject&#39; attribute.
    /// For example, the following maps the sub claim of the incoming credential to the &#39;subject&#39; attribute
    /// on a Google token:
    /// &#39;&#39;&#39;
    /// {&amp;quot;google.subject&amp;quot;: &amp;quot;assertion.sub&amp;quot;}
    /// &#39;&#39;&#39;
    /// 
    /// An object containing a list of &#39;&amp;quot;key&amp;quot;: value&#39; pairs.
    /// Example: &#39;{ &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }&#39;.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? AttributeMapping
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("attribute_mapping");
        set => this.WithProperty("attribute_mapping", value);
    }

    /// <summary>
    /// A user-specified description of the provider. Cannot exceed 256 characters.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Whether the provider is disabled. You cannot use a disabled provider to exchange tokens.
    /// However, existing tokens still grant access.
    /// </summary>
    public TerraformProperty<bool>? Disabled
    {
        get => GetProperty<TerraformProperty<bool>>("disabled");
        set => this.WithProperty("disabled", value);
    }

    /// <summary>
    /// A user-specified display name for the provider. Cannot exceed 32 characters.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// The location for the resource.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The ID for the provider, which becomes the final component of the resource name.
    /// This value must be 4-32 characters, and may contain the characters [a-z0-9-].
    /// The prefix &#39;gcp-&#39; is reserved for use by Google, and may not be specified.
    /// </summary>
    public TerraformProperty<string>? ProviderId
    {
        get => GetProperty<TerraformProperty<string>>("provider_id");
        set => this.WithProperty("provider_id", value);
    }

    /// <summary>
    /// Agentspace only. Specifies whether the workforce identity pool
    /// provider uses SCIM-managed groups instead of the &#39;google.groups&#39;
    /// attribute mapping for authorization checks.
    /// 
    /// The &#39;scimUsage&#39; and &#39;extendedAttributesOauth2Client&#39; fields are
    /// mutually exclusive. A request that enables both fields on the same
    /// workforce identity pool provider will produce an error.
    /// * SCIM_USAGE_UNSPECIFIED: Default behaviour
    /// * ENABLED_FOR_GROUPS: Use SCIM-managed groups instead of the &#39;google.groups&#39;
    ///   attribute mapping for authorization checks Possible values: [&amp;quot;SCIM_USAGE_UNSPECIFIED&amp;quot;, &amp;quot;ENABLED_FOR_GROUPS&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? ScimUsage
    {
        get => GetProperty<TerraformProperty<string>>("scim_usage");
        set => this.WithProperty("scim_usage", value);
    }

    /// <summary>
    /// The ID to use for the pool, which becomes the final component of the resource name.
    /// The IDs must be a globally unique string of 6 to 63 lowercase letters, digits, or hyphens.
    /// It must start with a letter, and cannot have a trailing hyphen.
    /// The prefix &#39;gcp-&#39; is reserved for use by Google, and may not be specified.
    /// </summary>
    public TerraformProperty<string>? WorkforcePoolId
    {
        get => GetProperty<TerraformProperty<string>>("workforce_pool_id");
        set => this.WithProperty("workforce_pool_id", value);
    }

    /// <summary>
    /// Output only. The resource name of the provider.
    /// Format: &#39;locations/{location}/workforcePools/{workforcePoolId}/providers/{providerId}&#39;
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The current state of the provider.
    /// * STATE_UNSPECIFIED: State unspecified.
    /// * ACTIVE: The provider is active and may be used to validate authentication credentials.
    /// * DELETED: The provider is soft-deleted. Soft-deleted providers are permanently
    ///   deleted after approximately 30 days. You can restore a soft-deleted provider using
    ///   [providers.undelete](https://cloud.google.com/iam/docs/reference/rest/v1/locations.workforcePools.providers/undelete#google.iam.admin.v1.WorkforcePools.UndeleteWorkforcePoolProvider).
    /// </summary>
    public TerraformExpression State => this["state"];

}
