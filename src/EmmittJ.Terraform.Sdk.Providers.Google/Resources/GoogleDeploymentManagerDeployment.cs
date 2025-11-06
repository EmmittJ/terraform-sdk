using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_deployment_manager_deployment resource.
/// </summary>
public class GoogleDeploymentManagerDeployment : TerraformResource
{
    public GoogleDeploymentManagerDeployment(string name) : base("google_deployment_manager_deployment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("deployment_id");
        this.DeclareOutput("manifest");
        this.DeclareOutput("self_link");
    }

    /// <summary>
    /// Set the policy to use for creating new resources. Only used on
    /// create and update. Valid values are &#39;CREATE_OR_ACQUIRE&#39; (default) or
    /// &#39;ACQUIRE&#39;. If set to &#39;ACQUIRE&#39; and resources do not already exist,
    /// the deployment will fail. Note that updating this field does not
    /// actually affect the deployment, just how it is updated. Default value: &amp;quot;CREATE_OR_ACQUIRE&amp;quot; Possible values: [&amp;quot;ACQUIRE&amp;quot;, &amp;quot;CREATE_OR_ACQUIRE&amp;quot;]
    /// </summary>
    public string? CreatePolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("create_policy")?.Value;
        set => this.WithProperty("create_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Set the policy to use for deleting new resources on update/delete.
    /// Valid values are &#39;DELETE&#39; (default) or &#39;ABANDON&#39;. If &#39;DELETE&#39;,
    /// resource is deleted after removal from Deployment Manager. If
    /// &#39;ABANDON&#39;, the resource is only removed from Deployment Manager
    /// and is not actually deleted. Note that updating this field does not
    /// actually change the deployment, just how it is updated. Default value: &amp;quot;DELETE&amp;quot; Possible values: [&amp;quot;ABANDON&amp;quot;, &amp;quot;DELETE&amp;quot;]
    /// </summary>
    public string? DeletePolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("delete_policy")?.Value;
        set => this.WithProperty("delete_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Optional user-provided description of deployment.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Unique name for the deployment
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    public bool? Preview
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("preview")?.Value;
        set => this.WithProperty("preview", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
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
