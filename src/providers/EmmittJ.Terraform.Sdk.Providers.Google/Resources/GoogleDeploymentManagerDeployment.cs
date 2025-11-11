using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for labels in .
/// Nesting mode: set
/// </summary>
public partial class GoogleDeploymentManagerDeploymentLabelsBlock : TerraformBlockBase
{
    /// <summary>
    /// Key for label.
    /// </summary>
    [TerraformProperty("key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Key { get; set; }

    /// <summary>
    /// Value of label.
    /// </summary>
    [TerraformProperty("value")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Value { get; set; }

}

/// <summary>
/// Block type for target in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDeploymentManagerDeploymentTargetBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDeploymentManagerDeploymentTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_deployment_manager_deployment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDeploymentManagerDeployment : TerraformResource
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
    [TerraformProperty("create_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CreatePolicy { get; set; }

    /// <summary>
    /// Set the policy to use for deleting new resources on update/delete.
    /// Valid values are &#39;DELETE&#39; (default) or &#39;ABANDON&#39;. If &#39;DELETE&#39;,
    /// resource is deleted after removal from Deployment Manager. If
    /// &#39;ABANDON&#39;, the resource is only removed from Deployment Manager
    /// and is not actually deleted. Note that updating this field does not
    /// actually change the deployment, just how it is updated. Default value: &amp;quot;DELETE&amp;quot; Possible values: [&amp;quot;ABANDON&amp;quot;, &amp;quot;DELETE&amp;quot;]
    /// </summary>
    [TerraformProperty("delete_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeletePolicy { get; set; }

    /// <summary>
    /// Optional user-provided description of deployment.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Unique name for the deployment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

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
    [TerraformProperty("preview")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Preview { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for labels.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("labels")]
    public partial TerraformSet<TerraformBlock<GoogleDeploymentManagerDeploymentLabelsBlock>>? Labels { get; set; }

    /// <summary>
    /// Block for target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Target block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Target block(s) allowed")]
    [TerraformProperty("target")]
    public partial TerraformList<TerraformBlock<GoogleDeploymentManagerDeploymentTargetBlock>>? Target { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleDeploymentManagerDeploymentTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Unique identifier for deployment. Output only.
    /// </summary>
    [TerraformProperty("deployment_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DeploymentId { get; }

    /// <summary>
    /// Output only. URL of the manifest representing the last manifest that
    /// was successfully deployed.
    /// </summary>
    [TerraformProperty("manifest")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Manifest { get; }

    /// <summary>
    /// Output only. Server defined URL for the resource.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SelfLink { get; }

}
