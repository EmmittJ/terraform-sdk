using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for notification_settings in .
/// Nesting mode: set
/// </summary>
public class AwsRolesanywhereTrustAnchorNotificationSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The channel attribute.
    /// </summary>
    [TerraformPropertyName("channel")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Channel { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "channel");

    /// <summary>
    /// The configured_by attribute.
    /// </summary>
    [TerraformPropertyName("configured_by")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ConfiguredBy => new TerraformReferenceProperty<TerraformProperty<string>>("", "configured_by");

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> Enabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "enabled");

    /// <summary>
    /// The event attribute.
    /// </summary>
    [TerraformPropertyName("event")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Event { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "event");

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    [TerraformPropertyName("threshold")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> Threshold { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "threshold");

}

/// <summary>
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public class AwsRolesanywhereTrustAnchorSourceBlock : ITerraformBlock
{
    /// <summary>
    /// The source_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceType is required")]
    [TerraformPropertyName("source_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SourceType { get; set; }

}

/// <summary>
/// Manages a aws_rolesanywhere_trust_anchor resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsRolesanywhereTrustAnchor : TerraformResource
{
    public AwsRolesanywhereTrustAnchor(string name) : base("aws_rolesanywhere_trust_anchor", name)
    {
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> Enabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enabled");

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
    /// Block for notification_settings.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 NotificationSettings block(s) allowed")]
    [TerraformPropertyName("notification_settings")]
    public TerraformSet<TerraformBlock<AwsRolesanywhereTrustAnchorNotificationSettingsBlock>>? NotificationSettings { get; set; } = new();

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    [TerraformPropertyName("source")]
    public TerraformList<TerraformBlock<AwsRolesanywhereTrustAnchorSourceBlock>>? Source { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
