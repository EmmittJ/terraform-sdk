using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_sagemaker_mlflow_tracking_server Terraform resource.
/// Manages a aws_sagemaker_mlflow_tracking_server resource.
/// </summary>
public partial class AwsSagemakerMlflowTrackingServer(string name) : TerraformResource("aws_sagemaker_mlflow_tracking_server", name)
{
    /// <summary>
    /// The artifact_store_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ArtifactStoreUri is required")]
    public required TerraformValue<string> ArtifactStoreUri
    {
        get => new TerraformReference<string>(this, "artifact_store_uri");
        set => SetArgument("artifact_store_uri", value);
    }

    /// <summary>
    /// The automatic_model_registration attribute.
    /// </summary>
    public TerraformValue<bool>? AutomaticModelRegistration
    {
        get => new TerraformReference<bool>(this, "automatic_model_registration");
        set => SetArgument("automatic_model_registration", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The mlflow_version attribute.
    /// </summary>
    public TerraformValue<string> MlflowVersion
    {
        get => new TerraformReference<string>(this, "mlflow_version");
        set => SetArgument("mlflow_version", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The tracking_server_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrackingServerName is required")]
    public required TerraformValue<string> TrackingServerName
    {
        get => new TerraformReference<string>(this, "tracking_server_name");
        set => SetArgument("tracking_server_name", value);
    }

    /// <summary>
    /// The tracking_server_size attribute.
    /// </summary>
    public TerraformValue<string>? TrackingServerSize
    {
        get => new TerraformReference<string>(this, "tracking_server_size");
        set => SetArgument("tracking_server_size", value);
    }

    /// <summary>
    /// The weekly_maintenance_window_start attribute.
    /// </summary>
    public TerraformValue<string> WeeklyMaintenanceWindowStart
    {
        get => new TerraformReference<string>(this, "weekly_maintenance_window_start");
        set => SetArgument("weekly_maintenance_window_start", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The tracking_server_url attribute.
    /// </summary>
    public TerraformValue<string> TrackingServerUrl
    {
        get => new TerraformReference<string>(this, "tracking_server_url");
    }

}
