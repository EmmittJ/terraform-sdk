using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_iam_workload_identity_pool_provider.
/// </summary>
public partial class GoogleIamWorkloadIdentityPoolProviderDataSource : TerraformDataSource
{
    public GoogleIamWorkloadIdentityPoolProviderDataSource(string name) : base("google_iam_workload_identity_pool_provider", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The ID used for the pool, which is the final component of the pool resource name. This
    /// value should be 4-32 characters, and may contain the characters [a-z0-9-]. The prefix
    /// &#39;gcp-&#39; is reserved for use by Google, and may not be specified.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkloadIdentityPoolId is required")]
    [TerraformProperty("workload_identity_pool_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> WorkloadIdentityPoolId { get; set; }

    /// <summary>
    /// The ID for the provider, which becomes the final component of the resource name. This
    /// value must be 4-32 characters, and may contain the characters [a-z0-9-]. The prefix
    /// &#39;gcp-&#39; is reserved for use by Google, and may not be specified.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkloadIdentityPoolProviderId is required")]
    [TerraformProperty("workload_identity_pool_provider_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> WorkloadIdentityPoolProviderId { get; set; }

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
    [TerraformProperty("attribute_condition")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AttributeCondition { get; }

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
    [TerraformProperty("attribute_mapping")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> AttributeMapping { get; }

    /// <summary>
    /// An Amazon Web Services identity provider. Not compatible with the property oidc or saml.
    /// </summary>
    [TerraformProperty("aws")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Aws { get; }

    /// <summary>
    /// A description for the provider. Cannot exceed 256 characters.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// Whether the provider is disabled. You cannot use a disabled provider to exchange tokens.
    /// However, existing tokens still grant access.
    /// </summary>
    [TerraformProperty("disabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Disabled { get; }

    /// <summary>
    /// A display name for the provider. Cannot exceed 32 characters.
    /// </summary>
    [TerraformProperty("display_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DisplayName { get; }

    /// <summary>
    /// The resource name of the provider as
    /// &#39;projects/{project_number}/locations/global/workloadIdentityPools/{workload_identity_pool_id}/providers/{workload_identity_pool_provider_id}&#39;.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// An OpenId Connect 1.0 identity provider. Not compatible with the property aws or saml.
    /// </summary>
    [TerraformProperty("oidc")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Oidc { get; }

    /// <summary>
    /// An SAML 2.0 identity provider. Not compatible with the property oidc or aws.
    /// </summary>
    [TerraformProperty("saml")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Saml { get; }

    /// <summary>
    /// The state of the provider.
    /// * STATE_UNSPECIFIED: State unspecified.
    /// * ACTIVE: The provider is active, and may be used to validate authentication credentials.
    /// * DELETED: The provider is soft-deleted. Soft-deleted providers are permanently deleted
    ///   after approximately 30 days. You can restore a soft-deleted provider using
    ///   UndeleteWorkloadIdentityPoolProvider. You cannot reuse the ID of a soft-deleted provider
    ///   until it is permanently deleted.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// An X.509-type identity provider represents a CA. It is trusted to assert a
    /// client identity if the client has a certificate that chains up to this CA.
    /// </summary>
    [TerraformProperty("x509")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> X509 { get; }

}
