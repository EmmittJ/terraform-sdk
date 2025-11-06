using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
    public string? ChannelId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("channel_id")?.Value;
        set => this.WithProperty("channel_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A reference to the associated storefront/marketplace.
    /// </summary>
    public string? ChannelUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("channel_uri")?.Value;
        set => this.WithProperty("channel_uri", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// App group name displayed in the UI
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Name of the AppGroup. Characters you can use in the name are restricted to: A-Z0-9._-$ %.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The Apigee Organization associated with the Apigee app group,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    public string? OrgId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("org_id")?.Value;
        set => this.WithProperty("org_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Valid values are active or inactive. Note that the status of the AppGroup should be updated via UpdateAppGroupRequest by setting the action as active or inactive. Possible values: [&amp;quot;active&amp;quot;, &amp;quot;inactive&amp;quot;]
    /// </summary>
    public string? Status
    {
        get => GetProperty<TerraformLiteralProperty<string>>("status")?.Value;
        set => this.WithProperty("status", value == null ? null : new TerraformLiteralProperty<string>(value));
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
