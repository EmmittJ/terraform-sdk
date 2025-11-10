using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for aws in .
/// Nesting mode: list
/// </summary>
public class GoogleIamWorkloadIdentityPoolProviderAwsBlock : TerraformBlock
{
    /// <summary>
    /// The AWS account ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountId is required")]
    public required TerraformProperty<string> AccountId
    {
        get => GetProperty<TerraformProperty<string>>("account_id");
        set => WithProperty("account_id", value);
    }

}

/// <summary>
/// Block type for oidc in .
/// Nesting mode: list
/// </summary>
public class GoogleIamWorkloadIdentityPoolProviderOidcBlock : TerraformBlock
{
    /// <summary>
    /// Acceptable values for the &#39;aud&#39; field (audience) in the OIDC token. Token exchange
    /// requests are rejected if the token audience does not match one of the configured
    /// values. Each audience may be at most 256 characters. A maximum of 10 audiences may
    /// be configured.
    /// 
    /// If this list is empty, the OIDC token audience must be equal to the full canonical
    /// resource name of the WorkloadIdentityPoolProvider, with or without the HTTPS prefix.
    /// For example:
    /// &#39;&#39;&#39;
    /// //iam.googleapis.com/projects/&amp;lt;project-number&amp;gt;/locations/&amp;lt;location&amp;gt;/workloadIdentityPools/&amp;lt;pool-id&amp;gt;/providers/&amp;lt;provider-id&amp;gt;
    /// https://iam.googleapis.com/projects/&amp;lt;project-number&amp;gt;/locations/&amp;lt;location&amp;gt;/workloadIdentityPools/&amp;lt;pool-id&amp;gt;/providers/&amp;lt;provider-id&amp;gt;
    /// &#39;&#39;&#39;
    /// </summary>
    public List<TerraformProperty<string>>? AllowedAudiences
    {
        get => GetProperty<List<TerraformProperty<string>>>("allowed_audiences");
        set => WithProperty("allowed_audiences", value);
    }

    /// <summary>
    /// The OIDC issuer URL.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IssuerUri is required")]
    public required TerraformProperty<string> IssuerUri
    {
        get => GetProperty<TerraformProperty<string>>("issuer_uri");
        set => WithProperty("issuer_uri", value);
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
    public TerraformProperty<string>? JwksJson
    {
        get => GetProperty<TerraformProperty<string>>("jwks_json");
        set => WithProperty("jwks_json", value);
    }

}

/// <summary>
/// Block type for saml in .
/// Nesting mode: list
/// </summary>
public class GoogleIamWorkloadIdentityPoolProviderSamlBlock : TerraformBlock
{
    /// <summary>
    /// SAML Identity provider configuration metadata xml doc.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdpMetadataXml is required")]
    public required TerraformProperty<string> IdpMetadataXml
    {
        get => GetProperty<TerraformProperty<string>>("idp_metadata_xml");
        set => WithProperty("idp_metadata_xml", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleIamWorkloadIdentityPoolProviderTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for x509 in .
/// Nesting mode: list
/// </summary>
public class GoogleIamWorkloadIdentityPoolProviderX509Block : TerraformBlock
{
}

/// <summary>
/// Manages a google_iam_workload_identity_pool_provider resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleIamWorkloadIdentityPoolProvider : TerraformResource
{
    public GoogleIamWorkloadIdentityPoolProvider(string name) : base("google_iam_workload_identity_pool_provider", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
        this.DeclareOutput("state");
    }

    /// <summary>
    /// [A Common Expression Language](https://opensource.google/projects/cel) expression, in
    /// plain text, to restrict what otherwise valid authentication credentials issued by the
    /// provider should not be accepted.
    /// 
    /// The expression must output a boolean representing whether to allow the federation.
    /// 
    /// The following keywords may be referenced in the expressions:
    ///   * &#39;assertion&#39;: JSON representing the authentication credential issued by the provider.
    ///   * &#39;google&#39;: The Google attributes mapped from the assertion in the &#39;attribute_mappings&#39;.
    ///   * &#39;attribute&#39;: The custom attributes mapped from the assertion in the &#39;attribute_mappings&#39;.
    /// 
    /// The maximum length of the attribute condition expression is 4096 characters. If
    /// unspecified, all valid authentication credential are accepted.
    /// 
    /// The following example shows how to only allow credentials with a mapped &#39;google.groups&#39;
    /// value of &#39;admins&#39;:
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
    /// Maps attributes from authentication credentials issued by an external identity provider
    /// to Google Cloud attributes, such as &#39;subject&#39; and &#39;segment&#39;.
    /// 
    /// Each key must be a string specifying the Google Cloud IAM attribute to map to.
    /// 
    /// The following keys are supported:
    ///   * &#39;google.subject&#39;: The principal IAM is authenticating. You can reference this value
    ///     in IAM bindings. This is also the subject that appears in Cloud Logging logs.
    ///     Cannot exceed 127 characters.
    ///   * &#39;google.groups&#39;: Groups the external identity belongs to. You can grant groups
    ///     access to resources using an IAM &#39;principalSet&#39; binding; access applies to all
    ///     members of the group.
    /// 
    /// You can also provide custom attributes by specifying &#39;attribute.{custom_attribute}&#39;,
    /// where &#39;{custom_attribute}&#39; is the name of the custom attribute to be mapped. You can
    /// define a maximum of 50 custom attributes. The maximum length of a mapped attribute key
    /// is 100 characters, and the key may only contain the characters [a-z0-9_].
    /// 
    /// You can reference these attributes in IAM policies to define fine-grained access for a
    /// workload to Google Cloud resources. For example:
    ///   * &#39;google.subject&#39;:
    ///     &#39;principal://iam.googleapis.com/projects/{project}/locations/{location}/workloadIdentityPools/{pool}/subject/{value}&#39;
    ///   * &#39;google.groups&#39;:
    ///     &#39;principalSet://iam.googleapis.com/projects/{project}/locations/{location}/workloadIdentityPools/{pool}/group/{value}&#39;
    ///   * &#39;attribute.{custom_attribute}&#39;:
    ///     &#39;principalSet://iam.googleapis.com/projects/{project}/locations/{location}/workloadIdentityPools/{pool}/attribute.{custom_attribute}/{value}&#39;
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
    /// For AWS providers, the following rules apply:
    ///   - If no attribute mapping is defined, the following default mapping applies:
    ///     &#39;&#39;&#39;
    ///     {
    ///       &amp;quot;google.subject&amp;quot;:&amp;quot;assertion.arn&amp;quot;,
    ///       &amp;quot;attribute.aws_role&amp;quot;:
    ///         &amp;quot;assertion.arn.contains(&#39;assumed-role&#39;)&amp;quot;
    ///         &amp;quot; ? assertion.arn.extract(&#39;{account_arn}assumed-role/&#39;)&amp;quot;
    ///         &amp;quot;   + &#39;assumed-role/&#39;&amp;quot;
    ///         &amp;quot;   + assertion.arn.extract(&#39;assumed-role/{role_name}/&#39;)&amp;quot;
    ///         &amp;quot; : assertion.arn&amp;quot;,
    ///     }
    ///     &#39;&#39;&#39;
    ///   - If any custom attribute mappings are defined, they must include a mapping to the
    ///     &#39;google.subject&#39; attribute.
    /// 
    /// For OIDC providers, the following rules apply:
    ///   - Custom attribute mappings must be defined, and must include a mapping to the
    ///     &#39;google.subject&#39; attribute. For example, the following maps the &#39;sub&#39; claim of the
    ///     incoming credential to the &#39;subject&#39; attribute on a Google token.
    ///     &#39;&#39;&#39;
    ///     {&amp;quot;google.subject&amp;quot;: &amp;quot;assertion.sub&amp;quot;}
    ///     &#39;&#39;&#39;
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? AttributeMapping
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("attribute_mapping");
        set => this.WithProperty("attribute_mapping", value);
    }

    /// <summary>
    /// A description for the provider. Cannot exceed 256 characters.
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
    /// A display name for the provider. Cannot exceed 32 characters.
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
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The ID used for the pool, which is the final component of the pool resource name. This
    /// value should be 4-32 characters, and may contain the characters [a-z0-9-]. The prefix
    /// &#39;gcp-&#39; is reserved for use by Google, and may not be specified.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkloadIdentityPoolId is required")]
    public required TerraformProperty<string> WorkloadIdentityPoolId
    {
        get => GetProperty<TerraformProperty<string>>("workload_identity_pool_id");
        set => this.WithProperty("workload_identity_pool_id", value);
    }

    /// <summary>
    /// The ID for the provider, which becomes the final component of the resource name. This
    /// value must be 4-32 characters, and may contain the characters [a-z0-9-]. The prefix
    /// &#39;gcp-&#39; is reserved for use by Google, and may not be specified.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkloadIdentityPoolProviderId is required")]
    public required TerraformProperty<string> WorkloadIdentityPoolProviderId
    {
        get => GetProperty<TerraformProperty<string>>("workload_identity_pool_provider_id");
        set => this.WithProperty("workload_identity_pool_provider_id", value);
    }

    /// <summary>
    /// Block for aws.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Aws block(s) allowed")]
    public List<GoogleIamWorkloadIdentityPoolProviderAwsBlock>? Aws
    {
        get => GetProperty<List<GoogleIamWorkloadIdentityPoolProviderAwsBlock>>("aws");
        set => this.WithProperty("aws", value);
    }

    /// <summary>
    /// Block for oidc.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Oidc block(s) allowed")]
    public List<GoogleIamWorkloadIdentityPoolProviderOidcBlock>? Oidc
    {
        get => GetProperty<List<GoogleIamWorkloadIdentityPoolProviderOidcBlock>>("oidc");
        set => this.WithProperty("oidc", value);
    }

    /// <summary>
    /// Block for saml.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Saml block(s) allowed")]
    public List<GoogleIamWorkloadIdentityPoolProviderSamlBlock>? Saml
    {
        get => GetProperty<List<GoogleIamWorkloadIdentityPoolProviderSamlBlock>>("saml");
        set => this.WithProperty("saml", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleIamWorkloadIdentityPoolProviderTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleIamWorkloadIdentityPoolProviderTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for x509.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 X509 block(s) allowed")]
    public List<GoogleIamWorkloadIdentityPoolProviderX509Block>? X509
    {
        get => GetProperty<List<GoogleIamWorkloadIdentityPoolProviderX509Block>>("x509");
        set => this.WithProperty("x509", value);
    }

    /// <summary>
    /// The resource name of the provider as
    /// &#39;projects/{project_number}/locations/global/workloadIdentityPools/{workload_identity_pool_id}/providers/{workload_identity_pool_provider_id}&#39;.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The state of the provider.
    /// * STATE_UNSPECIFIED: State unspecified.
    /// * ACTIVE: The provider is active, and may be used to validate authentication credentials.
    /// * DELETED: The provider is soft-deleted. Soft-deleted providers are permanently deleted
    ///   after approximately 30 days. You can restore a soft-deleted provider using
    ///   UndeleteWorkloadIdentityPoolProvider. You cannot reuse the ID of a soft-deleted provider
    ///   until it is permanently deleted.
    /// </summary>
    public TerraformExpression State => this["state"];

}
