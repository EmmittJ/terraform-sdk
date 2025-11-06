using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_access_context_manager_gcp_user_access_binding resource.
/// </summary>
public class GoogleAccessContextManagerGcpUserAccessBinding : TerraformResource
{
    public GoogleAccessContextManagerGcpUserAccessBinding(string name) : base("google_access_context_manager_gcp_user_access_binding", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
    }

    /// <summary>
    /// Optional. Access level that a user must have to be granted access. Only one access level is supported, not multiple. This repeated field must have exactly one element. Example: &amp;quot;accessPolicies/9522/accessLevels/device_trusted&amp;quot;
    /// </summary>
    public List<string>? AccessLevels
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("access_levels")?.Value;
        set => this.WithProperty("access_levels", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// Required. Immutable. Google Group id whose members are subject to this binding&#39;s restrictions. See &amp;quot;id&amp;quot; in the G Suite Directory API&#39;s Groups resource. If a group&#39;s email address/alias is changed, this resource will continue to point at the changed group. This field does not accept group email addresses or aliases. Example: &amp;quot;01d520gv4vjcrht&amp;quot;
    /// </summary>
    public string? GroupKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("group_key")?.Value;
        set => this.WithProperty("group_key", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Required. ID of the parent organization.
    /// </summary>
    public string? OrganizationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("organization_id")?.Value;
        set => this.WithProperty("organization_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Immutable. Assigned by the server during creation. The last segment has an arbitrary length and has only URI unreserved characters (as defined by RFC 3986 Section 2.3). Should not be specified by the client during creation. Example: &amp;quot;organizations/256/gcpUserAccessBindings/b3-BhcX_Ud5N&amp;quot;
    /// </summary>
    public TerraformExpression Name => this["name"];

}
