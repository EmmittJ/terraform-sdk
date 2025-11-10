using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_endpoints in .
/// Nesting mode: set
/// </summary>
public class AwsAppstreamStackAccessEndpointsBlock : ITerraformBlock
{
    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointType is required")]
    [TerraformPropertyName("endpoint_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EndpointType { get; set; }

    /// <summary>
    /// The vpce_id attribute.
    /// </summary>
    [TerraformPropertyName("vpce_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> VpceId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "vpce_id");

}

/// <summary>
/// Block type for application_settings in .
/// Nesting mode: list
/// </summary>
public class AwsAppstreamStackApplicationSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Enabled { get; set; }

    /// <summary>
    /// The settings_group attribute.
    /// </summary>
    [TerraformPropertyName("settings_group")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SettingsGroup { get; set; }

}

/// <summary>
/// Block type for storage_connectors in .
/// Nesting mode: set
/// </summary>
public class AwsAppstreamStackStorageConnectorsBlock : ITerraformBlock
{
    /// <summary>
    /// The connector_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectorType is required")]
    [TerraformPropertyName("connector_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ConnectorType { get; set; }

    /// <summary>
    /// The domains attribute.
    /// </summary>
    [TerraformPropertyName("domains")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> Domains { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>("", "domains");

    /// <summary>
    /// The resource_identifier attribute.
    /// </summary>
    [TerraformPropertyName("resource_identifier")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ResourceIdentifier { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "resource_identifier");

}

/// <summary>
/// Block type for streaming_experience_settings in .
/// Nesting mode: list
/// </summary>
public class AwsAppstreamStackStreamingExperienceSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The preferred_protocol attribute.
    /// </summary>
    [TerraformPropertyName("preferred_protocol")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PreferredProtocol { get; set; }

}

/// <summary>
/// Block type for user_settings in .
/// Nesting mode: set
/// </summary>
public class AwsAppstreamStackUserSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [TerraformPropertyName("action")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Action { get; set; }

    /// <summary>
    /// The permission attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permission is required")]
    [TerraformPropertyName("permission")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Permission { get; set; }

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
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DisplayName { get; set; }

    /// <summary>
    /// The embed_host_domains attribute.
    /// </summary>
    [TerraformPropertyName("embed_host_domains")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> EmbedHostDomains { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "embed_host_domains");

    /// <summary>
    /// The feedback_url attribute.
    /// </summary>
    [TerraformPropertyName("feedback_url")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> FeedbackUrl { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "feedback_url");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The redirect_url attribute.
    /// </summary>
    [TerraformPropertyName("redirect_url")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RedirectUrl { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "redirect_url");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for access_endpoints.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(4, ErrorMessage = "Maximum 4 AccessEndpoints block(s) allowed")]
    [TerraformPropertyName("access_endpoints")]
    public TerraformSet<TerraformBlock<AwsAppstreamStackAccessEndpointsBlock>>? AccessEndpoints { get; set; } = new();

    /// <summary>
    /// Block for application_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplicationSettings block(s) allowed")]
    [TerraformPropertyName("application_settings")]
    public TerraformList<TerraformBlock<AwsAppstreamStackApplicationSettingsBlock>>? ApplicationSettings { get; set; } = new();

    /// <summary>
    /// Block for storage_connectors.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("storage_connectors")]
    public TerraformSet<TerraformBlock<AwsAppstreamStackStorageConnectorsBlock>>? StorageConnectors { get; set; } = new();

    /// <summary>
    /// Block for streaming_experience_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StreamingExperienceSettings block(s) allowed")]
    [TerraformPropertyName("streaming_experience_settings")]
    public TerraformList<TerraformBlock<AwsAppstreamStackStreamingExperienceSettingsBlock>>? StreamingExperienceSettings { get; set; } = new();

    /// <summary>
    /// Block for user_settings.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("user_settings")]
    public TerraformSet<TerraformBlock<AwsAppstreamStackUserSettingsBlock>>? UserSettings { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    [TerraformPropertyName("created_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_time");

}
