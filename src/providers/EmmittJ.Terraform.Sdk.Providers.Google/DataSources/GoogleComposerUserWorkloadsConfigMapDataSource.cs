using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_composer_user_workloads_config_map.
/// </summary>
public class GoogleComposerUserWorkloadsConfigMapDataSource : TerraformDataSource
{
    public GoogleComposerUserWorkloadsConfigMapDataSource(string name) : base("google_composer_user_workloads_config_map", name)
    {
    }

    /// <summary>
    /// Environment where the Kubernetes ConfigMap will be stored and used.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Environment is required")]
    [TerraformPropertyName("environment")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Environment { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Name of the Kubernetes ConfigMap.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The location or Compute Engine region for the environment.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Region { get; set; }

    /// <summary>
    /// The &amp;quot;data&amp;quot; field of Kubernetes ConfigMap, organized in key-value pairs.
    /// For details see: https://kubernetes.io/docs/concepts/configuration/configmap/
    /// </summary>
    [TerraformPropertyName("data")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Data => new TerraformReference(this, "data");

}
