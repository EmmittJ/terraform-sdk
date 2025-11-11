using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_endpoints in .
/// Nesting mode: set
/// </summary>
public partial class AwsAppstreamStackAccessEndpointsBlock : TerraformBlockBase
{
    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointType is required")]
    [TerraformProperty("endpoint_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EndpointType { get; set; }

    /// <summary>
    /// The vpce_id attribute.
    /// </summary>
    [TerraformProperty("vpce_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> VpceId { get; set; }

}

/// <summary>
/// Block type for application_settings in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppstreamStackApplicationSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The settings_group attribute.
    /// </summary>
    [TerraformProperty("settings_group")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SettingsGroup { get; set; }

}

/// <summary>
/// Block type for storage_connectors in .
/// Nesting mode: set
/// </summary>
public partial class AwsAppstreamStackStorageConnectorsBlock : TerraformBlockBase
{
    /// <summary>
    /// The connector_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectorType is required")]
    [TerraformProperty("connector_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ConnectorType { get; set; }

    /// <summary>
    /// The domains attribute.
    /// </summary>
    [TerraformProperty("domains")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> Domains { get; set; }

    /// <summary>
    /// The resource_identifier attribute.
    /// </summary>
    [TerraformProperty("resource_identifier")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ResourceIdentifier { get; set; }

}

/// <summary>
/// Block type for streaming_experience_settings in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppstreamStackStreamingExperienceSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The preferred_protocol attribute.
    /// </summary>
    [TerraformProperty("preferred_protocol")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PreferredProtocol { get; set; }

}

/// <summary>
/// Block type for user_settings in .
/// Nesting mode: set
/// </summary>
public partial class AwsAppstreamStackUserSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [TerraformProperty("action")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Action { get; set; }

    /// <summary>
    /// The permission attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permission is required")]
    [TerraformProperty("permission")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Permission { get; set; }

}

/// <summary>
/// Manages a aws_appstream_stack resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsAppstreamStack : TerraformResource
{
    public AwsAppstreamStack(string name) : base("aws_appstream_stack", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The embed_host_domains attribute.
    /// </summary>
    [TerraformProperty("embed_host_domains")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> EmbedHostDomains { get; set; }

    /// <summary>
    /// The feedback_url attribute.
    /// </summary>
    [TerraformProperty("feedback_url")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> FeedbackUrl { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The redirect_url attribute.
    /// </summary>
    [TerraformProperty("redirect_url")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> RedirectUrl { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for access_endpoints.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(4, ErrorMessage = "Maximum 4 AccessEndpoints block(s) allowed")]
    [TerraformProperty("access_endpoints")]
    public partial TerraformSet<TerraformBlock<AwsAppstreamStackAccessEndpointsBlock>>? AccessEndpoints { get; set; }

    /// <summary>
    /// Block for application_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplicationSettings block(s) allowed")]
    [TerraformProperty("application_settings")]
    public partial TerraformList<TerraformBlock<AwsAppstreamStackApplicationSettingsBlock>>? ApplicationSettings { get; set; }

    /// <summary>
    /// Block for storage_connectors.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("storage_connectors")]
    public partial TerraformSet<TerraformBlock<AwsAppstreamStackStorageConnectorsBlock>>? StorageConnectors { get; set; }

    /// <summary>
    /// Block for streaming_experience_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StreamingExperienceSettings block(s) allowed")]
    [TerraformProperty("streaming_experience_settings")]
    public partial TerraformList<TerraformBlock<AwsAppstreamStackStreamingExperienceSettingsBlock>>? StreamingExperienceSettings { get; set; }

    /// <summary>
    /// Block for user_settings.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("user_settings")]
    public partial TerraformSet<TerraformBlock<AwsAppstreamStackUserSettingsBlock>>? UserSettings { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    [TerraformProperty("created_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedTime { get; }

}
