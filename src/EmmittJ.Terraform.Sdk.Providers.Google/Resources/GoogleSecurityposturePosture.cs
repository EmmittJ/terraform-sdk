using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_securityposture_posture resource.
/// </summary>
public class GoogleSecurityposturePosture : TerraformResource
{
    public GoogleSecurityposturePosture(string name) : base("google_securityposture_posture", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("etag");
        this.DeclareOutput("name");
        this.DeclareOutput("reconciling");
        this.DeclareOutput("revision_id");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// Description of the posture.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// Location of the resource, eg: global.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The parent of the resource, an organization. Format should be &#39;organizations/{organization_id}&#39;.
    /// </summary>
    public TerraformProperty<string>? Parent
    {
        get => GetProperty<TerraformProperty<string>>("parent");
        set => this.WithProperty("parent", value);
    }

    /// <summary>
    /// Id of the posture. It is an immutable field.
    /// </summary>
    public TerraformProperty<string>? PostureId
    {
        get => GetProperty<TerraformProperty<string>>("posture_id");
        set => this.WithProperty("posture_id", value);
    }

    /// <summary>
    /// State of the posture. Update to state field should not be triggered along with
    /// with other field updates. Possible values: [&amp;quot;DEPRECATED&amp;quot;, &amp;quot;DRAFT&amp;quot;, &amp;quot;ACTIVE&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? State
    {
        get => GetProperty<TerraformProperty<string>>("state");
        set => this.WithProperty("state", value);
    }

    /// <summary>
    /// Time the Posture was created in UTC.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// For Resource freshness validation (https://google.aip.dev/154)
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// Name of the posture.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// If set, there are currently changes in flight to the posture.
    /// </summary>
    public TerraformExpression Reconciling => this["reconciling"];

    /// <summary>
    /// Revision_id of the posture.
    /// </summary>
    public TerraformExpression RevisionId => this["revision_id"];

    /// <summary>
    /// Time the Posture was updated in UTC.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
