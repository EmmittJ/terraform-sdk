using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for labels in GoogleDeploymentManagerDeployment.
/// Nesting mode: set
/// </summary>
public class GoogleDeploymentManagerDeploymentLabelsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "labels";

    /// <summary>
    /// Key for label.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// Value of label.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for target in GoogleDeploymentManagerDeployment.
/// Nesting mode: list
/// </summary>
public class GoogleDeploymentManagerDeploymentTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target";

    /// <summary>
    /// Config block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Config is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Config block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Config block(s) allowed")]
    public required TerraformList<GoogleDeploymentManagerDeploymentTargetBlockConfigBlock> Config
    {
        get => GetRequiredArgument<TerraformList<GoogleDeploymentManagerDeploymentTargetBlockConfigBlock>>("config");
        set => SetArgument("config", value);
    }

    /// <summary>
    /// Imports block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDeploymentManagerDeploymentTargetBlockImportsBlock>? Imports
    {
        get => GetArgument<TerraformList<GoogleDeploymentManagerDeploymentTargetBlockImportsBlock>>("imports");
        set => SetArgument("imports", value);
    }

}

/// <summary>
/// Block type for config in GoogleDeploymentManagerDeploymentTargetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDeploymentManagerDeploymentTargetBlockConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "config";

    /// <summary>
    /// The full YAML contents of your configuration file.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    public required TerraformValue<string> Content
    {
        get => GetArgument<TerraformValue<string>>("content");
        set => SetArgument("content", value);
    }

}

/// <summary>
/// Block type for imports in GoogleDeploymentManagerDeploymentTargetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDeploymentManagerDeploymentTargetBlockImportsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "imports";

    /// <summary>
    /// The full contents of the template that you want to import.
    /// </summary>
    public TerraformValue<string>? Content
    {
        get => GetArgument<TerraformValue<string>>("content");
        set => SetArgument("content", value);
    }

    /// <summary>
    /// The name of the template to import, as declared in the YAML
    /// configuration.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDeploymentManagerDeployment.
/// Nesting mode: single
/// </summary>
public class GoogleDeploymentManagerDeploymentTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_deployment_manager_deployment Terraform resource.
/// Manages a google_deployment_manager_deployment resource.
/// </summary>
public partial class GoogleDeploymentManagerDeployment(string name) : TerraformResource("google_deployment_manager_deployment", name)
{
    /// <summary>
    /// Set the policy to use for creating new resources. Only used on
    /// create and update. Valid values are &#39;CREATE_OR_ACQUIRE&#39; (default) or
    /// &#39;ACQUIRE&#39;. If set to &#39;ACQUIRE&#39; and resources do not already exist,
    /// the deployment will fail. Note that updating this field does not
    /// actually affect the deployment, just how it is updated. Default value: &amp;quot;CREATE_OR_ACQUIRE&amp;quot; Possible values: [&amp;quot;ACQUIRE&amp;quot;, &amp;quot;CREATE_OR_ACQUIRE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? CreatePolicy
    {
        get => GetArgument<TerraformValue<string>>("create_policy");
        set => SetArgument("create_policy", value);
    }

    /// <summary>
    /// Set the policy to use for deleting new resources on update/delete.
    /// Valid values are &#39;DELETE&#39; (default) or &#39;ABANDON&#39;. If &#39;DELETE&#39;,
    /// resource is deleted after removal from Deployment Manager. If
    /// &#39;ABANDON&#39;, the resource is only removed from Deployment Manager
    /// and is not actually deleted. Note that updating this field does not
    /// actually change the deployment, just how it is updated. Default value: &amp;quot;DELETE&amp;quot; Possible values: [&amp;quot;ABANDON&amp;quot;, &amp;quot;DELETE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? DeletePolicy
    {
        get => GetArgument<TerraformValue<string>>("delete_policy");
        set => SetArgument("delete_policy", value);
    }

    /// <summary>
    /// Optional user-provided description of deployment.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Unique name for the deployment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    public TerraformValue<bool>? Preview
    {
        get => GetArgument<TerraformValue<bool>>("preview");
        set => SetArgument("preview", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Unique identifier for deployment. Output only.
    /// </summary>
    public TerraformValue<string> DeploymentId
        => AsReference("deployment_id");

    /// <summary>
    /// Output only. URL of the manifest representing the last manifest that
    /// was successfully deployed.
    /// </summary>
    public TerraformValue<string> Manifest
        => AsReference("manifest");

    /// <summary>
    /// Output only. Server defined URL for the resource.
    /// </summary>
    public TerraformValue<string> SelfLink
        => AsReference("self_link");

    /// <summary>
    /// Labels block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleDeploymentManagerDeploymentLabelsBlock>? Labels
    {
        get => GetArgument<TerraformSet<GoogleDeploymentManagerDeploymentLabelsBlock>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Target block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Target block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Target block(s) allowed")]
    public required TerraformList<GoogleDeploymentManagerDeploymentTargetBlock> Target
    {
        get => GetRequiredArgument<TerraformList<GoogleDeploymentManagerDeploymentTargetBlock>>("target");
        set => SetArgument("target", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDeploymentManagerDeploymentTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDeploymentManagerDeploymentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
