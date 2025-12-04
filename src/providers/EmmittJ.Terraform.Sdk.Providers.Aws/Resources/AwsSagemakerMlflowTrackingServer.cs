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
        get => GetRequiredArgument<TerraformValue<string>>("artifact_store_uri");
        set => SetArgument("artifact_store_uri", value);
    }

    /// <summary>
    /// The automatic_model_registration attribute.
    /// </summary>
    public TerraformValue<bool>? AutomaticModelRegistration
    {
        get => GetArgument<TerraformValue<bool>>("automatic_model_registration");
        set => SetArgument("automatic_model_registration", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The mlflow_version attribute.
    /// </summary>
    public TerraformValue<string> MlflowVersion
    {
        get => GetArgument<TerraformValue<string>>("mlflow_version") ?? AsReference("mlflow_version");
        set => SetArgument("mlflow_version", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The tracking_server_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrackingServerName is required")]
    public required TerraformValue<string> TrackingServerName
    {
        get => GetRequiredArgument<TerraformValue<string>>("tracking_server_name");
        set => SetArgument("tracking_server_name", value);
    }

    /// <summary>
    /// The tracking_server_size attribute.
    /// </summary>
    public TerraformValue<string>? TrackingServerSize
    {
        get => GetArgument<TerraformValue<string>>("tracking_server_size");
        set => SetArgument("tracking_server_size", value);
    }

    /// <summary>
    /// The weekly_maintenance_window_start attribute.
    /// </summary>
    public TerraformValue<string> WeeklyMaintenanceWindowStart
    {
        get => GetArgument<TerraformValue<string>>("weekly_maintenance_window_start") ?? AsReference("weekly_maintenance_window_start");
        set => SetArgument("weekly_maintenance_window_start", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The tracking_server_url attribute.
    /// </summary>
    public TerraformValue<string> TrackingServerUrl
        => AsReference("tracking_server_url");

}
