using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_access_context_manager_authorized_orgs_desc resource.
/// </summary>
public class GoogleAccessContextManagerAuthorizedOrgsDesc : TerraformResource
{
    public GoogleAccessContextManagerAuthorizedOrgsDesc(string name) : base("google_access_context_manager_authorized_orgs_desc", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The type of entities that need to use the authorization relationship during
    /// evaluation, such as a device. Valid values are &amp;quot;ASSET_TYPE_DEVICE&amp;quot; and
    /// &amp;quot;ASSET_TYPE_CREDENTIAL_STRENGTH&amp;quot;. Possible values: [&amp;quot;ASSET_TYPE_DEVICE&amp;quot;, &amp;quot;ASSET_TYPE_CREDENTIAL_STRENGTH&amp;quot;]
    /// </summary>
    public string? AssetType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("asset_type")?.Value;
        set => this.WithProperty("asset_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The direction of the authorization relationship between this organization
    /// and the organizations listed in the &amp;quot;orgs&amp;quot; field. The valid values for this
    /// field include the following:
    /// 
    /// AUTHORIZATION_DIRECTION_FROM: Allows this organization to evaluate traffic
    /// in the organizations listed in the &#39;orgs&#39; field.
    /// 
    /// AUTHORIZATION_DIRECTION_TO: Allows the organizations listed in the &#39;orgs&#39;
    /// field to evaluate the traffic in this organization.
    /// 
    /// For the authorization relationship to take effect, all of the organizations
    /// must authorize and specify the appropriate relationship direction. For
    /// example, if organization A authorized organization B and C to evaluate its
    /// traffic, by specifying &amp;quot;AUTHORIZATION_DIRECTION_TO&amp;quot; as the authorization
    /// direction, organizations B and C must specify
    /// &amp;quot;AUTHORIZATION_DIRECTION_FROM&amp;quot; as the authorization direction in their
    /// &amp;quot;AuthorizedOrgsDesc&amp;quot; resource. Possible values: [&amp;quot;AUTHORIZATION_DIRECTION_TO&amp;quot;, &amp;quot;AUTHORIZATION_DIRECTION_FROM&amp;quot;]
    /// </summary>
    public string? AuthorizationDirection
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authorization_direction")?.Value;
        set => this.WithProperty("authorization_direction", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A granular control type for authorization levels. Valid value is &amp;quot;AUTHORIZATION_TYPE_TRUST&amp;quot;. Possible values: [&amp;quot;AUTHORIZATION_TYPE_TRUST&amp;quot;]
    /// </summary>
    public string? AuthorizationType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authorization_type")?.Value;
        set => this.WithProperty("authorization_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Resource name for the &#39;AuthorizedOrgsDesc&#39;. Format:
    /// &#39;accessPolicies/{access_policy}/authorizedOrgsDescs/{authorized_orgs_desc}&#39;.
    /// The &#39;authorized_orgs_desc&#39; component must begin with a letter, followed by
    /// alphanumeric characters or &#39;_&#39;.
    /// After you create an &#39;AuthorizedOrgsDesc&#39;, you cannot change its &#39;name&#39;.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The list of organization ids in this AuthorizedOrgsDesc.
    /// Format: &#39;organizations/&amp;lt;org_number&amp;gt;&#39;
    /// Example: &#39;organizations/123456&#39;
    /// </summary>
    public List<string>? Orgs
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("orgs")?.Value;
        set => this.WithProperty("orgs", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// Required. Resource name for the access policy which owns this &#39;AuthorizedOrgsDesc&#39;.
    /// </summary>
    public string? Parent
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent")?.Value;
        set => this.WithProperty("parent", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Time the AuthorizedOrgsDesc was created in UTC.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Time the AuthorizedOrgsDesc was updated in UTC.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
