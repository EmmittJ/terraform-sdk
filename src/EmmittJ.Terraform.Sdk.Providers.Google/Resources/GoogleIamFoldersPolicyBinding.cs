using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_iam_folders_policy_binding resource.
/// </summary>
public class GoogleIamFoldersPolicyBinding : TerraformResource
{
    public GoogleIamFoldersPolicyBinding(string name) : base("google_iam_folders_policy_binding", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_annotations");
        this.DeclareOutput("etag");
        this.DeclareOutput("name");
        this.DeclareOutput("policy_uid");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// Optional. User defined annotations. See https://google.aip.dev/148#annotations for more details such as format and size limitations
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Annotations
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("annotations");
        set => this.WithProperty("annotations", value);
    }

    /// <summary>
    /// Optional. The description of the policy binding. Must be less than or equal to 63 characters.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The parent folder for the PolicyBinding.
    /// </summary>
    public TerraformProperty<string>? Folder
    {
        get => GetProperty<TerraformProperty<string>>("folder");
        set => this.WithProperty("folder", value);
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
    /// The location of the PolicyBinding.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// Required. Immutable. The resource name of the policy to be bound. The binding parent and policy must belong to the same Organization (or Project).
    /// </summary>
    public TerraformProperty<string>? Policy
    {
        get => GetProperty<TerraformProperty<string>>("policy");
        set => this.WithProperty("policy", value);
    }

    /// <summary>
    /// The Policy Binding ID.
    /// </summary>
    public TerraformProperty<string>? PolicyBindingId
    {
        get => GetProperty<TerraformProperty<string>>("policy_binding_id");
        set => this.WithProperty("policy_binding_id", value);
    }

    /// <summary>
    /// Immutable. The kind of the policy to attach in this binding. This
    /// field must be one of the following:  - Left empty (will be automatically set
    /// to the policy kind) - The input policy kind   Possible values:  POLICY_KIND_UNSPECIFIED PRINCIPAL_ACCESS_BOUNDARY ACCESS
    /// </summary>
    public TerraformProperty<string>? PolicyKind
    {
        get => GetProperty<TerraformProperty<string>>("policy_kind");
        set => this.WithProperty("policy_kind", value);
    }

    /// <summary>
    /// Output only. The time when the policy binding was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveAnnotations => this["effective_annotations"];

    /// <summary>
    /// Optional. The etag for the policy binding. If this is provided on update, it must match the server&#39;s etag.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// The name of the policy binding in the format &#39;{binding_parent/locations/{location}/policyBindings/{policy_binding_id}&#39;
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Output only. The globally unique ID of the policy to be bound.
    /// </summary>
    public TerraformExpression PolicyUid => this["policy_uid"];

    /// <summary>
    /// Output only. The globally unique ID of the policy binding. Assigned when the policy binding is created.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// Output only. The time when the policy binding was most recently updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
