using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for labels in .
/// Nesting mode: set
/// </summary>
public class GoogleDeploymentManagerDeploymentLabelsBlock : TerraformBlock
{
    /// <summary>
    /// Key for label.
    /// </summary>
    public TerraformProperty<string>? Key
    {
        get => GetProperty<TerraformProperty<string>>("key");
        set => WithProperty("key", value);
    }

    /// <summary>
    /// Value of label.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
    }

}

/// <summary>
/// Block type for target in .
/// Nesting mode: list
/// </summary>
public class GoogleDeploymentManagerDeploymentTargetBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDeploymentManagerDeploymentTimeoutsBlock : TerraformBlock
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
/// Manages a google_deployment_manager_deployment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDeploymentManagerDeployment : TerraformResource
{
    public GoogleDeploymentManagerDeployment(string name) : base("google_deployment_manager_deployment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("deployment_id");
        this.WithOutput("manifest");
        this.WithOutput("self_link");
    }

    /// <summary>
    /// Set the policy to use for creating new resources. Only used on
    /// create and update. Valid values are &#39;CREATE_OR_ACQUIRE&#39; (default) or
    /// &#39;ACQUIRE&#39;. If set to &#39;ACQUIRE&#39; and resources do not already exist,
    /// the deployment will fail. Note that updating this field does not
    /// actually affect the deployment, just how it is updated. Default value: &amp;quot;CREATE_OR_ACQUIRE&amp;quot; Possible values: [&amp;quot;ACQUIRE&amp;quot;, &amp;quot;CREATE_OR_ACQUIRE&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? CreatePolicy
    {
        get => GetProperty<TerraformProperty<string>>("create_policy");
        set => this.WithProperty("create_policy", value);
    }

    /// <summary>
    /// Set the policy to use for deleting new resources on update/delete.
    /// Valid values are &#39;DELETE&#39; (default) or &#39;ABANDON&#39;. If &#39;DELETE&#39;,
    /// resource is deleted after removal from Deployment Manager. If
    /// &#39;ABANDON&#39;, the resource is only removed from Deployment Manager
    /// and is not actually deleted. Note that updating this field does not
    /// actually change the deployment, just how it is updated. Default value: &amp;quot;DELETE&amp;quot; Possible values: [&amp;quot;ABANDON&amp;quot;, &amp;quot;DELETE&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? DeletePolicy
    {
        get => GetProperty<TerraformProperty<string>>("delete_policy");
        set => this.WithProperty("delete_policy", value);
    }

    /// <summary>
    /// Optional user-provided description of deployment.
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
    /// Unique name for the deployment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

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
    public TerraformProperty<bool>? Preview
    {
        get => GetProperty<TerraformProperty<bool>>("preview");
        set => this.WithProperty("preview", value);
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
    /// Block for labels.
    /// Nesting mode: set
    /// </summary>
    public HashSet<GoogleDeploymentManagerDeploymentLabelsBlock>? Labels
    {
        get => GetProperty<HashSet<GoogleDeploymentManagerDeploymentLabelsBlock>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// Block for target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Target block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Target block(s) allowed")]
    public List<GoogleDeploymentManagerDeploymentTargetBlock>? Target
    {
        get => GetProperty<List<GoogleDeploymentManagerDeploymentTargetBlock>>("target");
        set => this.WithProperty("target", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDeploymentManagerDeploymentTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDeploymentManagerDeploymentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Unique identifier for deployment. Output only.
    /// </summary>
    public TerraformExpression DeploymentId => this["deployment_id"];

    /// <summary>
    /// Output only. URL of the manifest representing the last manifest that
    /// was successfully deployed.
    /// </summary>
    public TerraformExpression Manifest => this["manifest"];

    /// <summary>
    /// Output only. Server defined URL for the resource.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

}
