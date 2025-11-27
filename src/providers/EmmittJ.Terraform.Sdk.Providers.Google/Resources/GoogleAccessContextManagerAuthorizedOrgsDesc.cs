using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleAccessContextManagerAuthorizedOrgsDesc.
/// Nesting mode: single
/// </summary>
public class GoogleAccessContextManagerAuthorizedOrgsDescTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_access_context_manager_authorized_orgs_desc Terraform resource.
/// Manages a google_access_context_manager_authorized_orgs_desc resource.
/// </summary>
public partial class GoogleAccessContextManagerAuthorizedOrgsDesc(string name) : TerraformResource("google_access_context_manager_authorized_orgs_desc", name)
{
    /// <summary>
    /// The type of entities that need to use the authorization relationship during
    /// evaluation, such as a device. Valid values are &amp;quot;ASSET_TYPE_DEVICE&amp;quot; and
    /// &amp;quot;ASSET_TYPE_CREDENTIAL_STRENGTH&amp;quot;. Possible values: [&amp;quot;ASSET_TYPE_DEVICE&amp;quot;, &amp;quot;ASSET_TYPE_CREDENTIAL_STRENGTH&amp;quot;]
    /// </summary>
    public TerraformValue<string>? AssetType
    {
        get => new TerraformReference<string>(this, "asset_type");
        set => SetArgument("asset_type", value);
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
    public TerraformValue<string>? AuthorizationDirection
    {
        get => new TerraformReference<string>(this, "authorization_direction");
        set => SetArgument("authorization_direction", value);
    }

    /// <summary>
    /// A granular control type for authorization levels. Valid value is &amp;quot;AUTHORIZATION_TYPE_TRUST&amp;quot;. Possible values: [&amp;quot;AUTHORIZATION_TYPE_TRUST&amp;quot;]
    /// </summary>
    public TerraformValue<string>? AuthorizationType
    {
        get => new TerraformReference<string>(this, "authorization_type");
        set => SetArgument("authorization_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Resource name for the &#39;AuthorizedOrgsDesc&#39;. Format:
    /// &#39;accessPolicies/{access_policy}/authorizedOrgsDescs/{authorized_orgs_desc}&#39;.
    /// The &#39;authorized_orgs_desc&#39; component must begin with a letter, followed by
    /// alphanumeric characters or &#39;_&#39;.
    /// After you create an &#39;AuthorizedOrgsDesc&#39;, you cannot change its &#39;name&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The list of organization ids in this AuthorizedOrgsDesc.
    /// Format: &#39;organizations/&amp;lt;org_number&amp;gt;&#39;
    /// Example: &#39;organizations/123456&#39;
    /// </summary>
    public TerraformList<string>? Orgs
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "orgs").ResolveNodes(ctx));
        set => SetArgument("orgs", value);
    }

    /// <summary>
    /// Required. Resource name for the access policy which owns this &#39;AuthorizedOrgsDesc&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformValue<string> Parent
    {
        get => new TerraformReference<string>(this, "parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// Time the AuthorizedOrgsDesc was created in UTC.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// Time the AuthorizedOrgsDesc was updated in UTC.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleAccessContextManagerAuthorizedOrgsDescTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleAccessContextManagerAuthorizedOrgsDescTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
