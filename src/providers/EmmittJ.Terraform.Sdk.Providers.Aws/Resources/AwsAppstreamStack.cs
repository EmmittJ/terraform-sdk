using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_endpoints in .
/// Nesting mode: set
/// </summary>
public class AwsAppstreamStackAccessEndpointsBlock
{
    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointType is required")]
    [TerraformPropertyName("endpoint_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> EndpointType { get; set; }

    /// <summary>
    /// The vpce_id attribute.
    /// </summary>
    [TerraformPropertyName("vpce_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> VpceId { get; set; } = default!;

}

/// <summary>
/// Block type for application_settings in .
/// Nesting mode: list
/// </summary>
public class AwsAppstreamStackApplicationSettingsBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The settings_group attribute.
    /// </summary>
    [TerraformPropertyName("settings_group")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SettingsGroup { get; set; }

}

/// <summary>
/// Block type for storage_connectors in .
/// Nesting mode: set
/// </summary>
public class AwsAppstreamStackStorageConnectorsBlock
{
    /// <summary>
    /// The connector_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectorType is required")]
    [TerraformPropertyName("connector_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ConnectorType { get; set; }

    /// <summary>
    /// The domains attribute.
    /// </summary>
    [TerraformPropertyName("domains")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> Domains { get; set; } = default!;

    /// <summary>
    /// The resource_identifier attribute.
    /// </summary>
    [TerraformPropertyName("resource_identifier")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ResourceIdentifier { get; set; } = default!;

}

/// <summary>
/// Block type for streaming_experience_settings in .
/// Nesting mode: list
/// </summary>
public class AwsAppstreamStackStreamingExperienceSettingsBlock
{
    /// <summary>
    /// The preferred_protocol attribute.
    /// </summary>
    [TerraformPropertyName("preferred_protocol")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PreferredProtocol { get; set; }

}

/// <summary>
/// Block type for user_settings in .
/// Nesting mode: set
/// </summary>
public class AwsAppstreamStackUserSettingsBlock
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [TerraformPropertyName("action")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Action { get; set; }

    /// <summary>
    /// The permission attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permission is required")]
    [TerraformPropertyName("permission")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Permission { get; set; }

}

/// <summary>
/// Manages a aws_appstream_stack resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAppstreamStack : TerraformResource
{
    public AwsAppstreamStack(string name) : base("aws_appstream_stack", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The embed_host_domains attribute.
    /// </summary>
    [TerraformPropertyName("embed_host_domains")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> EmbedHostDomains { get; set; } = default!;

    /// <summary>
    /// The feedback_url attribute.
    /// </summary>
    [TerraformPropertyName("feedback_url")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> FeedbackUrl { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The redirect_url attribute.
    /// </summary>
    [TerraformPropertyName("redirect_url")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> RedirectUrl { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

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
    /// Block for access_endpoints.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(4, ErrorMessage = "Maximum 4 AccessEndpoints block(s) allowed")]
    [TerraformPropertyName("access_endpoints")]
    public TerraformSet<TerraformBlock<AwsAppstreamStackAccessEndpointsBlock>>? AccessEndpoints { get; set; }

    /// <summary>
    /// Block for application_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplicationSettings block(s) allowed")]
    [TerraformPropertyName("application_settings")]
    public TerraformList<TerraformBlock<AwsAppstreamStackApplicationSettingsBlock>>? ApplicationSettings { get; set; }

    /// <summary>
    /// Block for storage_connectors.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("storage_connectors")]
    public TerraformSet<TerraformBlock<AwsAppstreamStackStorageConnectorsBlock>>? StorageConnectors { get; set; }

    /// <summary>
    /// Block for streaming_experience_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StreamingExperienceSettings block(s) allowed")]
    [TerraformPropertyName("streaming_experience_settings")]
    public TerraformList<TerraformBlock<AwsAppstreamStackStreamingExperienceSettingsBlock>>? StreamingExperienceSettings { get; set; }

    /// <summary>
    /// Block for user_settings.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("user_settings")]
    public TerraformSet<TerraformBlock<AwsAppstreamStackUserSettingsBlock>>? UserSettings { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    [TerraformPropertyName("created_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatedTime => new TerraformReference(this, "created_time");

}
