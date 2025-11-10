using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for labels in .
/// Nesting mode: set
/// </summary>
public class GoogleDeploymentManagerDeploymentLabelsBlock : ITerraformBlock
{
    /// <summary>
    /// Key for label.
    /// </summary>
    [TerraformPropertyName("key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Key { get; set; }

    /// <summary>
    /// Value of label.
    /// </summary>
    [TerraformPropertyName("value")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Value { get; set; }

}

/// <summary>
/// Block type for target in .
/// Nesting mode: list
/// </summary>
public class GoogleDeploymentManagerDeploymentTargetBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDeploymentManagerDeploymentTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_deployment_manager_deployment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDeploymentManagerDeployment : TerraformResource
{
    public GoogleDeploymentManagerDeployment(string name) : base("google_deployment_manager_deployment", name)
    {
    }

    /// <summary>
    /// Set the policy to use for creating new resources. Only used on
    /// create and update. Valid values are &#39;CREATE_OR_ACQUIRE&#39; (default) or
    /// &#39;ACQUIRE&#39;. If set to &#39;ACQUIRE&#39; and resources do not already exist,
    /// the deployment will fail. Note that updating this field does not
    /// actually affect the deployment, just how it is updated. Default value: &amp;quot;CREATE_OR_ACQUIRE&amp;quot; Possible values: [&amp;quot;ACQUIRE&amp;quot;, &amp;quot;CREATE_OR_ACQUIRE&amp;quot;]
    /// </summary>
    [TerraformPropertyName("create_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CreatePolicy { get; set; }

    /// <summary>
    /// Set the policy to use for deleting new resources on update/delete.
    /// Valid values are &#39;DELETE&#39; (default) or &#39;ABANDON&#39;. If &#39;DELETE&#39;,
    /// resource is deleted after removal from Deployment Manager. If
    /// &#39;ABANDON&#39;, the resource is only removed from Deployment Manager
    /// and is not actually deleted. Note that updating this field does not
    /// actually change the deployment, just how it is updated. Default value: &amp;quot;DELETE&amp;quot; Possible values: [&amp;quot;ABANDON&amp;quot;, &amp;quot;DELETE&amp;quot;]
    /// </summary>
    [TerraformPropertyName("delete_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DeletePolicy { get; set; }

    /// <summary>
    /// Optional user-provided description of deployment.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Unique name for the deployment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// If set to true, a deployment is created with &amp;quot;shell&amp;quot; resources
    /// that are not actually instantiated. This allows you to preview a
    /// deployment. It can be updated to false to actually deploy
    /// with real resources.
    ///  ~&amp;gt;**NOTE:** Deployment Manager does not allow update
    /// of a deployment in preview (unless updating to preview=false). Thus,
    /// Terraform will force-recreate deployments if either preview is updated
    /// to true or if other fields are updated while preview is true.
    /// </summary>
    [TerraformPropertyName("preview")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Preview { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for labels.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("labels")]
    public TerraformSet<TerraformBlock<GoogleDeploymentManagerDeploymentLabelsBlock>>? Labels { get; set; } = new();

    /// <summary>
    /// Block for target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Target block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Target block(s) allowed")]
    [TerraformPropertyName("target")]
    public TerraformList<TerraformBlock<GoogleDeploymentManagerDeploymentTargetBlock>>? Target { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDeploymentManagerDeploymentTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Unique identifier for deployment. Output only.
    /// </summary>
    [TerraformPropertyName("deployment_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DeploymentId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "deployment_id");

    /// <summary>
    /// Output only. URL of the manifest representing the last manifest that
    /// was successfully deployed.
    /// </summary>
    [TerraformPropertyName("manifest")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Manifest => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "manifest");

    /// <summary>
    /// Output only. Server defined URL for the resource.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link");

}
