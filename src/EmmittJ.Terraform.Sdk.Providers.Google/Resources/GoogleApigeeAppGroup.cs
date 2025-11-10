using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for attributes in .
/// Nesting mode: list
/// </summary>
public class GoogleApigeeAppGroupAttributesBlock : TerraformBlock
{
    /// <summary>
    /// Key of the attribute
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// Value of the attribute
    /// </summary>
    public TerraformProperty<string>? Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApigeeAppGroupTimeoutsBlock : TerraformBlock
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
/// Manages a google_apigee_app_group resource.
/// </summary>
public class GoogleApigeeAppGroup : TerraformResource
{
    public GoogleApigeeAppGroup(string name) : base("google_apigee_app_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("app_group_id");
        this.DeclareOutput("created_at");
        this.DeclareOutput("last_modified_at");
        this.DeclareOutput("organization");
    }

    /// <summary>
    /// Channel identifier identifies the owner maintaining this grouping.
    /// </summary>
    public TerraformProperty<string>? ChannelId
    {
        get => GetProperty<TerraformProperty<string>>("channel_id");
        set => this.WithProperty("channel_id", value);
    }

    /// <summary>
    /// A reference to the associated storefront/marketplace.
    /// </summary>
    public TerraformProperty<string>? ChannelUri
    {
        get => GetProperty<TerraformProperty<string>>("channel_uri");
        set => this.WithProperty("channel_uri", value);
    }

    /// <summary>
    /// App group name displayed in the UI
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
    /// Name of the AppGroup. Characters you can use in the name are restricted to: A-Z0-9._-$ %.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The Apigee Organization associated with the Apigee app group,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformProperty<string> OrgId
    {
        get => GetProperty<TerraformProperty<string>>("org_id");
        set => this.WithProperty("org_id", value);
    }

    /// <summary>
    /// Valid values are active or inactive. Note that the status of the AppGroup should be updated via UpdateAppGroupRequest by setting the action as active or inactive. Possible values: [&amp;quot;active&amp;quot;, &amp;quot;inactive&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Status
    {
        get => GetProperty<TerraformProperty<string>>("status");
        set => this.WithProperty("status", value);
    }

    /// <summary>
    /// Block for attributes.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleApigeeAppGroupAttributesBlock>? Attributes
    {
        get => GetProperty<List<GoogleApigeeAppGroupAttributesBlock>>("attributes");
        set => this.WithProperty("attributes", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleApigeeAppGroupTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleApigeeAppGroupTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Internal identifier that cannot be edited
    /// </summary>
    public TerraformExpression AppGroupId => this["app_group_id"];

    /// <summary>
    /// Created time as milliseconds since epoch.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// Modified time as milliseconds since epoch.
    /// </summary>
    public TerraformExpression LastModifiedAt => this["last_modified_at"];

    /// <summary>
    /// App group name displayed in the UI
    /// </summary>
    public TerraformExpression Organization => this["organization"];

}
