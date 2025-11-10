using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for rules in .
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployAutomationRulesBlock : TerraformBlock
{
}

/// <summary>
/// Block type for selector in .
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployAutomationSelectorBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleClouddeployAutomationTimeoutsBlock : TerraformBlock
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
/// Manages a google_clouddeploy_automation resource.
/// </summary>
public class GoogleClouddeployAutomation : TerraformResource
{
    public GoogleClouddeployAutomation(string name) : base("google_clouddeploy_automation", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_annotations");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("etag");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// Optional. User annotations. These attributes can only be set and used by the user, and not by Cloud Deploy. Annotations must meet the following constraints: * Annotations are key/value pairs. * Valid annotation keys have two segments: an optional prefix and name, separated by a slash (&#39;/&#39;). * The name segment is required and must be 63 characters or less, beginning and ending with an alphanumeric character (&#39;[a-z0-9A-Z]&#39;) with dashes (&#39;-&#39;), underscores (&#39;_&#39;), dots (&#39;.&#39;), and alphanumerics between. * The prefix is optional. If specified, the prefix must be a DNS subdomain: a series of DNS labels separated by dots(&#39;.&#39;), not longer than 253 characters in total, followed by a slash (&#39;/&#39;). See https://kubernetes.io/docs/concepts/overview/working-with-objects/annotations/#syntax-and-character-set for more details.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Annotations
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("annotations");
        set => this.WithProperty("annotations", value);
    }

    /// <summary>
    /// The delivery_pipeline for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeliveryPipeline is required")]
    public required TerraformProperty<string> DeliveryPipeline
    {
        get => GetProperty<TerraformProperty<string>>("delivery_pipeline");
        set => this.WithProperty("delivery_pipeline", value);
    }

    /// <summary>
    /// Optional. Description of the &#39;Automation&#39;. Max length is 255 characters.
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
    /// Optional. Labels are attributes that can be set and used by both the user and by Cloud Deploy. Labels must meet the following constraints: * Keys and values can contain only lowercase letters, numeric characters, underscores, and dashes. * All characters must use UTF-8 encoding, and international characters are allowed. * Keys must start with a lowercase letter or international character. * Each resource is limited to a maximum of 64 labels. Both keys and values are additionally constrained to be &amp;lt;= 63 characters.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// Name of the &#39;Automation&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// Required. Email address of the user-managed IAM service account that creates Cloud Deploy release and rollout resources.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccount is required")]
    public required TerraformProperty<string> ServiceAccount
    {
        get => GetProperty<TerraformProperty<string>>("service_account");
        set => this.WithProperty("service_account", value);
    }

    /// <summary>
    /// Optional. When Suspended, automation is deactivated from execution.
    /// </summary>
    public TerraformProperty<bool>? Suspended
    {
        get => GetProperty<TerraformProperty<bool>>("suspended");
        set => this.WithProperty("suspended", value);
    }

    /// <summary>
    /// Block for rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rules block(s) required")]
    public List<GoogleClouddeployAutomationRulesBlock>? Rules
    {
        get => GetProperty<List<GoogleClouddeployAutomationRulesBlock>>("rules");
        set => this.WithProperty("rules", value);
    }

    /// <summary>
    /// Block for selector.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Selector block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Selector block(s) allowed")]
    public List<GoogleClouddeployAutomationSelectorBlock>? Selector
    {
        get => GetProperty<List<GoogleClouddeployAutomationSelectorBlock>>("selector");
        set => this.WithProperty("selector", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleClouddeployAutomationTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleClouddeployAutomationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Output only. Time at which the automation was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveAnnotations => this["effective_annotations"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Optional. The weak etag of the &#39;Automation&#39; resource. This checksum is computed by the server based on the value of other fields, and may be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Output only. Unique identifier of the &#39;Automation&#39;.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// Output only. Time at which the automation was updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
