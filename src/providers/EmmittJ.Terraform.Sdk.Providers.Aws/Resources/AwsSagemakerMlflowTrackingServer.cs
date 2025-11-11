using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sagemaker_mlflow_tracking_server resource.
/// </summary>
public class AwsSagemakerMlflowTrackingServer : TerraformResource
{
    public AwsSagemakerMlflowTrackingServer(string name) : base("aws_sagemaker_mlflow_tracking_server", name)
    {
    }

    /// <summary>
    /// The artifact_store_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ArtifactStoreUri is required")]
    [TerraformPropertyName("artifact_store_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ArtifactStoreUri { get; set; }

    /// <summary>
    /// The automatic_model_registration attribute.
    /// </summary>
    [TerraformPropertyName("automatic_model_registration")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AutomaticModelRegistration { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The mlflow_version attribute.
    /// </summary>
    [TerraformPropertyName("mlflow_version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> MlflowVersion { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The tracking_server_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrackingServerName is required")]
    [TerraformPropertyName("tracking_server_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TrackingServerName { get; set; }

    /// <summary>
    /// The tracking_server_size attribute.
    /// </summary>
    [TerraformPropertyName("tracking_server_size")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TrackingServerSize { get; set; }

    /// <summary>
    /// The weekly_maintenance_window_start attribute.
    /// </summary>
    [TerraformPropertyName("weekly_maintenance_window_start")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> WeeklyMaintenanceWindowStart { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The tracking_server_url attribute.
    /// </summary>
    [TerraformPropertyName("tracking_server_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TrackingServerUrl => new TerraformReference(this, "tracking_server_url");

}
