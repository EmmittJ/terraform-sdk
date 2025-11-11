using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_grafana_workspace_service_account_token resource.
/// </summary>
public partial class AwsGrafanaWorkspaceServiceAccountToken : TerraformResource
{
    public AwsGrafanaWorkspaceServiceAccountToken(string name) : base("aws_grafana_workspace_service_account_token", name)
    {
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The seconds_to_live attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecondsToLive is required")]
    [TerraformProperty("seconds_to_live")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> SecondsToLive { get; set; }

    /// <summary>
    /// The service_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccountId is required")]
    [TerraformProperty("service_account_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ServiceAccountId { get; set; }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    [TerraformProperty("workspace_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> WorkspaceId { get; set; }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The expires_at attribute.
    /// </summary>
    [TerraformProperty("expires_at")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ExpiresAt { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [TerraformProperty("key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Key { get; }

    /// <summary>
    /// The service_account_token_id attribute.
    /// </summary>
    [TerraformProperty("service_account_token_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ServiceAccountTokenId { get; }

}
