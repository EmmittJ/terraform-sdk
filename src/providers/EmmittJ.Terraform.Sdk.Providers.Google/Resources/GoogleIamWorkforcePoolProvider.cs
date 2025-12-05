using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for extended_attributes_oauth2_client in GoogleIamWorkforcePoolProvider.
/// Nesting mode: list
/// </summary>
public class GoogleIamWorkforcePoolProviderExtendedAttributesOauth2ClientBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "extended_attributes_oauth2_client";

    /// <summary>
    /// Represents the IdP and type of claims that should be fetched.
    /// * AZURE_AD_GROUPS_ID:  Used to get the user&#39;s group claims from the Azure AD identity provider
    /// using configuration provided in ExtendedAttributesOAuth2Client and &#39;id&#39;
    /// property of the &#39;microsoft.graph.group&#39; object is used for claim mapping. See
    /// https://learn.microsoft.com/en-us/graph/api/resources/group?view=graph-rest-1.0#properties
    /// for more details on &#39;microsoft.graph.group&#39; properties. The
    /// group IDs obtained from Azure AD are present in &#39;assertion.groups&#39; for
    /// OIDC providers and &#39;assertion.attributes.groups&#39; for SAML providers for
    /// attribute mapping. Possible values: [&amp;quot;AZURE_AD_GROUPS_ID&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttributesType is required")]
    public required TerraformValue<string> AttributesType
    {
        get => GetRequiredArgument<TerraformValue<string>>("attributes_type");
        set => SetArgument("attributes_type", value);
    }

    /// <summary>
    /// The OAuth 2.0 client ID for retrieving extended attributes from the identity provider. Required to get the Access Token using client credentials grant flow.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => GetRequiredArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The OIDC identity provider&#39;s issuer URI. Must be a valid URI using the &#39;https&#39; scheme. Required to get the OIDC discovery document.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IssuerUri is required")]
    public required TerraformValue<string> IssuerUri
    {
        get => GetRequiredArgument<TerraformValue<string>>("issuer_uri");
        set => SetArgument("issuer_uri", value);
    }

    /// <summary>
    /// ClientSecret block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ClientSecret block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientSecret block(s) allowed")]
    public required TerraformList<GoogleIamWorkforcePoolProviderExtendedAttributesOauth2ClientBlockClientSecretBlock> ClientSecret
    {
        get => GetRequiredArgument<TerraformList<GoogleIamWorkforcePoolProviderExtendedAttributesOauth2ClientBlockClientSecretBlock>>("client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// QueryParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QueryParameters block(s) allowed")]
    public TerraformList<GoogleIamWorkforcePoolProviderExtendedAttributesOauth2ClientBlockQueryParametersBlock>? QueryParameters
    {
        get => GetArgument<TerraformList<GoogleIamWorkforcePoolProviderExtendedAttributesOauth2ClientBlockQueryParametersBlock>>("query_parameters");
        set => SetArgument("query_parameters", value);
    }

}

/// <summary>
/// Block type for client_secret in GoogleIamWorkforcePoolProviderExtendedAttributesOauth2ClientBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIamWorkforcePoolProviderExtendedAttributesOauth2ClientBlockClientSecretBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "client_secret";

    /// <summary>
    /// Value block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Value block(s) allowed")]
    public TerraformList<GoogleIamWorkforcePoolProviderExtendedAttributesOauth2ClientBlockClientSecretBlockValueBlock>? Value
    {
        get => GetArgument<TerraformList<GoogleIamWorkforcePoolProviderExtendedAttributesOauth2ClientBlockClientSecretBlockValueBlock>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for value in GoogleIamWorkforcePoolProviderExtendedAttributesOauth2ClientBlockClientSecretBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIamWorkforcePoolProviderExtendedAttributesOauth2ClientBlockClientSecretBlockValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "value";

    /// <summary>
    /// The plain text of the client secret value.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PlainText is required")]
    public required TerraformValue<string> PlainText
    {
        get => GetRequiredArgument<TerraformValue<string>>("plain_text");
        set => SetArgument("plain_text", value);
    }

    /// <summary>
    /// A thumbprint to represent the current client secret value.
    /// </summary>
    public TerraformValue<string> Thumbprint
        => CreateReference("thumbprint");

}

/// <summary>
/// Block type for query_parameters in GoogleIamWorkforcePoolProviderExtendedAttributesOauth2ClientBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIamWorkforcePoolProviderExtendedAttributesOauth2ClientBlockQueryParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "query_parameters";

    /// <summary>
    /// The filter used to request specific records from IdP. In case of attributes type as AZURE_AD_GROUPS_ID, it represents the
    /// filter used to request specific groups for users from IdP. By default, all of the groups associated with the user are fetched. The
    /// groups should be security enabled. See https://learn.microsoft.com/en-us/graph/search-query-parameter for more details.
    /// </summary>
    public TerraformValue<string>? Filter
    {
        get => GetArgument<TerraformValue<string>>("filter");
        set => SetArgument("filter", value);
    }

}


/// <summary>
/// Block type for extra_attributes_oauth2_client in GoogleIamWorkforcePoolProvider.
/// Nesting mode: list
/// </summary>
public class GoogleIamWorkforcePoolProviderExtraAttributesOauth2ClientBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "extra_attributes_oauth2_client";

    /// <summary>
    /// Represents the IdP and type of claims that should be fetched.
    /// * AZURE_AD_GROUPS_MAIL: Used to get the user&#39;s group claims from the Azure AD identity provider using configuration provided
    /// in ExtraAttributesOAuth2Client and &#39;mail&#39; property of the &#39;microsoft.graph.group&#39; object is used for claim mapping.
    /// See https://learn.microsoft.com/en-us/graph/api/resources/group?view=graph-rest-1.0#properties for more details on
    /// &#39;microsoft.graph.group&#39; properties. The attributes obtained from idntity provider are mapped to &#39;assertion.groups&#39;.
    /// * AZURE_AD_GROUPS_ID:  Used to get the user&#39;s group claims from the Azure AD identity provider
    /// using configuration provided in ExtraAttributesOAuth2Client and &#39;id&#39;
    /// property of the &#39;microsoft.graph.group&#39; object is used for claim mapping. See
    /// https://learn.microsoft.com/en-us/graph/api/resources/group?view=graph-rest-1.0#properties
    /// for more details on &#39;microsoft.graph.group&#39; properties. The
    /// group IDs obtained from Azure AD are present in &#39;assertion.groups&#39; for
    /// OIDC providers and &#39;assertion.attributes.groups&#39; for SAML providers for
    /// attribute mapping. Possible values: [&amp;quot;AZURE_AD_GROUPS_MAIL&amp;quot;, &amp;quot;AZURE_AD_GROUPS_ID&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttributesType is required")]
    public required TerraformValue<string> AttributesType
    {
        get => GetRequiredArgument<TerraformValue<string>>("attributes_type");
        set => SetArgument("attributes_type", value);
    }

    /// <summary>
    /// The OAuth 2.0 client ID for retrieving extra attributes from the identity provider. Required to get the Access Token using client credentials grant flow.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => GetRequiredArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The OIDC identity provider&#39;s issuer URI. Must be a valid URI using the &#39;https&#39; scheme. Required to get the OIDC discovery document.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IssuerUri is required")]
    public required TerraformValue<string> IssuerUri
    {
        get => GetRequiredArgument<TerraformValue<string>>("issuer_uri");
        set => SetArgument("issuer_uri", value);
    }

    /// <summary>
    /// ClientSecret block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ClientSecret block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientSecret block(s) allowed")]
    public required TerraformList<GoogleIamWorkforcePoolProviderExtraAttributesOauth2ClientBlockClientSecretBlock> ClientSecret
    {
        get => GetRequiredArgument<TerraformList<GoogleIamWorkforcePoolProviderExtraAttributesOauth2ClientBlockClientSecretBlock>>("client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// QueryParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QueryParameters block(s) allowed")]
    public TerraformList<GoogleIamWorkforcePoolProviderExtraAttributesOauth2ClientBlockQueryParametersBlock>? QueryParameters
    {
        get => GetArgument<TerraformList<GoogleIamWorkforcePoolProviderExtraAttributesOauth2ClientBlockQueryParametersBlock>>("query_parameters");
        set => SetArgument("query_parameters", value);
    }

}

/// <summary>
/// Block type for client_secret in GoogleIamWorkforcePoolProviderExtraAttributesOauth2ClientBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIamWorkforcePoolProviderExtraAttributesOauth2ClientBlockClientSecretBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "client_secret";

    /// <summary>
    /// Value block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Value block(s) allowed")]
    public TerraformList<GoogleIamWorkforcePoolProviderExtraAttributesOauth2ClientBlockClientSecretBlockValueBlock>? Value
    {
        get => GetArgument<TerraformList<GoogleIamWorkforcePoolProviderExtraAttributesOauth2ClientBlockClientSecretBlockValueBlock>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for value in GoogleIamWorkforcePoolProviderExtraAttributesOauth2ClientBlockClientSecretBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIamWorkforcePoolProviderExtraAttributesOauth2ClientBlockClientSecretBlockValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "value";

    /// <summary>
    /// The plain text of the client secret value.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PlainText is required")]
    public required TerraformValue<string> PlainText
    {
        get => GetRequiredArgument<TerraformValue<string>>("plain_text");
        set => SetArgument("plain_text", value);
    }

    /// <summary>
    /// A thumbprint to represent the current client secret value.
    /// </summary>
    public TerraformValue<string> Thumbprint
        => CreateReference("thumbprint");

}

/// <summary>
/// Block type for query_parameters in GoogleIamWorkforcePoolProviderExtraAttributesOauth2ClientBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIamWorkforcePoolProviderExtraAttributesOauth2ClientBlockQueryParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "query_parameters";

    /// <summary>
    /// The filter used to request specific records from IdP. In case of attributes type as AZURE_AD_GROUPS_MAIL and AZURE_AD_GROUPS_ID, it represents the
    /// filter used to request specific groups for users from IdP. By default, all of the groups associated with the user are fetched. The
    /// groups should be security enabled. See https://learn.microsoft.com/en-us/graph/search-query-parameter for more details.
    /// </summary>
    public TerraformValue<string>? Filter
    {
        get => GetArgument<TerraformValue<string>>("filter");
        set => SetArgument("filter", value);
    }

}


/// <summary>
/// Block type for oidc in GoogleIamWorkforcePoolProvider.
/// Nesting mode: list
/// </summary>
public class GoogleIamWorkforcePoolProviderOidcBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oidc";

    /// <summary>
    /// The client ID. Must match the audience claim of the JWT issued by the identity provider.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => GetRequiredArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The OIDC issuer URI. Must be a valid URI using the &#39;https&#39; scheme.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IssuerUri is required")]
    public required TerraformValue<string> IssuerUri
    {
        get => GetRequiredArgument<TerraformValue<string>>("issuer_uri");
        set => SetArgument("issuer_uri", value);
    }

    /// <summary>
    /// OIDC JWKs in JSON String format. For details on definition of a
    /// JWK, see https:tools.ietf.org/html/rfc7517. If not set, then we
    /// use the &#39;jwks_uri&#39; from the discovery document fetched from the
    /// .well-known path for the &#39;issuer_uri&#39;. Currently, RSA and EC asymmetric
    /// keys are supported. The JWK must use following format and include only
    /// the following fields:
    /// &#39;&#39;&#39;
    /// {
    ///   &amp;quot;keys&amp;quot;: [
    ///     {
    ///           &amp;quot;kty&amp;quot;: &amp;quot;RSA/EC&amp;quot;,
    ///           &amp;quot;alg&amp;quot;: &amp;quot;&amp;lt;algorithm&amp;gt;&amp;quot;,
    ///           &amp;quot;use&amp;quot;: &amp;quot;sig&amp;quot;,
    ///           &amp;quot;kid&amp;quot;: &amp;quot;&amp;lt;key-id&amp;gt;&amp;quot;,
    ///           &amp;quot;n&amp;quot;: &amp;quot;&amp;quot;,
    ///           &amp;quot;e&amp;quot;: &amp;quot;&amp;quot;,
    ///           &amp;quot;x&amp;quot;: &amp;quot;&amp;quot;,
    ///           &amp;quot;y&amp;quot;: &amp;quot;&amp;quot;,
    ///           &amp;quot;crv&amp;quot;: &amp;quot;&amp;quot;
    ///     }
    ///   ]
    /// }
    /// &#39;&#39;&#39;
    /// </summary>
    public TerraformValue<string>? JwksJson
    {
        get => GetArgument<TerraformValue<string>>("jwks_json");
        set => SetArgument("jwks_json", value);
    }

    /// <summary>
    /// ClientSecret block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientSecret block(s) allowed")]
    public TerraformList<GoogleIamWorkforcePoolProviderOidcBlockClientSecretBlock>? ClientSecret
    {
        get => GetArgument<TerraformList<GoogleIamWorkforcePoolProviderOidcBlockClientSecretBlock>>("client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// WebSsoConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WebSsoConfig block(s) allowed")]
    public TerraformList<GoogleIamWorkforcePoolProviderOidcBlockWebSsoConfigBlock>? WebSsoConfig
    {
        get => GetArgument<TerraformList<GoogleIamWorkforcePoolProviderOidcBlockWebSsoConfigBlock>>("web_sso_config");
        set => SetArgument("web_sso_config", value);
    }

}

/// <summary>
/// Block type for client_secret in GoogleIamWorkforcePoolProviderOidcBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIamWorkforcePoolProviderOidcBlockClientSecretBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "client_secret";

    /// <summary>
    /// Value block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Value block(s) allowed")]
    public TerraformList<GoogleIamWorkforcePoolProviderOidcBlockClientSecretBlockValueBlock>? Value
    {
        get => GetArgument<TerraformList<GoogleIamWorkforcePoolProviderOidcBlockClientSecretBlockValueBlock>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for value in GoogleIamWorkforcePoolProviderOidcBlockClientSecretBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIamWorkforcePoolProviderOidcBlockClientSecretBlockValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "value";

    /// <summary>
    /// The plain text of the client secret value.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PlainText is required")]
    public required TerraformValue<string> PlainText
    {
        get => GetRequiredArgument<TerraformValue<string>>("plain_text");
        set => SetArgument("plain_text", value);
    }

    /// <summary>
    /// A thumbprint to represent the current client secret value.
    /// </summary>
    public TerraformValue<string> Thumbprint
        => CreateReference("thumbprint");

}

/// <summary>
/// Block type for web_sso_config in GoogleIamWorkforcePoolProviderOidcBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIamWorkforcePoolProviderOidcBlockWebSsoConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "web_sso_config";

    /// <summary>
    /// Additional scopes to request for in the OIDC authentication request on top of scopes requested by default. By default, the &#39;openid&#39;, &#39;profile&#39; and &#39;email&#39; scopes that are supported by the identity provider are requested.
    /// Each additional scope may be at most 256 characters. A maximum of 10 additional scopes may be configured.
    /// </summary>
    public TerraformList<string>? AdditionalScopes
    {
        get => GetArgument<TerraformList<string>>("additional_scopes");
        set => SetArgument("additional_scopes", value);
    }

    /// <summary>
    /// The behavior for how OIDC Claims are included in the &#39;assertion&#39; object used for attribute mapping and attribute condition.
    /// * MERGE_USER_INFO_OVER_ID_TOKEN_CLAIMS: Merge the UserInfo Endpoint Claims with ID Token Claims, preferring UserInfo Claim Values for the same Claim Name. This option is available only for the Authorization Code Flow.
    /// * ONLY_ID_TOKEN_CLAIMS: Only include ID Token Claims. Possible values: [&amp;quot;MERGE_USER_INFO_OVER_ID_TOKEN_CLAIMS&amp;quot;, &amp;quot;ONLY_ID_TOKEN_CLAIMS&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssertionClaimsBehavior is required")]
    public required TerraformValue<string> AssertionClaimsBehavior
    {
        get => GetRequiredArgument<TerraformValue<string>>("assertion_claims_behavior");
        set => SetArgument("assertion_claims_behavior", value);
    }

    /// <summary>
    /// The Response Type to request for in the OIDC Authorization Request for web sign-in.
    /// 
    /// The &#39;CODE&#39; Response Type is recommended to avoid the Implicit Flow, for security reasons.
    /// * CODE: The &#39;response_type=code&#39; selection uses the Authorization Code Flow for web sign-in. Requires a configured client secret.
    /// * ID_TOKEN: The &#39;response_type=id_token&#39; selection uses the Implicit Flow for web sign-in. Possible values: [&amp;quot;CODE&amp;quot;, &amp;quot;ID_TOKEN&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResponseType is required")]
    public required TerraformValue<string> ResponseType
    {
        get => GetRequiredArgument<TerraformValue<string>>("response_type");
        set => SetArgument("response_type", value);
    }

}


/// <summary>
/// Block type for saml in GoogleIamWorkforcePoolProvider.
/// Nesting mode: list
/// </summary>
public class GoogleIamWorkforcePoolProviderSamlBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "saml";

    /// <summary>
    /// SAML Identity provider configuration metadata xml doc.
    /// The xml document should comply with [SAML 2.0 specification](https://docs.oasis-open.org/security/saml/v2.0/saml-metadata-2.0-os.pdf).
    /// The max size of the acceptable xml document will be bounded to 128k characters.
    /// 
    /// The metadata xml document should satisfy the following constraints:
    /// 1) Must contain an Identity Provider Entity ID.
    /// 2) Must contain at least one non-expired signing key certificate.
    /// 3) For each signing key:
    ///   a) Valid from should be no more than 7 days from now.
    ///   b) Valid to should be no more than 10 years in the future.
    /// 4) Up to 3 IdP signing keys are allowed in the metadata xml.
    /// 
    /// When updating the provider&#39;s metadata xml, at least one non-expired signing key
    /// must overlap with the existing metadata. This requirement is skipped if there are
    /// no non-expired signing keys present in the existing metadata.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdpMetadataXml is required")]
    public required TerraformValue<string> IdpMetadataXml
    {
        get => GetRequiredArgument<TerraformValue<string>>("idp_metadata_xml");
        set => SetArgument("idp_metadata_xml", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleIamWorkforcePoolProvider.
/// Nesting mode: single
/// </summary>
public class GoogleIamWorkforcePoolProviderTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_iam_workforce_pool_provider Terraform resource.
/// Manages a google_iam_workforce_pool_provider resource.
/// </summary>
public partial class GoogleIamWorkforcePoolProvider(string name) : TerraformResource("google_iam_workforce_pool_provider", name)
{
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
    public TerraformValue<string>? AttributeCondition
    {
        get => GetArgument<TerraformValue<string>>("attribute_condition");
        set => SetArgument("attribute_condition", value);
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
    public TerraformMap<string>? AttributeMapping
    {
        get => GetArgument<TerraformMap<string>>("attribute_mapping");
        set => SetArgument("attribute_mapping", value);
    }

    /// <summary>
    /// A user-specified description of the provider. Cannot exceed 256 characters.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Whether the provider is disabled. You cannot use a disabled provider to exchange tokens.
    /// However, existing tokens still grant access.
    /// </summary>
    public TerraformValue<bool>? Disabled
    {
        get => GetArgument<TerraformValue<bool>>("disabled");
        set => SetArgument("disabled", value);
    }

    /// <summary>
    /// A user-specified display name for the provider. Cannot exceed 32 characters.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
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
    /// The location for the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The ID for the provider, which becomes the final component of the resource name.
    /// This value must be 4-32 characters, and may contain the characters [a-z0-9-].
    /// The prefix &#39;gcp-&#39; is reserved for use by Google, and may not be specified.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProviderId is required")]
    public required TerraformValue<string> ProviderId
    {
        get => GetRequiredArgument<TerraformValue<string>>("provider_id");
        set => SetArgument("provider_id", value);
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
    public TerraformValue<string>? ScimUsage
    {
        get => GetArgument<TerraformValue<string>>("scim_usage");
        set => SetArgument("scim_usage", value);
    }

    /// <summary>
    /// The ID to use for the pool, which becomes the final component of the resource name.
    /// The IDs must be a globally unique string of 6 to 63 lowercase letters, digits, or hyphens.
    /// It must start with a letter, and cannot have a trailing hyphen.
    /// The prefix &#39;gcp-&#39; is reserved for use by Google, and may not be specified.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkforcePoolId is required")]
    public required TerraformValue<string> WorkforcePoolId
    {
        get => GetRequiredArgument<TerraformValue<string>>("workforce_pool_id");
        set => SetArgument("workforce_pool_id", value);
    }

    /// <summary>
    /// Output only. The resource name of the provider.
    /// Format: &#39;locations/{location}/workforcePools/{workforcePoolId}/providers/{providerId}&#39;
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// The current state of the provider.
    /// * STATE_UNSPECIFIED: State unspecified.
    /// * ACTIVE: The provider is active and may be used to validate authentication credentials.
    /// * DELETED: The provider is soft-deleted. Soft-deleted providers are permanently
    ///   deleted after approximately 30 days. You can restore a soft-deleted provider using
    ///   [providers.undelete](https://cloud.google.com/iam/docs/reference/rest/v1/locations.workforcePools.providers/undelete#google.iam.admin.v1.WorkforcePools.UndeleteWorkforcePoolProvider).
    /// </summary>
    public TerraformValue<string> State
        => CreateReference("state");

    /// <summary>
    /// ExtendedAttributesOauth2Client block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExtendedAttributesOauth2Client block(s) allowed")]
    public TerraformList<GoogleIamWorkforcePoolProviderExtendedAttributesOauth2ClientBlock>? ExtendedAttributesOauth2Client
    {
        get => GetArgument<TerraformList<GoogleIamWorkforcePoolProviderExtendedAttributesOauth2ClientBlock>>("extended_attributes_oauth2_client");
        set => SetArgument("extended_attributes_oauth2_client", value);
    }

    /// <summary>
    /// ExtraAttributesOauth2Client block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExtraAttributesOauth2Client block(s) allowed")]
    public TerraformList<GoogleIamWorkforcePoolProviderExtraAttributesOauth2ClientBlock>? ExtraAttributesOauth2Client
    {
        get => GetArgument<TerraformList<GoogleIamWorkforcePoolProviderExtraAttributesOauth2ClientBlock>>("extra_attributes_oauth2_client");
        set => SetArgument("extra_attributes_oauth2_client", value);
    }

    /// <summary>
    /// Oidc block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Oidc block(s) allowed")]
    public TerraformList<GoogleIamWorkforcePoolProviderOidcBlock>? Oidc
    {
        get => GetArgument<TerraformList<GoogleIamWorkforcePoolProviderOidcBlock>>("oidc");
        set => SetArgument("oidc", value);
    }

    /// <summary>
    /// Saml block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Saml block(s) allowed")]
    public TerraformList<GoogleIamWorkforcePoolProviderSamlBlock>? Saml
    {
        get => GetArgument<TerraformList<GoogleIamWorkforcePoolProviderSamlBlock>>("saml");
        set => SetArgument("saml", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleIamWorkforcePoolProviderTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleIamWorkforcePoolProviderTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
