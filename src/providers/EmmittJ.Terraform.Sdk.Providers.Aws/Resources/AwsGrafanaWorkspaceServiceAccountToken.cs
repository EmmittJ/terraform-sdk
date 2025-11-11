using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_grafana_workspace_service_account_token resource.
/// </summary>
public class AwsGrafanaWorkspaceServiceAccountToken : TerraformResource
{
    public AwsGrafanaWorkspaceServiceAccountToken(string name) : base("aws_grafana_workspace_service_account_token", name)
    {
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The seconds_to_live attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecondsToLive is required")]
    [TerraformPropertyName("seconds_to_live")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> SecondsToLive { get; set; }

    /// <summary>
    /// The service_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccountId is required")]
    [TerraformPropertyName("service_account_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ServiceAccountId { get; set; }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    [TerraformPropertyName("workspace_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> WorkspaceId { get; set; }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatedAt => new TerraformReference(this, "created_at");

    /// <summary>
    /// The expires_at attribute.
    /// </summary>
    [TerraformPropertyName("expires_at")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ExpiresAt => new TerraformReference(this, "expires_at");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

    /// <summary>
    /// The key attribute.
    /// </summary>
    [TerraformPropertyName("key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Key => new TerraformReference(this, "key");

    /// <summary>
    /// The service_account_token_id attribute.
    /// </summary>
    [TerraformPropertyName("service_account_token_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServiceAccountTokenId => new TerraformReference(this, "service_account_token_id");

}
